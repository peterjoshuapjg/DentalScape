Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

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
    Private Shared ReadOnly NavActive As Color = Color.FromArgb(14, 124, 134)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizedBounds = Screen.FromControl(Me).WorkingArea
        Me.WindowState = FormWindowState.Maximized

        lblUser.Text = Session.FullName & "   |   " & Session.Role

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
    End Sub

    ' ============================================================ AUDIT LOG
    Private Sub OpenAudit()
        dtpFrom.Value = DateTime.Today.AddDays(-7)
        dtpTo.Value = DateTime.Today
        LoadLog()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Ui.Try(AddressOf LoadLog)
    End Sub

    Private Sub LoadLog()
        Dim table As DataTable = Db.Query("
            SELECT DATE_FORMAT(a.Timestamp, '%Y-%m-%d %H:%i:%s') AS `Time`,
                   IFNULL(u.Username, '(none)') AS `User`,
                   a.Action, IFNULL(a.EntityName, '') AS Entity, IFNULL(a.RecordID, '') AS Record,
                   IFNULL(a.OldValue, '') AS `Old`, IFNULL(a.NewValue, '') AS `New`
            FROM tblAuditLogs a
            LEFT JOIN tblUsers u ON u.UserID = a.UserID
            WHERE a.Timestamp >= @from AND a.Timestamp < @to
            ORDER BY a.AuditLogID DESC
            LIMIT 1000",
            ("@from", dtpFrom.Value.Date), ("@to", dtpTo.Value.Date.AddDays(1)))
        Ui.Bind(dgvLog, table)
        lblCount.Text = If(table.Rows.Count >= 1000, "Showing the latest 1,000 entries", table.Rows.Count & " entries")
    End Sub

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
        Dim first As String = txtFirstName.Text.Trim()
        Dim last As String = txtLastName.Text.Trim()
        If first.Length = 0 OrElse last.Length = 0 Then
            Ui.Warn("First name and last name are required.")
            Return
        End If
        Dim email As String = Ui.Nz(txtEmail)
        If email IsNot Nothing AndAlso Not Ui.ValidEmail(email) Then
            Ui.Warn("Please enter a valid email address.")
            Return
        End If
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
        Ui.Fill(cboApptPatient, Db.Query("
            SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name
            FROM tblPatients WHERE Status <> 'Archived' ORDER BY LastName, FirstName"), "Name", "ID")
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
        Ui.SelectValue(cboApptPatient, r("PatientID"))
        Ui.SelectValue(cboDentist, r("DentistID"))
        Ui.SelectValue(cboType, r("AppointmentTypeID"))
        dtpDate.Value = Convert.ToDateTime(r("AppointmentDate"))
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
        cboDentist.SelectedIndex = If(cboDentist.Items.Count = 1, 0, -1)
        cboType.SelectedIndex = -1
        dtpDate.Value = If(chkAllDates.Checked, DateTime.Today, dtpFilterDate.Value.Date)
        dtpStart.Value = DateTime.Today.AddHours(9)
        dtpEnd.Checked = False
        txtReason.Clear()
        txtNotes.Clear()
        btnCancelAppt.Enabled = False
        dgvAppointments.ClearSelection()
        _apptLoading = False
        cboApptPatient.Focus()
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
        Dim patient As Integer? = Ui.SelId(cboApptPatient)
        Dim dentist As Integer? = Ui.SelId(cboDentist)
        Dim apptType As Integer? = Ui.SelId(cboType)
        If Not patient.HasValue Then
            Ui.Warn("Select a patient.")
            Return
        End If
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

    Private Sub OpenBilling()
        _invInit = True
        _invId = 0
        txtInvoiceNo.Clear()
        Try
            cboStatusFilter.SelectedIndex = 0
            Ui.Fill(cboInvoicePatient, Db.Query("
                SELECT PatientID AS ID, CONCAT(PatientCode, ' - ', LastName, ', ', FirstName) AS Name
                FROM tblPatients WHERE Status = 'Active' ORDER BY LastName, FirstName"), "Name", "ID")
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
        Dim isOpen As Boolean = saved AndAlso txtStatus.Text <> "Void"
        cboInvoicePatient.Enabled = Not saved
        numDiscount.Enabled = Not saved OrElse isOpen
        btnSaveInvoice.Enabled = Not saved OrElse isOpen
        btnVoid.Enabled = isOpen
        grpItems.Enabled = isOpen
        grpPayments.Enabled = isOpen
    End Sub

    Private Sub btnNewInvoice_Click(sender As Object, e As EventArgs) Handles btnNewInvoice.Click
        NewInvoice()
    End Sub

    ' ------------------------------------------------------------ save invoice header
    Private Sub btnSaveInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveInvoice.Click
        Ui.Try(Sub()
                   If _invId = 0 Then
                       Dim patient As Integer? = Ui.SelId(cboInvoicePatient)
                       If Not patient.HasValue Then
                           Ui.Warn("Select the patient to bill.")
                           Return
                       End If

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
        Dim msg As String = If(dgvPayments.Rows.Count > 0,
            "This invoice already has payments. Voiding keeps the payment records but removes the invoice from balances." & vbCrLf & vbCrLf & "Void it?",
            "Void this invoice?")
        If Not Ui.Confirm(msg) Then Return
        Ui.Try(Sub()
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

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If _invId = 0 Then
            Ui.Warn("Save the invoice first.")
            Return
        End If
        Dim desc As String = txtItemDesc.Text.Trim()
        If desc.Length = 0 Then
            Ui.Warn("Enter a description for the item.")
            Return
        End If
        Dim qty As Integer = CInt(numQty.Value)
        Dim price As Decimal = numUnitPrice.Value
        Dim disc As Decimal = numItemDiscount.Value
        If disc > qty * price Then
            Ui.Warn("The item discount cannot be more than quantity x unit price.")
            Return
        End If

        Ui.Try(Sub()
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
                   numItemDiscount.Value = 0
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
        txtAllergies.Clear()
        txtMedications.Clear()
        txtConditions.Clear()
        txtSurgeries.Clear()
        txtFamilyHistory.Clear()
        txtOtherNotes.Clear()
        lblMedicalUpdated.Text = ""
        dgvVisits.DataSource = Nothing
        dgvTreatments.DataSource = Nothing
        dgvChart.DataSource = Nothing
        NewVisit()
        NewChart()
        tabMain.SelectedIndex = 0
        tabMain.Enabled = False
    End Sub

    ' ------------------------------------------------------------ patient picker
    Private Sub cboPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPatient.SelectedIndexChanged
        If _recInit Then Return
        Dim id As Integer? = Ui.SelId(cboPatient)
        _recPatientId = If(id.HasValue, id.Value, 0)
        tabMain.Enabled = _recPatientId > 0
        If _recPatientId = 0 Then Return
        Ui.Try(Sub()
                   LoadMedical()
                   LoadVisits()
                   LoadChart()
               End Sub)
    End Sub

    ' ------------------------------------------------------------ medical history
    Private Sub LoadMedical()
        Dim table As DataTable = Db.Query("SELECT * FROM tblMedicalHistory WHERE PatientID = @p", ("@p", _recPatientId))
        If table.Rows.Count = 0 Then
            txtAllergies.Clear()
            txtMedications.Clear()
            txtConditions.Clear()
            txtSurgeries.Clear()
            txtFamilyHistory.Clear()
            txtOtherNotes.Clear()
            lblMedicalUpdated.Text = "No medical history recorded yet."
            Return
        End If
        Dim r As DataRow = table.Rows(0)
        txtAllergies.Text = Ui.Txt(r("Allergies"))
        txtMedications.Text = Ui.Txt(r("CurrentMedications"))
        txtConditions.Text = Ui.Txt(r("MedicalConditions"))
        txtSurgeries.Text = Ui.Txt(r("PreviousSurgeries"))
        txtFamilyHistory.Text = Ui.Txt(r("FamilyMedicalHistory"))
        txtOtherNotes.Text = Ui.Txt(r("OtherNotes"))
        lblMedicalUpdated.Text = "Last updated " & Convert.ToDateTime(r("UpdatedAt")).ToString("yyyy-MM-dd HH:mm")
    End Sub

    Private Sub btnSaveMedical_Click(sender As Object, e As EventArgs) Handles btnSaveMedical.Click
        If _recPatientId = 0 Then Return
        Ui.Try(Sub()
                   Db.Exec("
                INSERT INTO tblMedicalHistory
                    (PatientID, Allergies, CurrentMedications, MedicalConditions, PreviousSurgeries,
                     FamilyMedicalHistory, OtherNotes)
                VALUES (@p, @a, @m, @c, @s, @f, @o)
                ON DUPLICATE KEY UPDATE
                    Allergies = VALUES(Allergies), CurrentMedications = VALUES(CurrentMedications),
                    MedicalConditions = VALUES(MedicalConditions), PreviousSurgeries = VALUES(PreviousSurgeries),
                    FamilyMedicalHistory = VALUES(FamilyMedicalHistory), OtherNotes = VALUES(OtherNotes),
                    UpdatedAt = NOW()",
                       ("@p", _recPatientId), ("@a", Ui.Nz(txtAllergies)), ("@m", Ui.Nz(txtMedications)),
                       ("@c", Ui.Nz(txtConditions)), ("@s", Ui.Nz(txtSurgeries)),
                       ("@f", Ui.Nz(txtFamilyHistory)), ("@o", Ui.Nz(txtOtherNotes)))
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
                   IFNULL(t.ToothNumber, '') AS Tooth, t.Quantity AS Qty,
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
        Dim qty As Integer = CInt(numTreatQty.Value)
        Dim price As Decimal = numTreatPrice.Value
        Dim disc As Decimal = numTreatDiscount.Value
        If disc > qty * price Then
            Ui.Warn("The discount cannot be more than quantity x unit price.")
            Return
        End If

        Ui.Try(Sub()
                   Dim dentistId As Object = Db.Scalar("SELECT DentistID FROM tblDentalRecords WHERE DentalRecordID=@id", ("@id", _visitId))
                   Dim newId As Long = Db.Insert("
                INSERT INTO tblTreatmentRecords
                    (DentalRecordID, ProcedureID, DentistID, ToothNumber, Quantity, UnitPrice, Discount, TreatmentStatus)
                VALUES (@v, @pr, @d, @t, @q, @u, @disc, @st)",
                       ("@v", _visitId), ("@pr", procId), ("@d", dentistId), ("@t", Ui.Nz(txtTreatTooth)), ("@q", qty),
                       ("@u", price), ("@disc", disc), ("@st", cboTreatStatus.Text))
                   Audit.Log("Add Treatment", "tblTreatmentRecords", newId, Nothing, cboTreatProcedure.Text)

                   cboTreatProcedure.SelectedIndex = -1
                   txtTreatTooth.Clear()
                   numTreatQty.Value = 1
                   numTreatPrice.Value = 0
                   numTreatDiscount.Value = 0
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
        Dim tooth As String = txtChartTooth.Text.Trim()
        If tooth.Length = 0 Then
            Ui.Warn("Enter the tooth number.")
            Return
        End If
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
        txtProcCode.Clear()
        txtName.Clear()
        txtDescription.Clear()
        numPrice.Value = 0
        numDuration.Value = 0
        cboProcStatus.SelectedIndex = 0
        _procLoading = True
        dgvProcedures.ClearSelection()
        _procLoading = False
        txtProcCode.Focus()
    End Sub

    Private Sub btnNewProcedure_Click(sender As Object, e As EventArgs) Handles btnNewProcedure.Click
        NewProcedure()
    End Sub

    Private Sub btnSaveProcedure_Click(sender As Object, e As EventArgs) Handles btnSaveProcedure.Click
        Dim code As String = txtProcCode.Text.Trim()
        Dim name As String = txtName.Text.Trim()
        If code.Length = 0 OrElse name.Length = 0 Then
            Ui.Warn("Procedure code and name are required.")
            Return
        End If
        Dim duration As Object = If(numDuration.Value > 0, CObj(CInt(numDuration.Value)), Nothing)
        Dim status As String = If(cboProcStatus.SelectedIndex >= 0, cboProcStatus.Text, "Active")

        Ui.Try(Sub()
                   If _procId = 0 Then
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
        Dim name As String = txtProdName.Text.Trim()
        Dim unit As String = txtUnit.Text.Trim()
        Dim category As Integer? = Ui.SelId(cboCategory)
        If name.Length = 0 OrElse unit.Length = 0 OrElse Not category.HasValue Then
            Ui.Warn("Product name, category and unit are required.")
            Return
        End If
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
        Dim name As String = txtSupName.Text.Trim()
        If name.Length = 0 Then
            Ui.Warn("The supplier name is required.")
            Return
        End If
        Dim email As String = Ui.Nz(txtSupEmail)
        If email IsNot Nothing AndAlso Not Ui.ValidEmail(email) Then
            Ui.Warn("Please enter a valid email address.")
            Return
        End If
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
        txtStaffFirstName.Focus()
    End Sub

    Private Sub btnNewStaff_Click(sender As Object, e As EventArgs) Handles btnNewStaff.Click
        NewStaff()
    End Sub

    Private Sub btnSaveStaff_Click(sender As Object, e As EventArgs) Handles btnSaveStaff.Click
        Dim first As String = txtStaffFirstName.Text.Trim()
        Dim last As String = txtStaffLastName.Text.Trim()
        Dim position As String = Ui.GetText(cboPosition)
        If first.Length = 0 OrElse last.Length = 0 OrElse position Is Nothing Then
            Ui.Warn("First name, last name and position are required.")
            Return
        End If
        Dim email As String = Ui.Nz(txtStaffEmail)
        If email IsNot Nothing AndAlso Not Ui.ValidEmail(email) Then
            Ui.Warn("Please enter a valid email address.")
            Return
        End If
        Dim status As String = If(cboStaffStatus.SelectedIndex >= 0, cboStaffStatus.Text, "Active")

        Ui.Try(Sub()
                   If _staffId = 0 Then
                       Dim code As String = txtStaffCode.Text.Trim()
                       If code.Length = 0 Then
                           Dim nextId As Integer = Convert.ToInt32(Db.Scalar("SELECT IFNULL(MAX(StaffID), 0) + 1 FROM tblStaff"))
                           code = $"STF-{nextId:D3}"
                       End If
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
                   IFNULL(DATE_FORMAT(u.LastLogin, '%Y-%m-%d %H:%i'), 'never') AS `Last Login`
            FROM tblUsers u
            INNER JOIN tblRoles r ON r.RoleID = u.RoleID
            INNER JOIN tblStaff s ON s.StaffID = u.StaffID
            ORDER BY r.RoleID"))
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then
            Ui.Warn("Select an account first.")
            Return
        End If
        Dim username As String = Ui.Txt(dgvUsers.CurrentRow.Cells("Username").Value)

        Dim newPass As String = Ui.AskPassword("Set a new password for the account '" & username & "'.")
        If newPass Is Nothing Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET PasswordHash=@h WHERE UserID=@id", ("@h", Pwd.Hash(newPass)), ("@id", id))
                   Audit.Log("Reset Password", "tblUsers", id, Nothing, username)
                   LoadUsers()
                   Ui.Info($"The password for '{username}' was changed.")
               End Sub)
    End Sub

    Private Sub btnToggleActive_Click(sender As Object, e As EventArgs) Handles btnToggleActive.Click
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then
            Ui.Warn("Select an account first.")
            Return
        End If
        If id = Session.UserId Then
            Ui.Warn("You cannot disable the account you are signed in with.")
            Return
        End If
        Dim username As String = Ui.Txt(dgvUsers.CurrentRow.Cells("Username").Value)
        Dim active As Boolean = Ui.Txt(dgvUsers.CurrentRow.Cells("Active").Value) = "Yes"
        If Not Ui.Confirm(If(active, $"Disable the account '{username}'?", $"Enable the account '{username}'?")) Then Return
        Ui.Try(Sub()
                   Db.Exec("UPDATE tblUsers SET IsActive=@a WHERE UserID=@id", ("@a", If(active, 0, 1)), ("@id", id))
                   Audit.Log(If(active, "Disable Account", "Enable Account"), "tblUsers", id, Nothing, username)
                   LoadUsers()
               End Sub)
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick

    End Sub
End Class
