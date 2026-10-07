Imports System.Data.Common
Imports System.Drawing
Imports System.Globalization
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public da As MySqlDataAdapter

    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "server=localhost;user=root;password=;database=dentalclinicdb"
        cn.Open()
    End Sub
End Module

' =====================================================================================
' Shared helpers. frmLogin and frmMain both use these; all screen logic lives in frmMain.
' =====================================================================================

''' <summary>Small query helpers on top of the connection() sub above.</summary>
Public NotInheritable Class Db

    Private Sub New()
    End Sub

    Friend Shared Sub AddParams(c As MySqlCommand, p As (Name As String, Value As Object)())
        For Each item In p
            c.Parameters.AddWithValue(item.Name, If(item.Value, DBNull.Value))
        Next
    End Sub

    Public Shared Function Query(sql As String, ParamArray p As (Name As String, Value As Object)()) As DataTable
        connection()
        Using c As New MySqlCommand(sql, cn)
            AddParams(c, p)
            Using a As New MySqlDataAdapter(c)
                Dim t As New DataTable()
                a.Fill(t)
                Return t
            End Using
        End Using
    End Function

    Public Shared Function Scalar(sql As String, ParamArray p As (Name As String, Value As Object)()) As Object
        connection()
        Using c As New MySqlCommand(sql, cn)
            AddParams(c, p)
            Dim v As Object = c.ExecuteScalar()
            Return If(v Is DBNull.Value, Nothing, v)
        End Using
    End Function

    Public Shared Function Exec(sql As String, ParamArray p As (Name As String, Value As Object)()) As Integer
        connection()
        Using c As New MySqlCommand(sql, cn)
            AddParams(c, p)
            Return c.ExecuteNonQuery()
        End Using
    End Function

    ''' <summary>Runs an INSERT and returns the new AUTO_INCREMENT id.</summary>
    Public Shared Function Insert(sql As String, ParamArray p As (Name As String, Value As Object)()) As Long
        connection()
        Using c As New MySqlCommand(sql, cn)
            AddParams(c, p)
            c.ExecuteNonQuery()
            Return c.LastInsertedId
        End Using
    End Function

End Class

''' <summary>One connection with one transaction. Disposing without Commit() rolls back.</summary>
Public NotInheritable Class Tx
    Implements IDisposable

    Private ReadOnly _conn As MySqlConnection
    Private ReadOnly _tran As MySqlTransaction

    Public Sub New(transactional As Boolean)
        If cn.ConnectionString = "" Then connection()
        _conn = New MySqlConnection(cn.ConnectionString)
        _conn.Open()
        If transactional Then _tran = _conn.BeginTransaction()
    End Sub

    Private Function Make(sql As String, p As (Name As String, Value As Object)()) As MySqlCommand
        Dim c As New MySqlCommand(sql, _conn, _tran)
        Db.AddParams(c, p)
        Return c
    End Function

    Public Function Query(sql As String, ParamArray p As (Name As String, Value As Object)()) As DataTable
        Using c = Make(sql, p)
            Using a As New MySqlDataAdapter(c)
                Dim t As New DataTable()
                a.Fill(t)
                Return t
            End Using
        End Using
    End Function

    Public Function Scalar(sql As String, ParamArray p As (Name As String, Value As Object)()) As Object
        Using c = Make(sql, p)
            Dim v As Object = c.ExecuteScalar()
            Return If(v Is DBNull.Value, Nothing, v)
        End Using
    End Function

    Public Function Exec(sql As String, ParamArray p As (Name As String, Value As Object)()) As Integer
        Using c = Make(sql, p)
            Return c.ExecuteNonQuery()
        End Using
    End Function

    Public Function Insert(sql As String, ParamArray p As (Name As String, Value As Object)()) As Long
        Using c = Make(sql, p)
            c.ExecuteNonQuery()
            Return c.LastInsertedId
        End Using
    End Function

    Public Sub Commit()
        If _tran IsNot Nothing Then _tran.Commit()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If _tran IsNot Nothing Then _tran.Dispose()
        _conn.Dispose()
    End Sub

End Class

''' <summary>The signed-in user. Two roles only: Administrator and Front Desk.</summary>
Public NotInheritable Class Session

    Private Sub New()
    End Sub

    Public Const AdminRole As String = "Administrator"
    Public Const FrontDeskRole As String = "Front Desk"

    Public Shared Property UserId As Integer
    Public Shared Property Username As String = ""
    Public Shared Property FullName As String = ""
    Public Shared Property Role As String = ""

    Public Shared ReadOnly Property IsAdmin As Boolean
        Get
            Return Role = AdminRole
        End Get
    End Property

    Public Shared Sub Clear()
        UserId = 0
        Username = ""
        FullName = ""
        Role = ""
    End Sub

End Class

''' <summary>Writes one row to tblAuditLogs. Never throws - auditing must not break the screen.</summary>
Public NotInheritable Class Audit

    Private Sub New()
    End Sub

    Public Shared Sub Log(action As String,
                          Optional entity As String = Nothing,
                          Optional recordId As Object = Nothing,
                          Optional oldValue As String = Nothing,
                          Optional newValue As String = Nothing)
        Try
            Db.Exec("INSERT INTO tblAuditLogs (UserID, Action, EntityName, RecordID, OldValue, NewValue, IPAddress)
                      VALUES (@u, @a, @e, @r, @o, @n, @ip)",
                ("@u", If(Session.UserId = 0, Nothing, CObj(Session.UserId))),
                ("@a", action),
                ("@e", entity),
                ("@r", If(recordId Is Nothing, Nothing, recordId.ToString())),
                ("@o", oldValue),
                ("@n", newValue),
                ("@ip", Environment.MachineName))
        Catch
        End Try
    End Sub

End Class

''' <summary>
''' Password hashing (PBKDF2-SHA256, built into .NET Framework - no extra package needed).
''' Stored format: PBKDF2$iterations$salt$hash   (the SQL placeholder SET_PASSWORD_FIRST is not a hash).
''' </summary>
Public NotInheritable Class Pwd

    Private Sub New()
    End Sub

    Public Const FirstRunHash As String = "SET_PASSWORD_FIRST"
    Private Const Iterations As Integer = 100000

    Public Shared Function Hash(password As String) As String
        Dim salt(15) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Dim key As Byte() = Derive(password, salt, Iterations)
        Return "PBKDF2$" & Iterations.ToString(CultureInfo.InvariantCulture) & "$" &
               Convert.ToBase64String(salt) & "$" & Convert.ToBase64String(key)
    End Function

    Public Shared Function Verify(password As String, stored As String) As Boolean
        Try
            Dim parts() As String = stored.Split("$"c)
            If parts.Length <> 4 OrElse parts(0) <> "PBKDF2" Then Return False
            Dim iter As Integer = Integer.Parse(parts(1), CultureInfo.InvariantCulture)
            Dim salt As Byte() = Convert.FromBase64String(parts(2))
            Dim expected As Byte() = Convert.FromBase64String(parts(3))
            Dim actual As Byte() = Derive(password, salt, iter)
            If actual.Length <> expected.Length Then Return False
            Dim diff As Integer = 0
            For i As Integer = 0 To actual.Length - 1
                diff = diff Or (actual(i) Xor expected(i))
            Next
            Return diff = 0
        Catch
            Return False
        End Try
    End Function

    Private Shared Function Derive(password As String, salt As Byte(), iterations As Integer) As Byte()
        Using kdf As New Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)
            Return kdf.GetBytes(32)
        End Using
    End Function

End Class

''' <summary>Small helpers shared by the forms (messages, grids, combo boxes, date pickers).</summary>
Public NotInheritable Class Ui

    Private Sub New()
    End Sub

    Public Const Title As String = "DentalScape"

    ' ------------------------------------------------------------ messages
    Public Shared Sub Info(msg As String)
        MessageBox.Show(msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub Warn(msg As String)
        MessageBox.Show(msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Shared Function Confirm(msg As String) As Boolean
        Return MessageBox.Show(msg, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Shared Sub [Error](ex As Exception)
        Dim msg As String = ex.Message
        Dim mex As MySqlException = TryCast(ex, MySqlException)
        If mex IsNot Nothing Then
            Dim num As Integer = CInt(mex.Number)
            If num = 1062 Then
                msg = "That value already exists (a code or name must be unique)."
            ElseIf num = 1451 OrElse num = 1452 Then
                msg = "This record is linked to other records and cannot be changed that way."
            ElseIf num = 4025 OrElse num = 3819 Then
                msg = "A value was rejected by a database rule: " & mex.Message
            ElseIf num = 0 OrElse num = 1042 OrElse num = 2002 Then
                msg = "Cannot reach the database. Start MySQL in the XAMPP Control Panel and make sure DentalClinicDB is imported." &
                      vbCrLf & vbCrLf & mex.Message
            End If
        End If
        MessageBox.Show(msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ''' <summary>Runs an action; any exception is shown in a friendly message box.</summary>
    Public Shared Sub [Try](action As Action)
        Try
            action()
        Catch ex As Exception
            [Error](ex)
        End Try
    End Sub

    ' ------------------------------------------------------------ password rules
    Public Shared ReadOnly PasswordRuleText As String() = {
        "At least 8 characters",
        "One uppercase letter (A-Z)",
        "One lowercase letter (a-z)",
        "One number (0-9)",
        "One special character (@, !, #, etc.)"}

    ''' <summary>True/False for each line of PasswordRuleText, in the same order.</summary>
    Public Shared Function PasswordRuleResults(pw As String) As Boolean()
        If pw Is Nothing Then pw = ""
        Return {pw.Length >= 8,
                pw.Any(Function(c) c >= "A"c AndAlso c <= "Z"c),
                pw.Any(Function(c) c >= "a"c AndAlso c <= "z"c),
                pw.Any(Function(c) c >= "0"c AndAlso c <= "9"c),
                pw.Any(Function(c) Not Char.IsLetterOrDigit(c) AndAlso Not Char.IsWhiteSpace(c))}
    End Function

    Public Shared Function PasswordIsStrong(pw As String) As Boolean
        Return PasswordRuleResults(pw).All(Function(ok) ok)
    End Function

    ''' <summary>
    ''' Asks for a new password twice (masked) with a live checklist: each requirement turns from red
    ''' to teal (and the mark from X to a check) as soon as the typed password meets it.
    ''' Returns Nothing when cancelled. Built in code so no extra form file is needed.
    ''' </summary>
    Public Shared Function AskPassword(prompt As String) As String
        Dim unmet As Color = Color.FromArgb(185, 56, 56)
        Dim met As Color = Color.FromArgb(14, 124, 134)

        Using f As New Form()
            f.Text = Title
            f.FormBorderStyle = FormBorderStyle.FixedDialog
            f.StartPosition = FormStartPosition.CenterParent
            f.MaximizeBox = False
            f.MinimizeBox = False
            f.ShowInTaskbar = False
            f.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)       ' labels 10pt
            f.ClientSize = New Size(400, 410)

            Dim lbl As New Label() With {.Left = 16, .Top = 14, .Width = 368, .Height = 48, .Text = prompt}
            Dim lblNew As New Label() With {.Left = 16, .Top = 68, .Width = 368, .Height = 22, .Text = "New password"}
            Dim txtNew As New TextBox() With {.Left = 16, .Top = 92, .Width = 368, .UseSystemPasswordChar = True, .Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)}

            ' one row per requirement: a mark (X / check) and its text
            Dim marks(PasswordRuleText.Length - 1) As Label
            Dim texts(PasswordRuleText.Length - 1) As Label
            For i As Integer = 0 To PasswordRuleText.Length - 1
                marks(i) = New Label() With {.Left = 20, .Top = 130 + i * 25, .Width = 22, .Height = 22,
                                             .Font = New Font("Segoe UI Symbol", 10.0F, FontStyle.Bold),
                                             .TextAlign = ContentAlignment.MiddleCenter}
                texts(i) = New Label() With {.Left = 46, .Top = 130 + i * 25, .Width = 338, .Height = 22,
                                             .TextAlign = ContentAlignment.MiddleLeft, .Text = PasswordRuleText(i)}
            Next

            Dim lblConfirm As New Label() With {.Left = 16, .Top = 264, .Width = 368, .Height = 22, .Text = "Confirm password"}
            Dim txtConfirm As New TextBox() With {.Left = 16, .Top = 288, .Width = 368, .UseSystemPasswordChar = True, .Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)}
            Dim chkShow As New CheckBox() With {.Left = 16, .Top = 326, .Width = 200, .Height = 24, .Text = "Show password"}
            Dim ok As New Button() With {.Left = 204, .Top = 362, .Width = 88, .Height = 32, .Text = "OK"}
            Dim cancel As New Button() With {.Left = 296, .Top = 362, .Width = 88, .Height = 32, .Text = "Cancel", .DialogResult = DialogResult.Cancel}

            ' re-colour the checklist on every keystroke; OK only works once every requirement is met
            Dim refreshRules As Action =
                Sub()
                    Dim results As Boolean() = PasswordRuleResults(txtNew.Text)
                    For i As Integer = 0 To results.Length - 1
                        Dim c As Color = If(results(i), met, unmet)
                        marks(i).Text = If(results(i), ChrW(&H2713), ChrW(&H2717))
                        marks(i).ForeColor = c
                        texts(i).ForeColor = c
                    Next
                    ok.Enabled = results.All(Function(r) r)
                End Sub
            AddHandler txtNew.TextChanged, Sub(s As Object, e As EventArgs) refreshRules()
            refreshRules()

            AddHandler chkShow.CheckedChanged,
                Sub(s As Object, e As EventArgs)
                    txtNew.UseSystemPasswordChar = Not chkShow.Checked
                    txtConfirm.UseSystemPasswordChar = Not chkShow.Checked
                End Sub

            AddHandler ok.Click,
                Sub(s As Object, e As EventArgs)
                    If Not PasswordIsStrong(txtNew.Text) Then
                        Warn("The password does not meet all the requirements.")
                        Return
                    End If
                    If txtNew.Text <> txtConfirm.Text Then
                        Warn("The two passwords do not match.")
                        txtConfirm.Focus()
                        Return
                    End If
                    f.DialogResult = DialogResult.OK
                End Sub

            f.Controls.AddRange(New Control() {lbl, lblNew, txtNew, lblConfirm, txtConfirm, chkShow, ok, cancel})
            f.Controls.AddRange(marks)
            f.Controls.AddRange(texts)
            f.AcceptButton = ok
            f.CancelButton = cancel

            If f.ShowDialog() <> DialogResult.OK Then Return Nothing
            Return txtNew.Text
        End Using
    End Function

    ' ------------------------------------------------------------ formatting
    Public Shared Function Money(v As Object) As String
        Return "₱" & Convert.ToDecimal(v, CultureInfo.InvariantCulture).ToString("N2", CultureInfo.InvariantCulture)
    End Function

    Public Shared Function Txt(v As Object) As String
        Return If(v Is Nothing OrElse v Is DBNull.Value, "", v.ToString())
    End Function

    ''' <summary>Trimmed text, or Nothing when blank (so the database stores NULL).</summary>
    Public Shared Function Nz(t As TextBox) As String
        Dim s As String = t.Text.Trim()
        Return If(s.Length = 0, Nothing, s)
    End Function

    ' ------------------------------------------------------------ validation
    ' Email: name@domain.tld - letters/digits with single . _ % + - inside the name, a real domain and a
    ' top-level part of 2+ letters ("juan@clinic" and "juan..cruz@x.com" are rejected).
    Private Shared ReadOnly EmailPattern As New System.Text.RegularExpressions.Regex(
        "^[A-Za-z0-9]+([._%+\-][A-Za-z0-9]+)*@[A-Za-z0-9]+(-[A-Za-z0-9]+)*(\.[A-Za-z0-9]+(-[A-Za-z0-9]+)*)*\.[A-Za-z]{2,}$")

    ' Philippine numbers, after removing spaces - ( ) . :
    '   mobile   09171234567  /  +639171234567  /  639171234567
    '   landline (02) 8123 4567  /  032 123 4567  /  +63 2 8123 4567  /  8123 4567 (no area code)
    Private Shared ReadOnly PhonePattern As New System.Text.RegularExpressions.Regex(
        "^((\+63|63|0)9\d{9}|0[2-8]\d{8,9}|(\+63|63)[2-8]\d{8,9}|[2-8]\d{6,7})$")

    Public Shared Function ValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        email = email.Trim()
        Return email.Length <= 100 AndAlso EmailPattern.IsMatch(email)
    End Function

    Public Shared Function ValidPhone(phone As String) As Boolean
        If String.IsNullOrWhiteSpace(phone) Then Return False
        Dim digits As String = System.Text.RegularExpressions.Regex.Replace(phone.Trim(), "[\s\-().]", "")
        Return PhonePattern.IsMatch(digits)
    End Function

    ''' <summary>Optional phone box: empty is fine, anything typed must be a valid number. Warns and focuses the box.</summary>
    Public Shared Function CheckPhone(box As TextBox, label As String) As Boolean
        Dim s As String = box.Text.Trim()
        If s.Length = 0 OrElse ValidPhone(s) Then Return True
        Warn($"{label} is not valid." & vbCrLf & vbCrLf &
             "Use a mobile number like 0917 123 4567 or +63 917 123 4567," & vbCrLf &
             "or a landline like (02) 8123 4567.")
        box.Focus()
        box.SelectAll()
        Return False
    End Function

    ''' <summary>Optional email box: empty is fine, anything typed must be a valid address. Warns and focuses the box.</summary>
    Public Shared Function CheckEmail(box As TextBox) As Boolean
        Dim s As String = box.Text.Trim()
        If s.Length = 0 OrElse ValidEmail(s) Then Return True
        Warn("The email address is not valid." & vbCrLf & vbCrLf & "Use the form name@example.com")
        box.Focus()
        box.SelectAll()
        Return False
    End Function

    ''' <summary>
    ''' Required boxes: every text box, combo box or tick-box date picker in the list must be filled in (spaces only count as empty).
    ''' Shows ONE message naming all the empty fields and puts the cursor in the first one.
    ''' </summary>
    Public Shared Function Require(ParamArray fields As (Box As Control, Name As String)()) As Boolean
        Dim missing As New List(Of String)()
        Dim firstEmpty As Control = Nothing
        For Each f In fields
            Dim isEmpty As Boolean
            Dim cbo As ComboBox = TryCast(f.Box, ComboBox)
            Dim dtp As DateTimePicker = TryCast(f.Box, DateTimePicker)
            If dtp IsNot Nothing Then
                isEmpty = dtp.ShowCheckBox AndAlso Not dtp.Checked
            ElseIf cbo IsNot Nothing AndAlso cbo.DropDownStyle = ComboBoxStyle.DropDownList Then
                isEmpty = cbo.SelectedIndex < 0
            Else
                isEmpty = f.Box.Text.Trim().Length = 0
            End If
            If isEmpty Then
                missing.Add(f.Name)
                If firstEmpty Is Nothing Then firstEmpty = f.Box
            End If
        Next
        If missing.Count = 0 Then Return True

        Warn("Please fill in the required field" & If(missing.Count > 1, "s", "") & ":" & vbCrLf & vbCrLf &
             String.Join(vbCrLf, missing.Select(Function(n) "   " & ChrW(&H2022) & " " & n)))
        firstEmpty.Focus()
        Return False
    End Function

    ''' <summary>KeyPress filter for phone boxes: digits, + - ( ) . and space only.</summary>
    Public Shared Sub PhoneKey(e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse "+-(). ".IndexOf(e.KeyChar) >= 0 Then Return
        e.Handled = True
    End Sub

    ' ------------------------------------------------------------ grids
    ' Grid look: header #0D317F, selected row #D9E3FA, Segoe UI 10pt Regular
    Private Shared ReadOnly GridHeaderColor As Color = ColorTranslator.FromHtml("#0D317F")
    Private Shared ReadOnly GridSelectedColor As Color = ColorTranslator.FromHtml("#D9E3FA")

    Public Shared Sub Bind(g As DataGridView, table As DataTable)
        g.DataSource = table
        g.EnableHeadersVisualStyles = False
        g.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderColor
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridHeaderColor
        g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.ColumnHeadersHeight = 34
        g.DefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 250, 251)
        g.DefaultCellStyle.SelectionBackColor = GridSelectedColor
        g.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 40, 48)
        g.AlternatingRowsDefaultCellStyle.SelectionBackColor = GridSelectedColor
        g.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 40, 48)
        g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        If g.Columns.Contains("ID") Then g.Columns("ID").Visible = False
        For Each c As DataGridViewColumn In g.Columns
            Dim dc As DataColumn = table.Columns(c.Name)
            If dc IsNot Nothing AndAlso (dc.DataType Is GetType(Decimal) OrElse dc.DataType Is GetType(Double)) Then
                c.DefaultCellStyle.Format = "N2"
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    ''' <summary>The hidden "ID" column of the current row (0 when nothing is selected).</summary>
    Public Shared Function SelectedId(g As DataGridView) As Integer
        If g.CurrentRow Is Nothing OrElse Not g.Columns.Contains("ID") Then Return 0
        Dim v As Object = g.CurrentRow.Cells("ID").Value
        Return If(v Is Nothing OrElse v Is DBNull.Value, 0, Convert.ToInt32(v))
    End Function

    Public Shared Sub SelectRow(g As DataGridView, id As Integer)
        If Not g.Columns.Contains("ID") Then Return
        Dim firstVisible As DataGridViewColumn = Nothing
        For Each c As DataGridViewColumn In g.Columns
            If c.Visible Then
                firstVisible = c
                Exit For
            End If
        Next
        If firstVisible Is Nothing Then Return
        For Each row As DataGridViewRow In g.Rows
            If row.Cells("ID").Value IsNot Nothing AndAlso Convert.ToInt32(row.Cells("ID").Value) = id Then
                g.CurrentCell = row.Cells(firstVisible.Index)
                row.Selected = True
                Return
            End If
        Next
    End Sub

    ' ------------------------------------------------------------ combo boxes
    Public Shared Sub Fill(cbo As ComboBox, table As DataTable, display As String, value As String)
        cbo.DataSource = Nothing
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.DataSource = table
        cbo.SelectedIndex = -1
    End Sub

    ''' <summary>Selected ValueMember as an Integer, or Nothing when nothing is selected.</summary>
    Public Shared Function SelId(cbo As ComboBox) As Integer?
        If cbo.SelectedIndex < 0 OrElse cbo.SelectedValue Is Nothing Then Return Nothing
        Return Convert.ToInt32(cbo.SelectedValue)
    End Function

    Public Shared Sub SelectValue(cbo As ComboBox, id As Object)
        If id Is Nothing OrElse id Is DBNull.Value Then
            cbo.SelectedIndex = -1
            Return
        End If
        cbo.SelectedValue = Convert.ToInt32(id)
    End Sub

    ''' <summary>Selects a fixed-list item by text (or puts it in the text box of an editable combo).</summary>
    Public Shared Sub SetText(cbo As ComboBox, text As String)
        If String.IsNullOrEmpty(text) Then
            cbo.SelectedIndex = -1
            If cbo.DropDownStyle = ComboBoxStyle.DropDown Then cbo.Text = ""
            Return
        End If
        Dim i As Integer = cbo.FindStringExact(text)
        If i >= 0 Then
            cbo.SelectedIndex = i
        ElseIf cbo.DropDownStyle = ComboBoxStyle.DropDown Then
            cbo.Text = text
        Else
            cbo.SelectedIndex = -1
        End If
    End Sub

    Public Shared Function GetText(cbo As ComboBox) As String
        Dim t As String = cbo.Text.Trim()
        Return If(t.Length = 0, Nothing, t)
    End Function

    ' ------------------------------------------------------------ date pickers
    ''' <summary>DateTime (date part), or Nothing when the picker has a check box that is unticked.</summary>
    Public Shared Function GetDate(d As DateTimePicker) As Object
        If d.ShowCheckBox AndAlso Not d.Checked Then Return Nothing
        Return d.Value.Date
    End Function

    Public Shared Sub SetDate(d As DateTimePicker, value As Object)
        If value Is Nothing OrElse value Is DBNull.Value Then
            If d.ShowCheckBox Then d.Checked = False
            Return
        End If
        d.Value = Convert.ToDateTime(value)
        If d.ShowCheckBox Then d.Checked = True
    End Sub

    Public Shared Function GetTime(d As DateTimePicker) As TimeSpan
        Return New TimeSpan(d.Value.Hour, d.Value.Minute, 0)
    End Function

    Public Shared Sub SetTime(d As DateTimePicker, value As Object)
        If value Is Nothing OrElse value Is DBNull.Value Then
            If d.ShowCheckBox Then d.Checked = False
            Return
        End If
        Dim ts As TimeSpan = If(TypeOf value Is TimeSpan, DirectCast(value, TimeSpan), TimeSpan.Parse(value.ToString()))
        d.Value = DateTime.Today.Add(ts)
        If d.ShowCheckBox Then d.Checked = True
    End Sub

    ' ------------------------------------------------------------ numbers
    Public Shared Sub SetNum(n As NumericUpDown, value As Object)
        Dim v As Decimal = If(value Is Nothing OrElse value Is DBNull.Value, 0D, Convert.ToDecimal(value, CultureInfo.InvariantCulture))
        n.Value = Math.Min(n.Maximum, Math.Max(n.Minimum, v))
    End Sub

End Class

''' <summary>ListBox that never takes focus, so clicking a suggestion does not pull focus from the text box.</summary>
Friend NotInheritable Class SuggestList
    Inherits ListBox

    Public Sub New()
        SetStyle(ControlStyles.Selectable, False)
        TabStop = False
    End Sub
End Class

''' <summary>
''' Makes a patient combo box work like a search box: type a patient ID or any part of the name and a
''' list of matching patients appears under the box and narrows with every character typed.
''' The combo's DataSource must be a DataTable with the columns ID and Name ("PAT-00001 - Last, First").
''' </summary>
Public NotInheritable Class PatientSearch

    Private ReadOnly _cbo As ComboBox
    Private ReadOnly _list As New SuggestList()
    Private ReadOnly _ids As New List(Of Integer)()
    Private _host As Form
    Private _busy As Boolean

    Public Sub New(cbo As ComboBox)
        _cbo = cbo
        cbo.DropDownStyle = ComboBoxStyle.DropDown
        cbo.AutoCompleteMode = AutoCompleteMode.None
        cbo.AutoCompleteSource = AutoCompleteSource.None

        _list.Visible = False
        _list.BorderStyle = BorderStyle.FixedSingle
        _list.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        _list.IntegralHeight = False

        AddHandler cbo.TextChanged, AddressOf OnTextChanged
        AddHandler cbo.KeyDown, AddressOf OnKeyDown
        AddHandler cbo.Leave, AddressOf OnLeave
        AddHandler cbo.DropDown, Sub(s As Object, e As EventArgs) HideList()
        AddHandler _list.MouseClick, AddressOf OnListClick
        AddHandler _list.MouseMove, AddressOf OnListHover
    End Sub

    Private Function Source() As DataTable
        Return TryCast(_cbo.DataSource, DataTable)
    End Function

    Private Shared Function Words(text As String) As String()
        Return text.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries)
    End Function

    ' ------------------------------------------------------------ suggestions
    Private Sub OnTextChanged(sender As Object, e As EventArgs)
        If _busy OrElse Not _cbo.ContainsFocus Then Return
        Dim typed As String = _cbo.Text.Trim()
        If typed.Length = 0 Then
            HideList()
            Return
        End If
        Dim t As DataTable = Source()
        If t Is Nothing Then Return

        Dim ws As String() = Words(typed)
        _ids.Clear()
        _list.Items.Clear()
        For Each r As DataRow In t.Rows
            Dim name As String = r("Name").ToString()
            Dim ok As Boolean = True
            For Each w In ws
                If name.IndexOf(w, StringComparison.OrdinalIgnoreCase) < 0 Then
                    ok = False
                    Exit For
                End If
            Next
            If ok Then
                _ids.Add(Convert.ToInt32(r("ID")))
                _list.Items.Add(name)
                If _ids.Count >= 50 Then Exit For
            End If
        Next

        If _ids.Count = 0 Then
            HideList()
            Return
        End If
        ShowList()
    End Sub

    Private Sub ShowList()
        If _host Is Nothing Then
            _host = _cbo.FindForm()
            If _host Is Nothing Then Return
            _host.Controls.Add(_list)
        End If
        Dim pt As Point = _host.PointToClient(_cbo.Parent.PointToScreen(New Point(_cbo.Left, _cbo.Bottom)))
        Dim rows As Integer = Math.Min(_ids.Count, 8)
        _list.SetBounds(pt.X, pt.Y, Math.Max(_cbo.Width, 380), rows * _list.ItemHeight + 4)
        _list.BringToFront()
        _list.Visible = True
        _list.SelectedIndex = 0
    End Sub

    Private Sub HideList()
        _list.Visible = False
    End Sub

    Private Sub OnListHover(sender As Object, e As MouseEventArgs)
        Dim i As Integer = _list.IndexFromPoint(e.Location)
        If i >= 0 AndAlso i <> _list.SelectedIndex Then _list.SelectedIndex = i
    End Sub

    Private Sub OnListClick(sender As Object, e As MouseEventArgs)
        Dim i As Integer = _list.IndexFromPoint(e.Location)
        If i >= 0 AndAlso i < _ids.Count Then Pick(_ids(i))
    End Sub

    Private Sub Pick(id As Integer)
        _busy = True
        Try
            Ui.SelectValue(_cbo, id)
        Finally
            _busy = False
        End Try
        HideList()
        _cbo.SelectionStart = _cbo.Text.Length
    End Sub

    Private Sub OnKeyDown(sender As Object, e As KeyEventArgs)
        If _list.Visible Then
            Select Case e.KeyCode
                Case Keys.Down
                    If _list.SelectedIndex < _list.Items.Count - 1 Then _list.SelectedIndex += 1
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
                Case Keys.Up
                    If _list.SelectedIndex > 0 Then _list.SelectedIndex -= 1
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
                Case Keys.Escape
                    HideList()
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
                Case Keys.Enter
                    e.SuppressKeyPress = True
                    If _list.SelectedIndex >= 0 AndAlso _list.SelectedIndex < _ids.Count Then Pick(_ids(_list.SelectedIndex))
                    MoveNext()
                    Return
            End Select
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim id As Integer? = Resolve(True)
            If id.HasValue Then
                Pick(id.Value)
                MoveNext()
            End If
        End If
    End Sub

    Private Sub MoveNext()
        If _host IsNot Nothing Then _host.SelectNextControl(_cbo, True, True, True, True)
    End Sub

    ' leaving the box turns what was typed into the full patient entry when it is a single match
    Private Sub OnLeave(sender As Object, e As EventArgs)
        HideList()
        Try
            Dim id As Integer? = Resolve(False)
            If Not id.HasValue Then Return
            Dim cur As Integer? = Ui.SelId(_cbo)
            If Not cur.HasValue OrElse cur.Value <> id.Value Then
                _busy = True
                Try
                    Ui.SelectValue(_cbo, id.Value)
                Finally
                    _busy = False
                End Try
            End If
        Catch
        End Try
    End Sub

    ' ------------------------------------------------------------ what does the box mean?
    ''' <summary>
    ''' The patient the box means: one picked from the list, a patient ID (PAT-00001, 00001 or 1) or part of
    ''' a name. Nothing when there is no single match (explains why when showMessages is True).
    ''' </summary>
    Public Function Resolve(showMessages As Boolean) As Integer?
        Dim typed As String = _cbo.Text.Trim()
        If typed.Length = 0 Then Return Nothing
        Dim t As DataTable = Source()
        If t Is Nothing Then Return Nothing

        Dim picked As Integer? = Ui.SelId(_cbo)
        If picked.HasValue AndAlso String.Equals(_cbo.GetItemText(_cbo.SelectedItem), typed, StringComparison.OrdinalIgnoreCase) Then
            Return picked
        End If

        Dim key As String = typed
        Dim dash As Integer = key.IndexOf(" - ", StringComparison.Ordinal)
        If dash > 0 Then key = key.Substring(0, dash).Trim()

        Dim found As New List(Of DataRow)()
        Dim idNum As Integer
        Dim m As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(
            key, "^(?:PAT-?)?0*(\d+)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        If m.Success AndAlso Integer.TryParse(m.Groups(1).Value, idNum) Then
            Dim code As String = $"PAT-{idNum:D5} - "
            For Each r As DataRow In t.Rows
                If r("Name").ToString().StartsWith(code, StringComparison.OrdinalIgnoreCase) Then found.Add(r)
            Next
        Else
            Dim ws As String() = Words(key)
            If ws.Length = 0 Then Return Nothing
            For Each r As DataRow In t.Rows
                Dim name As String = r("Name").ToString()
                Dim ok As Boolean = True
                For Each w In ws
                    If name.IndexOf(w, StringComparison.OrdinalIgnoreCase) < 0 Then
                        ok = False
                        Exit For
                    End If
                Next
                If ok Then found.Add(r)
            Next
        End If

        If found.Count = 1 Then Return Convert.ToInt32(found(0)("ID"))

        ' several partial matches: an exact "Last, First" / "First Last" match wins
        Dim exactId As Integer = 0
        Dim exactCount As Integer = 0
        For Each r As DataRow In found
            Dim full As String = r("Name").ToString()
            Dim at As Integer = full.IndexOf(" - ", StringComparison.Ordinal)
            Dim person As String = If(at >= 0, full.Substring(at + 3), full)       ' "Last, First"
            Dim parts As String() = person.Split(New String() {", "}, 2, StringSplitOptions.None)
            Dim swapped As String = If(parts.Length = 2, parts(1) & " " & parts(0), person)
            If String.Equals(key, person, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(key, swapped, StringComparison.OrdinalIgnoreCase) Then
                exactId = Convert.ToInt32(r("ID"))
                exactCount += 1
            End If
        Next
        If exactCount = 1 Then Return exactId

        If showMessages Then
            If found.Count = 0 Then
                Ui.Warn($"No patient matches ""{typed}"". Type the patient ID (for example PAT-00001) or the patient's name.")
            Else
                Dim list As New System.Text.StringBuilder()
                For i As Integer = 0 To Math.Min(found.Count, 8) - 1
                    list.AppendLine(found(i)("Name").ToString())
                Next
                If found.Count > 8 Then list.AppendLine("...")
                Ui.Warn($"More than one patient matches ""{typed}"". Type more of the name or the patient ID:" & vbCrLf & vbCrLf & list.ToString())
            End If
        End If
        Return Nothing
    End Function

End Class

''' <summary>Export Report: the choices popup and the CSV writer (opens in Excel).</summary>
Public NotInheritable Class Reports

    Private Sub New()
    End Sub

    Public Shared ReadOnly Choices As String() = {
        "Audit Log", "Patient Records", "Appointments", "Billing & Payments", "Inventory", "Clinical Records"}

    ''' <summary>Shows the list of reports; returns the chosen name, or Nothing when cancelled.</summary>
    Public Shared Function Pick() As String
        Using f As New Form()
            f.Text = "Export Report"
            f.FormBorderStyle = FormBorderStyle.FixedDialog
            f.StartPosition = FormStartPosition.CenterParent
            f.MaximizeBox = False
            f.MinimizeBox = False
            f.ShowInTaskbar = False
            f.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
            f.ClientSize = New Size(340, 62 + Choices.Length * 32 + 64)

            Dim lbl As New Label() With {.Left = 16, .Top = 14, .Width = 308, .Height = 24, .Text = "Choose the report to export:"}
            f.Controls.Add(lbl)

            Dim radios As New List(Of RadioButton)()
            For i As Integer = 0 To Choices.Length - 1
                Dim rb As New RadioButton() With {.Left = 28, .Top = 46 + i * 32, .Width = 290, .Height = 26,
                                                  .Text = Choices(i), .Checked = (i = 0)}
                radios.Add(rb)
                f.Controls.Add(rb)
            Next

            Dim top As Integer = 62 + Choices.Length * 32 + 14
            Dim ok As New Button() With {.Left = 140, .Top = top, .Width = 90, .Height = 32, .Text = "Export", .DialogResult = DialogResult.OK}
            Dim cancel As New Button() With {.Left = 236, .Top = top, .Width = 90, .Height = 32, .Text = "Cancel", .DialogResult = DialogResult.Cancel}
            f.Controls.Add(ok)
            f.Controls.Add(cancel)
            f.AcceptButton = ok
            f.CancelButton = cancel

            If f.ShowDialog() <> DialogResult.OK Then Return Nothing
            For i As Integer = 0 To radios.Count - 1
                If radios(i).Checked Then Return Choices(i)
            Next
            Return Nothing
        End Using
    End Function

    ''' <summary>Asks where to save and writes the table as a UTF-8 CSV. Returns the path, or Nothing when cancelled.</summary>
    Public Shared Function SaveCsv(table As DataTable, defaultName As String) As String
        Using dlg As New SaveFileDialog()
            dlg.Title = "Export Report"
            dlg.Filter = "CSV file (opens in Excel) (*.csv)|*.csv"
            dlg.FileName = defaultName
            dlg.OverwritePrompt = True
            If dlg.ShowDialog() <> DialogResult.OK Then Return Nothing

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine(String.Join(",", table.Columns.Cast(Of DataColumn)().Select(Function(c) Cell(c.ColumnName))))
            For Each r As DataRow In table.Rows
                sb.AppendLine(String.Join(",", table.Columns.Cast(Of DataColumn)().Select(Function(c) Cell(r(c)))))
            Next
            System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), New System.Text.UTF8Encoding(True))
            Return dlg.FileName
        End Using
    End Function

    Private Shared Function Cell(v As Object) As String
        If v Is Nothing OrElse v Is DBNull.Value Then Return ""
        Dim s As String
        If TypeOf v Is DateTime Then
            s = DirectCast(v, DateTime).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        ElseIf TypeOf v Is Decimal Then
            s = DirectCast(v, Decimal).ToString("0.00", CultureInfo.InvariantCulture)
        ElseIf TypeOf v Is Double Then
            s = DirectCast(v, Double).ToString("0.00", CultureInfo.InvariantCulture)
        Else
            s = Convert.ToString(v, CultureInfo.InvariantCulture)
            ' text that starts like a formula is neutralised so Excel does not run it
            If s.Length > 0 AndAlso "=+-@".IndexOf(s(0)) >= 0 Then s = "'" & s
        End If
        If s.IndexOfAny(New Char() {","c, """"c, ControlChars.Cr, ControlChars.Lf}) >= 0 Then s = """" & s.Replace("""", """""") & """"
        Return s
    End Function

End Class
