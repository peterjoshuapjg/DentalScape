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

    ''' <summary>
    ''' Asks for a new password twice (masked). Returns Nothing when cancelled.
    ''' Built in code so no extra form file is needed - it behaves like a MessageBox.
    ''' </summary>
    Public Shared Function AskPassword(prompt As String) As String
        Using f As New Form()
            f.Text = Title
            f.FormBorderStyle = FormBorderStyle.FixedDialog
            f.StartPosition = FormStartPosition.CenterParent
            f.MaximizeBox = False
            f.MinimizeBox = False
            f.ShowInTaskbar = False
            f.ClientSize = New Size(380, 215)

            Dim lbl As New Label() With {.Left = 16, .Top = 14, .Width = 348, .Height = 44, .Text = prompt}
            Dim lblNew As New Label() With {.Left = 16, .Top = 66, .Width = 348, .Text = "New password (at least 6 characters)"}
            Dim txtNew As New TextBox() With {.Left = 16, .Top = 84, .Width = 348, .UseSystemPasswordChar = True}
            Dim lblConfirm As New Label() With {.Left = 16, .Top = 116, .Width = 348, .Text = "Confirm password"}
            Dim txtConfirm As New TextBox() With {.Left = 16, .Top = 134, .Width = 348, .UseSystemPasswordChar = True}
            Dim ok As New Button() With {.Left = 190, .Top = 172, .Width = 84, .Height = 28, .Text = "OK"}
            Dim cancel As New Button() With {.Left = 280, .Top = 172, .Width = 84, .Height = 28, .Text = "Cancel", .DialogResult = DialogResult.Cancel}

            AddHandler ok.Click,
                Sub(s As Object, e As EventArgs)
                    If txtNew.Text.Length < 6 Then
                        Warn("The password must be at least 6 characters long.")
                        Return
                    End If
                    If txtNew.Text <> txtConfirm.Text Then
                        Warn("The two passwords do not match.")
                        Return
                    End If
                    f.DialogResult = DialogResult.OK
                End Sub

            f.Controls.AddRange(New Control() {lbl, lblNew, txtNew, lblConfirm, txtConfirm, ok, cancel})
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

    Public Shared Function ValidEmail(email As String) As Boolean
        Try
            Return New MailAddress(email).Address = email
        Catch
            Return False
        End Try
    End Function

    ' ------------------------------------------------------------ grids
    Public Shared Sub Bind(g As DataGridView, table As DataTable)
        g.DataSource = table
        g.EnableHeadersVisualStyles = False
        g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 124, 134)
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(14, 124, 134)
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.ColumnHeadersHeight = 32
        g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 250, 251)
        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 233)
        g.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 40, 48)
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
