Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Charting = System.Windows.Forms.DataVisualization.Charting

''' <summary>
''' The one and only working window. Every page is a Panel on this form; clicking a sidebar button
''' hides the current panel and shows the chosen one (see OpenPage). All screen logic is in this file.
''' </summary>
Public Class frmMain

    ' ============================================================ navigation (panel.Hide / panel.Show)
    Private NotInheritable Class PageInfo
        Public ReadOnly Property Title As String
        Public ReadOnly Property AdminOnly As Boolean
        Public ReadOnly Property Host As Panel
        Public ReadOnly Property OnOpen As Action

        Public Sub New(title As String, adminOnly As Boolean, host As Panel, onOpen As Action)
            Me.Title = title
            Me.AdminOnly = adminOnly
            Me.Host = host
            Me.OnOpen = onOpen
        End Sub
    End Class

    Private ReadOnly _pages As New Dictionary(Of Button, PageInfo)()
    Private _current As Panel

    ''' <summary>True when the user chose "Sign Out" (so the sign-in screen comes back).</summary>
    Public Property LoggedOut As Boolean

    Private Shared ReadOnly NavNormal As Color = Color.FromArgb(13, 49, 127)
    Private Shared ReadOnly NavActive As Color = Color.FromArgb(36, 73, 163)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizedBounds = Screen.FromControl(Me).WorkingArea
        Me.WindowState = FormWindowState.Maximized

        lblUser.Text = Session.FullName & "   |   " & Session.Role

        ' Codes are automatic: the procedure code box can be read but not typed in.
        txtProcCode.ReadOnly = True

        ' Patient phone numbers: digits only, 11 digits.
        txtContact.MaxLength = 11
        txtEmergNum.MaxLength = 11

        ' Dashboard low-stock list: read-only, whole-row selection (double-click opens Inventory).
        dgvLowStockProducts.ReadOnly = True
        dgvLowStockProducts.AllowUserToAddRows = False
        dgvLowStockProducts.AllowUserToDeleteRows = False
        dgvLowStockProducts.RowHeadersVisible = False
        dgvLowStockProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        _pages(btnNavDashboard) = New PageInfo("Dashboard", False, pnlDashboard, AddressOf OpenDashboard)
        _pages(btnNavPatients) = New PageInfo("Patients", False, pnlPatients, AddressOf OpenPatients)
        _pages(btnNavAppointments) = New PageInfo("Appointments", False, pnlAppointment, AddressOf OpenAppointments)
        _pages(btnNavBilling) = New PageInfo("Billing & Payments", False, pnlBillingpayments, AddressOf OpenBilling)
        _pages(btnNavClinical) = New PageInfo("Clinical Records", True, pnlClinicalRecord, AddressOf OpenClinical)
        _pages(btnNavProcedures) = New PageInfo("Procedures & Prices", True, pnlProcedures, AddressOf OpenProcedures)
        _pages(btnNavInventory) = New PageInfo("Inventory", True, pnlInventory, AddressOf OpenInventory)
        _pages(btnNavStaff) = New PageInfo("Staff & Accounts", True, pnlStaff, AddressOf OpenStaff)
        _pages(btnNavAudit) = New PageInfo("Audit Log", True, pnlAuditlog, AddressOf OpenAudit)

        ' Start with every page panel hidden; the Front Desk account never sees the admin-only pages.
        For Each kv In _pages
            kv.Value.Host.Hide()
            kv.Key.Visible = Not (kv.Value.AdminOnly AndAlso Not Session.IsAdmin)
        Next

        OpenPage(btnNavDashboard)
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click, btnNavPatients.Click, btnNavAppointments.Click, btnNavBilling.Click, btnNavClinical.Click, btnNavProcedures.Click, btnNavInventory.Click, btnNavStaff.Click, btnNavAudit.Click
        OpenPage(DirectCast(sender, Button))
    End Sub

    Private Sub OpenPage(button As Button)
        Dim page As PageInfo = Nothing
        If Not _pages.TryGetValue(button, page) Then Return
        If page.AdminOnly AndAlso Not Session.IsAdmin Then
            Ui.Warn("Only the administrator can open this page.")
            Return
        End If

        ' hide the panel that is showing, show the one that was clicked
        If _current IsNot Nothing Then _current.Hide()
        page.Host.Show()
        page.Host.BringToFront()
        _current = page.Host

        lblPageTitle.Text = page.Title
        For Each b In _pages.Keys
            b.BackColor = If(b Is button, NavActive, NavNormal)
        Next

        Ui.Try(page.OnOpen)     ' (re)load the data of the page that was just opened
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim newPass As String = Ui.AskPassword("Choose a new password for your account.")
        If newPass Is Nothing Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET PasswordHash = @h WHERE UserID = @id", ("@h", Pwd.Hash(newPass)), ("@id", Session.UserId))
                   Audit.Log("Change Own Password", "tblUsers", Session.UserId)
                   Ui.Info("Your password was changed.")
               End Sub)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If Not Ui.Confirm("Sign out now?") Then Return
        Audit.Log("Logout", "tblUsers", Session.UserId)
        Session.Clear()
        LoggedOut = True
        Close()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If LoggedOut Then
            frmLogin.ShowAgain()
        Else
            Application.Exit()
        End If
    End Sub

    ' ============================================================ DASHBOARD
    Private Sub OpenDashboard()
        pnlCardLow.Visible = Session.IsAdmin   ' inventory is an admin topic
        lblLowStocks.Visible = Session.IsAdmin
        dgvLowStockProducts.Visible = Session.IsAdmin
        LoadDashboard()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Try(AddressOf LoadDashboard)
    End Sub

    Private Sub LoadDashboard()
        lblTodayCount.Text = Convert.ToString(Db.Scalar(
            "SELECT COUNT(*) FROM tblAppointments WHERE AppointmentDate = CURDATE() AND Status NOT IN ('Cancelled','No-show')"))
        lblPendingCount.Text = Convert.ToString(Db.Scalar(
            "SELECT COUNT(*) FROM tblAppointments WHERE Status = 'Pending' AND AppointmentDate >= CURDATE()"))

        Dim unpaid As DataTable = Db.Query(
            "SELECT COUNT(*) AS Cnt, IFNULL(SUM(Balance), 0) AS Bal FROM tblInvoices WHERE Status IN ('Unpaid','Partially Paid')")
        lblUnpaidCount.Text = Convert.ToString(unpaid.Rows(0)("Cnt"))
        lblUnpaidAmount.Text = Ui.Money(unpaid.Rows(0)("Bal")) & " outstanding"

        If Session.IsAdmin Then
            lblLowStockCount.Text = Convert.ToString(Db.Scalar("SELECT COUNT(*) FROM vwLowStockProducts"))
        End If

        Ui.Bind(dgvToday, Db.Query("
            SELECT AppointmentCode AS Code,
                   TIME_FORMAT(StartTime, '%h:%i %p') AS `Time`,
                   PatientName AS Patient, DentistName AS Dentist,
                   AppointmentType AS `Type`, Status
            FROM vwAppointmentDetails
            WHERE AppointmentDate = CURDATE()
            ORDER BY StartTime"))

        LoadRevenueChart()
        LoadTopProcedureChart()
        If Session.IsAdmin Then LoadLowStockGrid()
    End Sub

    Private Shared ReadOnly ChartBlue As Color = ColorTranslator.FromHtml("#0D317F")

    ''' <summary>chtMonthlyRevenue: payments received on each day of the current month (void invoices left out).</summary>
    Private Sub LoadRevenueChart()
        Dim monthStart As New DateTime(Date.Today.Year, Date.Today.Month, 1)
        Dim days As Integer = DateTime.DaysInMonth(monthStart.Year, monthStart.Month)
        Dim t As DataTable = Db.Query("
            SELECT DAY(p.PaymentDate) AS D, SUM(p.Amount) AS Amt
            FROM tblPayments p
            INNER JOIN tblInvoices i ON i.InvoiceID = p.InvoiceID
            WHERE i.Status <> 'Void' AND p.PaymentDate >= @s AND p.PaymentDate < @e
            GROUP BY DAY(p.PaymentDate)",
            ("@s", monthStart), ("@e", monthStart.AddMonths(1)))

        Dim perDay(days) As Decimal
        For Each r As DataRow In t.Rows
            perDay(Convert.ToInt32(r("D"))) = Convert.ToDecimal(r("Amt"))
        Next

        chtMonthlyRevenue.Series.Clear()
        chtMonthlyRevenue.Legends.Clear()
        chtMonthlyRevenue.Titles.Clear()
        Dim ser As Charting.Series = chtMonthlyRevenue.Series.Add("Revenue")
        ser.ChartType = Charting.SeriesChartType.Column
        ser.Color = ChartBlue
        ser.ToolTip = "Day #VALX: " & ChrW(&H20B1) & "#VALY{N2}"
        For d As Integer = 1 To days
            ser.Points.AddXY(d, perDay(d))
        Next

        Dim area As Charting.ChartArea = chtMonthlyRevenue.ChartAreas(0)
        ser.IsXValueIndexed = True                ' bars sit at 1..days, so the axis shows no 0 or days+1
        area.AxisX.Interval = 1
        area.AxisX.Title = monthStart.ToString("MMMM yyyy")
        area.AxisX.MajorGrid.Enabled = False
        area.AxisY.Title = "Amount received (" & ChrW(&H20B1) & ")"
        area.AxisY.LabelStyle.Format = "N0"
        area.AxisY.MajorGrid.LineColor = Color.Gainsboro

        ' Dynamic Y scale: gridlines every 10,000, top rounds up to the next 10k above the highest day.
        Dim peak As Double = 0
        For d As Integer = 1 To days
            If CDbl(perDay(d)) > peak Then peak = CDbl(perDay(d))
        Next
        Const stepSize As Double = 10000
        area.AxisY.Minimum = 0
        area.AxisY.Interval = stepSize
        area.AxisY.Maximum = Math.Max(stepSize, Math.Ceiling(peak / stepSize) * stepSize)
    End Sub

    ''' <summary>chtTopProcedure: the five most-used procedures of this month's visits (cancelled treatments left out).</summary>
    Private Sub LoadTopProcedureChart()
        Dim monthStart As New DateTime(Date.Today.Year, Date.Today.Month, 1)
        Dim t As DataTable = Db.Query("
            SELECT pr.ProcedureName AS ProcName, CAST(SUM(t.Quantity) AS SIGNED) AS Cnt
            FROM tblTreatmentRecords t
            INNER JOIN tblDentalRecords r ON r.DentalRecordID = t.DentalRecordID
            INNER JOIN tblProcedures pr ON pr.ProcedureID = t.ProcedureID
            WHERE t.TreatmentStatus <> 'Cancelled' AND r.VisitDate >= @s AND r.VisitDate < @e
            GROUP BY pr.ProcedureID, pr.ProcedureName
            ORDER BY Cnt DESC, pr.ProcedureName
            LIMIT 5",
            ("@s", monthStart), ("@e", monthStart.AddMonths(1)))

        chtTopProcedure.Series.Clear()
        chtTopProcedure.Legends.Clear()
        chtTopProcedure.Titles.Clear()
        Dim ser As Charting.Series = chtTopProcedure.Series.Add("Times performed")
        ser.ChartType = Charting.SeriesChartType.Bar
        ser.Color = ChartBlue
        ser.IsValueShownAsLabel = True
        ser.ToolTip = "#VALX: #VALY time(s)"

        ' A bar chart draws its first point at the bottom, so add the rows in reverse
        ' to get the top procedure at the top.
        For i As Integer = t.Rows.Count - 1 To 0 Step -1
            ser.Points.AddXY(t.Rows(i)("ProcName").ToString(), Convert.ToInt32(t.Rows(i)("Cnt")))
        Next

        If t.Rows.Count = 0 Then
            chtTopProcedure.Titles.Add("No completed procedures recorded this month yet")
        End If

        Dim area As Charting.ChartArea = chtTopProcedure.ChartAreas(0)
        area.AxisX.Interval = 1
        area.AxisX.MajorGrid.Enabled = False
        area.AxisX.LabelStyle.TruncatedLabels = False
        area.AxisY.Minimum = 0
        If t.Rows.Count > 0 Then
            Dim maxCnt As Integer = Convert.ToInt32(t.Rows(0)("Cnt"))
            area.AxisY.Maximum = maxCnt + Math.Max(1, CInt(Math.Ceiling(maxCnt * 0.15)))   ' room for the value label
            area.AxisY.Interval = Math.Max(1, CInt(Math.Ceiling(maxCnt / 5.0)))             ' whole numbers only
        Else
            area.AxisY.Maximum = 5
            area.AxisY.Interval = 1
        End If
        area.AxisY.Title = "Times performed"
        area.AxisY.MajorGrid.LineColor = Color.Gainsboro
        area.AxisY.LabelStyle.Format = "0"
        chtTopProcedure.Invalidate()
    End Sub

    ''' <summary>dgvLowStockProducts: products at or below their reorder level.</summary>
    Private Sub LoadLowStockGrid()
        Ui.Bind(dgvLowStockProducts, Db.Query("
            SELECT ProductID AS ID, ProductCode AS Code, ProductName AS Product,
                   CategoryName AS Category, CurrentStock AS Stock, ReorderLevel AS Reorder
            FROM vwLowStockProducts
            ORDER BY (CurrentStock - ReorderLevel), ProductName"))
    End Sub

    ' Double-click a low-stock product: go to Inventory with that product selected.
    Private Sub dgvLowStockProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLowStockProducts.CellDoubleClick
        If e.RowIndex < 0 OrElse Not Session.IsAdmin Then Return
        Dim productId As Integer = Ui.SelectedId(dgvLowStockProducts)
        OpenPage(btnNavInventory)
        If productId > 0 Then Ui.Try(Sub() LoadProducts(productId))
    End Sub

    ' ============================================================ AUDIT LOG
    Private Const LogPageSize As Integer = 25
    Private _logPage As Integer = 0          ' zero-based current page of the audit grid

    Private Sub OpenAudit()
        dtpFrom.Value = DateTime.Today.AddDays(-7)
        dtpTo.Value = DateTime.Today
        _logPage = 0
        LoadLog()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        _logPage = 0                          ' a new search always starts at page 1
        Ui.Try(AddressOf LoadLog)
    End Sub

    Private Sub btnLogPrev_Click(sender As Object, e As EventArgs) Handles btnLogPrev.Click
        If _logPage > 0 Then
            _logPage -= 1
            Ui.Try(AddressOf LoadLog)
        End If
    End Sub

    Private Sub btnLogNext_Click(sender As Object, e As EventArgs) Handles btnLogNext.Click
        _logPage += 1                         ' LoadLog clamps this to the last page
        Ui.Try(AddressOf LoadLog)
    End Sub

    Private Sub LoadLog()
        Dim fromDate As DateTime = dtpFrom.Value.Date
        Dim toDate As DateTime = dtpTo.Value.Date.AddDays(1)

        ' KPI cards + page count: counted over the whole date range (not just the 25 rows on this page)
        Dim k As DataRow = Db.Query("
            SELECT COUNT(*) AS Total,
                   IFNULL(SUM(Action = 'Login'), 0) AS Logins,
                   IFNULL(SUM(Action = 'Logout'), 0) AS Logouts,
                   IFNULL(SUM(Action NOT IN ('Login', 'Logout', 'Login Failed', 'Account Locked', 'Export Report')), 0) AS Changes
            FROM tblAuditLogs
            WHERE Timestamp >= @from AND Timestamp < @to",
            ("@from", fromDate), ("@to", toDate)).Rows(0)
        Dim total As Long = Convert.ToInt64(k("Total"))
        lblTotalLogsCounter.Text = total.ToString("N0")
        lblLoginCounter.Text = Convert.ToInt64(k("Logins")).ToString("N0")
        lblChangesCounter.Text = Convert.ToInt64(k("Changes")).ToString("N0")
        lblLogoutCounter.Text = Convert.ToInt64(k("Logouts")).ToString("N0")

        Dim pageCount As Integer = Math.Max(1, CInt(Math.Ceiling(total / CDbl(LogPageSize))))
        _logPage = Math.Max(0, Math.Min(_logPage, pageCount - 1))

        Dim table As DataTable = Db.Query("
            SELECT DATE_FORMAT(a.Timestamp, '%Y-%m-%d %H:%i:%s') AS `Time`,
                   IFNULL(u.Username, '(none)') AS `User`,
                   a.Action, IFNULL(a.NewValue, '') AS `New`
            FROM tblAuditLogs a
            LEFT JOIN tblUsers u ON u.UserID = a.UserID
            WHERE a.Timestamp >= @from AND a.Timestamp < @to
            ORDER BY a.AuditLogID DESC
            LIMIT @size OFFSET @offset",
            ("@from", fromDate), ("@to", toDate),
            ("@size", LogPageSize), ("@offset", _logPage * LogPageSize))
        Ui.Bind(dgvLog, table)

        If total = 0 Then
            lblCount.Text = "0 entries"
        Else
            Dim first As Long = CLng(_logPage) * LogPageSize + 1
            lblCount.Text = $"Showing {first:N0}-{first + table.Rows.Count - 1:N0} of {total:N0} entries"
        End If
        lblLogPage.Text = $"Page {_logPage + 1:N0} of {pageCount:N0}   ({total:N0} entries)"
        btnLogPrev.Enabled = _logPage > 0
        btnLogNext.Enabled = _logPage < pageCount - 1
    End Sub

    ' ---- Export Reports: pick a report from the popup, then save it as a CSV (opens in Excel)
    Private Sub btnExportReports_Click(sender As Object, e As EventArgs) Handles btnExportReports.Click
        Dim choice As String = Reports.Pick()
        If choice Is Nothing Then Return
        Ui.Try(Sub()
                   Dim table As DataTable = BuildReport(choice)
                   Dim fileName As String = choice.Replace(" & ", "_").Replace(" ", "_") & "_" & DateTime.Today.ToString("yyyyMMdd") & ".csv"
                   Dim path As String = Reports.SaveCsv(table, fileName)
                   If path Is Nothing Then Return
                   Audit.Log("Export Report", "Reports", Nothing, Nothing, $"{choice} ({table.Rows.Count} rows)")
                   Ui.Info($"{choice} exported ({table.Rows.Count} rows):" & vbCrLf & path)
               End Sub)
    End Sub

    Private Function BuildReport(choice As String) As DataTable
        Select Case choice
            Case "Audit Log"          ' follows the From / To dates on this page
                Return Db.Query("
                    SELECT DATE_FORMAT(a.Timestamp, '%Y-%m-%d %H:%i:%s') AS `Time`,
                           IFNULL(u.Username, '(none)') AS `User`,
                           a.Action, IFNULL(a.NewValue, '') AS Details
                    FROM tblAuditLogs a
                    LEFT JOIN tblUsers u ON u.UserID = a.UserID
                    WHERE a.Timestamp >= @from AND a.Timestamp < @to
                    ORDER BY a.AuditLogID DESC",
                    ("@from", dtpFrom.Value.Date), ("@to", dtpTo.Value.Date.AddDays(1)))
            Case "Patient Records"
                Return Db.Query("
                    SELECT PatientCode AS `Patient ID`, LastName AS `Last Name`, FirstName AS `First Name`,
                           IFNULL(MiddleName, '') AS `Middle Name`,
                           IFNULL(DATE_FORMAT(BirthDate, '%Y-%m-%d'), '') AS `Birth Date`,
                           IFNULL(Gender, '') AS Gender, IFNULL(ContactNumber, '') AS `Contact Number`,
                           IFNULL(Email, '') AS Email, IFNULL(Address, '') AS Address,
                           IFNULL(EmergencyContactName, '') AS `Emergency Contact`,
                           IFNULL(EmergencyContactNumber, '') AS `Emergency Number`,
                           Status, DATE_FORMAT(RegistrationDate, '%Y-%m-%d') AS Registered
                    FROM tblPatients ORDER BY LastName, FirstName")
            Case "Appointments"
                Return Db.Query("
                    SELECT a.AppointmentCode AS `Appointment ID`,
                           DATE_FORMAT(a.AppointmentDate, '%Y-%m-%d') AS `Date`,
                           TIME_FORMAT(a.StartTime, '%h:%i %p') AS `Start`,
                           IFNULL(TIME_FORMAT(a.EndTime, '%h:%i %p'), '') AS `End`,
                           CONCAT(p.LastName, ', ', p.FirstName) AS Patient,
                           CONCAT(s.FirstName, ' ', s.LastName) AS Dentist,
                           t.TypeName AS `Type`, a.Status, IFNULL(a.Reason, '') AS Reason
                    FROM tblAppointments a
                    INNER JOIN tblPatients p ON p.PatientID = a.PatientID
                    INNER JOIN tblStaff s ON s.StaffID = a.DentistID
                    INNER JOIN tblAppointmentTypes t ON t.AppointmentTypeID = a.AppointmentTypeID
                    ORDER BY a.AppointmentDate DESC, a.StartTime")
            Case "Billing & Payments"
                Return Db.Query("
                    SELECT i.InvoiceNumber AS `Invoice No`,
                           CONCAT(p.LastName, ', ', p.FirstName) AS Patient,
                           DATE_FORMAT(i.InvoiceDate, '%Y-%m-%d') AS `Invoice Date`,
                           i.SubTotal AS Subtotal, i.Discount, i.TotalAmount AS Total,
                           i.AmountPaid AS Paid, i.Balance, i.Status,
                           IFNULL(py.PaymentReference, '') AS `Payment Ref`,
                           IFNULL(DATE_FORMAT(py.PaymentDate, '%Y-%m-%d %H:%i'), '') AS `Payment Date`,
                           IFNULL(m.MethodName, '') AS Method, py.Amount AS `Payment Amount`
                    FROM tblInvoices i
                    INNER JOIN tblPatients p ON p.PatientID = i.PatientID
                    LEFT JOIN tblPayments py ON py.InvoiceID = i.InvoiceID
                    LEFT JOIN tblPaymentMethods m ON m.PaymentMethodID = py.PaymentMethodID
                    ORDER BY i.InvoiceDate DESC, i.InvoiceID DESC, py.PaymentID")
            Case "Inventory"
                Return Db.Query("
                    SELECT p.ProductCode AS Code, p.ProductName AS Product, c.CategoryName AS Category,
                           p.Unit, p.CurrentStock AS Stock, p.ReorderLevel AS `Reorder Level`,
                           p.UnitCost AS `Unit Cost`, p.Status
                    FROM tblProducts p
                    INNER JOIN tblProductCategories c ON c.CategoryID = p.CategoryID
                    ORDER BY p.ProductName")
            Case "Clinical Records"
                Return Db.Query("
                    SELECT DATE_FORMAT(r.VisitDate, '%Y-%m-%d %H:%i') AS Visit,
                           pt.PatientCode AS `Patient ID`, CONCAT(pt.LastName, ', ', pt.FirstName) AS Patient,
                           CONCAT(s.FirstName, ' ', s.LastName) AS Dentist,
                           IFNULL(r.ChiefComplaint, '') AS `Chief Complaint`, IFNULL(r.Diagnosis, '') AS Diagnosis,
                           IFNULL(pr.ProcedureName, '') AS Procedure, IFNULL(tr.ToothNumber, '') AS Tooth,
                           tr.TotalAmount AS `Treatment Total`, IFNULL(tr.TreatmentStatus, '') AS `Treatment Status`,
                           IFNULL(DATE_FORMAT(r.NextVisitDate, '%Y-%m-%d'), '') AS `Next Visit`
                    FROM tblDentalRecords r
                    INNER JOIN tblPatients pt ON pt.PatientID = r.PatientID
                    INNER JOIN tblStaff s ON s.StaffID = r.DentistID
                    LEFT JOIN tblTreatmentRecords tr ON tr.DentalRecordID = r.DentalRecordID
                    LEFT JOIN tblProcedures pr ON pr.ProcedureID = tr.ProcedureID
                    ORDER BY r.VisitDate DESC, r.DentalRecordID, tr.TreatmentRecordID")
        End Select
        Return New DataTable()
    End Function

    ' ============================================================ PATIENTS
    Private _patId As Integer          ' 0 = a new, unsaved patient
    Private _patLoading As Boolean

    Private Sub OpenPatients()
        _patId = 0
        LoadPatientGrid()
    End Sub

    Private Sub LoadPatientGrid(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT PatientID AS ID, PatientCode AS Code,
                   CONCAT(LastName, ', ', FirstName) AS Name,
                   ContactNumber AS Contact, Status
            FROM tblPatients
            ORDER BY LastName, FirstName")

        _patLoading = True
        Ui.Bind(dgvPatients, table)
        _patLoading = False

        If table.Rows.Count = 0 Then
            NewPatient()
            Return
        End If

        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvPatients))
        If selectId > 0 Then
            _patLoading = True
            Ui.SelectRow(dgvPatients, selectId)
            _patLoading = False
        End If
        LoadPatient(id)
    End Sub

    Private Sub dgvPatients_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPatients.SelectionChanged
        If _patLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvPatients)
        If id > 0 AndAlso id <> _patId Then Ui.Try(Sub() LoadPatient(id))
    End Sub

    Private Sub LoadPatient(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblPatients WHERE PatientID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewPatient()
            Return
        End If
        Dim r As DataRow = table.Rows(0)

        _patId = id
        txtCode.Text = Ui.Txt(r("PatientCode"))
        txtFirstName.Text = Ui.Txt(r("FirstName"))
        txtMiddleName.Text = Ui.Txt(r("MiddleName"))
        txtLastName.Text = Ui.Txt(r("LastName"))
        Ui.SetDate(dtpBirth, r("BirthDate"))
        Ui.SetText(cboGender, Ui.Txt(r("Gender")))
        txtContact.Text = Ui.Txt(r("ContactNumber"))
        txtEmail.Text = Ui.Txt(r("Email"))
        txtAddress.Text = Ui.Txt(r("Address"))
        txtEmergName.Text = Ui.Txt(r("EmergencyContactName"))
        txtEmergNum.Text = Ui.Txt(r("EmergencyContactNumber"))
        txtRegistered.Text = Convert.ToDateTime(r("RegistrationDate")).ToString("yyyy-MM-dd HH:mm")
        Ui.SetText(cboStatus, Ui.Txt(r("Status")))
        btnArchive.Enabled = Ui.Txt(r("Status")) <> "Archived"
    End Sub

    Private Sub NewPatient()
        _patId = 0
        txtCode.Text = "(assigned on save)"
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        Ui.SetDate(dtpBirth, Nothing)
        cboGender.SelectedIndex = -1
        txtContact.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtEmergName.Clear()
        txtEmergNum.Clear()
        txtRegistered.Clear()
        cboStatus.SelectedIndex = 0
        btnArchive.Enabled = False

        _patLoading = True
        dgvPatients.ClearSelection()
        _patLoading = False
        txtFirstName.Focus()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewPatient()
    End Sub

    ' "Clear" empties the patient form (same as New Patient).
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        NewPatient()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' every patient detail is required
        If Not Ui.RequireAll((txtFirstName, "First name"), (txtMiddleName, "Middle name"), (txtLastName, "Last name"),
                             (dtpBirth, "Birth date"), (cboGender, "Gender"),
                             (txtContact, "Contact number"), (txtEmail, "Email"), (txtAddress, "Address"),
                             (txtEmergName, "Emergency contact name"), (txtEmergNum, "Emergency contact number")) Then Return
        If Not Ui.CheckPhone11(txtContact, "Contact number") Then Return
        If Not Ui.CheckEmail(txtEmail) Then Return
        If Not Ui.CheckPhone11(txtEmergNum, "Emergency contact number") Then Return
        Dim first As String = txtFirstName.Text.Trim()
        Dim last As String = txtLastName.Text.Trim()
        Dim email As String = Ui.Nz(txtEmail)
        Dim birth As Object = Ui.GetDate(dtpBirth)
        If birth IsNot Nothing AndAlso CDate(birth) > DateTime.Today Then
            Ui.Warn("The birth date cannot be in the future.")
            Return
        End If
        Dim gender As String = If(cboGender.SelectedIndex >= 0, cboGender.Text, Nothing)
        Dim status As String = If(cboStatus.SelectedIndex >= 0, cboStatus.Text, "Active")

        Ui.Try(Sub()
                   If _patId = 0 Then
                       Dim nextId As Integer = Convert.ToInt32(Db.Scalar("SELECT IFNULL(MAX(PatientID), 0) + 1 FROM tblPatients"))
                       Dim code As String = $"PAT-{nextId:D5}"
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblPatients
                        (PatientCode, FirstName, MiddleName, LastName, BirthDate, Gender, ContactNumber, Email,
                         Address, EmergencyContactName, EmergencyContactNumber, Status)
                    VALUES (@code, @fn, @mn, @ln, @bd, @g, @ph, @em, @ad, @en, @enum, @st)",
                           ("@code", code), ("@fn", first), ("@mn", Ui.Nz(txtMiddleName)), ("@ln", last),
                           ("@bd", birth), ("@g", gender), ("@ph", Ui.Nz(txtContact)), ("@em", email),
                           ("@ad", Ui.Nz(txtAddress)), ("@en", Ui.Nz(txtEmergName)), ("@enum", Ui.Nz(txtEmergNum)),
                           ("@st", status))
                       Audit.Log("Create Patient", "tblPatients", newId, Nothing, $"{code} {last}, {first}")
                       LoadPatientGrid(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblPatients SET FirstName=@fn, MiddleName=@mn, LastName=@ln, BirthDate=@bd, Gender=@g,
                           ContactNumber=@ph, Email=@em, Address=@ad, EmergencyContactName=@en,
                           EmergencyContactNumber=@enum, Status=@st
                    WHERE PatientID=@id",
                           ("@fn", first), ("@mn", Ui.Nz(txtMiddleName)), ("@ln", last), ("@bd", birth),
                           ("@g", gender), ("@ph", Ui.Nz(txtContact)), ("@em", email), ("@ad", Ui.Nz(txtAddress)),
                           ("@en", Ui.Nz(txtEmergName)), ("@enum", Ui.Nz(txtEmergNum)), ("@st", status), ("@id", _patId))
                       Audit.Log("Update Patient", "tblPatients", _patId, Nothing, $"{txtCode.Text} {last}, {first}")
                       LoadPatientGrid(_patId)
                   End If
                   NewPatient()            ' auto-clear the form for the next entry
                   Ui.Info("Patient saved.")
               End Sub)
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        If _patId = 0 Then Return
        If Not Ui.Confirm("Archive this patient? Their records are kept, but they are marked Archived.") Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblPatients SET Status='Archived' WHERE PatientID=@id", ("@id", _patId))
                   Audit.Log("Archive Patient", "tblPatients", _patId, Nothing, txtCode.Text)
                   LoadPatientGrid(_patId)
               End Sub)
    End Sub

    ' ============================================================ APPOINTMENTS
    Private _apptId As Integer                 ' 0 = new appointment
    Private _apptOrigDate As DateTime = DateTime.MinValue   ' date the loaded appointment had before editing
    Private _apptLoading As Boolean            ' grid / control binding in progress
    Private _apptInit As Boolean               ' page is (re)opening - ignore filter events

    Private Sub OpenAppointments()
        _apptInit = True
        _apptId = 0
        txtApptCode.Clear()
        chkAllDates.Checked = False
        dtpFilterDate.Value = DateTime.Today
        cboFilterStatus.SelectedIndex = 0
        Try
            LoadApptLookups()
        Finally
            _apptInit = False
        End Try
        LoadApptGrid()
    End Sub

    Private Sub LoadApptLookups()
        Dim pats As DataTable = Db.Query("
            SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name,
                   PatientCode AS Code, FirstName, LastName
            FROM tblPatients WHERE Status <> 'Archived' ORDER BY LastName, FirstName")
        Ui.Fill(cboApptPatient, pats, "Name", "ID")

        ' type-ahead suggestions: the patient ID, "Last, First", "First Last" and the full list text
        Dim hints As New AutoCompleteStringCollection()
        For Each pr As DataRow In pats.Rows
            hints.Add(pr("Code").ToString())
            hints.Add(pr("LastName").ToString() & ", " & pr("FirstName").ToString())
            hints.Add(pr("FirstName").ToString() & " " & pr("LastName").ToString())
            hints.Add(pr("Name").ToString())
        Next
        cboApptPatient.AutoCompleteCustomSource = hints
        Ui.Fill(cboDentist, Db.Query("
            SELECT StaffID AS ID, CONCAT(FirstName, ' ', LastName) AS Name
            FROM tblStaff WHERE Position = 'Dentist' AND Status = 'Active' ORDER BY LastName"), "Name", "ID")
        Ui.Fill(cboType, Db.Query("
            SELECT AppointmentTypeID AS ID, TypeName AS Name, IFNULL(DefaultDuration, 30) AS Dur
            FROM tblAppointmentTypes WHERE Status = 'Active' ORDER BY TypeName"), "Name", "ID")
    End Sub

    Private Sub LoadApptGrid(Optional selectId As Integer = 0)
        Dim status As String = If(cboFilterStatus.SelectedIndex > 0, cboFilterStatus.Text, "")
        Dim table As DataTable = Db.Query("
            SELECT a.AppointmentID AS ID, a.AppointmentCode AS Code,
                   DATE_FORMAT(a.AppointmentDate, '%Y-%m-%d') AS `Date`,
                   CONCAT(TIME_FORMAT(a.StartTime, '%h:%i %p'),
                          IFNULL(CONCAT(' - ', TIME_FORMAT(a.EndTime, '%h:%i %p')), '')) AS `Time`,
                   CONCAT(p.LastName, ', ', p.FirstName) AS Patient,
                   CONCAT(s.FirstName, ' ', s.LastName) AS Dentist,
                   t.TypeName AS `Type`, a.Status
            FROM tblAppointments a
            INNER JOIN tblPatients p ON p.PatientID = a.PatientID
            INNER JOIN tblStaff s ON s.StaffID = a.DentistID
            INNER JOIN tblAppointmentTypes t ON t.AppointmentTypeID = a.AppointmentTypeID
            WHERE (@showAll = 1 OR a.AppointmentDate = @d)
              AND (@st = '' OR a.Status = @st)
            ORDER BY a.AppointmentDate, a.StartTime",
            ("@showAll", If(chkAllDates.Checked, 1, 0)), ("@d", dtpFilterDate.Value.Date), ("@st", status))

        _apptLoading = True
        Ui.Bind(dgvAppointments, table)
        _apptLoading = False

        If table.Rows.Count = 0 Then
            If _apptId <> 0 OrElse txtApptCode.Text.Length = 0 Then NewAppointment()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvAppointments))
        If selectId > 0 Then
            _apptLoading = True
            Ui.SelectRow(dgvAppointments, selectId)
            _apptLoading = False
        End If
        If id > 0 Then LoadAppointment(id)
    End Sub

    Private Sub ApptFilter_Changed(sender As Object, e As EventArgs) Handles dtpFilterDate.ValueChanged, chkAllDates.CheckedChanged, cboFilterStatus.SelectedIndexChanged
        If _apptInit Then Return
        If sender Is dtpFilterDate AndAlso chkAllDates.Checked Then Return
        Ui.Try(Sub() LoadApptGrid())
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        _apptInit = True
        chkAllDates.Checked = False
        dtpFilterDate.Value = DateTime.Today
        _apptInit = False
        Ui.Try(Sub() LoadApptGrid())
    End Sub

    Private Sub dgvAppointments_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAppointments.SelectionChanged
        If _apptLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvAppointments)
        If id > 0 AndAlso id <> _apptId Then Ui.Try(Sub() LoadAppointment(id))
    End Sub

    Private Sub LoadAppointment(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblAppointments WHERE AppointmentID = @id", ("@id", id))
        If table.Rows.Count = 0 Then Return
        Dim r As DataRow = table.Rows(0)

        _apptLoading = True
        _apptId = id
        txtApptCode.Text = Ui.Txt(r("AppointmentCode"))
        Ui.SetText(cboApptStatus, Ui.Txt(r("Status")))
        cboApptPatient.Text = ""
        Ui.SelectValue(cboApptPatient, r("PatientID"))
        Ui.SelectValue(cboDentist, r("DentistID"))
        Ui.SelectValue(cboType, r("AppointmentTypeID"))
        Dim loadedDate As DateTime = Convert.ToDateTime(r("AppointmentDate")).Date
        _apptOrigDate = loadedDate
        ' Past dates cannot be picked, but an existing past appointment must still be able to open.
        dtpDate.MinDate = If(loadedDate < DateTime.Today, loadedDate, DateTime.Today)
        dtpDate.Value = loadedDate
        Ui.SetTime(dtpStart, r("StartTime"))
        Ui.SetTime(dtpEnd, r("EndTime"))
        txtReason.Text = Ui.Txt(r("Reason"))
        txtNotes.Text = Ui.Txt(r("Notes"))
        btnCancelAppt.Enabled = Ui.Txt(r("Status")) <> "Cancelled"
        _apptLoading = False
    End Sub

    Private Sub NewAppointment()
        _apptLoading = True
        _apptId = 0
        txtApptCode.Text = "(assigned on save)"
        cboApptStatus.SelectedIndex = 0
        cboApptPatient.SelectedIndex = -1
        cboApptPatient.Text = ""
        cboDentist.SelectedIndex = If(cboDentist.Items.Count = 1, 0, -1)
        cboType.SelectedIndex = -1
        _apptOrigDate = DateTime.MinValue
        dtpDate.MinDate = DateTime.Today                 ' past dates cannot be selected
        Dim startDate As DateTime = If(chkAllDates.Checked, DateTime.Today, dtpFilterDate.Value.Date)
        dtpDate.Value = If(startDate < DateTime.Today, DateTime.Today, startDate)
        dtpStart.Value = DateTime.Today.AddHours(9)
        dtpEnd.Checked = False
        txtReason.Clear()
        txtNotes.Clear()
        btnCancelAppt.Enabled = False
        dgvAppointments.ClearSelection()
        _apptLoading = False
        cboApptPatient.Focus()
    End Sub

    ' ------------------------------------------------------------ patient box: type a name or an ID
    ''' <summary>
    ''' Works out which patient the Patient box means: an item picked from the list, a patient ID
    ''' (PAT-00001, 00001 or just 1) or part of a name ("Santos", "Maria Santos", "Santos, Maria").
    ''' Returns Nothing when there is no single match (and explains why when showMessages is True).
    ''' </summary>
    Private Function ResolveApptPatient(showMessages As Boolean) As Integer?
        Dim typed As String = cboApptPatient.Text.Trim()
        If typed.Length = 0 Then Return Nothing

        ' an item picked from the list and left unchanged
        Dim picked As Integer? = Ui.SelId(cboApptPatient)
        If picked.HasValue AndAlso String.Equals(cboApptPatient.GetItemText(cboApptPatient.SelectedItem), typed, StringComparison.OrdinalIgnoreCase) Then
            Return picked
        End If

        ' "PAT-00001 - Santos, Maria" typed or pasted in full: keep only the ID part
        Dim key As String = typed
        Dim dash As Integer = key.IndexOf(" - ", StringComparison.Ordinal)
        If dash > 0 Then key = key.Substring(0, dash).Trim()

        Const pick As String = "SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name, FirstName, LastName " &
                               "FROM tblPatients WHERE Status <> 'Archived' AND "
        Dim table As DataTable
        Dim idNum As Integer
        Dim m As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(
            key, "^(?:PAT-?)?0*(\d+)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        If m.Success AndAlso Integer.TryParse(m.Groups(1).Value, idNum) Then
            ' patient ID
            table = Db.Query(pick & "(PatientID = @id OR PatientCode = @code)", ("@id", idNum), ("@code", $"PAT-{idNum:D5}"))
        Else
            ' name: every word typed must appear somewhere in the patient's name or ID
            Dim words As String() = key.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            If words.Length = 0 Then Return Nothing
            Dim sql As New System.Text.StringBuilder(pick & "1 = 1")
            Dim args As New List(Of (Name As String, Value As Object))()
            For i As Integer = 0 To words.Length - 1
                sql.Append($" AND CONCAT_WS(' ', PatientCode, FirstName, MiddleName, LastName) LIKE @w{i}")
                args.Add(($"@w{i}", "%" & words(i).Replace("\", "\\").Replace("%", "\%").Replace("_", "\_") & "%"))
            Next
            sql.Append(" ORDER BY LastName, FirstName")
            table = Db.Query(sql.ToString(), args.ToArray())
        End If

        If table.Rows.Count = 1 Then Return Convert.ToInt32(table.Rows(0)("ID"))

        ' several partial matches: an exact full-name match wins
        Dim exactId As Integer = 0
        Dim exactCount As Integer = 0
        For Each r As DataRow In table.Rows
            Dim fn As String = r("FirstName").ToString()
            Dim ln As String = r("LastName").ToString()
            If String.Equals(key, fn & " " & ln, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(key, ln & ", " & fn, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(key, ln & " " & fn, StringComparison.OrdinalIgnoreCase) Then
                exactId = Convert.ToInt32(r("ID"))
                exactCount += 1
            End If
        Next
        If exactCount = 1 Then Return exactId

        If showMessages Then
            If table.Rows.Count = 0 Then
                Ui.Warn($"No active patient matches ""{typed}"". Type the patient ID (for example PAT-00001) or the patient's name.")
            Else
                Dim list As New System.Text.StringBuilder()
                For i As Integer = 0 To Math.Min(table.Rows.Count, 8) - 1
                    list.AppendLine(table.Rows(i)("Name").ToString())
                Next
                If table.Rows.Count > 8 Then list.AppendLine("...")
                Ui.Warn($"More than one patient matches ""{typed}"". Type more of the name or the patient ID:" & vbCrLf & vbCrLf & list.ToString())
            End If
        End If
        Return Nothing
    End Function

    ' leaving the box turns what was typed into the full patient entry (when it is a single match)
    Private Sub cboApptPatient_Leave(sender As Object, e As EventArgs) Handles cboApptPatient.Leave
        Try
            Dim id As Integer? = ResolveApptPatient(False)
            If Not id.HasValue Then Return
            Dim cur As Integer? = Ui.SelId(cboApptPatient)
            If Not cur.HasValue OrElse cur.Value <> id.Value Then Ui.SelectValue(cboApptPatient, id.Value)
        Catch
        End Try
    End Sub

    Private Sub cboApptPatient_KeyDown(sender As Object, e As KeyEventArgs) Handles cboApptPatient.KeyDown
        If e.KeyCode <> Keys.Enter Then Return
        e.SuppressKeyPress = True
        Ui.Try(Sub()
                   Dim id As Integer? = ResolveApptPatient(True)
                   If id.HasValue Then
                       Ui.SelectValue(cboApptPatient, id.Value)
                       Me.SelectNextControl(cboApptPatient, True, True, True, True)
                   End If
               End Sub)
    End Sub


    Private Sub btnNewAppt_Click(sender As Object, e As EventArgs) Handles btnNewAppt.Click
        NewAppointment()
    End Sub

    ' Suggest an end time from the appointment type's default duration (new appointments only).
    Private Sub SuggestEndTime()
        If _apptInit OrElse _apptLoading OrElse _apptId <> 0 Then Return
        Dim drv As DataRowView = TryCast(cboType.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            Dim minutes As Integer = Convert.ToInt32(drv("Dur"))
            dtpEnd.Value = dtpStart.Value.AddMinutes(minutes)
            dtpEnd.Checked = True
        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        SuggestEndTime()
    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        SuggestEndTime()
    End Sub

    Private Sub btnSaveAppt_Click(sender As Object, e As EventArgs) Handles btnSaveAppt.Click
        Dim patient As Integer? = ResolveApptPatient(True)
        If Not patient.HasValue Then
            If cboApptPatient.Text.Trim().Length = 0 Then Ui.Warn("Enter the patient's name or patient ID.")
            Return
        End If
        Ui.SelectValue(cboApptPatient, patient.Value)       ' show the full matched patient
        Dim dentist As Integer? = Ui.SelId(cboDentist)
        Dim apptType As Integer? = Ui.SelId(cboType)
        If Not dentist.HasValue Then
            Ui.Warn(If(cboDentist.Items.Count = 0,
                       "There is no active dentist yet. The administrator must add a staff member with the position ""Dentist"" first.",
                       "Select a dentist."))
            Return
        End If
        If Not apptType.HasValue Then
            Ui.Warn("Select an appointment type.")
            Return
        End If

        Dim start As TimeSpan = Ui.GetTime(dtpStart)
        Dim endTime As Object = If(dtpEnd.Checked, CObj(Ui.GetTime(dtpEnd)), Nothing)
        If endTime IsNot Nothing AndAlso DirectCast(endTime, TimeSpan) <= start Then
            Ui.Warn("The end time must be after the start time.")
            Return
        End If
        Dim status As String = If(cboApptStatus.SelectedIndex >= 0, cboApptStatus.Text, "Pending")
        Dim apptDate As DateTime = dtpDate.Value.Date
        If apptDate < DateTime.Today AndAlso (_apptId = 0 OrElse apptDate <> _apptOrigDate) Then
            Ui.Warn("Appointments cannot be set on a past date. Choose today or a later date.")
            Return
        End If
        Dim checkEnd As TimeSpan = If(endTime IsNot Nothing, DirectCast(endTime, TimeSpan), start.Add(TimeSpan.FromMinutes(30)))
        Dim patientId As Integer = patient.Value
        Dim dentistId As Integer = dentist.Value
        Dim typeId As Integer = apptType.Value

        Ui.Try(Sub()
                   ' Double-booking check for the same dentist (cancelled / no-show slots are free again).
                   If status <> "Cancelled" AndAlso status <> "No-show" Then
                       Dim clash As Long = Convert.ToInt64(Db.Scalar("
                    SELECT COUNT(*) FROM tblAppointments
                    WHERE DentistID = @dn AND AppointmentDate = @d AND AppointmentID <> @id
                      AND Status NOT IN ('Cancelled','No-show')
                      AND StartTime < @e
                      AND IFNULL(EndTime, ADDTIME(StartTime, '00:30:00')) > @s",
                           ("@dn", dentistId), ("@d", apptDate), ("@id", _apptId), ("@e", checkEnd), ("@s", start)))
                       If clash > 0 Then
                           Ui.Warn("This dentist already has an appointment that overlaps this time.")
                           Return
                       End If
                   End If

                   If _apptId = 0 Then
                       Dim nextId As Integer = Convert.ToInt32(Db.Scalar("SELECT IFNULL(MAX(AppointmentID), 0) + 1 FROM tblAppointments"))
                       Dim code As String = $"APT-{nextId:D5}"
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblAppointments
                        (AppointmentCode, PatientID, DentistID, AppointmentDate, StartTime, EndTime,
                         AppointmentTypeID, Status, Reason, Notes, CreatedBy)
                    VALUES (@code, @p, @dn, @d, @s, @e, @t, @st, @re, @no, @by)",
                           ("@code", code), ("@p", patientId), ("@dn", dentistId), ("@d", apptDate), ("@s", start), ("@e", endTime),
                           ("@t", typeId), ("@st", status), ("@re", Ui.Nz(txtReason)), ("@no", Ui.Nz(txtNotes)),
                           ("@by", Session.UserId))
                       Audit.Log("Create Appointment", "tblAppointments", newId, Nothing, $"{code} {apptDate:yyyy-MM-dd} {start:hh\:mm}")
                       LoadApptGrid(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblAppointments SET PatientID=@p, DentistID=@dn, AppointmentDate=@d, StartTime=@s,
                           EndTime=@e, AppointmentTypeID=@t, Status=@st, Reason=@re, Notes=@no
                    WHERE AppointmentID=@id",
                           ("@p", patientId), ("@dn", dentistId), ("@d", apptDate), ("@s", start), ("@e", endTime), ("@t", typeId),
                           ("@st", status), ("@re", Ui.Nz(txtReason)), ("@no", Ui.Nz(txtNotes)), ("@id", _apptId))
                       Audit.Log("Update Appointment", "tblAppointments", _apptId, Nothing, $"{txtApptCode.Text} {status}")
                       LoadApptGrid(_apptId)
                   End If
                   NewAppointment()            ' auto-clear the form for the next entry
                   Ui.Info("Appointment saved.")
               End Sub)
    End Sub

    Private Sub btnCancelAppt_Click(sender As Object, e As EventArgs) Handles btnCancelAppt.Click
        If _apptId = 0 Then Return
        If Not Ui.Confirm("Cancel this appointment?") Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblAppointments SET Status='Cancelled' WHERE AppointmentID=@id", ("@id", _apptId))
                   Audit.Log("Cancel Appointment", "tblAppointments", _apptId, Nothing, txtApptCode.Text)
                   LoadApptGrid(_apptId)
               End Sub)
    End Sub

    ' ============================================================ BILLING & PAYMENTS
    Private _invId As Integer              ' 0 = new invoice not yet saved
    Private _invLoading As Boolean
    Private _invInit As Boolean
    Private _invPatientSearch As PatientSearch   ' lets the Patient box be typed into (ID or name), not only picked

    Private Sub OpenBilling()
        _invInit = True
        _invId = 0
        txtInvoiceNo.Clear()
        Try
            cboStatusFilter.SelectedIndex = 0
            Ui.Fill(cboInvoicePatient, Db.Query("
                SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name
                FROM tblPatients WHERE Status = 'Active' ORDER BY LastName, FirstName"), "Name", "ID")
            If _invPatientSearch Is Nothing Then _invPatientSearch = New PatientSearch(cboInvoicePatient)
            cboItemDiscount.SelectedIndex = 0   ' None
            Ui.Fill(cboProcedure, Db.Query("
                SELECT ProcedureID AS ID, ProcedureName AS Name, StandardPrice AS Price
                FROM tblProcedures WHERE Status = 'Active' ORDER BY ProcedureName"), "Name", "ID")
            Ui.Fill(cboMethod, Db.Query("
                SELECT PaymentMethodID AS ID, MethodName AS Name
                FROM tblPaymentMethods WHERE Status = 'Active' ORDER BY PaymentMethodID"), "Name", "ID")
            btnVoid.Visible = Session.IsAdmin       ' only the administrator may void invoices
        Finally
            _invInit = False
        End Try
        LoadInvoices()
    End Sub

    ' ------------------------------------------------------------ invoice list
    Private Sub LoadInvoices(Optional selectId As Integer = 0)
        Dim status As String = If(cboStatusFilter.SelectedIndex > 0, cboStatusFilter.Text, "")
        Dim table As DataTable = Db.Query("
            SELECT i.InvoiceID AS ID, i.InvoiceNumber AS `Invoice No`,
                   CONCAT(p.LastName, ', ', p.FirstName) AS Patient,
                   DATE_FORMAT(i.InvoiceDate, '%Y-%m-%d') AS `Date`,
                   i.TotalAmount AS Total, i.AmountPaid AS Paid, i.Balance, i.Status
            FROM tblInvoices i
            INNER JOIN tblPatients p ON p.PatientID = i.PatientID
            WHERE (@st = '' OR i.Status = @st)
            ORDER BY i.InvoiceDate DESC, i.InvoiceID DESC
            LIMIT 500", ("@st", status))

        _invLoading = True
        Ui.Bind(dgvInvoices, table)
        _invLoading = False

        If table.Rows.Count = 0 Then
            If _invId <> 0 OrElse txtInvoiceNo.Text.Length = 0 Then NewInvoice()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvInvoices))
        If selectId > 0 Then
            _invLoading = True
            Ui.SelectRow(dgvInvoices, selectId)
            _invLoading = False
        End If
        If id > 0 Then LoadInvoice(id)
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        If _invInit Then Return
        Ui.Try(Sub() LoadInvoices())
    End Sub

    Private Sub dgvInvoices_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInvoices.SelectionChanged
        If _invLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvInvoices)
        If id > 0 AndAlso id <> _invId Then Ui.Try(Sub() LoadInvoice(id))
    End Sub

    ' ------------------------------------------------------------ one invoice
    Private Sub LoadInvoice(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblInvoices WHERE InvoiceID = @id", ("@id", id))
        If table.Rows.Count = 0 Then Return
        Dim r As DataRow = table.Rows(0)

        _invLoading = True
        _invId = id
        txtInvoiceNo.Text = Ui.Txt(r("InvoiceNumber"))
        txtStatus.Text = Ui.Txt(r("Status"))
        Ui.SelectValue(cboInvoicePatient, r("PatientID"))
        Ui.SetNum(numDiscount, r("Discount"))
        lblSubTotal.Text = "Subtotal: " & Ui.Money(r("SubTotal"))
        lblTotal.Text = "Total: " & Ui.Money(r("TotalAmount"))
        lblPaid.Text = "Paid: " & Ui.Money(r("AmountPaid"))
        lblBalance.Text = "Balance: " & Ui.Money(r("Balance"))
        _invLoading = False

        Ui.Bind(dgvItems, Db.Query("
            SELECT InvoiceItemID AS ID, Description, Quantity AS Qty, UnitPrice AS `Unit Price`,
                   Discount, TotalAmount AS Total
            FROM tblInvoiceItems WHERE InvoiceID = @id ORDER BY InvoiceItemID", ("@id", id)))
        Ui.Bind(dgvPayments, Db.Query("
            SELECT p.PaymentID AS ID, p.PaymentReference AS Reference,
                   DATE_FORMAT(p.PaymentDate, '%Y-%m-%d %H:%i') AS `Date`,
                   m.MethodName AS Method, p.Amount, u.Username AS `Received By`
            FROM tblPayments p
            INNER JOIN tblPaymentMethods m ON m.PaymentMethodID = p.PaymentMethodID
            INNER JOIN tblUsers u ON u.UserID = p.ReceivedBy
            WHERE p.InvoiceID = @id ORDER BY p.PaymentID", ("@id", id)))

        ApplyInvoiceState()
    End Sub

    Private Sub NewInvoice()
        _invLoading = True
        _invId = 0
        txtInvoiceNo.Text = "(assigned on save)"
        txtStatus.Text = "Draft"
        cboInvoicePatient.SelectedIndex = -1
        cboInvoicePatient.Text = ""
        numDiscount.Value = 0
        lblSubTotal.Text = "Subtotal: " & Ui.Money(0)
        lblTotal.Text = "Total: " & Ui.Money(0)
        lblPaid.Text = "Paid: " & Ui.Money(0)
        lblBalance.Text = "Balance: " & Ui.Money(0)
        dgvInvoices.ClearSelection()
        _invLoading = False

        dgvItems.DataSource = Nothing
        dgvPayments.DataSource = Nothing
        ApplyInvoiceState()
        cboInvoicePatient.Focus()
    End Sub

    ''' <summary>Enables/disables the groups depending on whether the invoice exists and is not void.</summary>
    Private Sub ApplyInvoiceState()
        Dim saved As Boolean = _invId > 0
        Dim isPaid As Boolean = saved AndAlso txtStatus.Text = "Paid"      ' paid in full: locked for good
        Dim isOpen As Boolean = saved AndAlso txtStatus.Text <> "Void" AndAlso Not isPaid
        cboInvoicePatient.Enabled = Not saved
        numDiscount.Enabled = Not saved OrElse isOpen
        btnSaveInvoice.Enabled = Not saved OrElse isOpen
        btnVoid.Enabled = isOpen AndAlso txtStatus.Text <> "Partially Paid"     ' partly paid: cannot be voided
        grpItems.Enabled = isOpen
        grpPayments.Enabled = isOpen
    End Sub

    Private Sub btnNewInvoice_Click(sender As Object, e As EventArgs) Handles btnNewInvoice.Click
        NewInvoice()
    End Sub

    ''' <summary>
    ''' True (and a message) when the saved invoice is already paid in full. A paid invoice can no longer be
    ''' changed, voided or have items removed. Checked against the database, not just the screen.
    ''' </summary>
    Private Function InvoiceIsPaid() As Boolean
        If _invId = 0 Then Return False
        Dim st As String = Convert.ToString(Db.Scalar("SELECT Status FROM tblInvoices WHERE InvoiceID=@id", ("@id", _invId)))
        If st <> "Paid" Then Return False
        Ui.Warn("This invoice is already paid, so it can no longer be changed or deleted.")
        LoadInvoices(_invId)
        Return True
    End Function

    ''' <summary>
    ''' True (and a message) when the saved invoice is partially paid (or has any payment at all) and so cannot
    ''' be voided. Checked against the database, not just the screen.
    ''' </summary>
    Private Function InvoiceHasPayments() As Boolean
        If _invId = 0 Then Return False
        Dim st As String = Convert.ToString(Db.Scalar("SELECT Status FROM tblInvoices WHERE InvoiceID=@id", ("@id", _invId)))
        Dim n As Integer = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tblPayments WHERE InvoiceID=@id", ("@id", _invId)))
        If st <> "Partially Paid" AndAlso n = 0 Then Return False
        Ui.Warn("This invoice is already partially paid, so it cannot be voided.")
        LoadInvoices(_invId)
        Return True
    End Function

    ' ------------------------------------------------------------ save invoice header
    Private Sub btnSaveInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveInvoice.Click
        Ui.Try(Sub()
                   If _invId = 0 Then
                       ' the Patient box can be typed into: a patient ID (PAT-00001) or part of the name
                       If cboInvoicePatient.Text.Trim().Length = 0 Then
                           Ui.Warn("Type or select the patient to bill.")
                           Return
                       End If
                       Dim patient As Integer? = _invPatientSearch.Resolve(True)
                       If Not patient.HasValue Then Return      ' Resolve already explained why
                       Ui.SelectValue(cboInvoicePatient, patient.Value)

                       Dim nextId As Integer = Convert.ToInt32(Db.Scalar("SELECT IFNULL(MAX(InvoiceID), 0) + 1 FROM tblInvoices"))
                       Dim number As String = $"INV-{nextId:D5}"
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblInvoices (InvoiceNumber, PatientID, Discount, Status)
                    VALUES (@n, @p, @d, 'Unpaid')",
                           ("@n", number), ("@p", patient.Value), ("@d", numDiscount.Value))
                       Using tx As New Tx(True)
                           Recalc(tx, CInt(newId))
                           tx.Commit()
                       End Using
                       Audit.Log("Create Invoice", "tblInvoices", newId, Nothing, number)
                       LoadInvoices(CInt(newId))
                       Ui.Info($"Invoice {number} created. Now add the items.")
                   Else
                       If InvoiceIsPaid() Then Return
                       Using tx As New Tx(True)
                           tx.Exec("UPDATE tblInvoices SET Discount=@d WHERE InvoiceID=@id",
                               ("@d", numDiscount.Value), ("@id", _invId))
                           Recalc(tx, _invId)
                           tx.Commit()
                       End Using
                       Audit.Log("Update Invoice Discount", "tblInvoices", _invId, Nothing, numDiscount.Value.ToString("N2"))
                       LoadInvoices(_invId)
                   End If
               End Sub)
    End Sub

    ''' <summary>
    ''' Recalculates SubTotal / Discount / TotalAmount / AmountPaid / Status of one invoice.
    ''' (The database has no triggers - this is where the billing rules live.)
    ''' </summary>
    Private Shared Sub Recalc(tx As Tx, invoiceId As Integer)
        Dim head As DataRow = tx.Query("SELECT Discount, Status FROM tblInvoices WHERE InvoiceID = @id", ("@id", invoiceId)).Rows(0)
        Dim discount As Decimal = Convert.ToDecimal(head("Discount"))
        Dim status As String = head("Status").ToString()

        Dim subTotal As Decimal = Convert.ToDecimal(tx.Scalar(
            "SELECT IFNULL(SUM(TotalAmount), 0) FROM tblInvoiceItems WHERE InvoiceID = @id", ("@id", invoiceId)))
        Dim paid As Decimal = Convert.ToDecimal(tx.Scalar(
            "SELECT IFNULL(SUM(Amount), 0) FROM tblPayments WHERE InvoiceID = @id", ("@id", invoiceId)))

        If discount > subTotal Then discount = subTotal
        Dim total As Decimal = subTotal - discount
        If status <> "Void" Then
            status = If(paid <= 0, "Unpaid", If(paid >= total, "Paid", "Partially Paid"))
        End If

        tx.Exec("UPDATE tblInvoices
                  SET SubTotal=@s, Discount=@d, TotalAmount=@t, AmountPaid=@p, Status=@st
                  WHERE InvoiceID=@id",
            ("@s", subTotal), ("@d", discount), ("@t", total), ("@p", paid), ("@st", status), ("@id", invoiceId))
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If _invId = 0 OrElse Not Session.IsAdmin Then Return
        If InvoiceIsPaid() OrElse InvoiceHasPayments() Then Return     ' paid or partially paid: cannot be voided
        If Not Ui.Confirm("Void this invoice?") Then Return
        Ui.Try(Sub()
                   If InvoiceIsPaid() OrElse InvoiceHasPayments() Then Return
                   Db.Exec("UPDATE tblInvoices SET Status='Void' WHERE InvoiceID=@id", ("@id", _invId))
                   Audit.Log("Void Invoice", "tblInvoices", _invId, Nothing, txtInvoiceNo.Text)
                   LoadInvoices(_invId)
               End Sub)
    End Sub

    ' ------------------------------------------------------------ items
    Private Sub cboProcedure_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcedure.SelectedIndexChanged
        If _invInit OrElse _invLoading Then Return
        Dim drv As DataRowView = TryCast(cboProcedure.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            txtItemDesc.Text = drv("Name").ToString()
            Ui.SetNum(numUnitPrice, drv("Price"))
        End If
    End Sub

    ' PWD and Senior Citizen get 20% off the item (quantity x unit price); the amount is worked out automatically.
    Private Function ItemDiscountAmount() As Decimal
        If cboItemDiscount.SelectedIndex <= 0 Then Return 0D
        Return Math.Round(numQty.Value * numUnitPrice.Value * SeniorPwdDiscountRate, 2, MidpointRounding.AwayFromZero)
    End Function

    Private Sub ItemDiscount_Changed(sender As Object, e As EventArgs) Handles cboItemDiscount.SelectedIndexChanged, numQty.ValueChanged, numUnitPrice.ValueChanged
        If txtItemDiscountAmt Is Nothing Then Return
        txtItemDiscountAmt.Text = ItemDiscountAmount().ToString("N2")
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If _invId = 0 Then
            Ui.Warn("Save the invoice first.")
            Return
        End If
        ' the unit price comes from the procedure (it cannot be typed), so a procedure must be chosen
        If cboProcedure.SelectedIndex < 0 Then
            Ui.Warn("Select the procedure.")
            Return
        End If
        If Not Ui.Require((txtItemDesc, "Description")) Then Return
        Dim desc As String = txtItemDesc.Text.Trim()
        Dim qty As Integer = CInt(numQty.Value)
        Dim price As Decimal = numUnitPrice.Value
        Dim disc As Decimal = ItemDiscountAmount()

        Ui.Try(Sub()
                   If InvoiceIsPaid() Then Return
                   Using tx As New Tx(True)
                       tx.Exec("INSERT INTO tblInvoiceItems (InvoiceID, Description, Quantity, UnitPrice, Discount)
                          VALUES (@i, @d, @q, @p, @disc)",
                           ("@i", _invId), ("@d", desc), ("@q", qty), ("@p", price), ("@disc", disc))
                       Recalc(tx, _invId)
                       tx.Commit()
                   End Using
                   Audit.Log("Add Invoice Item", "tblInvoices", _invId, Nothing, $"{desc} x{qty} @ {price:N2}")

                   cboProcedure.SelectedIndex = -1
                   txtItemDesc.Clear()
                   numQty.Value = 1
                   numUnitPrice.Value = 0
                   cboItemDiscount.SelectedIndex = 0
                   LoadInvoices(_invId)
               End Sub)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Dim itemId As Integer = Ui.SelectedId(dgvItems)
        If _invId = 0 OrElse itemId = 0 Then
            Ui.Warn("Select an item in the list first.")
            Return
        End If
        If Not Ui.Confirm("Remove the selected item?") Then Return
        Ui.Try(Sub()
                   If InvoiceIsPaid() Then Return
                   Using tx As New Tx(True)
                       tx.Exec("DELETE FROM tblInvoiceItems WHERE InvoiceItemID=@id AND InvoiceID=@inv",
                           ("@id", itemId), ("@inv", _invId))
                       Recalc(tx, _invId)
                       tx.Commit()
                   End Using
                   Audit.Log("Remove Invoice Item", "tblInvoices", _invId, Nothing, "item " & itemId)
                   LoadInvoices(_invId)
               End Sub)
    End Sub

    ' ------------------------------------------------------------ payments
    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        If _invId = 0 Then
            Ui.Warn("Save the invoice first.")
            Return
        End If
        Dim method As Integer? = Ui.SelId(cboMethod)
        Dim amount As Decimal = numPayAmount.Value
        If Not method.HasValue Then
            Ui.Warn("Select the payment method.")
            Return
        End If
        If amount <= 0 Then
            Ui.Warn("Enter the amount received.")
            Return
        End If
        Dim methodId As Integer = method.Value

        Ui.Try(Sub()
                   If InvoiceIsPaid() Then Return
                   Dim balance As Decimal = Convert.ToDecimal(Db.Scalar(
                       "SELECT Balance FROM tblInvoices WHERE InvoiceID=@id", ("@id", _invId)))
                   If amount > balance AndAlso
                      Not Ui.Confirm($"The amount is more than the balance ({Ui.Money(balance)}). It will be recorded as a credit." & vbCrLf & vbCrLf & "Continue?") Then
                       Return
                   End If

                   Dim reference As String
                   Dim payId As Long
                   Using tx As New Tx(True)
                       Dim nextId As Integer = Convert.ToInt32(tx.Scalar("SELECT IFNULL(MAX(PaymentID), 0) + 1 FROM tblPayments"))
                       reference = $"PAY-{nextId:D5}"
                       payId = tx.Insert("
                    INSERT INTO tblPayments (InvoiceID, PaymentReference, Amount, PaymentMethodID, ReceivedBy, Notes)
                    VALUES (@i, @ref, @a, @m, @u, @n)",
                           ("@i", _invId), ("@ref", reference), ("@a", amount), ("@m", methodId),
                           ("@u", Session.UserId), ("@n", Ui.Nz(txtPayNotes)))
                       Recalc(tx, _invId)
                       tx.Commit()
                   End Using
                   Audit.Log("Receive Payment", "tblPayments", payId, Nothing, $"{reference} {amount:N2} for {txtInvoiceNo.Text}")

                   numPayAmount.Value = 0
                   txtPayNotes.Clear()
                   LoadInvoices(_invId)
               End Sub)
    End Sub

    ' ============================================================ CLINICAL RECORDS
    Private _recPatientId As Integer
    Private _visitId As Integer         ' 0 = new visit
    Private _chartId As Integer         ' 0 = new chart entry
    Private _recLoading As Boolean
    Private _recInit As Boolean
    Private _medLoading As Boolean      ' true while the Medical History tab is being filled from the database
    Private _medDirty As Boolean        ' true when the Medical History tab has edits that are not saved
    Private _prevPatientIndex As Integer = -1

    Private Sub OpenClinical()
        _recInit = True
        _recPatientId = 0
        _visitId = 0
        _chartId = 0
        Try
            Ui.Fill(cboPatient, Db.Query("
                SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name
                FROM tblPatients WHERE Status <> 'Archived' ORDER BY LastName, FirstName"), "Name", "ID")
            Ui.Fill(cboVisitDentist, Db.Query("
                SELECT StaffID AS ID, CONCAT(FirstName, ' ', LastName) AS Name
                FROM tblStaff WHERE Position = 'Dentist' AND Status = 'Active' ORDER BY LastName"), "Name", "ID")
            Ui.Fill(cboTreatProcedure, Db.Query("
                SELECT ProcedureID AS ID, ProcedureName AS Name, StandardPrice AS Price
                FROM tblProcedures WHERE Status = 'Active' ORDER BY ProcedureName"), "Name", "ID")
        Finally
            _recInit = False
        End Try

        ' blank page until a patient is picked
        cboTreatStatus.SelectedIndex = 2    ' Completed
        cboTreatDiscount.SelectedIndex = 0  ' None
        txtAllergies.Clear()
        txtMedications.Clear()
        txtConditions.Clear()
        txtSurgeries.Clear()
        txtFamilyHistory.Clear()
        txtOtherNotes.Clear()
        ClearMedicalFlags()
        ClearPatientHeader()
        SetMedicalDirty(False)
        _prevPatientIndex = -1
        lblMedicalUpdated.Text = ""
        dgvVisits.DataSource = Nothing
        dgvTreatments.DataSource = Nothing
        dgvChart.DataSource = Nothing
        ctlDentalChart1.ClearConditions()
        NewVisit()
        NewChart()
        tabMain.SelectedIndex = 0
        tabMain.Enabled = False
    End Sub

    ' ------------------------------------------------------------ patient picker
    Private Sub cboPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPatient.SelectedIndexChanged
        If _recInit Then Return
        If _medDirty AndAlso Not Ui.Confirm("You have unsaved changes to this patient's medical history." & vbCrLf & "Discard them and switch patient?") Then
            _recInit = True                     ' put the picker back without re-running this handler
            cboPatient.SelectedIndex = _prevPatientIndex
            _recInit = False
            Return
        End If
        _prevPatientIndex = cboPatient.SelectedIndex
        Dim id As Integer? = Ui.SelId(cboPatient)
        _recPatientId = If(id.HasValue, id.Value, 0)
        tabMain.Enabled = _recPatientId > 0
        If _recPatientId = 0 Then
            ClearPatientHeader()
            Return
        End If
        Ui.Try(Sub()
                   LoadPatientHeader()
                   LoadMedical()
                   LoadVisits()
                   LoadChart()
               End Sub)
    End Sub

    ' ------------------------------------------------------------ medical history
    Private Sub LoadMedical()
        _medLoading = True
        Try
            Dim table As DataTable = Db.Query("SELECT * FROM tblMedicalHistory WHERE PatientID = @p", ("@p", _recPatientId))
            If table.Rows.Count = 0 Then
                txtAllergies.Clear()
                txtMedications.Clear()
                txtConditions.Clear()
                txtSurgeries.Clear()
                txtFamilyHistory.Clear()
                txtOtherNotes.Clear()
                ClearMedicalFlags()
                lblMedicalUpdated.Text = "No medical history recorded yet."
            Else
                Dim r As DataRow = table.Rows(0)
                txtAllergies.Text = Ui.Txt(r("Allergies"))
                txtMedications.Text = Ui.Txt(r("CurrentMedications"))
                txtConditions.Text = Ui.Txt(r("MedicalConditions"))
                txtSurgeries.Text = Ui.Txt(r("PreviousSurgeries"))
                txtFamilyHistory.Text = Ui.Txt(r("FamilyMedicalHistory"))
                txtOtherNotes.Text = Ui.Txt(r("OtherNotes"))
                chkDiabetes.Checked = FlagOf(r, "HasDiabetes")
                chkHypertension.Checked = FlagOf(r, "HasHypertension")
                chkHeartDisease.Checked = FlagOf(r, "HasHeartDisease")
                chkAsthma.Checked = FlagOf(r, "HasAsthma")
                chkPregnant.Checked = FlagOf(r, "HasPregnant")
                chkSmoker.Checked = FlagOf(r, "HasSmoker")
                chkBleedingDisorder.Checked = FlagOf(r, "HasBleedingDisorder")
                lblMedicalUpdated.Text = "Last updated " & Convert.ToDateTime(r("UpdatedAt")).ToString("yyyy-MM-dd HH:mm")
            End If
        Finally
            _medLoading = False
        End Try
        SetMedicalDirty(False)
    End Sub

    Private Shared Function FlagOf(r As DataRow, column As String) As Boolean
        Return r(column) IsNot DBNull.Value AndAlso Convert.ToInt32(r(column)) <> 0
    End Function

    Private Sub ClearMedicalFlags()
        Dim wasLoading As Boolean = _medLoading
        _medLoading = True
        chkDiabetes.Checked = False
        chkHypertension.Checked = False
        chkHeartDisease.Checked = False
        chkAsthma.Checked = False
        chkPregnant.Checked = False
        chkSmoker.Checked = False
        chkBleedingDisorder.Checked = False
        _medLoading = wasLoading
    End Sub

    ' ---- unsaved-changes tracking: any edit on the Medical History tab shows the red link
    Private Sub MedicalField_Changed(sender As Object, e As EventArgs) Handles txtAllergies.TextChanged, txtMedications.TextChanged, txtConditions.TextChanged, txtSurgeries.TextChanged, txtFamilyHistory.TextChanged, txtOtherNotes.TextChanged, chkDiabetes.CheckedChanged, chkHypertension.CheckedChanged, chkHeartDisease.CheckedChanged, chkAsthma.CheckedChanged, chkPregnant.CheckedChanged, chkSmoker.CheckedChanged, chkBleedingDisorder.CheckedChanged
        If _medLoading OrElse _recInit OrElse _recPatientId = 0 Then Return
        SetMedicalDirty(True)
    End Sub

    Private Sub SetMedicalDirty(dirty As Boolean)
        _medDirty = dirty
        lnkUnsavedChanges.Visible = dirty
    End Sub

    Private Sub lnkUnsavedChanges_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUnsavedChanges.LinkClicked
        btnSaveMedical.PerformClick()
    End Sub

    ' ---- patient strip above the tabs: age / sex, contact number, last visit
    Private Sub ClearPatientHeader()
        lblAgeSexValue.Text = ""
        lblContactVal.Text = ""
        lblLastVisitVal.Text = ""
    End Sub

    Private Sub LoadPatientHeader()
        Dim t As DataTable = Db.Query("SELECT BirthDate, Gender, ContactNumber FROM tblPatients WHERE PatientID = @p", ("@p", _recPatientId))
        If t.Rows.Count = 0 Then
            ClearPatientHeader()
            Return
        End If
        Dim r As DataRow = t.Rows(0)
        Dim age As String = "Age n/a"
        If r("BirthDate") IsNot DBNull.Value Then
            Dim bd As Date = Convert.ToDateTime(r("BirthDate"))
            Dim years As Integer = Date.Today.Year - bd.Year
            If bd.Date > Date.Today.AddYears(-years) Then years -= 1
            age = years.ToString() & " yrs"
        End If
        Dim sex As String = Ui.Txt(r("Gender"))
        lblAgeSexValue.Text = age & If(sex.Length > 0, " / " & sex, "")
        Dim contact As String = Ui.Txt(r("ContactNumber"))
        lblContactVal.Text = "Contact: " & If(contact.Length > 0, contact, "n/a")
        Dim last As Object = Db.Scalar("SELECT MAX(VisitDate) FROM tblDentalRecords WHERE PatientID = @p", ("@p", _recPatientId))
        lblLastVisitVal.Text = "Last visit: " & If(last Is Nothing OrElse last Is DBNull.Value, "none yet", Convert.ToDateTime(last).ToString("yyyy-MM-dd"))
    End Sub

    Private Sub btnSaveMedical_Click(sender As Object, e As EventArgs) Handles btnSaveMedical.Click
        If _recPatientId = 0 Then Return
        Ui.Try(Sub()
                   Db.Exec("
                INSERT INTO tblMedicalHistory
                    (PatientID, Allergies, CurrentMedications, MedicalConditions, PreviousSurgeries,
                     FamilyMedicalHistory, OtherNotes,
                     HasDiabetes, HasHypertension, HasHeartDisease, HasAsthma, HasPregnant, HasSmoker, HasBleedingDisorder)
                VALUES (@p, @a, @m, @c, @s, @f, @o, @d, @h, @hd, @asth, @pr, @sm, @bd)
                ON DUPLICATE KEY UPDATE
                    Allergies = VALUES(Allergies), CurrentMedications = VALUES(CurrentMedications),
                    MedicalConditions = VALUES(MedicalConditions), PreviousSurgeries = VALUES(PreviousSurgeries),
                    FamilyMedicalHistory = VALUES(FamilyMedicalHistory), OtherNotes = VALUES(OtherNotes),
                    HasDiabetes = VALUES(HasDiabetes), HasHypertension = VALUES(HasHypertension),
                    HasHeartDisease = VALUES(HasHeartDisease), HasAsthma = VALUES(HasAsthma),
                    HasPregnant = VALUES(HasPregnant), HasSmoker = VALUES(HasSmoker),
                    HasBleedingDisorder = VALUES(HasBleedingDisorder),
                    UpdatedAt = NOW()",
                       ("@p", _recPatientId), ("@a", Ui.Nz(txtAllergies)), ("@m", Ui.Nz(txtMedications)),
                       ("@c", Ui.Nz(txtConditions)), ("@s", Ui.Nz(txtSurgeries)),
                       ("@f", Ui.Nz(txtFamilyHistory)), ("@o", Ui.Nz(txtOtherNotes)),
                       ("@d", chkDiabetes.Checked), ("@h", chkHypertension.Checked), ("@hd", chkHeartDisease.Checked),
                       ("@asth", chkAsthma.Checked), ("@pr", chkPregnant.Checked), ("@sm", chkSmoker.Checked),
                       ("@bd", chkBleedingDisorder.Checked))
                   Audit.Log("Save Medical History", "tblMedicalHistory", _recPatientId)
                   LoadMedical()
                   Ui.Info("Medical history saved.")
               End Sub)
    End Sub

    ' ------------------------------------------------------------ visits
    Private Sub LoadVisits(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT r.DentalRecordID AS ID,
                   DATE_FORMAT(r.VisitDate, '%Y-%m-%d %H:%i') AS Visit,
                   CONCAT(s.FirstName, ' ', s.LastName) AS Dentist,
                   LEFT(IFNULL(r.Diagnosis, ''), 40) AS Diagnosis
            FROM tblDentalRecords r
            INNER JOIN tblStaff s ON s.StaffID = r.DentistID
            WHERE r.PatientID = @p
            ORDER BY r.VisitDate DESC", ("@p", _recPatientId))

        _recLoading = True
        Ui.Bind(dgvVisits, table)
        _recLoading = False

        If table.Rows.Count = 0 Then
            NewVisit()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvVisits))
        If selectId > 0 Then
            _recLoading = True
            Ui.SelectRow(dgvVisits, selectId)
            _recLoading = False
        End If
        LoadVisit(id)
    End Sub

    Private Sub dgvVisits_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVisits.SelectionChanged
        If _recLoading OrElse _recPatientId = 0 Then Return
        Dim id As Integer = Ui.SelectedId(dgvVisits)
        If id > 0 AndAlso id <> _visitId Then Ui.Try(Sub() LoadVisit(id))
    End Sub

    Private Sub LoadVisit(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblDentalRecords WHERE DentalRecordID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewVisit()
            Return
        End If
        Dim r As DataRow = table.Rows(0)

        _recLoading = True
        _visitId = id
        dtpVisit.Value = Convert.ToDateTime(r("VisitDate"))
        Ui.SelectValue(cboVisitDentist, r("DentistID"))
        Ui.SetDate(dtpNextVisit, r("NextVisitDate"))
        txtComplaint.Text = Ui.Txt(r("ChiefComplaint"))
        txtDiagnosis.Text = Ui.Txt(r("Diagnosis"))
        txtClinicalNotes.Text = Ui.Txt(r("ClinicalNotes"))
        txtRecommendations.Text = Ui.Txt(r("Recommendations"))
        _recLoading = False

        LoadTreatments()
        grpTreat.Enabled = True
    End Sub

    Private Sub NewVisit()
        _recLoading = True
        _visitId = 0
        dtpVisit.Value = DateTime.Now
        cboVisitDentist.SelectedIndex = If(cboVisitDentist.Items.Count = 1, 0, -1)
        Ui.SetDate(dtpNextVisit, Nothing)
        txtComplaint.Clear()
        txtDiagnosis.Clear()
        txtClinicalNotes.Clear()
        txtRecommendations.Clear()
        dgvVisits.ClearSelection()
        _recLoading = False

        dgvTreatments.DataSource = Nothing
        grpTreat.Enabled = False        ' save the visit first, then add treatments
    End Sub

    Private Sub btnNewVisit_Click(sender As Object, e As EventArgs) Handles btnNewVisit.Click
        NewVisit()
    End Sub

    Private Sub btnSaveVisit_Click(sender As Object, e As EventArgs) Handles btnSaveVisit.Click
        If _recPatientId = 0 Then Return
        Dim dentist As Integer? = Ui.SelId(cboVisitDentist)
        If Not dentist.HasValue Then
            Ui.Warn(If(cboVisitDentist.Items.Count = 0,
                       "There is no active dentist yet. Add a staff member with the position ""Dentist"" first.",
                       "Select the dentist."))
            Return
        End If
        Dim dentistId As Integer = dentist.Value
        Dim nextVisit As Object = Ui.GetDate(dtpNextVisit)
        Ui.Try(Sub()
                   If _visitId = 0 Then
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblDentalRecords
                        (PatientID, DentistID, VisitDate, ChiefComplaint, Diagnosis, ClinicalNotes, Recommendations, NextVisitDate)
                    VALUES (@p, @d, @v, @cc, @dx, @cn, @rc, @nv)",
                           ("@p", _recPatientId), ("@d", dentistId), ("@v", dtpVisit.Value), ("@cc", Ui.Nz(txtComplaint)),
                           ("@dx", Ui.Nz(txtDiagnosis)), ("@cn", Ui.Nz(txtClinicalNotes)),
                           ("@rc", Ui.Nz(txtRecommendations)), ("@nv", nextVisit))
                       Audit.Log("Create Dental Record", "tblDentalRecords", newId)
                       LoadVisits(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblDentalRecords SET DentistID=@d, VisitDate=@v, ChiefComplaint=@cc, Diagnosis=@dx,
                           ClinicalNotes=@cn, Recommendations=@rc, NextVisitDate=@nv
                    WHERE DentalRecordID=@id",
                           ("@d", dentistId), ("@v", dtpVisit.Value), ("@cc", Ui.Nz(txtComplaint)), ("@dx", Ui.Nz(txtDiagnosis)),
                           ("@cn", Ui.Nz(txtClinicalNotes)), ("@rc", Ui.Nz(txtRecommendations)), ("@nv", nextVisit), ("@id", _visitId))
                       Audit.Log("Update Dental Record", "tblDentalRecords", _visitId)
                       LoadVisits(_visitId)
                   End If
                   Ui.Info("Visit record saved.")
               End Sub)
    End Sub

    ' ------------------------------------------------------------ treatments of a visit
    Private Sub LoadTreatments()
        Ui.Bind(dgvTreatments, Db.Query("
            SELECT t.TreatmentRecordID AS ID, pr.ProcedureName AS Service,
                   IFNULL(t.ToothNumber, '') AS Tooth,
                   t.UnitPrice AS `Unit Price`, t.Discount, t.TotalAmount AS Total,
                   t.TreatmentStatus AS Status
            FROM tblTreatmentRecords t
            INNER JOIN tblProcedures pr ON pr.ProcedureID = t.ProcedureID
            WHERE t.DentalRecordID = @v ORDER BY t.TreatmentRecordID", ("@v", _visitId)))
    End Sub

    Private Sub cboTreatProcedure_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTreatProcedure.SelectedIndexChanged
        If _recInit Then Return
        Dim drv As DataRowView = TryCast(cboTreatProcedure.SelectedItem, DataRowView)
        If drv IsNot Nothing Then Ui.SetNum(numTreatPrice, drv("Price"))
    End Sub

    ' PWD and Senior Citizen get 20% off the unit price (the amount is worked out automatically, not typed).
    Private Const SeniorPwdDiscountRate As Decimal = 0.2D

    Private Function TreatDiscountAmount() As Decimal
        If cboTreatDiscount.SelectedIndex <= 0 Then Return 0D
        Return Math.Round(numTreatPrice.Value * SeniorPwdDiscountRate, 2, MidpointRounding.AwayFromZero)
    End Function

    Private Sub TreatDiscount_Changed(sender As Object, e As EventArgs) Handles cboTreatDiscount.SelectedIndexChanged, numTreatPrice.ValueChanged
        If txtTreatDiscountAmt Is Nothing Then Return
        txtTreatDiscountAmt.Text = TreatDiscountAmount().ToString("N2")
    End Sub

    Private Sub btnAddTreatment_Click(sender As Object, e As EventArgs) Handles btnAddTreatment.Click
        If _visitId = 0 Then
            Ui.Warn("Save the visit record first.")
            Return
        End If
        Dim proc As Integer? = Ui.SelId(cboTreatProcedure)
        If Not proc.HasValue Then
            Ui.Warn("Select the procedure.")
            Return
        End If
        Dim procId As Integer = proc.Value
        ' one treatment row = one tooth (or the whole mouth when no tooth is picked), so the quantity is always 1
        Dim price As Decimal = numTreatPrice.Value
        Dim disc As Decimal = TreatDiscountAmount()

        Ui.Try(Sub()
                   Dim dentistId As Object = Db.Scalar("SELECT DentistID FROM tblDentalRecords WHERE DentalRecordID=@id", ("@id", _visitId))
                   Dim newId As Long = Db.Insert("
                INSERT INTO tblTreatmentRecords
                    (DentalRecordID, ProcedureID, DentistID, ToothNumber, Quantity, UnitPrice, Discount, TreatmentStatus)
                VALUES (@v, @pr, @d, @t, @q, @u, @disc, @st)",
                       ("@v", _visitId), ("@pr", procId), ("@d", dentistId), ("@t", If(cboTreatTooth.SelectedIndex > 0, CObj(cboTreatTooth.Text), Nothing)), ("@q", 1),
                       ("@u", price), ("@disc", disc), ("@st", cboTreatStatus.Text))
                   Audit.Log("Add Treatment", "tblTreatmentRecords", newId, Nothing, cboTreatProcedure.Text)

                   cboTreatProcedure.SelectedIndex = -1
                   cboTreatTooth.SelectedIndex = 0
                   numTreatPrice.Value = 0
                   cboTreatDiscount.SelectedIndex = 0
                   LoadTreatments()
               End Sub)
    End Sub

    Private Sub btnRemoveTreatment_Click(sender As Object, e As EventArgs) Handles btnRemoveTreatment.Click
        Dim id As Integer = Ui.SelectedId(dgvTreatments)
        If id = 0 Then
            Ui.Warn("Select a treatment in the list first.")
            Return
        End If
        If Not Ui.Confirm("Remove the selected treatment?") Then Return
        Ui.Try(Sub()
                   Dim used As Long = Convert.ToInt64(Db.Scalar(
                       "SELECT COUNT(*) FROM tblInvoiceItems WHERE TreatmentRecordID=@id", ("@id", id)))
                   If used > 0 Then
                       Ui.Warn("This treatment is already on an invoice. Set its status to Cancelled instead of removing it.")
                       Return
                   End If
                   Db.Exec("DELETE FROM tblTreatmentRecords WHERE TreatmentRecordID=@id", ("@id", id))
                   Audit.Log("Remove Treatment", "tblTreatmentRecords", id)
                   LoadTreatments()
               End Sub)
    End Sub

    ' ------------------------------------------------------------ dental chart
    Private Sub LoadChart(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT DentalChartID AS ID, ToothNumber AS Tooth, ToothCondition AS `Dental Condition`,
                   IFNULL(Surface, '') AS Surface, LEFT(IFNULL(Notes, ''), 40) AS Notes,
                   DATE_FORMAT(UpdatedAt, '%Y-%m-%d') AS Updated
            FROM tblDentalChart WHERE PatientID = @p
            ORDER BY ToothNumber, UpdatedAt DESC", ("@p", _recPatientId))

        _recLoading = True
        Ui.Bind(dgvChart, table)
        _recLoading = False
        RefreshOdontogram(table)

        If table.Rows.Count = 0 Then
            NewChart()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvChart))
        If selectId > 0 Then
            _recLoading = True
            Ui.SelectRow(dgvChart, selectId)
            _recLoading = False
        End If
        LoadChartEntry(id)
    End Sub

    Private Sub dgvChart_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChart.SelectionChanged
        If _recLoading OrElse _recPatientId = 0 Then Return
        Dim id As Integer = Ui.SelectedId(dgvChart)
        If id > 0 AndAlso id <> _chartId Then Ui.Try(Sub() LoadChartEntry(id))
    End Sub

    ' Colour the odontogram from the chart table (newest row per tooth wins)
    Private Sub RefreshOdontogram(table As DataTable)
        ctlDentalChart1.ClearConditions()
        Dim seen As New HashSet(Of Integer)
        For Each r As DataRow In table.Rows
            Dim tooth As Integer
            If Integer.TryParse(Ui.Txt(r("Tooth")), tooth) AndAlso seen.Add(tooth) Then
                ctlDentalChart1.SetCondition(tooth, Ui.Txt(r("Dental Condition")))
            End If
        Next
    End Sub

    ' Click a tooth: open its latest entry, or start a new one for that tooth
    Private Sub ctlDentalChart1_ToothClicked(tooth As Integer) Handles ctlDentalChart1.ToothClicked
        If _recPatientId = 0 Then Return
        For Each row As DataGridViewRow In dgvChart.Rows
            If Ui.Txt(row.Cells("Tooth").Value) = tooth.ToString() Then
                Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)
                Ui.SelectRow(dgvChart, id)
                LoadChartEntry(id)
                Return
            End If
        Next
        NewChart()
        txtChartTooth.Text = tooth.ToString()
        ctlDentalChart1.SelectedTooth = tooth
        cboCondition.Focus()
    End Sub

    ' Keep the highlight in sync when typing a tooth number
    Private Sub txtChartTooth_TextChanged(sender As Object, e As EventArgs) Handles txtChartTooth.TextChanged
        Dim n As Integer
        ctlDentalChart1.SelectedTooth = If(Integer.TryParse(txtChartTooth.Text.Trim(), n), n, 0)
    End Sub
    Private Sub LoadChartEntry(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblDentalChart WHERE DentalChartID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewChart()
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        _chartId = id
        txtChartTooth.Text = Ui.Txt(r("ToothNumber"))
        Ui.SetText(cboCondition, Ui.Txt(r("ToothCondition")))
        Ui.SetText(cboSurface, Ui.Txt(r("Surface")))
        txtChartNotes.Text = Ui.Txt(r("Notes"))
        btnDeleteChart.Enabled = True
    End Sub

    Private Sub NewChart()
        _chartId = 0
        txtChartTooth.Clear()
        cboCondition.SelectedIndex = -1
        cboCondition.Text = ""
        cboSurface.SelectedIndex = -1
        cboSurface.Text = ""
        txtChartNotes.Clear()
        btnDeleteChart.Enabled = False
        _recLoading = True
        dgvChart.ClearSelection()
        _recLoading = False
        txtChartTooth.Focus()
    End Sub

    Private Sub btnNewChart_Click(sender As Object, e As EventArgs) Handles btnNewChart.Click
        NewChart()
    End Sub

    Private Sub btnSaveChart_Click(sender As Object, e As EventArgs) Handles btnSaveChart.Click
        If _recPatientId = 0 Then Return
        If Not Ui.Require((txtChartTooth, "Tooth number")) Then Return
        Dim tooth As String = txtChartTooth.Text.Trim()
        Ui.Try(Sub()
                   If _chartId = 0 Then
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblDentalChart (PatientID, ToothNumber, ToothCondition, Surface, Notes, UpdatedBy)
                    VALUES (@p, @t, @c, @s, @n, @u)",
                           ("@p", _recPatientId), ("@t", tooth), ("@c", Ui.GetText(cboCondition)), ("@s", Ui.GetText(cboSurface)),
                           ("@n", Ui.Nz(txtChartNotes)), ("@u", Session.UserId))
                       Audit.Log("Add Chart Entry", "tblDentalChart", newId, Nothing, "tooth " & tooth)
                       LoadChart(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblDentalChart SET ToothNumber=@t, ToothCondition=@c, Surface=@s, Notes=@n,
                           UpdatedBy=@u, UpdatedAt=NOW()
                    WHERE DentalChartID=@id",
                           ("@t", tooth), ("@c", Ui.GetText(cboCondition)), ("@s", Ui.GetText(cboSurface)),
                           ("@n", Ui.Nz(txtChartNotes)), ("@u", Session.UserId), ("@id", _chartId))
                       Audit.Log("Update Chart Entry", "tblDentalChart", _chartId, Nothing, "tooth " & tooth)
                       LoadChart(_chartId)
                   End If
                   NewChart()            ' auto-clear the form for the next entry
               End Sub)
    End Sub

    Private Sub btnDeleteChart_Click(sender As Object, e As EventArgs) Handles btnDeleteChart.Click
        If _chartId = 0 Then Return
        If Not Ui.Confirm("Delete this chart entry?") Then Return
        Ui.Try(Sub()
                   Db.Exec("DELETE FROM tblDentalChart WHERE DentalChartID=@id", ("@id", _chartId))
                   Audit.Log("Delete Chart Entry", "tblDentalChart", _chartId)
                   _chartId = 0
                   LoadChart()
               End Sub)
    End Sub

    ' ============================================================ PROCEDURES & PRICES
    Private _procId As Integer
    Private _procLoading As Boolean

    Private Sub OpenProcedures()
        _procId = 0
        LoadProcGrid()
    End Sub

    Private Sub LoadProcGrid(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT ProcedureID AS ID, ProcedureCode AS Code, ProcedureName AS Name,
                   StandardPrice AS Price, Status
            FROM tblProcedures
            ORDER BY ProcedureCode")

        _procLoading = True
        Ui.Bind(dgvProcedures, table)
        _procLoading = False

        If table.Rows.Count = 0 Then
            NewProcedure()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvProcedures))
        If selectId > 0 Then
            _procLoading = True
            Ui.SelectRow(dgvProcedures, selectId)
            _procLoading = False
        End If
        LoadProcedure(id)
    End Sub

    Private Sub dgvProcedures_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProcedures.SelectionChanged
        If _procLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvProcedures)
        If id > 0 AndAlso id <> _procId Then Ui.Try(Sub() LoadProcedure(id))
    End Sub

    Private Sub LoadProcedure(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblProcedures WHERE ProcedureID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewProcedure()
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        _procId = id
        txtProcCode.Text = Ui.Txt(r("ProcedureCode"))
        txtName.Text = Ui.Txt(r("ProcedureName"))
        txtDescription.Text = Ui.Txt(r("Description"))
        Ui.SetNum(numPrice, r("StandardPrice"))
        Ui.SetNum(numDuration, r("EstimatedDuration"))
        Ui.SetText(cboProcStatus, Ui.Txt(r("Status")))
    End Sub

    Private Sub NewProcedure()
        _procId = 0
        txtProcCode.Text = "(assigned on save)"
        txtName.Clear()
        txtDescription.Clear()
        numPrice.Value = 0
        numDuration.Value = 0
        cboProcStatus.SelectedIndex = 0
        _procLoading = True
        dgvProcedures.ClearSelection()
        _procLoading = False
        txtName.Focus()
    End Sub

    Private Sub btnNewProcedure_Click(sender As Object, e As EventArgs) Handles btnNewProcedure.Click
        NewProcedure()
    End Sub

    Private Sub btnSaveProcedure_Click(sender As Object, e As EventArgs) Handles btnSaveProcedure.Click
        If Not Ui.Require((txtName, "Procedure name")) Then Return
        Dim code As String = txtProcCode.Text.Trim()      ' new procedures get their code below
        Dim name As String = txtName.Text.Trim()
        Dim duration As Object = If(numDuration.Value > 0, CObj(CInt(numDuration.Value)), Nothing)
        Dim status As String = If(cboProcStatus.SelectedIndex >= 0, cboProcStatus.Text, "Active")

        Ui.Try(Sub()
                   If _procId = 0 Then
                       ' automatic code in the existing PR-001 style: one more than the highest number in use
                       Dim nextNo As Integer = Convert.ToInt32(Db.Scalar(
                           "SELECT IFNULL(MAX(CAST(SUBSTRING(ProcedureCode, 4) AS UNSIGNED)), 0) + 1 FROM tblProcedures WHERE ProcedureCode LIKE 'PR-%'"))
                       code = $"PR-{nextNo:D3}"
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblProcedures (ProcedureCode, ProcedureName, Description, StandardPrice, EstimatedDuration, Status)
                    VALUES (@c, @n, @d, @p, @e, @s)",
                           ("@c", code), ("@n", name), ("@d", Ui.Nz(txtDescription)), ("@p", numPrice.Value),
                           ("@e", duration), ("@s", status))
                       Audit.Log("Create Procedure", "tblProcedures", newId, Nothing, $"{code} {name} {numPrice.Value:N2}")
                       LoadProcGrid(CInt(newId))
                   Else
                       Dim oldPrice As String = Convert.ToString(Db.Scalar("SELECT StandardPrice FROM tblProcedures WHERE ProcedureID=@id", ("@id", _procId)))
                       Db.Exec("
                    UPDATE tblProcedures SET ProcedureCode=@c, ProcedureName=@n, Description=@d, StandardPrice=@p,
                           EstimatedDuration=@e, Status=@s
                    WHERE ProcedureID=@id",
                           ("@c", code), ("@n", name), ("@d", Ui.Nz(txtDescription)), ("@p", numPrice.Value),
                           ("@e", duration), ("@s", status), ("@id", _procId))
                       Audit.Log("Update Procedure", "tblProcedures", _procId, "price " & oldPrice, $"{code} {name} price {numPrice.Value:N2}")
                       LoadProcGrid(_procId)
                   End If
                   NewProcedure()            ' auto-clear the form for the next entry
                   Ui.Info("Procedure saved.")
               End Sub)
    End Sub

    ' ============================================================ INVENTORY
    Private Shared ReadOnly StockInTypes As String() = {"Stock In", "Adjustment In"}

    Private _prodId As Integer
    Private _supId As Integer
    Private _invtLoading As Boolean
    Private _invtInit As Boolean

    Private Sub OpenInventory()
        _invtInit = True
        _prodId = 0
        _supId = 0
        txtProdCode.Clear()
        txtSupName.Clear()
        Try
            tabInventory.SelectedIndex = 0
            chkLowStock.Checked = False
            cboProdStatus.SelectedIndex = 0
            cboSupStatus.SelectedIndex = 0
            cboTxType.SelectedIndex = 0
            Ui.Fill(cboCategory, Db.Query("
                SELECT CategoryID AS ID, CategoryName AS Name
                FROM tblProductCategories WHERE Status = 'Active' ORDER BY CategoryName"), "Name", "ID")
        Finally
            _invtInit = False
        End Try
        LoadProducts()
        LoadSuppliers()
    End Sub

    ' ------------------------------------------------------------ products
    Private Sub LoadProducts(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT p.ProductID AS ID, p.ProductCode AS Code, p.ProductName AS Product,
                   c.CategoryName AS Category, p.CurrentStock AS Stock, p.ReorderLevel AS Reorder, p.Status
            FROM tblProducts p
            INNER JOIN tblProductCategories c ON c.CategoryID = p.CategoryID
            WHERE (@low = 0 OR (p.Status = 'Active' AND p.CurrentStock <= p.ReorderLevel))
            ORDER BY p.ProductName",
            ("@low", If(chkLowStock.Checked, 1, 0)))

        _invtLoading = True
        Ui.Bind(dgvProducts, table)
        _invtLoading = False

        If table.Rows.Count = 0 Then
            If _prodId <> 0 OrElse txtProdCode.Text.Length = 0 Then NewProduct()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvProducts))
        If selectId > 0 Then
            _invtLoading = True
            Ui.SelectRow(dgvProducts, selectId)
            _invtLoading = False
        End If
        LoadProduct(id)
    End Sub

    Private Sub chkLowStock_CheckedChanged(sender As Object, e As EventArgs) Handles chkLowStock.CheckedChanged
        If _invtInit Then Return
        Ui.Try(Sub() LoadProducts())
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If _invtLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvProducts)
        If id > 0 AndAlso id <> _prodId Then Ui.Try(Sub() LoadProduct(id))
    End Sub

    Private Sub LoadProduct(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblProducts WHERE ProductID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewProduct()
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        _prodId = id
        txtProdCode.Text = Ui.Txt(r("ProductCode"))
        txtProdName.Text = Ui.Txt(r("ProductName"))
        Ui.SelectValue(cboCategory, r("CategoryID"))
        txtUnit.Text = Ui.Txt(r("Unit"))
        Ui.SetNum(numReorder, r("ReorderLevel"))
        Ui.SetNum(numCost, r("UnitCost"))
        txtStock.Text = Ui.Txt(r("CurrentStock"))
        Ui.SetText(cboProdStatus, Ui.Txt(r("Status")))
        grpStock.Enabled = True
        LoadTransactions()
    End Sub

    Private Sub NewProduct()
        _prodId = 0
        txtProdCode.Clear()
        txtProdName.Clear()
        txtUnit.Clear()
        cboCategory.SelectedIndex = -1
        numReorder.Value = 0
        numCost.Value = 0
        txtStock.Text = "0"
        cboProdStatus.SelectedIndex = 0
        _invtLoading = True
        dgvProducts.ClearSelection()
        _invtLoading = False
        dgvTransactions.DataSource = Nothing
        grpStock.Enabled = False        ' save the product first, then post stock
        txtProdCode.Focus()
    End Sub

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        NewProduct()
    End Sub

    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        If Not Ui.Require((txtProdName, "Product name"), (cboCategory, "Category"), (txtUnit, "Unit")) Then Return
        Dim name As String = txtProdName.Text.Trim()
        Dim unit As String = txtUnit.Text.Trim()
        Dim category As Integer? = Ui.SelId(cboCategory)
        Dim categoryId As Integer = category.Value
        Dim status As String = If(cboProdStatus.SelectedIndex >= 0, cboProdStatus.Text, "Active")

        Ui.Try(Sub()
                   If _prodId = 0 Then
                       Dim code As String = txtProdCode.Text.Trim()
                       If code.Length = 0 Then
                           Dim nextId As Integer = Convert.ToInt32(Db.Scalar("SELECT IFNULL(MAX(ProductID), 0) + 1 FROM tblProducts"))
                           code = $"PRD-{nextId:D4}"
                       End If
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblProducts (ProductCode, ProductName, CategoryID, Unit, ReorderLevel, UnitCost, Status)
                    VALUES (@c, @n, @cat, @u, @r, @cost, @s)",
                           ("@c", code), ("@n", name), ("@cat", categoryId), ("@u", unit),
                           ("@r", CInt(numReorder.Value)), ("@cost", numCost.Value), ("@s", status))
                       Audit.Log("Create Product", "tblProducts", newId, Nothing, $"{code} {name}")
                       LoadProducts(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblProducts SET ProductCode=@c, ProductName=@n, CategoryID=@cat, Unit=@u,
                           ReorderLevel=@r, UnitCost=@cost, Status=@s
                    WHERE ProductID=@id",
                           ("@c", txtProdCode.Text.Trim()), ("@n", name), ("@cat", categoryId), ("@u", unit),
                           ("@r", CInt(numReorder.Value)), ("@cost", numCost.Value), ("@s", status), ("@id", _prodId))
                       Audit.Log("Update Product", "tblProducts", _prodId, Nothing, name)
                       LoadProducts(_prodId)
                   End If
                   NewProduct()            ' auto-clear the form for the next entry
                   Ui.Info("Product saved.")
               End Sub)
    End Sub

    ' ------------------------------------------------------------ stock transactions
    Private Sub LoadTransactions()
        Ui.Bind(dgvTransactions, Db.Query("
            SELECT t.TransactionID AS ID, DATE_FORMAT(t.TransactionDate, '%Y-%m-%d %H:%i') AS `Date`,
                   t.TransactionType AS `Type`, t.Quantity AS Qty, IFNULL(t.Reference, '') AS Reference,
                   u.Username AS `By`
            FROM tblInventoryTransactions t
            INNER JOIN tblUsers u ON u.UserID = t.PerformedBy
            WHERE t.ProductID = @p ORDER BY t.TransactionID DESC LIMIT 200", ("@p", _prodId)))
    End Sub

    Private Sub btnPostStock_Click(sender As Object, e As EventArgs) Handles btnPostStock.Click
        If _prodId = 0 Then
            Ui.Warn("Save the product first.")
            Return
        End If
        If cboTxType.SelectedIndex < 0 Then
            Ui.Warn("Select the transaction type.")
            Return
        End If
        Dim type As String = cboTxType.Text
        Dim qty As Integer = CInt(numTxQty.Value)
        Dim delta As Integer = If(Array.IndexOf(StockInTypes, type) >= 0, qty, -qty)

        Ui.Try(Sub()
                   Using tx As New Tx(True)
                       Dim current As Integer = Convert.ToInt32(tx.Scalar(
                           "SELECT CurrentStock FROM tblProducts WHERE ProductID = @id FOR UPDATE", ("@id", _prodId)))
                       If current + delta < 0 Then
                           Ui.Warn($"Not enough stock. Current stock is {current}.")
                           Return      ' disposing the Tx rolls back
                       End If
                       tx.Exec("UPDATE tblProducts SET CurrentStock = CurrentStock + @d WHERE ProductID = @id",
                           ("@d", delta), ("@id", _prodId))
                       Dim newId As Long = tx.Insert("
                INSERT INTO tblInventoryTransactions (ProductID, TransactionType, Quantity, Reference, PerformedBy, Notes)
                VALUES (@p, @t, @q, @r, @u, @n)",
                           ("@p", _prodId), ("@t", type), ("@q", qty), ("@r", Ui.Nz(txtTxRef)),
                           ("@u", Session.UserId), ("@n", Ui.Nz(txtTxNotes)))
                       tx.Commit()

                       Audit.Log("Stock " & type, "tblInventoryTransactions", newId, current.ToString(), (current + delta).ToString())
                   End Using
                   txtTxRef.Clear()
                   txtTxNotes.Clear()
                   numTxQty.Value = 1
                   LoadProducts(_prodId)
               End Sub)
    End Sub

    ' ------------------------------------------------------------ suppliers
    Private Sub LoadSuppliers(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT SupplierID AS ID, SupplierName AS Supplier, IFNULL(ContactPerson, '') AS Contact,
                   IFNULL(ContactNumber, '') AS Phone, Status
            FROM tblSuppliers
            ORDER BY SupplierName")

        _invtLoading = True
        Ui.Bind(dgvSuppliers, table)
        _invtLoading = False

        If table.Rows.Count = 0 Then
            If _supId <> 0 OrElse txtSupName.Text.Length = 0 Then NewSupplier()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvSuppliers))
        If selectId > 0 Then
            _invtLoading = True
            Ui.SelectRow(dgvSuppliers, selectId)
            _invtLoading = False
        End If
        LoadSupplier(id)
    End Sub

    Private Sub dgvSuppliers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSuppliers.SelectionChanged
        If _invtLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvSuppliers)
        If id > 0 AndAlso id <> _supId Then Ui.Try(Sub() LoadSupplier(id))
    End Sub

    Private Sub LoadSupplier(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblSuppliers WHERE SupplierID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewSupplier()
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        _supId = id
        txtSupName.Text = Ui.Txt(r("SupplierName"))
        txtSupContact.Text = Ui.Txt(r("ContactPerson"))
        txtSupPhone.Text = Ui.Txt(r("ContactNumber"))
        txtSupEmail.Text = Ui.Txt(r("Email"))
        txtSupAddress.Text = Ui.Txt(r("Address"))
        Ui.SetText(cboSupStatus, Ui.Txt(r("Status")))
    End Sub

    Private Sub NewSupplier()
        _supId = 0
        txtSupName.Clear()
        txtSupContact.Clear()
        txtSupPhone.Clear()
        txtSupEmail.Clear()
        txtSupAddress.Clear()
        cboSupStatus.SelectedIndex = 0
        _invtLoading = True
        dgvSuppliers.ClearSelection()
        _invtLoading = False
        txtSupName.Focus()
    End Sub

    Private Sub btnNewSupplier_Click(sender As Object, e As EventArgs) Handles btnNewSupplier.Click
        NewSupplier()
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click
        If Not Ui.Require((txtSupName, "Supplier name")) Then Return
        If Not Ui.CheckPhone(txtSupPhone, "Phone number") Then Return
        If Not Ui.CheckEmail(txtSupEmail) Then Return
        Dim name As String = txtSupName.Text.Trim()
        Dim email As String = Ui.Nz(txtSupEmail)
        Dim status As String = If(cboSupStatus.SelectedIndex >= 0, cboSupStatus.Text, "Active")

        Ui.Try(Sub()
                   If _supId = 0 Then
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblSuppliers (SupplierName, ContactPerson, ContactNumber, Email, Address, Status)
                    VALUES (@n, @cp, @ph, @em, @ad, @s)",
                           ("@n", name), ("@cp", Ui.Nz(txtSupContact)), ("@ph", Ui.Nz(txtSupPhone)), ("@em", email),
                           ("@ad", Ui.Nz(txtSupAddress)), ("@s", status))
                       Audit.Log("Create Supplier", "tblSuppliers", newId, Nothing, name)
                       LoadSuppliers(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblSuppliers SET SupplierName=@n, ContactPerson=@cp, ContactNumber=@ph, Email=@em,
                           Address=@ad, Status=@s WHERE SupplierID=@id",
                           ("@n", name), ("@cp", Ui.Nz(txtSupContact)), ("@ph", Ui.Nz(txtSupPhone)), ("@em", email),
                           ("@ad", Ui.Nz(txtSupAddress)), ("@s", status), ("@id", _supId))
                       Audit.Log("Update Supplier", "tblSuppliers", _supId, Nothing, name)
                       LoadSuppliers(_supId)
                   End If
                   NewSupplier()            ' auto-clear the form for the next entry
                   Ui.Info("Supplier saved.")
               End Sub)
    End Sub

    ' ============================================================ STAFF & ACCOUNTS
    Private _staffId As Integer
    Private _staffLoading As Boolean

    Private Sub OpenStaff()
        _staffId = 0
        txtStaffFirstName.Clear()
        LoadStaffGrid()
        LoadUsers()
    End Sub

    Private Sub LoadStaffGrid(Optional selectId As Integer = 0)
        Dim table As DataTable = Db.Query("
            SELECT StaffID AS ID, StaffCode AS Code, CONCAT(LastName, ', ', FirstName) AS Name,
                   Position, Status
            FROM tblStaff
            ORDER BY LastName, FirstName")

        _staffLoading = True
        Ui.Bind(dgvStaff, table)
        _staffLoading = False

        If table.Rows.Count = 0 Then
            If _staffId <> 0 OrElse txtStaffFirstName.Text.Length = 0 Then NewStaff()
            Return
        End If
        Dim id As Integer = If(selectId > 0, selectId, Ui.SelectedId(dgvStaff))
        If selectId > 0 Then
            _staffLoading = True
            Ui.SelectRow(dgvStaff, selectId)
            _staffLoading = False
        End If
        LoadStaff(id)
    End Sub

    Private Sub dgvStaff_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaff.SelectionChanged
        If _staffLoading Then Return
        Dim id As Integer = Ui.SelectedId(dgvStaff)
        If id > 0 AndAlso id <> _staffId Then Ui.Try(Sub() LoadStaff(id))
    End Sub

    Private Sub LoadStaff(id As Integer)
        Dim table As DataTable = Db.Query("SELECT * FROM tblStaff WHERE StaffID = @id", ("@id", id))
        If table.Rows.Count = 0 Then
            NewStaff()
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        _staffId = id
        txtStaffCode.Text = Ui.Txt(r("StaffCode"))
        txtStaffFirstName.Text = Ui.Txt(r("FirstName"))
        txtStaffLastName.Text = Ui.Txt(r("LastName"))
        txtStaffContact.Text = Ui.Txt(r("ContactNumber"))
        txtStaffEmail.Text = Ui.Txt(r("Email"))
        Ui.SetText(cboPosition, Ui.Txt(r("Position")))
        txtLicense.Text = Ui.Txt(r("LicenseNumber"))
        Ui.SetText(cboStaffStatus, Ui.Txt(r("Status")))
    End Sub

    Private Sub NewStaff()
        _staffId = 0
        txtStaffCode.Clear()
        txtStaffFirstName.Clear()
        txtStaffLastName.Clear()
        txtStaffContact.Clear()
        txtStaffEmail.Clear()
        txtLicense.Clear()
        cboPosition.SelectedIndex = 0
        cboStaffStatus.SelectedIndex = 0
        _staffLoading = True
        dgvStaff.ClearSelection()
        _staffLoading = False
        UpdateStaffCode()
        txtStaffFirstName.Focus()
    End Sub

    ''' <summary>Code prefix for a staff position: Front Desk FD, Administrator ADM, Dental Assistant DA, Dentist DR.</summary>
    Private Shared Function StaffPrefix(position As String) As String
        Select Case position
            Case "Front Desk" : Return "FD"
            Case "Administrator" : Return "ADM"
            Case "Dental Assistant" : Return "DA"
            Case "Dentist" : Return "DR"
            Case Else : Return "STF"
        End Select
    End Function

    ''' <summary>Next free code for the position, e.g. DR-001, DR-002 (continues after the highest existing number).</summary>
    Private Function NextStaffCode(position As String) As String
        Dim prefix As String = StaffPrefix(position)
        Dim highest As Integer = Convert.ToInt32(Db.Scalar(
            "SELECT IFNULL(MAX(CAST(SUBSTRING(StaffCode, @len) AS UNSIGNED)), 0) FROM tblStaff WHERE StaffCode LIKE @like",
            ("@len", prefix.Length + 2), ("@like", prefix & "-%")))
        Return $"{prefix}-{highest + 1:D3}"
    End Function

    ''' <summary>Fills the Staff Code box for a NEW staff member as soon as a position is chosen.</summary>
    Private Sub UpdateStaffCode()
        If _staffId <> 0 OrElse cboPosition.SelectedIndex < 0 Then Return
        Ui.Try(Sub() txtStaffCode.Text = NextStaffCode(Ui.GetText(cboPosition)))
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        If _staffLoading Then Return
        UpdateStaffCode()
    End Sub

    Private Sub btnNewStaff_Click(sender As Object, e As EventArgs) Handles btnNewStaff.Click
        NewStaff()
    End Sub

    Private Sub btnSaveStaff_Click(sender As Object, e As EventArgs) Handles btnSaveStaff.Click
        If Not Ui.Require((txtStaffFirstName, "First name"), (txtStaffLastName, "Last name"), (cboPosition, "Position")) Then Return
        If Not Ui.CheckPhone(txtStaffContact, "Contact number") Then Return
        If Not Ui.CheckEmail(txtStaffEmail) Then Return
        Dim first As String = txtStaffFirstName.Text.Trim()
        Dim last As String = txtStaffLastName.Text.Trim()
        Dim position As String = Ui.GetText(cboPosition)
        Dim email As String = Ui.Nz(txtStaffEmail)
        Dim status As String = If(cboStaffStatus.SelectedIndex >= 0, cboStaffStatus.Text, "Active")

        Ui.Try(Sub()
                   If _staffId = 0 Then
                       Dim code As String = NextStaffCode(position)   ' re-checked at save so two codes never clash
                       Dim newId As Long = Db.Insert("
                    INSERT INTO tblStaff (StaffCode, FirstName, LastName, ContactNumber, Email, Position, LicenseNumber, Status)
                    VALUES (@c, @fn, @ln, @ph, @em, @pos, @lic, @st)",
                           ("@c", code), ("@fn", first), ("@ln", last), ("@ph", Ui.Nz(txtStaffContact)), ("@em", email),
                           ("@pos", position), ("@lic", Ui.Nz(txtLicense)), ("@st", status))
                       Audit.Log("Create Staff", "tblStaff", newId, Nothing, $"{code} {last}, {first} ({position})")
                       LoadStaffGrid(CInt(newId))
                   Else
                       Db.Exec("
                    UPDATE tblStaff SET StaffCode=@c, FirstName=@fn, LastName=@ln, ContactNumber=@ph, Email=@em,
                           Position=@pos, LicenseNumber=@lic, Status=@st
                    WHERE StaffID=@id",
                           ("@c", txtStaffCode.Text.Trim()), ("@fn", first), ("@ln", last), ("@ph", Ui.Nz(txtStaffContact)),
                           ("@em", email), ("@pos", position), ("@lic", Ui.Nz(txtLicense)), ("@st", status), ("@id", _staffId))
                       Audit.Log("Update Staff", "tblStaff", _staffId, Nothing, $"{last}, {first} ({position}) {status}")
                       LoadStaffGrid(_staffId)
                   End If
                   LoadUsers()
                   NewStaff()            ' auto-clear the form for the next entry
                   Ui.Info("Staff member saved.")
               End Sub)
    End Sub

    ' ------------------------------------------------------------ login accounts
    Private Sub LoadUsers()
        Ui.Bind(dgvUsers, Db.Query("
            SELECT u.UserID AS ID, u.Username, r.RoleName AS Role,
                   CONCAT(s.FirstName, ' ', s.LastName) AS Staff,
                   IF(u.IsActive = 1, 'Yes', 'No') AS Active,
                   IF(u.PasswordHash = 'SET_PASSWORD_FIRST', 'not set', 'set') AS Password,
                   IF(u.LockedUntil IS NOT NULL AND u.LockedUntil > NOW(), 'Yes', 'No') AS Locked,
                   IFNULL(DATE_FORMAT(u.LastLogin, '%Y-%m-%d %H:%i'), 'never') AS `Last Login`
            FROM tblUsers u
            INNER JOIN tblRoles r ON r.RoleID = u.RoleID
            INNER JOIN tblStaff s ON s.StaffID = u.StaffID
            ORDER BY r.RoleID"))
    End Sub

    ''' <summary>The account selected in the grid, or 0 (with a warning) when none is selected.</summary>
    Private Function SelectedAccount(ByRef username As String) As Integer
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then
            Ui.Warn("Select an account first.")
            Return 0
        End If
        username = Ui.Txt(dgvUsers.CurrentRow.Cells("Username").Value)
        Return id
    End Function

    Private Sub ChangePassword(auditAction As String, prompt As String, doneText As String)
        Dim username As String = Nothing
        Dim id As Integer = SelectedAccount(username)
        If id = 0 Then Return
        Dim isSet As Boolean = Ui.Txt(dgvUsers.CurrentRow.Cells("Password").Value) = "set"
        If auditAction = "Set Password" AndAlso isSet Then
            Ui.Warn($"'{username}' already has a password. Use Reset Password to change it.")
            Return
        End If
        If auditAction = "Reset Password" AndAlso Not isSet Then
            Ui.Warn($"'{username}' has no password yet. Use Set Password first.")
            Return
        End If

        Dim newPass As String = Ui.AskPassword(String.Format(prompt, username))
        If newPass Is Nothing Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET PasswordHash=@h WHERE UserID=@id", ("@h", Pwd.Hash(newPass)), ("@id", id))
                   Audit.Log(auditAction, "tblUsers", id, Nothing, username)
                   LoadUsers()
                   Ui.Info(String.Format(doneText, username))
               End Sub)
    End Sub

    Private Sub btnSetPassword_Click(sender As Object, e As EventArgs) Handles btnSetPassword.Click
        ChangePassword("Set Password", "Set the first password for the account '{0}'.", "The password for '{0}' was set.")
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        ChangePassword("Reset Password", "Set a new password for the account '{0}'.", "The password for '{0}' was changed.")
    End Sub

    Private Sub btnEnableAccount_Click(sender As Object, e As EventArgs) Handles btnEnableAccount.Click
        Dim username As String = Nothing
        Dim id As Integer = SelectedAccount(username)
        If id = 0 Then Return
        If Ui.Txt(dgvUsers.CurrentRow.Cells("Active").Value) = "Yes" Then
            Ui.Info($"'{username}' is already enabled.")
            Return
        End If
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET IsActive=1 WHERE UserID=@id", ("@id", id))
                   Audit.Log("Enable Account", "tblUsers", id, Nothing, username)
                   LoadUsers()
               End Sub)
    End Sub

    Private Sub btnDisableAccount_Click(sender As Object, e As EventArgs) Handles btnDisableAccount.Click
        Dim username As String = Nothing
        Dim id As Integer = SelectedAccount(username)
        If id = 0 Then Return
        If id = Session.UserId Then
            Ui.Warn("You cannot disable the account you are signed in with.")
            Return
        End If
        If Ui.Txt(dgvUsers.CurrentRow.Cells("Active").Value) <> "Yes" Then
            Ui.Info($"'{username}' is already disabled.")
            Return
        End If
        If Not Ui.Confirm($"Disable the account '{username}'?") Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET IsActive=0 WHERE UserID=@id", ("@id", id))
                   Audit.Log("Disable Account", "tblUsers", id, Nothing, username)
                   LoadUsers()
               End Sub)
    End Sub

    ' Unlock works straight away: it clears the lock and the failed-attempt count, so the 15-minute wait is skipped.
    Private Sub btnUnlockAccount_Click(sender As Object, e As EventArgs) Handles btnUnlockAccount.Click
        Dim username As String = Nothing
        Dim id As Integer = SelectedAccount(username)
        If id = 0 Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET LockedUntil=NULL, FailedAttempts=0 WHERE UserID=@id", ("@id", id))
                   Audit.Log("Unlock Account", "tblUsers", id, Nothing, username)
                   LoadUsers()
                   Ui.Info($"'{username}' is unlocked and can sign in now.")
               End Sub)
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick

    End Sub

    ' ============================================================ INPUT RULES
    ' Phone boxes accept only digits and + - ( ) . space while typing (the full check is on Save).
    Private Sub PhoneBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffContact.KeyPress, txtSupPhone.KeyPress
        Ui.PhoneKey(e)
    End Sub

    ' Patient phone boxes accept digits only.
    Private Sub PatientPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress, txtEmergNum.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    ' Email boxes do not accept spaces.
    Private Sub EmailBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress, txtStaffEmail.KeyPress, txtSupEmail.KeyPress
        If e.KeyChar = " "c Then e.Handled = True
    End Sub

End Class
