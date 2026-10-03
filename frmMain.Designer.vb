<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.btnNavPatients = New System.Windows.Forms.Button()
        Me.btnNavAppointments = New System.Windows.Forms.Button()
        Me.btnNavBilling = New System.Windows.Forms.Button()
        Me.btnNavClinical = New System.Windows.Forms.Button()
        Me.btnNavProcedures = New System.Windows.Forms.Button()
        Me.btnNavInventory = New System.Windows.Forms.Button()
        Me.btnNavStaff = New System.Windows.Forms.Button()
        Me.btnNavAudit = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.pnlCardToday = New System.Windows.Forms.Panel()
        Me.lblCardTodayCaption = New System.Windows.Forms.Label()
        Me.lblTodayCount = New System.Windows.Forms.Label()
        Me.pnlCardPending = New System.Windows.Forms.Panel()
        Me.lblCardPendingCaption = New System.Windows.Forms.Label()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.pnlCardUnpaid = New System.Windows.Forms.Panel()
        Me.lblCardUnpaidCaption = New System.Windows.Forms.Label()
        Me.lblUnpaidCount = New System.Windows.Forms.Label()
        Me.lblUnpaidAmount = New System.Windows.Forms.Label()
        Me.pnlCardLow = New System.Windows.Forms.Panel()
        Me.lblCardLowCaption = New System.Windows.Forms.Label()
        Me.lblLowStockCount = New System.Windows.Forms.Label()
        Me.lblTodayAppointments = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvToday = New System.Windows.Forms.DataGridView()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.tabInventory = New System.Windows.Forms.TabControl()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.pnlProdRight = New System.Windows.Forms.Panel()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.lblProdCode = New System.Windows.Forms.Label()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblReorder = New System.Windows.Forms.Label()
        Me.numReorder = New System.Windows.Forms.NumericUpDown()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.numCost = New System.Windows.Forms.NumericUpDown()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblProdStatus = New System.Windows.Forms.Label()
        Me.cboProdStatus = New System.Windows.Forms.ComboBox()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.grpStock = New System.Windows.Forms.GroupBox()
        Me.lblTxType = New System.Windows.Forms.Label()
        Me.cboTxType = New System.Windows.Forms.ComboBox()
        Me.lblTxQty = New System.Windows.Forms.Label()
        Me.numTxQty = New System.Windows.Forms.NumericUpDown()
        Me.lblTxRef = New System.Windows.Forms.Label()
        Me.txtTxRef = New System.Windows.Forms.TextBox()
        Me.lblTxNotes = New System.Windows.Forms.Label()
        Me.txtTxNotes = New System.Windows.Forms.TextBox()
        Me.btnPostStock = New System.Windows.Forms.Button()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.pnlProdLeft = New System.Windows.Forms.Panel()
        Me.chkLowStock = New System.Windows.Forms.CheckBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.tabSuppliers = New System.Windows.Forms.TabPage()
        Me.pnlSupRight = New System.Windows.Forms.Panel()
        Me.grpSupplier = New System.Windows.Forms.GroupBox()
        Me.lblSupName = New System.Windows.Forms.Label()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.lblSupStatus = New System.Windows.Forms.Label()
        Me.cboSupStatus = New System.Windows.Forms.ComboBox()
        Me.lblSupContact = New System.Windows.Forms.Label()
        Me.txtSupContact = New System.Windows.Forms.TextBox()
        Me.lblSupPhone = New System.Windows.Forms.Label()
        Me.txtSupPhone = New System.Windows.Forms.TextBox()
        Me.lblSupEmail = New System.Windows.Forms.Label()
        Me.txtSupEmail = New System.Windows.Forms.TextBox()
        Me.lblSupAddress = New System.Windows.Forms.Label()
        Me.txtSupAddress = New System.Windows.Forms.TextBox()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.pnlSupLeft = New System.Windows.Forms.Panel()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.pnlAppointment = New System.Windows.Forms.Panel()
        Me.pnlApptRight = New System.Windows.Forms.Panel()
        Me.grpAppointment = New System.Windows.Forms.GroupBox()
        Me.lblApptCode = New System.Windows.Forms.Label()
        Me.txtApptCode = New System.Windows.Forms.TextBox()
        Me.lblApptStatus = New System.Windows.Forms.Label()
        Me.cboApptStatus = New System.Windows.Forms.ComboBox()
        Me.lblApptPatient = New System.Windows.Forms.Label()
        Me.cboApptPatient = New System.Windows.Forms.ComboBox()
        Me.lblDentist = New System.Windows.Forms.Label()
        Me.cboDentist = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnNewAppt = New System.Windows.Forms.Button()
        Me.btnSaveAppt = New System.Windows.Forms.Button()
        Me.btnCancelAppt = New System.Windows.Forms.Button()
        Me.pnlApptLeft = New System.Windows.Forms.Panel()
        Me.dtpFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.chkAllDates = New System.Windows.Forms.CheckBox()
        Me.cboFilterStatus = New System.Windows.Forms.ComboBox()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.pnlPatients = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvPatients = New System.Windows.Forms.DataGridView()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblRegistered = New System.Windows.Forms.Label()
        Me.txtRegistered = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblEmergName = New System.Windows.Forms.Label()
        Me.txtEmergName = New System.Windows.Forms.TextBox()
        Me.lblEmergNum = New System.Windows.Forms.Label()
        Me.txtEmergNum = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.pnlClinicalRecord = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.cboPatient = New System.Windows.Forms.ComboBox()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabMedical = New System.Windows.Forms.TabPage()
        Me.lblAllergies = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.lblMedications = New System.Windows.Forms.Label()
        Me.txtMedications = New System.Windows.Forms.TextBox()
        Me.lblConditions = New System.Windows.Forms.Label()
        Me.txtConditions = New System.Windows.Forms.TextBox()
        Me.lblSurgeries = New System.Windows.Forms.Label()
        Me.txtSurgeries = New System.Windows.Forms.TextBox()
        Me.lblFamilyHistory = New System.Windows.Forms.Label()
        Me.txtFamilyHistory = New System.Windows.Forms.TextBox()
        Me.lblOtherNotes = New System.Windows.Forms.Label()
        Me.txtOtherNotes = New System.Windows.Forms.TextBox()
        Me.btnSaveMedical = New System.Windows.Forms.Button()
        Me.lblMedicalUpdated = New System.Windows.Forms.Label()
        Me.tabVisits = New System.Windows.Forms.TabPage()
        Me.dgvVisits = New System.Windows.Forms.DataGridView()
        Me.grpVisit = New System.Windows.Forms.GroupBox()
        Me.lblVisit = New System.Windows.Forms.Label()
        Me.dtpVisit = New System.Windows.Forms.DateTimePicker()
        Me.lblVisitDentist = New System.Windows.Forms.Label()
        Me.cboVisitDentist = New System.Windows.Forms.ComboBox()
        Me.lblNextVisit = New System.Windows.Forms.Label()
        Me.dtpNextVisit = New System.Windows.Forms.DateTimePicker()
        Me.lblComplaint = New System.Windows.Forms.Label()
        Me.txtComplaint = New System.Windows.Forms.TextBox()
        Me.lblDiagnosis = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New System.Windows.Forms.TextBox()
        Me.lblClinicalNotes = New System.Windows.Forms.Label()
        Me.txtClinicalNotes = New System.Windows.Forms.TextBox()
        Me.lblRecommendations = New System.Windows.Forms.Label()
        Me.txtRecommendations = New System.Windows.Forms.TextBox()
        Me.btnNewVisit = New System.Windows.Forms.Button()
        Me.btnSaveVisit = New System.Windows.Forms.Button()
        Me.grpTreat = New System.Windows.Forms.GroupBox()
        Me.lblTreatProcedure = New System.Windows.Forms.Label()
        Me.cboTreatProcedure = New System.Windows.Forms.ComboBox()
        Me.lblTreatTooth = New System.Windows.Forms.Label()
        Me.txtTreatTooth = New System.Windows.Forms.TextBox()
        Me.lblTreatQty = New System.Windows.Forms.Label()
        Me.numTreatQty = New System.Windows.Forms.NumericUpDown()
        Me.lblTreatPrice = New System.Windows.Forms.Label()
        Me.numTreatPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblTreatDiscount = New System.Windows.Forms.Label()
        Me.numTreatDiscount = New System.Windows.Forms.NumericUpDown()
        Me.lblTreatStatus = New System.Windows.Forms.Label()
        Me.cboTreatStatus = New System.Windows.Forms.ComboBox()
        Me.btnAddTreatment = New System.Windows.Forms.Button()
        Me.btnRemoveTreatment = New System.Windows.Forms.Button()
        Me.dgvTreatments = New System.Windows.Forms.DataGridView()
        Me.tabChart = New System.Windows.Forms.TabPage()
        Me.dgvChart = New System.Windows.Forms.DataGridView()
        Me.grpChart = New System.Windows.Forms.GroupBox()
        Me.lblChartTooth = New System.Windows.Forms.Label()
        Me.txtChartTooth = New System.Windows.Forms.TextBox()
        Me.lblSurface = New System.Windows.Forms.Label()
        Me.cboSurface = New System.Windows.Forms.ComboBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.lblChartNotes = New System.Windows.Forms.Label()
        Me.txtChartNotes = New System.Windows.Forms.TextBox()
        Me.btnNewChart = New System.Windows.Forms.Button()
        Me.btnSaveChart = New System.Windows.Forms.Button()
        Me.btnDeleteChart = New System.Windows.Forms.Button()
        Me.pnlProcedures = New System.Windows.Forms.Panel()
        Me.pnlProcRight = New System.Windows.Forms.Panel()
        Me.grpProcedure = New System.Windows.Forms.GroupBox()
        Me.lblProcCode = New System.Windows.Forms.Label()
        Me.txtProcCode = New System.Windows.Forms.TextBox()
        Me.lblProcStatus = New System.Windows.Forms.Label()
        Me.cboProcStatus = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.numDuration = New System.Windows.Forms.NumericUpDown()
        Me.btnNewProcedure = New System.Windows.Forms.Button()
        Me.btnSaveProcedure = New System.Windows.Forms.Button()
        Me.pnlProcLeft = New System.Windows.Forms.Panel()
        Me.dgvProcedures = New System.Windows.Forms.DataGridView()
        Me.pnlAuditlog = New System.Windows.Forms.Panel()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.pnlStaff = New System.Windows.Forms.Panel()
        Me.pnlStaffRight = New System.Windows.Forms.Panel()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.lblStaffCode = New System.Windows.Forms.Label()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.lblStaffStatus = New System.Windows.Forms.Label()
        Me.cboStaffStatus = New System.Windows.Forms.ComboBox()
        Me.lblStaffFirstName = New System.Windows.Forms.Label()
        Me.txtStaffFirstName = New System.Windows.Forms.TextBox()
        Me.lblStaffLastName = New System.Windows.Forms.Label()
        Me.txtStaffLastName = New System.Windows.Forms.TextBox()
        Me.lblStaffContact = New System.Windows.Forms.Label()
        Me.txtStaffContact = New System.Windows.Forms.TextBox()
        Me.lblStaffEmail = New System.Windows.Forms.Label()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.btnNewStaff = New System.Windows.Forms.Button()
        Me.btnSaveStaff = New System.Windows.Forms.Button()
        Me.grpUsers = New System.Windows.Forms.GroupBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.btnToggleActive = New System.Windows.Forms.Button()
        Me.pnlStaffLeft = New System.Windows.Forms.Panel()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.pnlBillingpayments = New System.Windows.Forms.Panel()
        Me.pnlInvoiceRight = New System.Windows.Forms.Panel()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblInvoiceStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.numDiscount = New System.Windows.Forms.NumericUpDown()
        Me.lblInvoicePatient = New System.Windows.Forms.Label()
        Me.cboInvoicePatient = New System.Windows.Forms.ComboBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.btnNewInvoice = New System.Windows.Forms.Button()
        Me.btnSaveInvoice = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.cboProcedure = New System.Windows.Forms.ComboBox()
        Me.lblItemDesc = New System.Windows.Forms.Label()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.numUnitPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblItemDiscount = New System.Windows.Forms.Label()
        Me.numItemDiscount = New System.Windows.Forms.NumericUpDown()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.grpPayments = New System.Windows.Forms.GroupBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.cboMethod = New System.Windows.Forms.ComboBox()
        Me.lblPayAmount = New System.Windows.Forms.Label()
        Me.numPayAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblPayNotes = New System.Windows.Forms.Label()
        Me.txtPayNotes = New System.Windows.Forms.TextBox()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.pnlInvoiceLeft = New System.Windows.Forms.Panel()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.dgvInvoices = New System.Windows.Forms.DataGridView()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlCardToday.SuspendLayout()
        Me.pnlCardPending.SuspendLayout()
        Me.pnlCardUnpaid.SuspendLayout()
        Me.pnlCardLow.SuspendLayout()
        CType(Me.dgvToday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        Me.tabInventory.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.pnlProdRight.SuspendLayout()
        Me.grpProduct.SuspendLayout()
        CType(Me.numReorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStock.SuspendLayout()
        CType(Me.numTxQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProdLeft.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSuppliers.SuspendLayout()
        Me.pnlSupRight.SuspendLayout()
        Me.grpSupplier.SuspendLayout()
        Me.pnlSupLeft.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAppointment.SuspendLayout()
        Me.pnlApptRight.SuspendLayout()
        Me.grpAppointment.SuspendLayout()
        Me.pnlApptLeft.SuspendLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPatients.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        Me.pnlClinicalRecord.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabMedical.SuspendLayout()
        Me.tabVisits.SuspendLayout()
        CType(Me.dgvVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVisit.SuspendLayout()
        Me.grpTreat.SuspendLayout()
        CType(Me.numTreatQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTreatPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTreatDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreatments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabChart.SuspendLayout()
        CType(Me.dgvChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChart.SuspendLayout()
        Me.pnlProcedures.SuspendLayout()
        Me.pnlProcRight.SuspendLayout()
        Me.grpProcedure.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProcLeft.SuspendLayout()
        CType(Me.dgvProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAuditlog.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaff.SuspendLayout()
        Me.pnlStaffRight.SuspendLayout()
        Me.grpStaff.SuspendLayout()
        Me.grpUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaffLeft.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBillingpayments.SuspendLayout()
        Me.pnlInvoiceRight.SuspendLayout()
        Me.grpInvoice.SuspendLayout()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItems.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayments.SuspendLayout()
        CType(Me.numPayAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInvoiceLeft.SuspendLayout()
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.picLogo)
        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.lblBrandSub)
        Me.pnlSidebar.Controls.Add(Me.btnNavDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnNavPatients)
        Me.pnlSidebar.Controls.Add(Me.btnNavAppointments)
        Me.pnlSidebar.Controls.Add(Me.btnNavBilling)
        Me.pnlSidebar.Controls.Add(Me.btnNavClinical)
        Me.pnlSidebar.Controls.Add(Me.btnNavProcedures)
        Me.pnlSidebar.Controls.Add(Me.btnNavInventory)
        Me.pnlSidebar.Controls.Add(Me.btnNavStaff)
        Me.pnlSidebar.Controls.Add(Me.btnNavAudit)
        Me.pnlSidebar.Controls.Add(Me.btnChangePassword)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 1080)
        Me.pnlSidebar.TabIndex = 6
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(35, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(153, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(12, 162)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(152, 30)
        Me.lblBrand.TabIndex = 6
        Me.lblBrand.Text = "DentalScapes"
        '
        'lblBrandSub
        '
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(14, 192)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(97, 13)
        Me.lblBrandSub.TabIndex = 7
        Me.lblBrandSub.Text = "Clinic Management"
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavDashboard.FlatAppearance.BorderSize = 0
        Me.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnNavDashboard.Location = New System.Drawing.Point(10, 235)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavDashboard.Size = New System.Drawing.Size(200, 40)
        Me.btnNavDashboard.TabIndex = 8
        Me.btnNavDashboard.Text = "Dashboard"
        Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavDashboard.UseVisualStyleBackColor = False
        '
        'btnNavPatients
        '
        Me.btnNavPatients.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPatients.FlatAppearance.BorderSize = 0
        Me.btnNavPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPatients.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavPatients.ForeColor = System.Drawing.Color.White
        Me.btnNavPatients.Location = New System.Drawing.Point(10, 281)
        Me.btnNavPatients.Name = "btnNavPatients"
        Me.btnNavPatients.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavPatients.Size = New System.Drawing.Size(200, 40)
        Me.btnNavPatients.TabIndex = 9
        Me.btnNavPatients.Text = "Patients"
        Me.btnNavPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavPatients.UseVisualStyleBackColor = False
        '
        'btnNavAppointments
        '
        Me.btnNavAppointments.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavAppointments.FlatAppearance.BorderSize = 0
        Me.btnNavAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavAppointments.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavAppointments.ForeColor = System.Drawing.Color.White
        Me.btnNavAppointments.Location = New System.Drawing.Point(10, 327)
        Me.btnNavAppointments.Name = "btnNavAppointments"
        Me.btnNavAppointments.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavAppointments.Size = New System.Drawing.Size(200, 40)
        Me.btnNavAppointments.TabIndex = 10
        Me.btnNavAppointments.Text = "Appointments"
        Me.btnNavAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavAppointments.UseVisualStyleBackColor = False
        '
        'btnNavBilling
        '
        Me.btnNavBilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavBilling.FlatAppearance.BorderSize = 0
        Me.btnNavBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavBilling.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavBilling.ForeColor = System.Drawing.Color.White
        Me.btnNavBilling.Location = New System.Drawing.Point(10, 373)
        Me.btnNavBilling.Name = "btnNavBilling"
        Me.btnNavBilling.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavBilling.Size = New System.Drawing.Size(200, 40)
        Me.btnNavBilling.TabIndex = 11
        Me.btnNavBilling.Text = "Billing && Payments"
        Me.btnNavBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavBilling.UseVisualStyleBackColor = False
        '
        'btnNavClinical
        '
        Me.btnNavClinical.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavClinical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavClinical.FlatAppearance.BorderSize = 0
        Me.btnNavClinical.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavClinical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavClinical.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavClinical.ForeColor = System.Drawing.Color.White
        Me.btnNavClinical.Location = New System.Drawing.Point(10, 419)
        Me.btnNavClinical.Name = "btnNavClinical"
        Me.btnNavClinical.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavClinical.Size = New System.Drawing.Size(200, 40)
        Me.btnNavClinical.TabIndex = 12
        Me.btnNavClinical.Text = "Clinical Records"
        Me.btnNavClinical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavClinical.UseVisualStyleBackColor = False
        '
        'btnNavProcedures
        '
        Me.btnNavProcedures.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavProcedures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavProcedures.FlatAppearance.BorderSize = 0
        Me.btnNavProcedures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavProcedures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavProcedures.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavProcedures.ForeColor = System.Drawing.Color.White
        Me.btnNavProcedures.Location = New System.Drawing.Point(10, 465)
        Me.btnNavProcedures.Name = "btnNavProcedures"
        Me.btnNavProcedures.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavProcedures.Size = New System.Drawing.Size(200, 40)
        Me.btnNavProcedures.TabIndex = 13
        Me.btnNavProcedures.Text = "Procedures && Prices"
        Me.btnNavProcedures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavProcedures.UseVisualStyleBackColor = False
        '
        'btnNavInventory
        '
        Me.btnNavInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavInventory.FlatAppearance.BorderSize = 0
        Me.btnNavInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavInventory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavInventory.ForeColor = System.Drawing.Color.White
        Me.btnNavInventory.Location = New System.Drawing.Point(10, 511)
        Me.btnNavInventory.Name = "btnNavInventory"
        Me.btnNavInventory.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavInventory.Size = New System.Drawing.Size(200, 40)
        Me.btnNavInventory.TabIndex = 14
        Me.btnNavInventory.Text = "Inventory"
        Me.btnNavInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavInventory.UseVisualStyleBackColor = False
        '
        'btnNavStaff
        '
        Me.btnNavStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavStaff.FlatAppearance.BorderSize = 0
        Me.btnNavStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavStaff.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavStaff.ForeColor = System.Drawing.Color.White
        Me.btnNavStaff.Location = New System.Drawing.Point(10, 557)
        Me.btnNavStaff.Name = "btnNavStaff"
        Me.btnNavStaff.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavStaff.Size = New System.Drawing.Size(200, 40)
        Me.btnNavStaff.TabIndex = 15
        Me.btnNavStaff.Text = "Staff && Accounts"
        Me.btnNavStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavStaff.UseVisualStyleBackColor = False
        '
        'btnNavAudit
        '
        Me.btnNavAudit.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNavAudit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavAudit.FlatAppearance.BorderSize = 0
        Me.btnNavAudit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNavAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavAudit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNavAudit.ForeColor = System.Drawing.Color.White
        Me.btnNavAudit.Location = New System.Drawing.Point(10, 603)
        Me.btnNavAudit.Name = "btnNavAudit"
        Me.btnNavAudit.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnNavAudit.Size = New System.Drawing.Size(200, 40)
        Me.btnNavAudit.TabIndex = 16
        Me.btnNavAudit.Text = "Audit Log"
        Me.btnNavAudit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavAudit.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(10, 970)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(200, 38)
        Me.btnChangePassword.TabIndex = 17
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(10, 1018)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 38)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPageTitle)
        Me.pnlHeader.Controls.Add(Me.lblUser)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1700, 56)
        Me.pnlHeader.TabIndex = 20
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(18, 15)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(109, 25)
        Me.lblPageTitle.TabIndex = 3
        Me.lblPageTitle.Text = "Dashboard"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(1290, 12)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(396, 32)
        Me.lblUser.TabIndex = 4
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.pnlCardToday)
        Me.pnlDashboard.Controls.Add(Me.pnlCardPending)
        Me.pnlDashboard.Controls.Add(Me.pnlCardUnpaid)
        Me.pnlDashboard.Controls.Add(Me.pnlCardLow)
        Me.pnlDashboard.Controls.Add(Me.lblTodayAppointments)
        Me.pnlDashboard.Controls.Add(Me.btnRefresh)
        Me.pnlDashboard.Controls.Add(Me.dgvToday)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(220, 56)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlDashboard.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlDashboard.TabIndex = 21
        '
        'pnlCardToday
        '
        Me.pnlCardToday.BackColor = System.Drawing.Color.White
        Me.pnlCardToday.Controls.Add(Me.lblCardTodayCaption)
        Me.pnlCardToday.Controls.Add(Me.lblTodayCount)
        Me.pnlCardToday.Location = New System.Drawing.Point(34, 30)
        Me.pnlCardToday.Name = "pnlCardToday"
        Me.pnlCardToday.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardToday.TabIndex = 17
        '
        'lblCardTodayCaption
        '
        Me.lblCardTodayCaption.AutoSize = True
        Me.lblCardTodayCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCardTodayCaption.Location = New System.Drawing.Point(14, 12)
        Me.lblCardTodayCaption.Name = "lblCardTodayCaption"
        Me.lblCardTodayCaption.Size = New System.Drawing.Size(100, 13)
        Me.lblCardTodayCaption.TabIndex = 2
        Me.lblCardTodayCaption.Text = "Appointments today"
        '
        'lblTodayCount
        '
        Me.lblTodayCount.AutoSize = True
        Me.lblTodayCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lblTodayCount.Location = New System.Drawing.Point(12, 36)
        Me.lblTodayCount.Name = "lblTodayCount"
        Me.lblTodayCount.Size = New System.Drawing.Size(38, 45)
        Me.lblTodayCount.TabIndex = 3
        Me.lblTodayCount.Text = "0"
        '
        'pnlCardPending
        '
        Me.pnlCardPending.BackColor = System.Drawing.Color.White
        Me.pnlCardPending.Controls.Add(Me.lblCardPendingCaption)
        Me.pnlCardPending.Controls.Add(Me.lblPendingCount)
        Me.pnlCardPending.Location = New System.Drawing.Point(278, 30)
        Me.pnlCardPending.Name = "pnlCardPending"
        Me.pnlCardPending.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardPending.TabIndex = 18
        '
        'lblCardPendingCaption
        '
        Me.lblCardPendingCaption.AutoSize = True
        Me.lblCardPendingCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCardPendingCaption.Location = New System.Drawing.Point(14, 12)
        Me.lblCardPendingCaption.Name = "lblCardPendingCaption"
        Me.lblCardPendingCaption.Size = New System.Drawing.Size(106, 13)
        Me.lblCardPendingCaption.TabIndex = 5
        Me.lblCardPendingCaption.Text = "Pending confirmation"
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lblPendingCount.Location = New System.Drawing.Point(12, 36)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(38, 45)
        Me.lblPendingCount.TabIndex = 6
        Me.lblPendingCount.Text = "0"
        '
        'pnlCardUnpaid
        '
        Me.pnlCardUnpaid.BackColor = System.Drawing.Color.White
        Me.pnlCardUnpaid.Controls.Add(Me.lblCardUnpaidCaption)
        Me.pnlCardUnpaid.Controls.Add(Me.lblUnpaidCount)
        Me.pnlCardUnpaid.Controls.Add(Me.lblUnpaidAmount)
        Me.pnlCardUnpaid.Location = New System.Drawing.Point(522, 30)
        Me.pnlCardUnpaid.Name = "pnlCardUnpaid"
        Me.pnlCardUnpaid.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardUnpaid.TabIndex = 19
        '
        'lblCardUnpaidCaption
        '
        Me.lblCardUnpaidCaption.AutoSize = True
        Me.lblCardUnpaidCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCardUnpaidCaption.Location = New System.Drawing.Point(14, 12)
        Me.lblCardUnpaidCaption.Name = "lblCardUnpaidCaption"
        Me.lblCardUnpaidCaption.Size = New System.Drawing.Size(83, 13)
        Me.lblCardUnpaidCaption.TabIndex = 8
        Me.lblCardUnpaidCaption.Text = "Unpaid invoices"
        '
        'lblUnpaidCount
        '
        Me.lblUnpaidCount.AutoSize = True
        Me.lblUnpaidCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnpaidCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lblUnpaidCount.Location = New System.Drawing.Point(12, 36)
        Me.lblUnpaidCount.Name = "lblUnpaidCount"
        Me.lblUnpaidCount.Size = New System.Drawing.Size(38, 45)
        Me.lblUnpaidCount.TabIndex = 9
        Me.lblUnpaidCount.Text = "0"
        '
        'lblUnpaidAmount
        '
        Me.lblUnpaidAmount.AutoSize = True
        Me.lblUnpaidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblUnpaidAmount.Location = New System.Drawing.Point(14, 76)
        Me.lblUnpaidAmount.Name = "lblUnpaidAmount"
        Me.lblUnpaidAmount.Size = New System.Drawing.Size(93, 13)
        Me.lblUnpaidAmount.TabIndex = 13
        Me.lblUnpaidAmount.Text = "₱0.00 outstanding"
        '
        'pnlCardLow
        '
        Me.pnlCardLow.BackColor = System.Drawing.Color.White
        Me.pnlCardLow.Controls.Add(Me.lblCardLowCaption)
        Me.pnlCardLow.Controls.Add(Me.lblLowStockCount)
        Me.pnlCardLow.Location = New System.Drawing.Point(766, 30)
        Me.pnlCardLow.Name = "pnlCardLow"
        Me.pnlCardLow.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardLow.TabIndex = 20
        '
        'lblCardLowCaption
        '
        Me.lblCardLowCaption.AutoSize = True
        Me.lblCardLowCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCardLowCaption.Location = New System.Drawing.Point(14, 12)
        Me.lblCardLowCaption.Name = "lblCardLowCaption"
        Me.lblCardLowCaption.Size = New System.Drawing.Size(100, 13)
        Me.lblCardLowCaption.TabIndex = 11
        Me.lblCardLowCaption.Text = "Low-stock products"
        '
        'lblLowStockCount
        '
        Me.lblLowStockCount.AutoSize = True
        Me.lblLowStockCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lblLowStockCount.Location = New System.Drawing.Point(12, 36)
        Me.lblLowStockCount.Name = "lblLowStockCount"
        Me.lblLowStockCount.Size = New System.Drawing.Size(38, 45)
        Me.lblLowStockCount.TabIndex = 12
        Me.lblLowStockCount.Text = "0"
        '
        'lblTodayAppointments
        '
        Me.lblTodayAppointments.AutoSize = True
        Me.lblTodayAppointments.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayAppointments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblTodayAppointments.Location = New System.Drawing.Point(34, 146)
        Me.lblTodayAppointments.Name = "lblTodayAppointments"
        Me.lblTodayAppointments.Size = New System.Drawing.Size(163, 20)
        Me.lblTodayAppointments.TabIndex = 21
        Me.lblTodayAppointments.Text = "Today's appointments"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(936, 140)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dgvToday
        '
        Me.dgvToday.AllowUserToAddRows = False
        Me.dgvToday.AllowUserToDeleteRows = False
        Me.dgvToday.AllowUserToResizeRows = False
        Me.dgvToday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvToday.BackgroundColor = System.Drawing.Color.White
        Me.dgvToday.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvToday.Location = New System.Drawing.Point(34, 178)
        Me.dgvToday.MultiSelect = False
        Me.dgvToday.Name = "dgvToday"
        Me.dgvToday.ReadOnly = True
        Me.dgvToday.RowHeadersVisible = False
        Me.dgvToday.RowTemplate.Height = 26
        Me.dgvToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvToday.Size = New System.Drawing.Size(1002, 497)
        Me.dgvToday.TabIndex = 23
        '
        'pnlInventory
        '
        Me.pnlInventory.Controls.Add(Me.tabInventory)
        Me.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventory.Location = New System.Drawing.Point(220, 56)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlInventory.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlInventory.TabIndex = 22
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.tabProducts)
        Me.tabInventory.Controls.Add(Me.tabSuppliers)
        Me.tabInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabInventory.Location = New System.Drawing.Point(10, 10)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.SelectedIndex = 0
        Me.tabInventory.Size = New System.Drawing.Size(1680, 1004)
        Me.tabInventory.TabIndex = 2
        '
        'tabProducts
        '
        Me.tabProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabProducts.Controls.Add(Me.pnlProdRight)
        Me.tabProducts.Controls.Add(Me.pnlProdLeft)
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Padding = New System.Windows.Forms.Padding(6)
        Me.tabProducts.Size = New System.Drawing.Size(1672, 978)
        Me.tabProducts.TabIndex = 2
        Me.tabProducts.Text = "Products && Stock"
        '
        'pnlProdRight
        '
        Me.pnlProdRight.AutoScroll = True
        Me.pnlProdRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlProdRight.Controls.Add(Me.grpProduct)
        Me.pnlProdRight.Controls.Add(Me.grpStock)
        Me.pnlProdRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProdRight.Location = New System.Drawing.Point(476, 6)
        Me.pnlProdRight.Name = "pnlProdRight"
        Me.pnlProdRight.Size = New System.Drawing.Size(1190, 966)
        Me.pnlProdRight.TabIndex = 4
        '
        'grpProduct
        '
        Me.grpProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduct.Controls.Add(Me.lblProdCode)
        Me.grpProduct.Controls.Add(Me.txtProdCode)
        Me.grpProduct.Controls.Add(Me.lblProdName)
        Me.grpProduct.Controls.Add(Me.txtProdName)
        Me.grpProduct.Controls.Add(Me.lblCategory)
        Me.grpProduct.Controls.Add(Me.cboCategory)
        Me.grpProduct.Controls.Add(Me.lblUnit)
        Me.grpProduct.Controls.Add(Me.txtUnit)
        Me.grpProduct.Controls.Add(Me.lblReorder)
        Me.grpProduct.Controls.Add(Me.numReorder)
        Me.grpProduct.Controls.Add(Me.lblCost)
        Me.grpProduct.Controls.Add(Me.numCost)
        Me.grpProduct.Controls.Add(Me.lblStock)
        Me.grpProduct.Controls.Add(Me.txtStock)
        Me.grpProduct.Controls.Add(Me.lblProdStatus)
        Me.grpProduct.Controls.Add(Me.cboProdStatus)
        Me.grpProduct.Controls.Add(Me.btnNewProduct)
        Me.grpProduct.Controls.Add(Me.btnSaveProduct)
        Me.grpProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpProduct.Location = New System.Drawing.Point(8, 8)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(1490, 290)
        Me.grpProduct.TabIndex = 9
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Product"
        '
        'lblProdCode
        '
        Me.lblProdCode.AutoSize = True
        Me.lblProdCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProdCode.Location = New System.Drawing.Point(14, 24)
        Me.lblProdCode.Name = "lblProdCode"
        Me.lblProdCode.Size = New System.Drawing.Size(139, 13)
        Me.lblProdCode.TabIndex = 10
        Me.lblProdCode.Text = "Product code (blank = auto)"
        '
        'txtProdCode
        '
        Me.txtProdCode.Location = New System.Drawing.Point(14, 44)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(225, 20)
        Me.txtProdCode.TabIndex = 11
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProdName.Location = New System.Drawing.Point(254, 24)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(80, 13)
        Me.lblProdName.TabIndex = 12
        Me.lblProdName.Text = "Product name *"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(254, 44)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(225, 20)
        Me.txtProdName.TabIndex = 13
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(14, 80)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(56, 13)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category *"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(14, 100)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(225, 21)
        Me.cboCategory.TabIndex = 15
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblUnit.Location = New System.Drawing.Point(254, 80)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(118, 13)
        Me.lblUnit.TabIndex = 16
        Me.lblUnit.Text = "Unit * (pc, box, bottle...)"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(254, 100)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(225, 20)
        Me.txtUnit.TabIndex = 17
        '
        'lblReorder
        '
        Me.lblReorder.AutoSize = True
        Me.lblReorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblReorder.Location = New System.Drawing.Point(14, 136)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(70, 13)
        Me.lblReorder.TabIndex = 18
        Me.lblReorder.Text = "Reorder level"
        '
        'numReorder
        '
        Me.numReorder.Location = New System.Drawing.Point(14, 156)
        Me.numReorder.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numReorder.Name = "numReorder"
        Me.numReorder.Size = New System.Drawing.Size(225, 20)
        Me.numReorder.TabIndex = 19
        Me.numReorder.ThousandsSeparator = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCost.Location = New System.Drawing.Point(254, 136)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(65, 13)
        Me.lblCost.TabIndex = 20
        Me.lblCost.Text = "Unit cost (₱)"
        '
        'numCost
        '
        Me.numCost.DecimalPlaces = 2
        Me.numCost.Location = New System.Drawing.Point(254, 156)
        Me.numCost.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numCost.Name = "numCost"
        Me.numCost.Size = New System.Drawing.Size(225, 20)
        Me.numCost.TabIndex = 21
        Me.numCost.ThousandsSeparator = True
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStock.Location = New System.Drawing.Point(14, 192)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(197, 13)
        Me.lblStock.TabIndex = 22
        Me.lblStock.Text = "Current stock (changes via transactions)"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(14, 212)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(225, 20)
        Me.txtStock.TabIndex = 23
        '
        'lblProdStatus
        '
        Me.lblProdStatus.AutoSize = True
        Me.lblProdStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProdStatus.Location = New System.Drawing.Point(254, 192)
        Me.lblProdStatus.Name = "lblProdStatus"
        Me.lblProdStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblProdStatus.TabIndex = 24
        Me.lblProdStatus.Text = "Status"
        '
        'cboProdStatus
        '
        Me.cboProdStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProdStatus.FormattingEnabled = True
        Me.cboProdStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboProdStatus.Location = New System.Drawing.Point(254, 212)
        Me.cboProdStatus.Name = "cboProdStatus"
        Me.cboProdStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboProdStatus.TabIndex = 25
        '
        'btnNewProduct
        '
        Me.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewProduct.FlatAppearance.BorderSize = 0
        Me.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewProduct.Location = New System.Drawing.Point(14, 244)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(130, 32)
        Me.btnNewProduct.TabIndex = 26
        Me.btnNewProduct.Text = "New Product"
        Me.btnNewProduct.UseVisualStyleBackColor = False
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveProduct.FlatAppearance.BorderSize = 0
        Me.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveProduct.ForeColor = System.Drawing.Color.White
        Me.btnSaveProduct.Location = New System.Drawing.Point(152, 244)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveProduct.TabIndex = 27
        Me.btnSaveProduct.Text = "Save Product"
        Me.btnSaveProduct.UseVisualStyleBackColor = False
        '
        'grpStock
        '
        Me.grpStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStock.Controls.Add(Me.lblTxType)
        Me.grpStock.Controls.Add(Me.cboTxType)
        Me.grpStock.Controls.Add(Me.lblTxQty)
        Me.grpStock.Controls.Add(Me.numTxQty)
        Me.grpStock.Controls.Add(Me.lblTxRef)
        Me.grpStock.Controls.Add(Me.txtTxRef)
        Me.grpStock.Controls.Add(Me.lblTxNotes)
        Me.grpStock.Controls.Add(Me.txtTxNotes)
        Me.grpStock.Controls.Add(Me.btnPostStock)
        Me.grpStock.Controls.Add(Me.dgvTransactions)
        Me.grpStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpStock.Location = New System.Drawing.Point(8, 306)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(1490, 340)
        Me.grpStock.TabIndex = 28
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Stock transaction"
        '
        'lblTxType
        '
        Me.lblTxType.AutoSize = True
        Me.lblTxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTxType.Location = New System.Drawing.Point(14, 24)
        Me.lblTxType.Name = "lblTxType"
        Me.lblTxType.Size = New System.Drawing.Size(31, 13)
        Me.lblTxType.TabIndex = 29
        Me.lblTxType.Text = "Type"
        '
        'cboTxType
        '
        Me.cboTxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTxType.FormattingEnabled = True
        Me.cboTxType.Items.AddRange(New Object() {"Stock In", "Stock Out", "Adjustment In", "Adjustment Out", "Expired", "Damaged"})
        Me.cboTxType.Location = New System.Drawing.Point(14, 44)
        Me.cboTxType.Name = "cboTxType"
        Me.cboTxType.Size = New System.Drawing.Size(225, 21)
        Me.cboTxType.TabIndex = 30
        '
        'lblTxQty
        '
        Me.lblTxQty.AutoSize = True
        Me.lblTxQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTxQty.Location = New System.Drawing.Point(254, 24)
        Me.lblTxQty.Name = "lblTxQty"
        Me.lblTxQty.Size = New System.Drawing.Size(46, 13)
        Me.lblTxQty.TabIndex = 31
        Me.lblTxQty.Text = "Quantity"
        '
        'numTxQty
        '
        Me.numTxQty.Location = New System.Drawing.Point(254, 44)
        Me.numTxQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numTxQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTxQty.Name = "numTxQty"
        Me.numTxQty.Size = New System.Drawing.Size(225, 20)
        Me.numTxQty.TabIndex = 32
        Me.numTxQty.ThousandsSeparator = True
        Me.numTxQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTxRef
        '
        Me.lblTxRef.AutoSize = True
        Me.lblTxRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTxRef.Location = New System.Drawing.Point(14, 80)
        Me.lblTxRef.Name = "lblTxRef"
        Me.lblTxRef.Size = New System.Drawing.Size(144, 13)
        Me.lblTxRef.TabIndex = 33
        Me.lblTxRef.Text = "Reference (PO / invoice no.)"
        '
        'txtTxRef
        '
        Me.txtTxRef.Location = New System.Drawing.Point(14, 100)
        Me.txtTxRef.Name = "txtTxRef"
        Me.txtTxRef.Size = New System.Drawing.Size(225, 20)
        Me.txtTxRef.TabIndex = 34
        '
        'lblTxNotes
        '
        Me.lblTxNotes.AutoSize = True
        Me.lblTxNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTxNotes.Location = New System.Drawing.Point(254, 80)
        Me.lblTxNotes.Name = "lblTxNotes"
        Me.lblTxNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblTxNotes.TabIndex = 35
        Me.lblTxNotes.Text = "Notes"
        '
        'txtTxNotes
        '
        Me.txtTxNotes.Location = New System.Drawing.Point(254, 100)
        Me.txtTxNotes.Name = "txtTxNotes"
        Me.txtTxNotes.Size = New System.Drawing.Size(225, 20)
        Me.txtTxNotes.TabIndex = 36
        '
        'btnPostStock
        '
        Me.btnPostStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnPostStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPostStock.FlatAppearance.BorderSize = 0
        Me.btnPostStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPostStock.ForeColor = System.Drawing.Color.White
        Me.btnPostStock.Location = New System.Drawing.Point(14, 134)
        Me.btnPostStock.Name = "btnPostStock"
        Me.btnPostStock.Size = New System.Drawing.Size(160, 32)
        Me.btnPostStock.TabIndex = 37
        Me.btnPostStock.Text = "Post Transaction"
        Me.btnPostStock.UseVisualStyleBackColor = False
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.AllowUserToResizeRows = False
        Me.dgvTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvTransactions.Location = New System.Drawing.Point(14, 176)
        Me.dgvTransactions.MultiSelect = False
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowTemplate.Height = 26
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactions.Size = New System.Drawing.Size(1460, 156)
        Me.dgvTransactions.TabIndex = 38
        '
        'pnlProdLeft
        '
        Me.pnlProdLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlProdLeft.Controls.Add(Me.chkLowStock)
        Me.pnlProdLeft.Controls.Add(Me.dgvProducts)
        Me.pnlProdLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlProdLeft.Location = New System.Drawing.Point(6, 6)
        Me.pnlProdLeft.Name = "pnlProdLeft"
        Me.pnlProdLeft.Size = New System.Drawing.Size(470, 966)
        Me.pnlProdLeft.TabIndex = 5
        '
        'chkLowStock
        '
        Me.chkLowStock.AutoSize = True
        Me.chkLowStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.chkLowStock.Location = New System.Drawing.Point(308, 13)
        Me.chkLowStock.Name = "chkLowStock"
        Me.chkLowStock.Size = New System.Drawing.Size(97, 17)
        Me.chkLowStock.TabIndex = 7
        Me.chkLowStock.Text = "Low stock only"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvProducts.Location = New System.Drawing.Point(8, 48)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowTemplate.Height = 26
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(454, 906)
        Me.dgvProducts.TabIndex = 8
        '
        'tabSuppliers
        '
        Me.tabSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabSuppliers.Controls.Add(Me.pnlSupRight)
        Me.tabSuppliers.Controls.Add(Me.pnlSupLeft)
        Me.tabSuppliers.Location = New System.Drawing.Point(4, 22)
        Me.tabSuppliers.Name = "tabSuppliers"
        Me.tabSuppliers.Padding = New System.Windows.Forms.Padding(6)
        Me.tabSuppliers.Size = New System.Drawing.Size(1672, 978)
        Me.tabSuppliers.TabIndex = 3
        Me.tabSuppliers.Text = "Suppliers"
        '
        'pnlSupRight
        '
        Me.pnlSupRight.AutoScroll = True
        Me.pnlSupRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlSupRight.Controls.Add(Me.grpSupplier)
        Me.pnlSupRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSupRight.Location = New System.Drawing.Point(476, 6)
        Me.pnlSupRight.Name = "pnlSupRight"
        Me.pnlSupRight.Size = New System.Drawing.Size(1190, 966)
        Me.pnlSupRight.TabIndex = 39
        '
        'grpSupplier
        '
        Me.grpSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSupplier.Controls.Add(Me.lblSupName)
        Me.grpSupplier.Controls.Add(Me.txtSupName)
        Me.grpSupplier.Controls.Add(Me.lblSupStatus)
        Me.grpSupplier.Controls.Add(Me.cboSupStatus)
        Me.grpSupplier.Controls.Add(Me.lblSupContact)
        Me.grpSupplier.Controls.Add(Me.txtSupContact)
        Me.grpSupplier.Controls.Add(Me.lblSupPhone)
        Me.grpSupplier.Controls.Add(Me.txtSupPhone)
        Me.grpSupplier.Controls.Add(Me.lblSupEmail)
        Me.grpSupplier.Controls.Add(Me.txtSupEmail)
        Me.grpSupplier.Controls.Add(Me.lblSupAddress)
        Me.grpSupplier.Controls.Add(Me.txtSupAddress)
        Me.grpSupplier.Controls.Add(Me.btnNewSupplier)
        Me.grpSupplier.Controls.Add(Me.btnSaveSupplier)
        Me.grpSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpSupplier.Location = New System.Drawing.Point(8, 8)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(1490, 360)
        Me.grpSupplier.TabIndex = 43
        Me.grpSupplier.TabStop = False
        Me.grpSupplier.Text = "Supplier"
        '
        'lblSupName
        '
        Me.lblSupName.AutoSize = True
        Me.lblSupName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupName.Location = New System.Drawing.Point(14, 24)
        Me.lblSupName.Name = "lblSupName"
        Me.lblSupName.Size = New System.Drawing.Size(81, 13)
        Me.lblSupName.TabIndex = 44
        Me.lblSupName.Text = "Supplier name *"
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(14, 44)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(225, 20)
        Me.txtSupName.TabIndex = 45
        '
        'lblSupStatus
        '
        Me.lblSupStatus.AutoSize = True
        Me.lblSupStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupStatus.Location = New System.Drawing.Point(254, 24)
        Me.lblSupStatus.Name = "lblSupStatus"
        Me.lblSupStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblSupStatus.TabIndex = 46
        Me.lblSupStatus.Text = "Status"
        '
        'cboSupStatus
        '
        Me.cboSupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupStatus.FormattingEnabled = True
        Me.cboSupStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboSupStatus.Location = New System.Drawing.Point(254, 44)
        Me.cboSupStatus.Name = "cboSupStatus"
        Me.cboSupStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboSupStatus.TabIndex = 47
        '
        'lblSupContact
        '
        Me.lblSupContact.AutoSize = True
        Me.lblSupContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupContact.Location = New System.Drawing.Point(14, 80)
        Me.lblSupContact.Name = "lblSupContact"
        Me.lblSupContact.Size = New System.Drawing.Size(79, 13)
        Me.lblSupContact.TabIndex = 48
        Me.lblSupContact.Text = "Contact person"
        '
        'txtSupContact
        '
        Me.txtSupContact.Location = New System.Drawing.Point(14, 100)
        Me.txtSupContact.Name = "txtSupContact"
        Me.txtSupContact.Size = New System.Drawing.Size(225, 20)
        Me.txtSupContact.TabIndex = 49
        '
        'lblSupPhone
        '
        Me.lblSupPhone.AutoSize = True
        Me.lblSupPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupPhone.Location = New System.Drawing.Point(254, 80)
        Me.lblSupPhone.Name = "lblSupPhone"
        Me.lblSupPhone.Size = New System.Drawing.Size(82, 13)
        Me.lblSupPhone.TabIndex = 50
        Me.lblSupPhone.Text = "Contact number"
        '
        'txtSupPhone
        '
        Me.txtSupPhone.Location = New System.Drawing.Point(254, 100)
        Me.txtSupPhone.Name = "txtSupPhone"
        Me.txtSupPhone.Size = New System.Drawing.Size(225, 20)
        Me.txtSupPhone.TabIndex = 51
        '
        'lblSupEmail
        '
        Me.lblSupEmail.AutoSize = True
        Me.lblSupEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupEmail.Location = New System.Drawing.Point(14, 136)
        Me.lblSupEmail.Name = "lblSupEmail"
        Me.lblSupEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblSupEmail.TabIndex = 52
        Me.lblSupEmail.Text = "Email"
        '
        'txtSupEmail
        '
        Me.txtSupEmail.Location = New System.Drawing.Point(14, 156)
        Me.txtSupEmail.Name = "txtSupEmail"
        Me.txtSupEmail.Size = New System.Drawing.Size(465, 20)
        Me.txtSupEmail.TabIndex = 53
        '
        'lblSupAddress
        '
        Me.lblSupAddress.AutoSize = True
        Me.lblSupAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSupAddress.Location = New System.Drawing.Point(14, 192)
        Me.lblSupAddress.Name = "lblSupAddress"
        Me.lblSupAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblSupAddress.TabIndex = 54
        Me.lblSupAddress.Text = "Address"
        '
        'txtSupAddress
        '
        Me.txtSupAddress.Location = New System.Drawing.Point(14, 212)
        Me.txtSupAddress.Multiline = True
        Me.txtSupAddress.Name = "txtSupAddress"
        Me.txtSupAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSupAddress.Size = New System.Drawing.Size(465, 70)
        Me.txtSupAddress.TabIndex = 55
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewSupplier.FlatAppearance.BorderSize = 0
        Me.btnNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewSupplier.Location = New System.Drawing.Point(14, 300)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(130, 32)
        Me.btnNewSupplier.TabIndex = 56
        Me.btnNewSupplier.Text = "New Supplier"
        Me.btnNewSupplier.UseVisualStyleBackColor = False
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSaveSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSupplier.FlatAppearance.BorderSize = 0
        Me.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSaveSupplier.Location = New System.Drawing.Point(152, 300)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveSupplier.TabIndex = 57
        Me.btnSaveSupplier.Text = "Save Supplier"
        Me.btnSaveSupplier.UseVisualStyleBackColor = False
        '
        'pnlSupLeft
        '
        Me.pnlSupLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlSupLeft.Controls.Add(Me.dgvSuppliers)
        Me.pnlSupLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSupLeft.Location = New System.Drawing.Point(6, 6)
        Me.pnlSupLeft.Name = "pnlSupLeft"
        Me.pnlSupLeft.Size = New System.Drawing.Size(470, 966)
        Me.pnlSupLeft.TabIndex = 40
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AllowUserToResizeRows = False
        Me.dgvSuppliers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSuppliers.BackgroundColor = System.Drawing.Color.White
        Me.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvSuppliers.Location = New System.Drawing.Point(8, 48)
        Me.dgvSuppliers.MultiSelect = False
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.RowTemplate.Height = 26
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.Size = New System.Drawing.Size(454, 906)
        Me.dgvSuppliers.TabIndex = 42
        '
        'pnlAppointment
        '
        Me.pnlAppointment.Controls.Add(Me.pnlApptRight)
        Me.pnlAppointment.Controls.Add(Me.pnlApptLeft)
        Me.pnlAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAppointment.Location = New System.Drawing.Point(220, 56)
        Me.pnlAppointment.Name = "pnlAppointment"
        Me.pnlAppointment.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlAppointment.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlAppointment.TabIndex = 23
        '
        'pnlApptRight
        '
        Me.pnlApptRight.AutoScroll = True
        Me.pnlApptRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlApptRight.Controls.Add(Me.grpAppointment)
        Me.pnlApptRight.Controls.Add(Me.btnNewAppt)
        Me.pnlApptRight.Controls.Add(Me.btnSaveAppt)
        Me.pnlApptRight.Controls.Add(Me.btnCancelAppt)
        Me.pnlApptRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlApptRight.Location = New System.Drawing.Point(610, 10)
        Me.pnlApptRight.Name = "pnlApptRight"
        Me.pnlApptRight.Size = New System.Drawing.Size(1080, 1004)
        Me.pnlApptRight.TabIndex = 3
        '
        'grpAppointment
        '
        Me.grpAppointment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAppointment.Controls.Add(Me.lblApptCode)
        Me.grpAppointment.Controls.Add(Me.txtApptCode)
        Me.grpAppointment.Controls.Add(Me.lblApptStatus)
        Me.grpAppointment.Controls.Add(Me.cboApptStatus)
        Me.grpAppointment.Controls.Add(Me.lblApptPatient)
        Me.grpAppointment.Controls.Add(Me.cboApptPatient)
        Me.grpAppointment.Controls.Add(Me.lblDentist)
        Me.grpAppointment.Controls.Add(Me.cboDentist)
        Me.grpAppointment.Controls.Add(Me.lblDate)
        Me.grpAppointment.Controls.Add(Me.dtpDate)
        Me.grpAppointment.Controls.Add(Me.lblType)
        Me.grpAppointment.Controls.Add(Me.cboType)
        Me.grpAppointment.Controls.Add(Me.lblStart)
        Me.grpAppointment.Controls.Add(Me.dtpStart)
        Me.grpAppointment.Controls.Add(Me.lblEnd)
        Me.grpAppointment.Controls.Add(Me.dtpEnd)
        Me.grpAppointment.Controls.Add(Me.lblReason)
        Me.grpAppointment.Controls.Add(Me.txtReason)
        Me.grpAppointment.Controls.Add(Me.lblNotes)
        Me.grpAppointment.Controls.Add(Me.txtNotes)
        Me.grpAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpAppointment.Location = New System.Drawing.Point(8, 8)
        Me.grpAppointment.Name = "grpAppointment"
        Me.grpAppointment.Size = New System.Drawing.Size(1454, 420)
        Me.grpAppointment.TabIndex = 9
        Me.grpAppointment.TabStop = False
        Me.grpAppointment.Text = "Appointment details"
        '
        'lblApptCode
        '
        Me.lblApptCode.AutoSize = True
        Me.lblApptCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblApptCode.Location = New System.Drawing.Point(14, 24)
        Me.lblApptCode.Name = "lblApptCode"
        Me.lblApptCode.Size = New System.Drawing.Size(93, 13)
        Me.lblApptCode.TabIndex = 10
        Me.lblApptCode.Text = "Appointment code"
        '
        'txtApptCode
        '
        Me.txtApptCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtApptCode.Location = New System.Drawing.Point(14, 44)
        Me.txtApptCode.Name = "txtApptCode"
        Me.txtApptCode.ReadOnly = True
        Me.txtApptCode.Size = New System.Drawing.Size(225, 20)
        Me.txtApptCode.TabIndex = 11
        '
        'lblApptStatus
        '
        Me.lblApptStatus.AutoSize = True
        Me.lblApptStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblApptStatus.Location = New System.Drawing.Point(254, 24)
        Me.lblApptStatus.Name = "lblApptStatus"
        Me.lblApptStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblApptStatus.TabIndex = 12
        Me.lblApptStatus.Text = "Status"
        '
        'cboApptStatus
        '
        Me.cboApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApptStatus.FormattingEnabled = True
        Me.cboApptStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled", "No-show"})
        Me.cboApptStatus.Location = New System.Drawing.Point(254, 44)
        Me.cboApptStatus.Name = "cboApptStatus"
        Me.cboApptStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboApptStatus.TabIndex = 13
        '
        'lblApptPatient
        '
        Me.lblApptPatient.AutoSize = True
        Me.lblApptPatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblApptPatient.Location = New System.Drawing.Point(14, 80)
        Me.lblApptPatient.Name = "lblApptPatient"
        Me.lblApptPatient.Size = New System.Drawing.Size(47, 13)
        Me.lblApptPatient.TabIndex = 14
        Me.lblApptPatient.Text = "Patient *"
        '
        'cboApptPatient
        '
        Me.cboApptPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApptPatient.FormattingEnabled = True
        Me.cboApptPatient.Location = New System.Drawing.Point(14, 100)
        Me.cboApptPatient.Name = "cboApptPatient"
        Me.cboApptPatient.Size = New System.Drawing.Size(225, 21)
        Me.cboApptPatient.TabIndex = 15
        '
        'lblDentist
        '
        Me.lblDentist.AutoSize = True
        Me.lblDentist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDentist.Location = New System.Drawing.Point(254, 80)
        Me.lblDentist.Name = "lblDentist"
        Me.lblDentist.Size = New System.Drawing.Size(47, 13)
        Me.lblDentist.TabIndex = 16
        Me.lblDentist.Text = "Dentist *"
        '
        'cboDentist
        '
        Me.cboDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDentist.FormattingEnabled = True
        Me.cboDentist.Location = New System.Drawing.Point(254, 100)
        Me.cboDentist.Name = "cboDentist"
        Me.cboDentist.Size = New System.Drawing.Size(225, 21)
        Me.cboDentist.TabIndex = 17
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(14, 136)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 13)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Date *"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(14, 156)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(225, 20)
        Me.dtpDate.TabIndex = 19
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblType.Location = New System.Drawing.Point(254, 136)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(96, 13)
        Me.lblType.TabIndex = 20
        Me.lblType.Text = "Appointment type *"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(254, 156)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(225, 21)
        Me.cboType.TabIndex = 21
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStart.Location = New System.Drawing.Point(14, 192)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(58, 13)
        Me.lblStart.TabIndex = 22
        Me.lblStart.Text = "Start time *"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "hh:mm tt"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(14, 212)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(225, 20)
        Me.dtpStart.TabIndex = 23
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblEnd.Location = New System.Drawing.Point(254, 192)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(48, 13)
        Me.lblEnd.TabIndex = 24
        Me.lblEnd.Text = "End time"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "hh:mm tt"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(254, 212)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowCheckBox = True
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(225, 20)
        Me.dtpEnd.TabIndex = 25
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblReason.Location = New System.Drawing.Point(14, 248)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(44, 13)
        Me.lblReason.TabIndex = 26
        Me.lblReason.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(14, 268)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(465, 20)
        Me.txtReason.TabIndex = 27
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblNotes.Location = New System.Drawing.Point(14, 304)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 28
        Me.lblNotes.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(14, 324)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(465, 90)
        Me.txtNotes.TabIndex = 29
        '
        'btnNewAppt
        '
        Me.btnNewAppt.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewAppt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewAppt.FlatAppearance.BorderSize = 0
        Me.btnNewAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewAppt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewAppt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewAppt.Location = New System.Drawing.Point(8, 440)
        Me.btnNewAppt.Name = "btnNewAppt"
        Me.btnNewAppt.Size = New System.Drawing.Size(150, 36)
        Me.btnNewAppt.TabIndex = 30
        Me.btnNewAppt.Text = "New Appointment"
        Me.btnNewAppt.UseVisualStyleBackColor = False
        '
        'btnSaveAppt
        '
        Me.btnSaveAppt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveAppt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveAppt.FlatAppearance.BorderSize = 0
        Me.btnSaveAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAppt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveAppt.ForeColor = System.Drawing.Color.White
        Me.btnSaveAppt.Location = New System.Drawing.Point(166, 440)
        Me.btnSaveAppt.Name = "btnSaveAppt"
        Me.btnSaveAppt.Size = New System.Drawing.Size(130, 36)
        Me.btnSaveAppt.TabIndex = 31
        Me.btnSaveAppt.Text = "Save"
        Me.btnSaveAppt.UseVisualStyleBackColor = False
        '
        'btnCancelAppt
        '
        Me.btnCancelAppt.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnCancelAppt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelAppt.FlatAppearance.BorderSize = 0
        Me.btnCancelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelAppt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelAppt.ForeColor = System.Drawing.Color.White
        Me.btnCancelAppt.Location = New System.Drawing.Point(304, 440)
        Me.btnCancelAppt.Name = "btnCancelAppt"
        Me.btnCancelAppt.Size = New System.Drawing.Size(170, 36)
        Me.btnCancelAppt.TabIndex = 32
        Me.btnCancelAppt.Text = "Cancel Appointment"
        Me.btnCancelAppt.UseVisualStyleBackColor = False
        '
        'pnlApptLeft
        '
        Me.pnlApptLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlApptLeft.Controls.Add(Me.dtpFilterDate)
        Me.pnlApptLeft.Controls.Add(Me.chkAllDates)
        Me.pnlApptLeft.Controls.Add(Me.cboFilterStatus)
        Me.pnlApptLeft.Controls.Add(Me.btnToday)
        Me.pnlApptLeft.Controls.Add(Me.dgvAppointments)
        Me.pnlApptLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlApptLeft.Location = New System.Drawing.Point(10, 10)
        Me.pnlApptLeft.Name = "pnlApptLeft"
        Me.pnlApptLeft.Size = New System.Drawing.Size(600, 1004)
        Me.pnlApptLeft.TabIndex = 4
        '
        'dtpFilterDate
        '
        Me.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFilterDate.Location = New System.Drawing.Point(8, 10)
        Me.dtpFilterDate.Name = "dtpFilterDate"
        Me.dtpFilterDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpFilterDate.TabIndex = 3
        '
        'chkAllDates
        '
        Me.chkAllDates.AutoSize = True
        Me.chkAllDates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.chkAllDates.Location = New System.Drawing.Point(148, 13)
        Me.chkAllDates.Name = "chkAllDates"
        Me.chkAllDates.Size = New System.Drawing.Size(66, 17)
        Me.chkAllDates.TabIndex = 4
        Me.chkAllDates.Text = "All dates"
        '
        'cboFilterStatus
        '
        Me.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterStatus.FormattingEnabled = True
        Me.cboFilterStatus.Items.AddRange(New Object() {"All statuses", "Pending", "Confirmed", "Completed", "Cancelled", "No-show"})
        Me.cboFilterStatus.Location = New System.Drawing.Point(244, 10)
        Me.cboFilterStatus.Name = "cboFilterStatus"
        Me.cboFilterStatus.Size = New System.Drawing.Size(150, 21)
        Me.cboFilterStatus.TabIndex = 5
        '
        'btnToday
        '
        Me.btnToday.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnToday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToday.FlatAppearance.BorderSize = 0
        Me.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToday.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnToday.Location = New System.Drawing.Point(404, 9)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(80, 29)
        Me.btnToday.TabIndex = 6
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'dgvAppointments
        '
        Me.dgvAppointments.AllowUserToAddRows = False
        Me.dgvAppointments.AllowUserToDeleteRows = False
        Me.dgvAppointments.AllowUserToResizeRows = False
        Me.dgvAppointments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvAppointments.Location = New System.Drawing.Point(8, 84)
        Me.dgvAppointments.MultiSelect = False
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.ReadOnly = True
        Me.dgvAppointments.RowHeadersVisible = False
        Me.dgvAppointments.RowTemplate.Height = 26
        Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointments.Size = New System.Drawing.Size(584, 912)
        Me.dgvAppointments.TabIndex = 8
        '
        'pnlPatients
        '
        Me.pnlPatients.Controls.Add(Me.pnlRight)
        Me.pnlPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatients.Location = New System.Drawing.Point(220, 56)
        Me.pnlPatients.Name = "pnlPatients"
        Me.pnlPatients.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlPatients.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlPatients.TabIndex = 24
        '
        'pnlRight
        '
        Me.pnlRight.AutoScroll = True
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlRight.Controls.Add(Me.pnlLeft)
        Me.pnlRight.Controls.Add(Me.grpDetails)
        Me.pnlRight.Controls.Add(Me.btnNew)
        Me.pnlRight.Controls.Add(Me.btnSave)
        Me.pnlRight.Controls.Add(Me.btnArchive)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(10, 10)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(1680, 1004)
        Me.pnlRight.TabIndex = 3
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.btnClear)
        Me.pnlLeft.Controls.Add(Me.dgvPatients)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(470, 1004)
        Me.pnlLeft.TabIndex = 36
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(368, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 29)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.AllowUserToResizeRows = False
        Me.dgvPatients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatients.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatients.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvPatients.Location = New System.Drawing.Point(8, 48)
        Me.dgvPatients.MultiSelect = False
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.ReadOnly = True
        Me.dgvPatients.RowHeadersVisible = False
        Me.dgvPatients.RowTemplate.Height = 26
        Me.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatients.Size = New System.Drawing.Size(454, 948)
        Me.dgvPatients.TabIndex = 5
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.lblCode)
        Me.grpDetails.Controls.Add(Me.txtCode)
        Me.grpDetails.Controls.Add(Me.lblStatus)
        Me.grpDetails.Controls.Add(Me.cboStatus)
        Me.grpDetails.Controls.Add(Me.lblFirstName)
        Me.grpDetails.Controls.Add(Me.txtFirstName)
        Me.grpDetails.Controls.Add(Me.lblMiddleName)
        Me.grpDetails.Controls.Add(Me.txtMiddleName)
        Me.grpDetails.Controls.Add(Me.lblLastName)
        Me.grpDetails.Controls.Add(Me.txtLastName)
        Me.grpDetails.Controls.Add(Me.lblBirth)
        Me.grpDetails.Controls.Add(Me.dtpBirth)
        Me.grpDetails.Controls.Add(Me.lblGender)
        Me.grpDetails.Controls.Add(Me.cboGender)
        Me.grpDetails.Controls.Add(Me.lblContact)
        Me.grpDetails.Controls.Add(Me.txtContact)
        Me.grpDetails.Controls.Add(Me.lblEmail)
        Me.grpDetails.Controls.Add(Me.txtEmail)
        Me.grpDetails.Controls.Add(Me.lblRegistered)
        Me.grpDetails.Controls.Add(Me.txtRegistered)
        Me.grpDetails.Controls.Add(Me.lblAddress)
        Me.grpDetails.Controls.Add(Me.txtAddress)
        Me.grpDetails.Controls.Add(Me.lblEmergName)
        Me.grpDetails.Controls.Add(Me.txtEmergName)
        Me.grpDetails.Controls.Add(Me.lblEmergNum)
        Me.grpDetails.Controls.Add(Me.txtEmergNum)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpDetails.Location = New System.Drawing.Point(476, 9)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(1980, 430)
        Me.grpDetails.TabIndex = 6
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Patient details"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCode.Location = New System.Drawing.Point(14, 24)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(67, 13)
        Me.lblCode.TabIndex = 7
        Me.lblCode.Text = "Patient code"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(14, 44)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(225, 20)
        Me.txtCode.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(254, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive", "Archived"})
        Me.cboStatus.Location = New System.Drawing.Point(254, 44)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboStatus.TabIndex = 10
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(14, 80)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(62, 13)
        Me.lblFirstName.TabIndex = 11
        Me.lblFirstName.Text = "First name *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(14, 100)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(225, 20)
        Me.txtFirstName.TabIndex = 12
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(254, 80)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(67, 13)
        Me.lblMiddleName.TabIndex = 13
        Me.lblMiddleName.Text = "Middle name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(254, 100)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(225, 20)
        Me.txtMiddleName.TabIndex = 14
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(14, 136)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(63, 13)
        Me.lblLastName.TabIndex = 15
        Me.lblLastName.Text = "Last name *"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(14, 156)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(225, 20)
        Me.txtLastName.TabIndex = 16
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblBirth.Location = New System.Drawing.Point(254, 136)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(52, 13)
        Me.lblBirth.TabIndex = 17
        Me.lblBirth.Text = "Birth date"
        '
        'dtpBirth
        '
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirth.Location = New System.Drawing.Point(254, 156)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.ShowCheckBox = True
        Me.dtpBirth.Size = New System.Drawing.Size(225, 20)
        Me.dtpBirth.TabIndex = 18
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(14, 192)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 19
        Me.lblGender.Text = "Gender"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female", "Other", "Prefer not to say"})
        Me.cboGender.Location = New System.Drawing.Point(14, 212)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(225, 21)
        Me.cboGender.TabIndex = 20
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(254, 192)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(82, 13)
        Me.lblContact.TabIndex = 21
        Me.lblContact.Text = "Contact number"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(254, 212)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(225, 20)
        Me.txtContact.TabIndex = 22
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(14, 248)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(14, 268)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 24
        '
        'lblRegistered
        '
        Me.lblRegistered.AutoSize = True
        Me.lblRegistered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblRegistered.Location = New System.Drawing.Point(254, 248)
        Me.lblRegistered.Name = "lblRegistered"
        Me.lblRegistered.Size = New System.Drawing.Size(73, 13)
        Me.lblRegistered.TabIndex = 25
        Me.lblRegistered.Text = "Registered on"
        '
        'txtRegistered
        '
        Me.txtRegistered.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtRegistered.Location = New System.Drawing.Point(254, 268)
        Me.txtRegistered.Name = "txtRegistered"
        Me.txtRegistered.ReadOnly = True
        Me.txtRegistered.Size = New System.Drawing.Size(225, 20)
        Me.txtRegistered.TabIndex = 26
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(14, 304)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(14, 324)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(465, 20)
        Me.txtAddress.TabIndex = 28
        '
        'lblEmergName
        '
        Me.lblEmergName.AutoSize = True
        Me.lblEmergName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblEmergName.Location = New System.Drawing.Point(14, 360)
        Me.lblEmergName.Name = "lblEmergName"
        Me.lblEmergName.Size = New System.Drawing.Size(128, 13)
        Me.lblEmergName.TabIndex = 29
        Me.lblEmergName.Text = "Emergency contact name"
        '
        'txtEmergName
        '
        Me.txtEmergName.Location = New System.Drawing.Point(14, 380)
        Me.txtEmergName.Name = "txtEmergName"
        Me.txtEmergName.Size = New System.Drawing.Size(225, 20)
        Me.txtEmergName.TabIndex = 30
        '
        'lblEmergNum
        '
        Me.lblEmergNum.AutoSize = True
        Me.lblEmergNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblEmergNum.Location = New System.Drawing.Point(254, 360)
        Me.lblEmergNum.Name = "lblEmergNum"
        Me.lblEmergNum.Size = New System.Drawing.Size(137, 13)
        Me.lblEmergNum.TabIndex = 31
        Me.lblEmergNum.Text = "Emergency contact number"
        '
        'txtEmergNum
        '
        Me.txtEmergNum.Location = New System.Drawing.Point(254, 380)
        Me.txtEmergNum.Name = "txtEmergNum"
        Me.txtEmergNum.Size = New System.Drawing.Size(225, 20)
        Me.txtEmergNum.TabIndex = 32
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNew.Location = New System.Drawing.Point(480, 449)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(130, 36)
        Me.btnNew.TabIndex = 33
        Me.btnNew.Text = "New Patient"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(618, 449)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 36)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchive.FlatAppearance.BorderSize = 0
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnArchive.ForeColor = System.Drawing.Color.White
        Me.btnArchive.Location = New System.Drawing.Point(756, 449)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(130, 36)
        Me.btnArchive.TabIndex = 35
        Me.btnArchive.Text = "Archive"
        Me.btnArchive.UseVisualStyleBackColor = False
        '
        'pnlClinicalRecord
        '
        Me.pnlClinicalRecord.Controls.Add(Me.pnlTop)
        Me.pnlClinicalRecord.Controls.Add(Me.tabMain)
        Me.pnlClinicalRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlClinicalRecord.Location = New System.Drawing.Point(220, 56)
        Me.pnlClinicalRecord.Name = "pnlClinicalRecord"
        Me.pnlClinicalRecord.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlClinicalRecord.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlClinicalRecord.TabIndex = 25
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblPatient)
        Me.pnlTop.Controls.Add(Me.cboPatient)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(10, 10)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1680, 52)
        Me.pnlTop.TabIndex = 4
        '
        'lblPatient
        '
        Me.lblPatient.AutoSize = True
        Me.lblPatient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPatient.Location = New System.Drawing.Point(12, 18)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(47, 15)
        Me.lblPatient.TabIndex = 3
        Me.lblPatient.Text = "Patient"
        '
        'cboPatient
        '
        Me.cboPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPatient.FormattingEnabled = True
        Me.cboPatient.Location = New System.Drawing.Point(72, 13)
        Me.cboPatient.Name = "cboPatient"
        Me.cboPatient.Size = New System.Drawing.Size(420, 21)
        Me.cboPatient.TabIndex = 4
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabMedical)
        Me.tabMain.Controls.Add(Me.tabVisits)
        Me.tabMain.Controls.Add(Me.tabChart)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(10, 10)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1680, 1004)
        Me.tabMain.TabIndex = 3
        '
        'tabMedical
        '
        Me.tabMedical.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabMedical.Controls.Add(Me.lblAllergies)
        Me.tabMedical.Controls.Add(Me.txtAllergies)
        Me.tabMedical.Controls.Add(Me.lblMedications)
        Me.tabMedical.Controls.Add(Me.txtMedications)
        Me.tabMedical.Controls.Add(Me.lblConditions)
        Me.tabMedical.Controls.Add(Me.txtConditions)
        Me.tabMedical.Controls.Add(Me.lblSurgeries)
        Me.tabMedical.Controls.Add(Me.txtSurgeries)
        Me.tabMedical.Controls.Add(Me.lblFamilyHistory)
        Me.tabMedical.Controls.Add(Me.txtFamilyHistory)
        Me.tabMedical.Controls.Add(Me.lblOtherNotes)
        Me.tabMedical.Controls.Add(Me.txtOtherNotes)
        Me.tabMedical.Controls.Add(Me.btnSaveMedical)
        Me.tabMedical.Controls.Add(Me.lblMedicalUpdated)
        Me.tabMedical.Location = New System.Drawing.Point(4, 22)
        Me.tabMedical.Name = "tabMedical"
        Me.tabMedical.Padding = New System.Windows.Forms.Padding(6)
        Me.tabMedical.Size = New System.Drawing.Size(1672, 978)
        Me.tabMedical.TabIndex = 5
        Me.tabMedical.Text = "Medical History"
        '
        'lblAllergies
        '
        Me.lblAllergies.AutoSize = True
        Me.lblAllergies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblAllergies.Location = New System.Drawing.Point(12, 10)
        Me.lblAllergies.Name = "lblAllergies"
        Me.lblAllergies.Size = New System.Drawing.Size(46, 13)
        Me.lblAllergies.TabIndex = 8
        Me.lblAllergies.Text = "Allergies"
        '
        'txtAllergies
        '
        Me.txtAllergies.Location = New System.Drawing.Point(12, 30)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllergies.Size = New System.Drawing.Size(450, 100)
        Me.txtAllergies.TabIndex = 9
        '
        'lblMedications
        '
        Me.lblMedications.AutoSize = True
        Me.lblMedications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblMedications.Location = New System.Drawing.Point(480, 10)
        Me.lblMedications.Name = "lblMedications"
        Me.lblMedications.Size = New System.Drawing.Size(100, 13)
        Me.lblMedications.TabIndex = 10
        Me.lblMedications.Text = "Current medications"
        '
        'txtMedications
        '
        Me.txtMedications.Location = New System.Drawing.Point(480, 30)
        Me.txtMedications.Multiline = True
        Me.txtMedications.Name = "txtMedications"
        Me.txtMedications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMedications.Size = New System.Drawing.Size(450, 100)
        Me.txtMedications.TabIndex = 11
        '
        'lblConditions
        '
        Me.lblConditions.AutoSize = True
        Me.lblConditions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblConditions.Location = New System.Drawing.Point(12, 130)
        Me.lblConditions.Name = "lblConditions"
        Me.lblConditions.Size = New System.Drawing.Size(95, 13)
        Me.lblConditions.TabIndex = 12
        Me.lblConditions.Text = "Medical conditions"
        '
        'txtConditions
        '
        Me.txtConditions.Location = New System.Drawing.Point(12, 150)
        Me.txtConditions.Multiline = True
        Me.txtConditions.Name = "txtConditions"
        Me.txtConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConditions.Size = New System.Drawing.Size(450, 100)
        Me.txtConditions.TabIndex = 13
        '
        'lblSurgeries
        '
        Me.lblSurgeries.AutoSize = True
        Me.lblSurgeries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSurgeries.Location = New System.Drawing.Point(480, 130)
        Me.lblSurgeries.Name = "lblSurgeries"
        Me.lblSurgeries.Size = New System.Drawing.Size(93, 13)
        Me.lblSurgeries.TabIndex = 14
        Me.lblSurgeries.Text = "Previous surgeries"
        '
        'txtSurgeries
        '
        Me.txtSurgeries.Location = New System.Drawing.Point(480, 150)
        Me.txtSurgeries.Multiline = True
        Me.txtSurgeries.Name = "txtSurgeries"
        Me.txtSurgeries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSurgeries.Size = New System.Drawing.Size(450, 100)
        Me.txtSurgeries.TabIndex = 15
        '
        'lblFamilyHistory
        '
        Me.lblFamilyHistory.AutoSize = True
        Me.lblFamilyHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblFamilyHistory.Location = New System.Drawing.Point(12, 250)
        Me.lblFamilyHistory.Name = "lblFamilyHistory"
        Me.lblFamilyHistory.Size = New System.Drawing.Size(108, 13)
        Me.lblFamilyHistory.TabIndex = 16
        Me.lblFamilyHistory.Text = "Family medical history"
        '
        'txtFamilyHistory
        '
        Me.txtFamilyHistory.Location = New System.Drawing.Point(12, 270)
        Me.txtFamilyHistory.Multiline = True
        Me.txtFamilyHistory.Name = "txtFamilyHistory"
        Me.txtFamilyHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFamilyHistory.Size = New System.Drawing.Size(450, 100)
        Me.txtFamilyHistory.TabIndex = 17
        '
        'lblOtherNotes
        '
        Me.lblOtherNotes.AutoSize = True
        Me.lblOtherNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblOtherNotes.Location = New System.Drawing.Point(480, 250)
        Me.lblOtherNotes.Name = "lblOtherNotes"
        Me.lblOtherNotes.Size = New System.Drawing.Size(62, 13)
        Me.lblOtherNotes.TabIndex = 18
        Me.lblOtherNotes.Text = "Other notes"
        '
        'txtOtherNotes
        '
        Me.txtOtherNotes.Location = New System.Drawing.Point(480, 270)
        Me.txtOtherNotes.Multiline = True
        Me.txtOtherNotes.Name = "txtOtherNotes"
        Me.txtOtherNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtherNotes.Size = New System.Drawing.Size(450, 100)
        Me.txtOtherNotes.TabIndex = 19
        '
        'btnSaveMedical
        '
        Me.btnSaveMedical.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveMedical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveMedical.FlatAppearance.BorderSize = 0
        Me.btnSaveMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMedical.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveMedical.ForeColor = System.Drawing.Color.White
        Me.btnSaveMedical.Location = New System.Drawing.Point(12, 376)
        Me.btnSaveMedical.Name = "btnSaveMedical"
        Me.btnSaveMedical.Size = New System.Drawing.Size(190, 36)
        Me.btnSaveMedical.TabIndex = 20
        Me.btnSaveMedical.Text = "Save Medical History"
        Me.btnSaveMedical.UseVisualStyleBackColor = False
        '
        'lblMedicalUpdated
        '
        Me.lblMedicalUpdated.AutoSize = True
        Me.lblMedicalUpdated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblMedicalUpdated.Location = New System.Drawing.Point(214, 386)
        Me.lblMedicalUpdated.Name = "lblMedicalUpdated"
        Me.lblMedicalUpdated.Size = New System.Drawing.Size(0, 13)
        Me.lblMedicalUpdated.TabIndex = 21
        '
        'tabVisits
        '
        Me.tabVisits.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabVisits.Controls.Add(Me.dgvVisits)
        Me.tabVisits.Controls.Add(Me.grpVisit)
        Me.tabVisits.Controls.Add(Me.grpTreat)
        Me.tabVisits.Location = New System.Drawing.Point(4, 22)
        Me.tabVisits.Name = "tabVisits"
        Me.tabVisits.Padding = New System.Windows.Forms.Padding(6)
        Me.tabVisits.Size = New System.Drawing.Size(1672, 978)
        Me.tabVisits.TabIndex = 6
        Me.tabVisits.Text = "Visit Records && Treatments"
        '
        'dgvVisits
        '
        Me.dgvVisits.AllowUserToAddRows = False
        Me.dgvVisits.AllowUserToDeleteRows = False
        Me.dgvVisits.AllowUserToResizeRows = False
        Me.dgvVisits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVisits.BackgroundColor = System.Drawing.Color.White
        Me.dgvVisits.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvVisits.Location = New System.Drawing.Point(8, 8)
        Me.dgvVisits.MultiSelect = False
        Me.dgvVisits.Name = "dgvVisits"
        Me.dgvVisits.ReadOnly = True
        Me.dgvVisits.RowHeadersVisible = False
        Me.dgvVisits.RowTemplate.Height = 26
        Me.dgvVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVisits.Size = New System.Drawing.Size(350, 1424)
        Me.dgvVisits.TabIndex = 22
        '
        'grpVisit
        '
        Me.grpVisit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVisit.Controls.Add(Me.lblVisit)
        Me.grpVisit.Controls.Add(Me.dtpVisit)
        Me.grpVisit.Controls.Add(Me.lblVisitDentist)
        Me.grpVisit.Controls.Add(Me.cboVisitDentist)
        Me.grpVisit.Controls.Add(Me.lblNextVisit)
        Me.grpVisit.Controls.Add(Me.dtpNextVisit)
        Me.grpVisit.Controls.Add(Me.lblComplaint)
        Me.grpVisit.Controls.Add(Me.txtComplaint)
        Me.grpVisit.Controls.Add(Me.lblDiagnosis)
        Me.grpVisit.Controls.Add(Me.txtDiagnosis)
        Me.grpVisit.Controls.Add(Me.lblClinicalNotes)
        Me.grpVisit.Controls.Add(Me.txtClinicalNotes)
        Me.grpVisit.Controls.Add(Me.lblRecommendations)
        Me.grpVisit.Controls.Add(Me.txtRecommendations)
        Me.grpVisit.Controls.Add(Me.btnNewVisit)
        Me.grpVisit.Controls.Add(Me.btnSaveVisit)
        Me.grpVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpVisit.Location = New System.Drawing.Point(366, 8)
        Me.grpVisit.Name = "grpVisit"
        Me.grpVisit.Size = New System.Drawing.Size(2088, 270)
        Me.grpVisit.TabIndex = 23
        Me.grpVisit.TabStop = False
        Me.grpVisit.Text = "Visit record"
        '
        'lblVisit
        '
        Me.lblVisit.AutoSize = True
        Me.lblVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblVisit.Location = New System.Drawing.Point(14, 22)
        Me.lblVisit.Name = "lblVisit"
        Me.lblVisit.Size = New System.Drawing.Size(75, 13)
        Me.lblVisit.TabIndex = 24
        Me.lblVisit.Text = "Visit date & time"
        '
        'dtpVisit
        '
        Me.dtpVisit.CustomFormat = "yyyy-MM-dd  hh:mm tt"
        Me.dtpVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisit.Location = New System.Drawing.Point(14, 42)
        Me.dtpVisit.Name = "dtpVisit"
        Me.dtpVisit.Size = New System.Drawing.Size(190, 20)
        Me.dtpVisit.TabIndex = 25
        '
        'lblVisitDentist
        '
        Me.lblVisitDentist.AutoSize = True
        Me.lblVisitDentist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblVisitDentist.Location = New System.Drawing.Point(214, 22)
        Me.lblVisitDentist.Name = "lblVisitDentist"
        Me.lblVisitDentist.Size = New System.Drawing.Size(47, 13)
        Me.lblVisitDentist.TabIndex = 26
        Me.lblVisitDentist.Text = "Dentist *"
        '
        'cboVisitDentist
        '
        Me.cboVisitDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVisitDentist.FormattingEnabled = True
        Me.cboVisitDentist.Location = New System.Drawing.Point(214, 42)
        Me.cboVisitDentist.Name = "cboVisitDentist"
        Me.cboVisitDentist.Size = New System.Drawing.Size(200, 21)
        Me.cboVisitDentist.TabIndex = 27
        '
        'lblNextVisit
        '
        Me.lblNextVisit.AutoSize = True
        Me.lblNextVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblNextVisit.Location = New System.Drawing.Point(424, 22)
        Me.lblNextVisit.Name = "lblNextVisit"
        Me.lblNextVisit.Size = New System.Drawing.Size(50, 13)
        Me.lblNextVisit.TabIndex = 28
        Me.lblNextVisit.Text = "Next visit"
        '
        'dtpNextVisit
        '
        Me.dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextVisit.Location = New System.Drawing.Point(424, 42)
        Me.dtpNextVisit.Name = "dtpNextVisit"
        Me.dtpNextVisit.ShowCheckBox = True
        Me.dtpNextVisit.Size = New System.Drawing.Size(170, 20)
        Me.dtpNextVisit.TabIndex = 29
        '
        'lblComplaint
        '
        Me.lblComplaint.AutoSize = True
        Me.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblComplaint.Location = New System.Drawing.Point(14, 76)
        Me.lblComplaint.Name = "lblComplaint"
        Me.lblComplaint.Size = New System.Drawing.Size(79, 13)
        Me.lblComplaint.TabIndex = 30
        Me.lblComplaint.Text = "Chief complaint"
        '
        'txtComplaint
        '
        Me.txtComplaint.Location = New System.Drawing.Point(14, 96)
        Me.txtComplaint.Multiline = True
        Me.txtComplaint.Name = "txtComplaint"
        Me.txtComplaint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComplaint.Size = New System.Drawing.Size(284, 52)
        Me.txtComplaint.TabIndex = 31
        '
        'lblDiagnosis
        '
        Me.lblDiagnosis.AutoSize = True
        Me.lblDiagnosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDiagnosis.Location = New System.Drawing.Point(306, 76)
        Me.lblDiagnosis.Name = "lblDiagnosis"
        Me.lblDiagnosis.Size = New System.Drawing.Size(53, 13)
        Me.lblDiagnosis.TabIndex = 32
        Me.lblDiagnosis.Text = "Diagnosis"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Location = New System.Drawing.Point(306, 96)
        Me.txtDiagnosis.Multiline = True
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiagnosis.Size = New System.Drawing.Size(288, 52)
        Me.txtDiagnosis.TabIndex = 33
        '
        'lblClinicalNotes
        '
        Me.lblClinicalNotes.AutoSize = True
        Me.lblClinicalNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblClinicalNotes.Location = New System.Drawing.Point(14, 150)
        Me.lblClinicalNotes.Name = "lblClinicalNotes"
        Me.lblClinicalNotes.Size = New System.Drawing.Size(69, 13)
        Me.lblClinicalNotes.TabIndex = 34
        Me.lblClinicalNotes.Text = "Clinical notes"
        '
        'txtClinicalNotes
        '
        Me.txtClinicalNotes.Location = New System.Drawing.Point(14, 170)
        Me.txtClinicalNotes.Multiline = True
        Me.txtClinicalNotes.Name = "txtClinicalNotes"
        Me.txtClinicalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtClinicalNotes.Size = New System.Drawing.Size(284, 52)
        Me.txtClinicalNotes.TabIndex = 35
        '
        'lblRecommendations
        '
        Me.lblRecommendations.AutoSize = True
        Me.lblRecommendations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblRecommendations.Location = New System.Drawing.Point(306, 150)
        Me.lblRecommendations.Name = "lblRecommendations"
        Me.lblRecommendations.Size = New System.Drawing.Size(95, 13)
        Me.lblRecommendations.TabIndex = 36
        Me.lblRecommendations.Text = "Recommendations"
        '
        'txtRecommendations
        '
        Me.txtRecommendations.Location = New System.Drawing.Point(306, 170)
        Me.txtRecommendations.Multiline = True
        Me.txtRecommendations.Name = "txtRecommendations"
        Me.txtRecommendations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecommendations.Size = New System.Drawing.Size(288, 52)
        Me.txtRecommendations.TabIndex = 37
        '
        'btnNewVisit
        '
        Me.btnNewVisit.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewVisit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewVisit.FlatAppearance.BorderSize = 0
        Me.btnNewVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewVisit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewVisit.Location = New System.Drawing.Point(14, 226)
        Me.btnNewVisit.Name = "btnNewVisit"
        Me.btnNewVisit.Size = New System.Drawing.Size(120, 32)
        Me.btnNewVisit.TabIndex = 38
        Me.btnNewVisit.Text = "New Visit"
        Me.btnNewVisit.UseVisualStyleBackColor = False
        '
        'btnSaveVisit
        '
        Me.btnSaveVisit.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveVisit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveVisit.FlatAppearance.BorderSize = 0
        Me.btnSaveVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveVisit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveVisit.ForeColor = System.Drawing.Color.White
        Me.btnSaveVisit.Location = New System.Drawing.Point(142, 226)
        Me.btnSaveVisit.Name = "btnSaveVisit"
        Me.btnSaveVisit.Size = New System.Drawing.Size(120, 32)
        Me.btnSaveVisit.TabIndex = 39
        Me.btnSaveVisit.Text = "Save Visit"
        Me.btnSaveVisit.UseVisualStyleBackColor = False
        '
        'grpTreat
        '
        Me.grpTreat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTreat.Controls.Add(Me.lblTreatProcedure)
        Me.grpTreat.Controls.Add(Me.cboTreatProcedure)
        Me.grpTreat.Controls.Add(Me.lblTreatTooth)
        Me.grpTreat.Controls.Add(Me.txtTreatTooth)
        Me.grpTreat.Controls.Add(Me.lblTreatQty)
        Me.grpTreat.Controls.Add(Me.numTreatQty)
        Me.grpTreat.Controls.Add(Me.lblTreatPrice)
        Me.grpTreat.Controls.Add(Me.numTreatPrice)
        Me.grpTreat.Controls.Add(Me.lblTreatDiscount)
        Me.grpTreat.Controls.Add(Me.numTreatDiscount)
        Me.grpTreat.Controls.Add(Me.lblTreatStatus)
        Me.grpTreat.Controls.Add(Me.cboTreatStatus)
        Me.grpTreat.Controls.Add(Me.btnAddTreatment)
        Me.grpTreat.Controls.Add(Me.btnRemoveTreatment)
        Me.grpTreat.Controls.Add(Me.dgvTreatments)
        Me.grpTreat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpTreat.Location = New System.Drawing.Point(366, 286)
        Me.grpTreat.Name = "grpTreat"
        Me.grpTreat.Size = New System.Drawing.Size(2088, 262)
        Me.grpTreat.TabIndex = 40
        Me.grpTreat.TabStop = False
        Me.grpTreat.Text = "Treatments performed in this visit"
        '
        'lblTreatProcedure
        '
        Me.lblTreatProcedure.AutoSize = True
        Me.lblTreatProcedure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatProcedure.Location = New System.Drawing.Point(14, 22)
        Me.lblTreatProcedure.Name = "lblTreatProcedure"
        Me.lblTreatProcedure.Size = New System.Drawing.Size(63, 13)
        Me.lblTreatProcedure.TabIndex = 41
        Me.lblTreatProcedure.Text = "Procedure *"
        '
        'cboTreatProcedure
        '
        Me.cboTreatProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTreatProcedure.FormattingEnabled = True
        Me.cboTreatProcedure.Location = New System.Drawing.Point(14, 42)
        Me.cboTreatProcedure.Name = "cboTreatProcedure"
        Me.cboTreatProcedure.Size = New System.Drawing.Size(230, 21)
        Me.cboTreatProcedure.TabIndex = 42
        '
        'lblTreatTooth
        '
        Me.lblTreatTooth.AutoSize = True
        Me.lblTreatTooth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatTooth.Location = New System.Drawing.Point(252, 22)
        Me.lblTreatTooth.Name = "lblTreatTooth"
        Me.lblTreatTooth.Size = New System.Drawing.Size(35, 13)
        Me.lblTreatTooth.TabIndex = 43
        Me.lblTreatTooth.Text = "Tooth"
        '
        'txtTreatTooth
        '
        Me.txtTreatTooth.Location = New System.Drawing.Point(252, 42)
        Me.txtTreatTooth.Name = "txtTreatTooth"
        Me.txtTreatTooth.Size = New System.Drawing.Size(70, 20)
        Me.txtTreatTooth.TabIndex = 44
        '
        'lblTreatQty
        '
        Me.lblTreatQty.AutoSize = True
        Me.lblTreatQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatQty.Location = New System.Drawing.Point(330, 22)
        Me.lblTreatQty.Name = "lblTreatQty"
        Me.lblTreatQty.Size = New System.Drawing.Size(23, 13)
        Me.lblTreatQty.TabIndex = 45
        Me.lblTreatQty.Text = "Qty"
        '
        'numTreatQty
        '
        Me.numTreatQty.Location = New System.Drawing.Point(330, 42)
        Me.numTreatQty.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numTreatQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTreatQty.Name = "numTreatQty"
        Me.numTreatQty.Size = New System.Drawing.Size(60, 20)
        Me.numTreatQty.TabIndex = 46
        Me.numTreatQty.ThousandsSeparator = True
        Me.numTreatQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTreatPrice
        '
        Me.lblTreatPrice.AutoSize = True
        Me.lblTreatPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatPrice.Location = New System.Drawing.Point(398, 22)
        Me.lblTreatPrice.Name = "lblTreatPrice"
        Me.lblTreatPrice.Size = New System.Drawing.Size(52, 13)
        Me.lblTreatPrice.TabIndex = 47
        Me.lblTreatPrice.Text = "Unit price"
        '
        'numTreatPrice
        '
        Me.numTreatPrice.DecimalPlaces = 2
        Me.numTreatPrice.Location = New System.Drawing.Point(398, 42)
        Me.numTreatPrice.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numTreatPrice.Name = "numTreatPrice"
        Me.numTreatPrice.Size = New System.Drawing.Size(90, 20)
        Me.numTreatPrice.TabIndex = 48
        Me.numTreatPrice.ThousandsSeparator = True
        '
        'lblTreatDiscount
        '
        Me.lblTreatDiscount.AutoSize = True
        Me.lblTreatDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatDiscount.Location = New System.Drawing.Point(496, 22)
        Me.lblTreatDiscount.Name = "lblTreatDiscount"
        Me.lblTreatDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblTreatDiscount.TabIndex = 49
        Me.lblTreatDiscount.Text = "Discount"
        '
        'numTreatDiscount
        '
        Me.numTreatDiscount.DecimalPlaces = 2
        Me.numTreatDiscount.Location = New System.Drawing.Point(496, 42)
        Me.numTreatDiscount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numTreatDiscount.Name = "numTreatDiscount"
        Me.numTreatDiscount.Size = New System.Drawing.Size(98, 20)
        Me.numTreatDiscount.TabIndex = 50
        Me.numTreatDiscount.ThousandsSeparator = True
        '
        'lblTreatStatus
        '
        Me.lblTreatStatus.AutoSize = True
        Me.lblTreatStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTreatStatus.Location = New System.Drawing.Point(14, 76)
        Me.lblTreatStatus.Name = "lblTreatStatus"
        Me.lblTreatStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblTreatStatus.TabIndex = 51
        Me.lblTreatStatus.Text = "Status"
        '
        'cboTreatStatus
        '
        Me.cboTreatStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTreatStatus.FormattingEnabled = True
        Me.cboTreatStatus.Items.AddRange(New Object() {"Planned", "In Progress", "Completed", "Cancelled"})
        Me.cboTreatStatus.Location = New System.Drawing.Point(14, 96)
        Me.cboTreatStatus.Name = "cboTreatStatus"
        Me.cboTreatStatus.Size = New System.Drawing.Size(140, 21)
        Me.cboTreatStatus.TabIndex = 52
        '
        'btnAddTreatment
        '
        Me.btnAddTreatment.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddTreatment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTreatment.FlatAppearance.BorderSize = 0
        Me.btnAddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTreatment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTreatment.ForeColor = System.Drawing.Color.White
        Me.btnAddTreatment.Location = New System.Drawing.Point(170, 94)
        Me.btnAddTreatment.Name = "btnAddTreatment"
        Me.btnAddTreatment.Size = New System.Drawing.Size(130, 30)
        Me.btnAddTreatment.TabIndex = 53
        Me.btnAddTreatment.Text = "Add Treatment"
        Me.btnAddTreatment.UseVisualStyleBackColor = False
        '
        'btnRemoveTreatment
        '
        Me.btnRemoveTreatment.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRemoveTreatment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveTreatment.FlatAppearance.BorderSize = 0
        Me.btnRemoveTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveTreatment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveTreatment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRemoveTreatment.Location = New System.Drawing.Point(308, 94)
        Me.btnRemoveTreatment.Name = "btnRemoveTreatment"
        Me.btnRemoveTreatment.Size = New System.Drawing.Size(140, 30)
        Me.btnRemoveTreatment.TabIndex = 54
        Me.btnRemoveTreatment.Text = "Remove Selected"
        Me.btnRemoveTreatment.UseVisualStyleBackColor = False
        '
        'dgvTreatments
        '
        Me.dgvTreatments.AllowUserToAddRows = False
        Me.dgvTreatments.AllowUserToDeleteRows = False
        Me.dgvTreatments.AllowUserToResizeRows = False
        Me.dgvTreatments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreatments.BackgroundColor = System.Drawing.Color.White
        Me.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvTreatments.Location = New System.Drawing.Point(14, 134)
        Me.dgvTreatments.MultiSelect = False
        Me.dgvTreatments.Name = "dgvTreatments"
        Me.dgvTreatments.ReadOnly = True
        Me.dgvTreatments.RowHeadersVisible = False
        Me.dgvTreatments.RowTemplate.Height = 26
        Me.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreatments.Size = New System.Drawing.Size(2058, 118)
        Me.dgvTreatments.TabIndex = 55
        '
        'tabChart
        '
        Me.tabChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabChart.Controls.Add(Me.dgvChart)
        Me.tabChart.Controls.Add(Me.grpChart)
        Me.tabChart.Location = New System.Drawing.Point(4, 22)
        Me.tabChart.Name = "tabChart"
        Me.tabChart.Padding = New System.Windows.Forms.Padding(6)
        Me.tabChart.Size = New System.Drawing.Size(1672, 978)
        Me.tabChart.TabIndex = 7
        Me.tabChart.Text = "Dental Chart"
        '
        'dgvChart
        '
        Me.dgvChart.AllowUserToAddRows = False
        Me.dgvChart.AllowUserToDeleteRows = False
        Me.dgvChart.AllowUserToResizeRows = False
        Me.dgvChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvChart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChart.BackgroundColor = System.Drawing.Color.White
        Me.dgvChart.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvChart.Location = New System.Drawing.Point(8, 8)
        Me.dgvChart.MultiSelect = False
        Me.dgvChart.Name = "dgvChart"
        Me.dgvChart.ReadOnly = True
        Me.dgvChart.RowHeadersVisible = False
        Me.dgvChart.RowTemplate.Height = 26
        Me.dgvChart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChart.Size = New System.Drawing.Size(560, 1424)
        Me.dgvChart.TabIndex = 56
        '
        'grpChart
        '
        Me.grpChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChart.Controls.Add(Me.lblChartTooth)
        Me.grpChart.Controls.Add(Me.txtChartTooth)
        Me.grpChart.Controls.Add(Me.lblSurface)
        Me.grpChart.Controls.Add(Me.cboSurface)
        Me.grpChart.Controls.Add(Me.lblCondition)
        Me.grpChart.Controls.Add(Me.cboCondition)
        Me.grpChart.Controls.Add(Me.lblChartNotes)
        Me.grpChart.Controls.Add(Me.txtChartNotes)
        Me.grpChart.Controls.Add(Me.btnNewChart)
        Me.grpChart.Controls.Add(Me.btnSaveChart)
        Me.grpChart.Controls.Add(Me.btnDeleteChart)
        Me.grpChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpChart.Location = New System.Drawing.Point(580, 8)
        Me.grpChart.Name = "grpChart"
        Me.grpChart.Size = New System.Drawing.Size(1868, 300)
        Me.grpChart.TabIndex = 57
        Me.grpChart.TabStop = False
        Me.grpChart.Text = "Tooth entry"
        '
        'lblChartTooth
        '
        Me.lblChartTooth.AutoSize = True
        Me.lblChartTooth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblChartTooth.Location = New System.Drawing.Point(14, 22)
        Me.lblChartTooth.Name = "lblChartTooth"
        Me.lblChartTooth.Size = New System.Drawing.Size(80, 13)
        Me.lblChartTooth.TabIndex = 58
        Me.lblChartTooth.Text = "Tooth number *"
        '
        'txtChartTooth
        '
        Me.txtChartTooth.Location = New System.Drawing.Point(14, 42)
        Me.txtChartTooth.Name = "txtChartTooth"
        Me.txtChartTooth.Size = New System.Drawing.Size(110, 20)
        Me.txtChartTooth.TabIndex = 59
        '
        'lblSurface
        '
        Me.lblSurface.AutoSize = True
        Me.lblSurface.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblSurface.Location = New System.Drawing.Point(134, 22)
        Me.lblSurface.Name = "lblSurface"
        Me.lblSurface.Size = New System.Drawing.Size(44, 13)
        Me.lblSurface.TabIndex = 60
        Me.lblSurface.Text = "Surface"
        '
        'cboSurface
        '
        Me.cboSurface.FormattingEnabled = True
        Me.cboSurface.Items.AddRange(New Object() {"Mesial", "Distal", "Occlusal", "Buccal", "Lingual", "Incisal", "Whole tooth"})
        Me.cboSurface.Location = New System.Drawing.Point(134, 42)
        Me.cboSurface.Name = "cboSurface"
        Me.cboSurface.Size = New System.Drawing.Size(180, 21)
        Me.cboSurface.TabIndex = 61
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCondition.Location = New System.Drawing.Point(14, 76)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(51, 13)
        Me.lblCondition.TabIndex = 62
        Me.lblCondition.Text = "Condition"
        '
        'cboCondition
        '
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"Healthy", "Cavity", "Filled", "Crown", "Root canal", "Missing", "Extracted", "Impacted", "Fractured", "Implant"})
        Me.cboCondition.Location = New System.Drawing.Point(14, 96)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(300, 21)
        Me.cboCondition.TabIndex = 63
        '
        'lblChartNotes
        '
        Me.lblChartNotes.AutoSize = True
        Me.lblChartNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblChartNotes.Location = New System.Drawing.Point(14, 130)
        Me.lblChartNotes.Name = "lblChartNotes"
        Me.lblChartNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblChartNotes.TabIndex = 64
        Me.lblChartNotes.Text = "Notes"
        '
        'txtChartNotes
        '
        Me.txtChartNotes.Location = New System.Drawing.Point(14, 150)
        Me.txtChartNotes.Multiline = True
        Me.txtChartNotes.Name = "txtChartNotes"
        Me.txtChartNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChartNotes.Size = New System.Drawing.Size(360, 90)
        Me.txtChartNotes.TabIndex = 65
        '
        'btnNewChart
        '
        Me.btnNewChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewChart.FlatAppearance.BorderSize = 0
        Me.btnNewChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewChart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewChart.Location = New System.Drawing.Point(14, 244)
        Me.btnNewChart.Name = "btnNewChart"
        Me.btnNewChart.Size = New System.Drawing.Size(100, 32)
        Me.btnNewChart.TabIndex = 66
        Me.btnNewChart.Text = "New"
        Me.btnNewChart.UseVisualStyleBackColor = False
        '
        'btnSaveChart
        '
        Me.btnSaveChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveChart.FlatAppearance.BorderSize = 0
        Me.btnSaveChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveChart.ForeColor = System.Drawing.Color.White
        Me.btnSaveChart.Location = New System.Drawing.Point(122, 244)
        Me.btnSaveChart.Name = "btnSaveChart"
        Me.btnSaveChart.Size = New System.Drawing.Size(100, 32)
        Me.btnSaveChart.TabIndex = 67
        Me.btnSaveChart.Text = "Save"
        Me.btnSaveChart.UseVisualStyleBackColor = False
        '
        'btnDeleteChart
        '
        Me.btnDeleteChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDeleteChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteChart.FlatAppearance.BorderSize = 0
        Me.btnDeleteChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteChart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteChart.ForeColor = System.Drawing.Color.White
        Me.btnDeleteChart.Location = New System.Drawing.Point(230, 244)
        Me.btnDeleteChart.Name = "btnDeleteChart"
        Me.btnDeleteChart.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteChart.TabIndex = 68
        Me.btnDeleteChart.Text = "Delete"
        Me.btnDeleteChart.UseVisualStyleBackColor = False
        '
        'pnlProcedures
        '
        Me.pnlProcedures.Controls.Add(Me.pnlProcRight)
        Me.pnlProcedures.Controls.Add(Me.pnlProcLeft)
        Me.pnlProcedures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProcedures.Location = New System.Drawing.Point(220, 56)
        Me.pnlProcedures.Name = "pnlProcedures"
        Me.pnlProcedures.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlProcedures.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlProcedures.TabIndex = 26
        '
        'pnlProcRight
        '
        Me.pnlProcRight.AutoScroll = True
        Me.pnlProcRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlProcRight.Controls.Add(Me.grpProcedure)
        Me.pnlProcRight.Controls.Add(Me.btnNewProcedure)
        Me.pnlProcRight.Controls.Add(Me.btnSaveProcedure)
        Me.pnlProcRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProcRight.Location = New System.Drawing.Point(480, 10)
        Me.pnlProcRight.Name = "pnlProcRight"
        Me.pnlProcRight.Size = New System.Drawing.Size(1210, 1004)
        Me.pnlProcRight.TabIndex = 3
        '
        'grpProcedure
        '
        Me.grpProcedure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProcedure.Controls.Add(Me.lblProcCode)
        Me.grpProcedure.Controls.Add(Me.txtProcCode)
        Me.grpProcedure.Controls.Add(Me.lblProcStatus)
        Me.grpProcedure.Controls.Add(Me.cboProcStatus)
        Me.grpProcedure.Controls.Add(Me.lblName)
        Me.grpProcedure.Controls.Add(Me.txtName)
        Me.grpProcedure.Controls.Add(Me.lblDescription)
        Me.grpProcedure.Controls.Add(Me.txtDescription)
        Me.grpProcedure.Controls.Add(Me.lblPrice)
        Me.grpProcedure.Controls.Add(Me.numPrice)
        Me.grpProcedure.Controls.Add(Me.lblDuration)
        Me.grpProcedure.Controls.Add(Me.numDuration)
        Me.grpProcedure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpProcedure.Location = New System.Drawing.Point(8, 8)
        Me.grpProcedure.Name = "grpProcedure"
        Me.grpProcedure.Size = New System.Drawing.Size(1510, 330)
        Me.grpProcedure.TabIndex = 5
        Me.grpProcedure.TabStop = False
        Me.grpProcedure.Text = "Procedure details"
        '
        'lblProcCode
        '
        Me.lblProcCode.AutoSize = True
        Me.lblProcCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProcCode.Location = New System.Drawing.Point(14, 24)
        Me.lblProcCode.Name = "lblProcCode"
        Me.lblProcCode.Size = New System.Drawing.Size(90, 13)
        Me.lblProcCode.TabIndex = 6
        Me.lblProcCode.Text = "Procedure code *"
        '
        'txtProcCode
        '
        Me.txtProcCode.Location = New System.Drawing.Point(14, 44)
        Me.txtProcCode.Name = "txtProcCode"
        Me.txtProcCode.Size = New System.Drawing.Size(225, 20)
        Me.txtProcCode.TabIndex = 7
        '
        'lblProcStatus
        '
        Me.lblProcStatus.AutoSize = True
        Me.lblProcStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProcStatus.Location = New System.Drawing.Point(254, 24)
        Me.lblProcStatus.Name = "lblProcStatus"
        Me.lblProcStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblProcStatus.TabIndex = 8
        Me.lblProcStatus.Text = "Status"
        '
        'cboProcStatus
        '
        Me.cboProcStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcStatus.FormattingEnabled = True
        Me.cboProcStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboProcStatus.Location = New System.Drawing.Point(254, 44)
        Me.cboProcStatus.Name = "cboProcStatus"
        Me.cboProcStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboProcStatus.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(14, 80)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Procedure name *"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(14, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(465, 20)
        Me.txtName.TabIndex = 11
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(14, 136)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(14, 156)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(465, 70)
        Me.txtDescription.TabIndex = 13
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(14, 232)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(99, 13)
        Me.lblPrice.TabIndex = 14
        Me.lblPrice.Text = "Standard price (₱) *"
        '
        'numPrice
        '
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Location = New System.Drawing.Point(14, 252)
        Me.numPrice.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(225, 20)
        Me.numPrice.TabIndex = 15
        Me.numPrice.ThousandsSeparator = True
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDuration.Location = New System.Drawing.Point(254, 232)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(187, 13)
        Me.lblDuration.TabIndex = 16
        Me.lblDuration.Text = "Estimated duration (minutes, 0 = none)"
        '
        'numDuration
        '
        Me.numDuration.Location = New System.Drawing.Point(254, 252)
        Me.numDuration.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.numDuration.Name = "numDuration"
        Me.numDuration.Size = New System.Drawing.Size(225, 20)
        Me.numDuration.TabIndex = 17
        Me.numDuration.ThousandsSeparator = True
        '
        'btnNewProcedure
        '
        Me.btnNewProcedure.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewProcedure.FlatAppearance.BorderSize = 0
        Me.btnNewProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewProcedure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewProcedure.Location = New System.Drawing.Point(8, 350)
        Me.btnNewProcedure.Name = "btnNewProcedure"
        Me.btnNewProcedure.Size = New System.Drawing.Size(140, 36)
        Me.btnNewProcedure.TabIndex = 18
        Me.btnNewProcedure.Text = "New Procedure"
        Me.btnNewProcedure.UseVisualStyleBackColor = False
        '
        'btnSaveProcedure
        '
        Me.btnSaveProcedure.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveProcedure.FlatAppearance.BorderSize = 0
        Me.btnSaveProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveProcedure.ForeColor = System.Drawing.Color.White
        Me.btnSaveProcedure.Location = New System.Drawing.Point(156, 350)
        Me.btnSaveProcedure.Name = "btnSaveProcedure"
        Me.btnSaveProcedure.Size = New System.Drawing.Size(130, 36)
        Me.btnSaveProcedure.TabIndex = 19
        Me.btnSaveProcedure.Text = "Save"
        Me.btnSaveProcedure.UseVisualStyleBackColor = False
        '
        'pnlProcLeft
        '
        Me.pnlProcLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlProcLeft.Controls.Add(Me.dgvProcedures)
        Me.pnlProcLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlProcLeft.Location = New System.Drawing.Point(10, 10)
        Me.pnlProcLeft.Name = "pnlProcLeft"
        Me.pnlProcLeft.Size = New System.Drawing.Size(470, 1004)
        Me.pnlProcLeft.TabIndex = 4
        '
        'dgvProcedures
        '
        Me.dgvProcedures.AllowUserToAddRows = False
        Me.dgvProcedures.AllowUserToDeleteRows = False
        Me.dgvProcedures.AllowUserToResizeRows = False
        Me.dgvProcedures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProcedures.BackgroundColor = System.Drawing.Color.White
        Me.dgvProcedures.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvProcedures.Location = New System.Drawing.Point(8, 48)
        Me.dgvProcedures.MultiSelect = False
        Me.dgvProcedures.Name = "dgvProcedures"
        Me.dgvProcedures.ReadOnly = True
        Me.dgvProcedures.RowHeadersVisible = False
        Me.dgvProcedures.RowTemplate.Height = 26
        Me.dgvProcedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcedures.Size = New System.Drawing.Size(454, 948)
        Me.dgvProcedures.TabIndex = 4
        '
        'pnlAuditlog
        '
        Me.pnlAuditlog.Controls.Add(Me.lblFrom)
        Me.pnlAuditlog.Controls.Add(Me.dtpFrom)
        Me.pnlAuditlog.Controls.Add(Me.lblTo)
        Me.pnlAuditlog.Controls.Add(Me.dtpTo)
        Me.pnlAuditlog.Controls.Add(Me.btnLoad)
        Me.pnlAuditlog.Controls.Add(Me.lblCount)
        Me.pnlAuditlog.Controls.Add(Me.dgvLog)
        Me.pnlAuditlog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAuditlog.Location = New System.Drawing.Point(220, 56)
        Me.pnlAuditlog.Name = "pnlAuditlog"
        Me.pnlAuditlog.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlAuditlog.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlAuditlog.TabIndex = 27
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(23, 10)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 9
        Me.lblFrom.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(65, 6)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(120, 20)
        Me.dtpFrom.TabIndex = 10
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(197, 10)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 11
        Me.lblTo.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(223, 6)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(120, 20)
        Me.dtpTo.TabIndex = 12
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(915, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(90, 30)
        Me.btnLoad.TabIndex = 13
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(717, 11)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 13)
        Me.lblCount.TabIndex = 14
        '
        'dgvLog
        '
        Me.dgvLog.AllowUserToAddRows = False
        Me.dgvLog.AllowUserToDeleteRows = False
        Me.dgvLog.AllowUserToResizeRows = False
        Me.dgvLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLog.BackgroundColor = System.Drawing.Color.White
        Me.dgvLog.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvLog.Location = New System.Drawing.Point(21, 46)
        Me.dgvLog.MultiSelect = False
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.ReadOnly = True
        Me.dgvLog.RowHeadersVisible = False
        Me.dgvLog.RowTemplate.Height = 26
        Me.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLog.Size = New System.Drawing.Size(986, 582)
        Me.dgvLog.TabIndex = 15
        '
        'pnlStaff
        '
        Me.pnlStaff.Controls.Add(Me.pnlStaffRight)
        Me.pnlStaff.Controls.Add(Me.pnlStaffLeft)
        Me.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStaff.Location = New System.Drawing.Point(220, 56)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStaff.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlStaff.TabIndex = 28
        '
        'pnlStaffRight
        '
        Me.pnlStaffRight.AutoScroll = True
        Me.pnlStaffRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlStaffRight.Controls.Add(Me.grpStaff)
        Me.pnlStaffRight.Controls.Add(Me.grpUsers)
        Me.pnlStaffRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStaffRight.Location = New System.Drawing.Point(480, 10)
        Me.pnlStaffRight.Name = "pnlStaffRight"
        Me.pnlStaffRight.Size = New System.Drawing.Size(1210, 1004)
        Me.pnlStaffRight.TabIndex = 3
        '
        'grpStaff
        '
        Me.grpStaff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStaff.Controls.Add(Me.lblStaffCode)
        Me.grpStaff.Controls.Add(Me.txtStaffCode)
        Me.grpStaff.Controls.Add(Me.lblStaffStatus)
        Me.grpStaff.Controls.Add(Me.cboStaffStatus)
        Me.grpStaff.Controls.Add(Me.lblStaffFirstName)
        Me.grpStaff.Controls.Add(Me.txtStaffFirstName)
        Me.grpStaff.Controls.Add(Me.lblStaffLastName)
        Me.grpStaff.Controls.Add(Me.txtStaffLastName)
        Me.grpStaff.Controls.Add(Me.lblStaffContact)
        Me.grpStaff.Controls.Add(Me.txtStaffContact)
        Me.grpStaff.Controls.Add(Me.lblStaffEmail)
        Me.grpStaff.Controls.Add(Me.txtStaffEmail)
        Me.grpStaff.Controls.Add(Me.lblPosition)
        Me.grpStaff.Controls.Add(Me.cboPosition)
        Me.grpStaff.Controls.Add(Me.lblLicense)
        Me.grpStaff.Controls.Add(Me.txtLicense)
        Me.grpStaff.Controls.Add(Me.btnNewStaff)
        Me.grpStaff.Controls.Add(Me.btnSaveStaff)
        Me.grpStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpStaff.Location = New System.Drawing.Point(8, 8)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(1527, 300)
        Me.grpStaff.TabIndex = 5
        Me.grpStaff.TabStop = False
        Me.grpStaff.Text = "Staff member"
        '
        'lblStaffCode
        '
        Me.lblStaffCode.AutoSize = True
        Me.lblStaffCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffCode.Location = New System.Drawing.Point(14, 24)
        Me.lblStaffCode.Name = "lblStaffCode"
        Me.lblStaffCode.Size = New System.Drawing.Size(124, 13)
        Me.lblStaffCode.TabIndex = 6
        Me.lblStaffCode.Text = "Staff code (blank = auto)"
        '
        'txtStaffCode
        '
        Me.txtStaffCode.Location = New System.Drawing.Point(14, 44)
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.Size = New System.Drawing.Size(225, 20)
        Me.txtStaffCode.TabIndex = 7
        '
        'lblStaffStatus
        '
        Me.lblStaffStatus.AutoSize = True
        Me.lblStaffStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffStatus.Location = New System.Drawing.Point(254, 24)
        Me.lblStaffStatus.Name = "lblStaffStatus"
        Me.lblStaffStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStaffStatus.TabIndex = 8
        Me.lblStaffStatus.Text = "Status"
        '
        'cboStaffStatus
        '
        Me.cboStaffStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffStatus.FormattingEnabled = True
        Me.cboStaffStatus.Items.AddRange(New Object() {"Active", "Inactive", "Suspended"})
        Me.cboStaffStatus.Location = New System.Drawing.Point(254, 44)
        Me.cboStaffStatus.Name = "cboStaffStatus"
        Me.cboStaffStatus.Size = New System.Drawing.Size(225, 21)
        Me.cboStaffStatus.TabIndex = 9
        '
        'lblStaffFirstName
        '
        Me.lblStaffFirstName.AutoSize = True
        Me.lblStaffFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffFirstName.Location = New System.Drawing.Point(14, 80)
        Me.lblStaffFirstName.Name = "lblStaffFirstName"
        Me.lblStaffFirstName.Size = New System.Drawing.Size(62, 13)
        Me.lblStaffFirstName.TabIndex = 10
        Me.lblStaffFirstName.Text = "First name *"
        '
        'txtStaffFirstName
        '
        Me.txtStaffFirstName.Location = New System.Drawing.Point(14, 100)
        Me.txtStaffFirstName.Name = "txtStaffFirstName"
        Me.txtStaffFirstName.Size = New System.Drawing.Size(225, 20)
        Me.txtStaffFirstName.TabIndex = 11
        '
        'lblStaffLastName
        '
        Me.lblStaffLastName.AutoSize = True
        Me.lblStaffLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffLastName.Location = New System.Drawing.Point(254, 80)
        Me.lblStaffLastName.Name = "lblStaffLastName"
        Me.lblStaffLastName.Size = New System.Drawing.Size(63, 13)
        Me.lblStaffLastName.TabIndex = 12
        Me.lblStaffLastName.Text = "Last name *"
        '
        'txtStaffLastName
        '
        Me.txtStaffLastName.Location = New System.Drawing.Point(254, 100)
        Me.txtStaffLastName.Name = "txtStaffLastName"
        Me.txtStaffLastName.Size = New System.Drawing.Size(225, 20)
        Me.txtStaffLastName.TabIndex = 13
        '
        'lblStaffContact
        '
        Me.lblStaffContact.AutoSize = True
        Me.lblStaffContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffContact.Location = New System.Drawing.Point(14, 136)
        Me.lblStaffContact.Name = "lblStaffContact"
        Me.lblStaffContact.Size = New System.Drawing.Size(82, 13)
        Me.lblStaffContact.TabIndex = 14
        Me.lblStaffContact.Text = "Contact number"
        '
        'txtStaffContact
        '
        Me.txtStaffContact.Location = New System.Drawing.Point(14, 156)
        Me.txtStaffContact.Name = "txtStaffContact"
        Me.txtStaffContact.Size = New System.Drawing.Size(225, 20)
        Me.txtStaffContact.TabIndex = 15
        '
        'lblStaffEmail
        '
        Me.lblStaffEmail.AutoSize = True
        Me.lblStaffEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblStaffEmail.Location = New System.Drawing.Point(254, 136)
        Me.lblStaffEmail.Name = "lblStaffEmail"
        Me.lblStaffEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblStaffEmail.TabIndex = 16
        Me.lblStaffEmail.Text = "Email"
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Location = New System.Drawing.Point(254, 156)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtStaffEmail.TabIndex = 17
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(14, 192)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(51, 13)
        Me.lblPosition.TabIndex = 18
        Me.lblPosition.Text = "Position *"
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Dentist", "Dental Assistant", "Administrator", "Front Desk"})
        Me.cboPosition.Location = New System.Drawing.Point(14, 212)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(225, 21)
        Me.cboPosition.TabIndex = 19
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblLicense.Location = New System.Drawing.Point(254, 192)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(82, 13)
        Me.lblLicense.TabIndex = 20
        Me.lblLicense.Text = "License number"
        '
        'txtLicense
        '
        Me.txtLicense.Location = New System.Drawing.Point(254, 212)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(225, 20)
        Me.txtLicense.TabIndex = 21
        '
        'btnNewStaff
        '
        Me.btnNewStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewStaff.FlatAppearance.BorderSize = 0
        Me.btnNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewStaff.Location = New System.Drawing.Point(14, 250)
        Me.btnNewStaff.Name = "btnNewStaff"
        Me.btnNewStaff.Size = New System.Drawing.Size(120, 32)
        Me.btnNewStaff.TabIndex = 22
        Me.btnNewStaff.Text = "New Staff"
        Me.btnNewStaff.UseVisualStyleBackColor = False
        '
        'btnSaveStaff
        '
        Me.btnSaveStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveStaff.FlatAppearance.BorderSize = 0
        Me.btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveStaff.ForeColor = System.Drawing.Color.White
        Me.btnSaveStaff.Location = New System.Drawing.Point(142, 250)
        Me.btnSaveStaff.Name = "btnSaveStaff"
        Me.btnSaveStaff.Size = New System.Drawing.Size(120, 32)
        Me.btnSaveStaff.TabIndex = 23
        Me.btnSaveStaff.Text = "Save"
        Me.btnSaveStaff.UseVisualStyleBackColor = False
        '
        'grpUsers
        '
        Me.grpUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUsers.Controls.Add(Me.dgvUsers)
        Me.grpUsers.Controls.Add(Me.btnResetPassword)
        Me.grpUsers.Controls.Add(Me.btnToggleActive)
        Me.grpUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpUsers.Location = New System.Drawing.Point(8, 318)
        Me.grpUsers.Name = "grpUsers"
        Me.grpUsers.Size = New System.Drawing.Size(1527, 220)
        Me.grpUsers.TabIndex = 24
        Me.grpUsers.TabStop = False
        Me.grpUsers.Text = "Login accounts (Administrator and Front Desk)"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvUsers.Location = New System.Drawing.Point(14, 26)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.RowTemplate.Height = 26
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(1497, 120)
        Me.dgvUsers.TabIndex = 25
        '
        'btnResetPassword
        '
        Me.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetPassword.FlatAppearance.BorderSize = 0
        Me.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnResetPassword.ForeColor = System.Drawing.Color.White
        Me.btnResetPassword.Location = New System.Drawing.Point(14, 160)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(170, 32)
        Me.btnResetPassword.TabIndex = 26
        Me.btnResetPassword.Text = "Set / Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = False
        '
        'btnToggleActive
        '
        Me.btnToggleActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToggleActive.FlatAppearance.BorderSize = 0
        Me.btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnToggleActive.Location = New System.Drawing.Point(192, 160)
        Me.btnToggleActive.Name = "btnToggleActive"
        Me.btnToggleActive.Size = New System.Drawing.Size(150, 32)
        Me.btnToggleActive.TabIndex = 27
        Me.btnToggleActive.Text = "Enable / Disable"
        Me.btnToggleActive.UseVisualStyleBackColor = False
        '
        'pnlStaffLeft
        '
        Me.pnlStaffLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlStaffLeft.Controls.Add(Me.dgvStaff)
        Me.pnlStaffLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlStaffLeft.Location = New System.Drawing.Point(10, 10)
        Me.pnlStaffLeft.Name = "pnlStaffLeft"
        Me.pnlStaffLeft.Size = New System.Drawing.Size(470, 1004)
        Me.pnlStaffLeft.TabIndex = 4
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToDeleteRows = False
        Me.dgvStaff.AllowUserToResizeRows = False
        Me.dgvStaff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaff.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvStaff.Location = New System.Drawing.Point(8, 48)
        Me.dgvStaff.MultiSelect = False
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.RowHeadersVisible = False
        Me.dgvStaff.RowTemplate.Height = 26
        Me.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaff.Size = New System.Drawing.Size(454, 948)
        Me.dgvStaff.TabIndex = 4
        '
        'pnlBillingpayments
        '
        Me.pnlBillingpayments.Controls.Add(Me.pnlInvoiceRight)
        Me.pnlBillingpayments.Controls.Add(Me.pnlInvoiceLeft)
        Me.pnlBillingpayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillingpayments.Location = New System.Drawing.Point(220, 56)
        Me.pnlBillingpayments.Name = "pnlBillingpayments"
        Me.pnlBillingpayments.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBillingpayments.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlBillingpayments.TabIndex = 29
        '
        'pnlInvoiceRight
        '
        Me.pnlInvoiceRight.AutoScroll = True
        Me.pnlInvoiceRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlInvoiceRight.Controls.Add(Me.grpInvoice)
        Me.pnlInvoiceRight.Controls.Add(Me.grpItems)
        Me.pnlInvoiceRight.Controls.Add(Me.grpPayments)
        Me.pnlInvoiceRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInvoiceRight.Location = New System.Drawing.Point(480, 10)
        Me.pnlInvoiceRight.Name = "pnlInvoiceRight"
        Me.pnlInvoiceRight.Size = New System.Drawing.Size(1210, 1004)
        Me.pnlInvoiceRight.TabIndex = 3
        '
        'grpInvoice
        '
        Me.grpInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInvoice.Controls.Add(Me.lblInvoiceNo)
        Me.grpInvoice.Controls.Add(Me.txtInvoiceNo)
        Me.grpInvoice.Controls.Add(Me.lblInvoiceStatus)
        Me.grpInvoice.Controls.Add(Me.txtStatus)
        Me.grpInvoice.Controls.Add(Me.lblDiscount)
        Me.grpInvoice.Controls.Add(Me.numDiscount)
        Me.grpInvoice.Controls.Add(Me.lblInvoicePatient)
        Me.grpInvoice.Controls.Add(Me.cboInvoicePatient)
        Me.grpInvoice.Controls.Add(Me.lblSubTotal)
        Me.grpInvoice.Controls.Add(Me.lblTotal)
        Me.grpInvoice.Controls.Add(Me.lblPaid)
        Me.grpInvoice.Controls.Add(Me.lblBalance)
        Me.grpInvoice.Controls.Add(Me.btnNewInvoice)
        Me.grpInvoice.Controls.Add(Me.btnSaveInvoice)
        Me.grpInvoice.Controls.Add(Me.btnVoid)
        Me.grpInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpInvoice.Location = New System.Drawing.Point(8, 8)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(1510, 180)
        Me.grpInvoice.TabIndex = 6
        Me.grpInvoice.TabStop = False
        Me.grpInvoice.Text = "Invoice"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(14, 22)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(60, 13)
        Me.lblInvoiceNo.TabIndex = 7
        Me.lblInvoiceNo.Text = "Invoice no."
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(14, 42)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(130, 20)
        Me.txtInvoiceNo.TabIndex = 8
        '
        'lblInvoiceStatus
        '
        Me.lblInvoiceStatus.AutoSize = True
        Me.lblInvoiceStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblInvoiceStatus.Location = New System.Drawing.Point(154, 22)
        Me.lblInvoiceStatus.Name = "lblInvoiceStatus"
        Me.lblInvoiceStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblInvoiceStatus.TabIndex = 9
        Me.lblInvoiceStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(154, 42)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(110, 20)
        Me.txtStatus.TabIndex = 10
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(274, 22)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(65, 13)
        Me.lblDiscount.TabIndex = 11
        Me.lblDiscount.Text = "Discount (₱)"
        '
        'numDiscount
        '
        Me.numDiscount.DecimalPlaces = 2
        Me.numDiscount.Location = New System.Drawing.Point(274, 42)
        Me.numDiscount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numDiscount.Name = "numDiscount"
        Me.numDiscount.Size = New System.Drawing.Size(120, 20)
        Me.numDiscount.TabIndex = 12
        Me.numDiscount.ThousandsSeparator = True
        '
        'lblInvoicePatient
        '
        Me.lblInvoicePatient.AutoSize = True
        Me.lblInvoicePatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblInvoicePatient.Location = New System.Drawing.Point(14, 76)
        Me.lblInvoicePatient.Name = "lblInvoicePatient"
        Me.lblInvoicePatient.Size = New System.Drawing.Size(47, 13)
        Me.lblInvoicePatient.TabIndex = 13
        Me.lblInvoicePatient.Text = "Patient *"
        '
        'cboInvoicePatient
        '
        Me.cboInvoicePatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvoicePatient.FormattingEnabled = True
        Me.cboInvoicePatient.Location = New System.Drawing.Point(14, 96)
        Me.cboInvoicePatient.Name = "cboInvoicePatient"
        Me.cboInvoicePatient.Size = New System.Drawing.Size(380, 21)
        Me.cboInvoicePatient.TabIndex = 14
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(14, 140)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(35, 13)
        Me.lblSubTotal.TabIndex = 15
        Me.lblSubTotal.Text = "₱0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(134, 140)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "₱0.00"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPaid.Location = New System.Drawing.Point(254, 140)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(35, 13)
        Me.lblPaid.TabIndex = 17
        Me.lblPaid.Text = "₱0.00"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lblBalance.Location = New System.Drawing.Point(374, 140)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(39, 15)
        Me.lblBalance.TabIndex = 18
        Me.lblBalance.Text = "₱0.00"
        '
        'btnNewInvoice
        '
        Me.btnNewInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewInvoice.FlatAppearance.BorderSize = 0
        Me.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNewInvoice.Location = New System.Drawing.Point(404, 40)
        Me.btnNewInvoice.Name = "btnNewInvoice"
        Me.btnNewInvoice.Size = New System.Drawing.Size(84, 28)
        Me.btnNewInvoice.TabIndex = 19
        Me.btnNewInvoice.Text = "New"
        Me.btnNewInvoice.UseVisualStyleBackColor = False
        '
        'btnSaveInvoice
        '
        Me.btnSaveInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveInvoice.FlatAppearance.BorderSize = 0
        Me.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveInvoice.ForeColor = System.Drawing.Color.White
        Me.btnSaveInvoice.Location = New System.Drawing.Point(404, 74)
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        Me.btnSaveInvoice.Size = New System.Drawing.Size(84, 28)
        Me.btnSaveInvoice.TabIndex = 20
        Me.btnSaveInvoice.Text = "Save"
        Me.btnSaveInvoice.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoid.FlatAppearance.BorderSize = 0
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(404, 108)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(84, 28)
        Me.btnVoid.TabIndex = 21
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'grpItems
        '
        Me.grpItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItems.Controls.Add(Me.lblProcedure)
        Me.grpItems.Controls.Add(Me.cboProcedure)
        Me.grpItems.Controls.Add(Me.lblItemDesc)
        Me.grpItems.Controls.Add(Me.txtItemDesc)
        Me.grpItems.Controls.Add(Me.lblQty)
        Me.grpItems.Controls.Add(Me.numQty)
        Me.grpItems.Controls.Add(Me.lblUnitPrice)
        Me.grpItems.Controls.Add(Me.numUnitPrice)
        Me.grpItems.Controls.Add(Me.lblItemDiscount)
        Me.grpItems.Controls.Add(Me.numItemDiscount)
        Me.grpItems.Controls.Add(Me.btnAddItem)
        Me.grpItems.Controls.Add(Me.btnRemoveItem)
        Me.grpItems.Controls.Add(Me.dgvItems)
        Me.grpItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpItems.Location = New System.Drawing.Point(8, 196)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(1510, 290)
        Me.grpItems.TabIndex = 22
        Me.grpItems.TabStop = False
        Me.grpItems.Text = "Invoice items"
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblProcedure.Location = New System.Drawing.Point(14, 22)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(226, 13)
        Me.lblProcedure.TabIndex = 23
        Me.lblProcedure.Text = "Procedure (optional - fills description and price)"
        '
        'cboProcedure
        '
        Me.cboProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcedure.FormattingEnabled = True
        Me.cboProcedure.Location = New System.Drawing.Point(14, 42)
        Me.cboProcedure.Name = "cboProcedure"
        Me.cboProcedure.Size = New System.Drawing.Size(470, 21)
        Me.cboProcedure.TabIndex = 24
        '
        'lblItemDesc
        '
        Me.lblItemDesc.AutoSize = True
        Me.lblItemDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblItemDesc.Location = New System.Drawing.Point(14, 76)
        Me.lblItemDesc.Name = "lblItemDesc"
        Me.lblItemDesc.Size = New System.Drawing.Size(67, 13)
        Me.lblItemDesc.TabIndex = 25
        Me.lblItemDesc.Text = "Description *"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(14, 96)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(220, 20)
        Me.txtItemDesc.TabIndex = 26
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblQty.Location = New System.Drawing.Point(242, 76)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(23, 13)
        Me.lblQty.TabIndex = 27
        Me.lblQty.Text = "Qty"
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(242, 96)
        Me.numQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(50, 20)
        Me.numQty.TabIndex = 28
        Me.numQty.ThousandsSeparator = True
        Me.numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblUnitPrice.Location = New System.Drawing.Point(300, 76)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(52, 13)
        Me.lblUnitPrice.TabIndex = 29
        Me.lblUnitPrice.Text = "Unit price"
        '
        'numUnitPrice
        '
        Me.numUnitPrice.DecimalPlaces = 2
        Me.numUnitPrice.Location = New System.Drawing.Point(300, 96)
        Me.numUnitPrice.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numUnitPrice.Name = "numUnitPrice"
        Me.numUnitPrice.Size = New System.Drawing.Size(90, 20)
        Me.numUnitPrice.TabIndex = 30
        Me.numUnitPrice.ThousandsSeparator = True
        '
        'lblItemDiscount
        '
        Me.lblItemDiscount.AutoSize = True
        Me.lblItemDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblItemDiscount.Location = New System.Drawing.Point(398, 76)
        Me.lblItemDiscount.Name = "lblItemDiscount"
        Me.lblItemDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblItemDiscount.TabIndex = 31
        Me.lblItemDiscount.Text = "Discount"
        '
        'numItemDiscount
        '
        Me.numItemDiscount.DecimalPlaces = 2
        Me.numItemDiscount.Location = New System.Drawing.Point(398, 96)
        Me.numItemDiscount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numItemDiscount.Name = "numItemDiscount"
        Me.numItemDiscount.Size = New System.Drawing.Size(86, 20)
        Me.numItemDiscount.TabIndex = 32
        Me.numItemDiscount.ThousandsSeparator = True
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(14, 128)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(110, 30)
        Me.btnAddItem.TabIndex = 33
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveItem.FlatAppearance.BorderSize = 0
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRemoveItem.Location = New System.Drawing.Point(132, 128)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 30)
        Me.btnRemoveItem.TabIndex = 34
        Me.btnRemoveItem.Text = "Remove Selected"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvItems.Location = New System.Drawing.Point(14, 166)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowTemplate.Height = 26
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(1482, 116)
        Me.dgvItems.TabIndex = 35
        '
        'grpPayments
        '
        Me.grpPayments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPayments.Controls.Add(Me.lblMethod)
        Me.grpPayments.Controls.Add(Me.cboMethod)
        Me.grpPayments.Controls.Add(Me.lblPayAmount)
        Me.grpPayments.Controls.Add(Me.numPayAmount)
        Me.grpPayments.Controls.Add(Me.lblPayNotes)
        Me.grpPayments.Controls.Add(Me.txtPayNotes)
        Me.grpPayments.Controls.Add(Me.btnReceive)
        Me.grpPayments.Controls.Add(Me.dgvPayments)
        Me.grpPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpPayments.Location = New System.Drawing.Point(8, 494)
        Me.grpPayments.Name = "grpPayments"
        Me.grpPayments.Size = New System.Drawing.Size(1510, 215)
        Me.grpPayments.TabIndex = 36
        Me.grpPayments.TabStop = False
        Me.grpPayments.Text = "Payments"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblMethod.Location = New System.Drawing.Point(14, 22)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(50, 13)
        Me.lblMethod.TabIndex = 37
        Me.lblMethod.Text = "Method *"
        '
        'cboMethod
        '
        Me.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMethod.FormattingEnabled = True
        Me.cboMethod.Location = New System.Drawing.Point(14, 42)
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.Size = New System.Drawing.Size(150, 21)
        Me.cboMethod.TabIndex = 38
        '
        'lblPayAmount
        '
        Me.lblPayAmount.AutoSize = True
        Me.lblPayAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblPayAmount.Location = New System.Drawing.Point(174, 22)
        Me.lblPayAmount.Name = "lblPayAmount"
        Me.lblPayAmount.Size = New System.Drawing.Size(66, 13)
        Me.lblPayAmount.TabIndex = 39
        Me.lblPayAmount.Text = "Amount (₱) *"
        '
        'numPayAmount
        '
        Me.numPayAmount.DecimalPlaces = 2
        Me.numPayAmount.Location = New System.Drawing.Point(174, 42)
        Me.numPayAmount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.numPayAmount.Name = "numPayAmount"
        Me.numPayAmount.Size = New System.Drawing.Size(110, 20)
        Me.numPayAmount.TabIndex = 40
        Me.numPayAmount.ThousandsSeparator = True
        '
        'lblPayNotes
        '
        Me.lblPayNotes.AutoSize = True
        Me.lblPayNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblPayNotes.Location = New System.Drawing.Point(294, 22)
        Me.lblPayNotes.Name = "lblPayNotes"
        Me.lblPayNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblPayNotes.TabIndex = 41
        Me.lblPayNotes.Text = "Notes"
        '
        'txtPayNotes
        '
        Me.txtPayNotes.Location = New System.Drawing.Point(294, 42)
        Me.txtPayNotes.Name = "txtPayNotes"
        Me.txtPayNotes.Size = New System.Drawing.Size(190, 20)
        Me.txtPayNotes.TabIndex = 42
        '
        'btnReceive
        '
        Me.btnReceive.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceive.FlatAppearance.BorderSize = 0
        Me.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceive.ForeColor = System.Drawing.Color.White
        Me.btnReceive.Location = New System.Drawing.Point(14, 74)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(150, 30)
        Me.btnReceive.TabIndex = 43
        Me.btnReceive.Text = "Receive Payment"
        Me.btnReceive.UseVisualStyleBackColor = False
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AllowUserToResizeRows = False
        Me.dgvPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPayments.BackgroundColor = System.Drawing.Color.White
        Me.dgvPayments.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvPayments.Location = New System.Drawing.Point(14, 112)
        Me.dgvPayments.MultiSelect = False
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.RowTemplate.Height = 26
        Me.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayments.Size = New System.Drawing.Size(1482, 95)
        Me.dgvPayments.TabIndex = 44
        '
        'pnlInvoiceLeft
        '
        Me.pnlInvoiceLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlInvoiceLeft.Controls.Add(Me.cboStatusFilter)
        Me.pnlInvoiceLeft.Controls.Add(Me.dgvInvoices)
        Me.pnlInvoiceLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInvoiceLeft.Location = New System.Drawing.Point(10, 10)
        Me.pnlInvoiceLeft.Name = "pnlInvoiceLeft"
        Me.pnlInvoiceLeft.Size = New System.Drawing.Size(470, 1004)
        Me.pnlInvoiceLeft.TabIndex = 4
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFilter.FormattingEnabled = True
        Me.cboStatusFilter.Items.AddRange(New Object() {"All statuses", "Unpaid", "Partially Paid", "Paid", "Void"})
        Me.cboStatusFilter.Location = New System.Drawing.Point(306, 10)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(152, 21)
        Me.cboStatusFilter.TabIndex = 4
        '
        'dgvInvoices
        '
        Me.dgvInvoices.AllowUserToAddRows = False
        Me.dgvInvoices.AllowUserToDeleteRows = False
        Me.dgvInvoices.AllowUserToResizeRows = False
        Me.dgvInvoices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoices.BackgroundColor = System.Drawing.Color.White
        Me.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.dgvInvoices.Location = New System.Drawing.Point(8, 48)
        Me.dgvInvoices.MultiSelect = False
        Me.dgvInvoices.Name = "dgvInvoices"
        Me.dgvInvoices.ReadOnly = True
        Me.dgvInvoices.RowHeadersVisible = False
        Me.dgvInvoices.RowTemplate.Height = 26
        Me.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoices.Size = New System.Drawing.Size(454, 948)
        Me.dgvInvoices.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnlStaff)
        Me.Controls.Add(Me.pnlBillingpayments)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlAuditlog)
        Me.Controls.Add(Me.pnlProcedures)
        Me.Controls.Add(Me.pnlClinicalRecord)
        Me.Controls.Add(Me.pnlPatients)
        Me.Controls.Add(Me.pnlAppointment)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.pnlCardToday.ResumeLayout(False)
        Me.pnlCardToday.PerformLayout()
        Me.pnlCardPending.ResumeLayout(False)
        Me.pnlCardPending.PerformLayout()
        Me.pnlCardUnpaid.ResumeLayout(False)
        Me.pnlCardUnpaid.PerformLayout()
        Me.pnlCardLow.ResumeLayout(False)
        Me.pnlCardLow.PerformLayout()
        CType(Me.dgvToday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        Me.tabInventory.ResumeLayout(False)
        Me.tabProducts.ResumeLayout(False)
        Me.pnlProdRight.ResumeLayout(False)
        Me.grpProduct.ResumeLayout(False)
        Me.grpProduct.PerformLayout()
        CType(Me.numReorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStock.ResumeLayout(False)
        Me.grpStock.PerformLayout()
        CType(Me.numTxQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProdLeft.ResumeLayout(False)
        Me.pnlProdLeft.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSuppliers.ResumeLayout(False)
        Me.pnlSupRight.ResumeLayout(False)
        Me.grpSupplier.ResumeLayout(False)
        Me.grpSupplier.PerformLayout()
        Me.pnlSupLeft.ResumeLayout(False)
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAppointment.ResumeLayout(False)
        Me.pnlApptRight.ResumeLayout(False)
        Me.grpAppointment.ResumeLayout(False)
        Me.grpAppointment.PerformLayout()
        Me.pnlApptLeft.ResumeLayout(False)
        Me.pnlApptLeft.PerformLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPatients.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.pnlClinicalRecord.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabMedical.ResumeLayout(False)
        Me.tabMedical.PerformLayout()
        Me.tabVisits.ResumeLayout(False)
        CType(Me.dgvVisits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVisit.ResumeLayout(False)
        Me.grpVisit.PerformLayout()
        Me.grpTreat.ResumeLayout(False)
        Me.grpTreat.PerformLayout()
        CType(Me.numTreatQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTreatPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTreatDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTreatments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabChart.ResumeLayout(False)
        CType(Me.dgvChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChart.ResumeLayout(False)
        Me.grpChart.PerformLayout()
        Me.pnlProcedures.ResumeLayout(False)
        Me.pnlProcRight.ResumeLayout(False)
        Me.grpProcedure.ResumeLayout(False)
        Me.grpProcedure.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProcLeft.ResumeLayout(False)
        CType(Me.dgvProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAuditlog.ResumeLayout(False)
        Me.pnlAuditlog.PerformLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaff.ResumeLayout(False)
        Me.pnlStaffRight.ResumeLayout(False)
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        Me.grpUsers.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaffLeft.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBillingpayments.ResumeLayout(False)
        Me.pnlInvoiceRight.ResumeLayout(False)
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItems.ResumeLayout(False)
        Me.grpItems.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayments.ResumeLayout(False)
        Me.grpPayments.PerformLayout()
        CType(Me.numPayAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInvoiceLeft.ResumeLayout(False)
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSub As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavPatients As Button
    Friend WithEvents btnNavAppointments As Button
    Friend WithEvents btnNavBilling As Button
    Friend WithEvents btnNavClinical As Button
    Friend WithEvents btnNavProcedures As Button
    Friend WithEvents btnNavInventory As Button
    Friend WithEvents btnNavStaff As Button
    Friend WithEvents btnNavAudit As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlCardToday As Panel
    Friend WithEvents lblCardTodayCaption As Label
    Friend WithEvents lblTodayCount As Label
    Friend WithEvents pnlCardPending As Panel
    Friend WithEvents lblCardPendingCaption As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents pnlCardUnpaid As Panel
    Friend WithEvents lblCardUnpaidCaption As Label
    Friend WithEvents lblUnpaidCount As Label
    Friend WithEvents lblUnpaidAmount As Label
    Friend WithEvents pnlCardLow As Panel
    Friend WithEvents lblCardLowCaption As Label
    Friend WithEvents lblLowStockCount As Label
    Friend WithEvents lblTodayAppointments As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvToday As DataGridView
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents tabInventory As TabControl
    Friend WithEvents tabProducts As TabPage
    Friend WithEvents pnlProdRight As Panel
    Friend WithEvents grpProduct As GroupBox
    Friend WithEvents lblProdCode As Label
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents lblProdName As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblReorder As Label
    Friend WithEvents numReorder As NumericUpDown
    Friend WithEvents lblCost As Label
    Friend WithEvents numCost As NumericUpDown
    Friend WithEvents lblStock As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblProdStatus As Label
    Friend WithEvents cboProdStatus As ComboBox
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents grpStock As GroupBox
    Friend WithEvents lblTxType As Label
    Friend WithEvents cboTxType As ComboBox
    Friend WithEvents lblTxQty As Label
    Friend WithEvents numTxQty As NumericUpDown
    Friend WithEvents lblTxRef As Label
    Friend WithEvents txtTxRef As TextBox
    Friend WithEvents lblTxNotes As Label
    Friend WithEvents txtTxNotes As TextBox
    Friend WithEvents btnPostStock As Button
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents pnlProdLeft As Panel
    Friend WithEvents chkLowStock As CheckBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents tabSuppliers As TabPage
    Friend WithEvents pnlSupRight As Panel
    Friend WithEvents grpSupplier As GroupBox
    Friend WithEvents lblSupName As Label
    Friend WithEvents txtSupName As TextBox
    Friend WithEvents lblSupStatus As Label
    Friend WithEvents cboSupStatus As ComboBox
    Friend WithEvents lblSupContact As Label
    Friend WithEvents txtSupContact As TextBox
    Friend WithEvents lblSupPhone As Label
    Friend WithEvents txtSupPhone As TextBox
    Friend WithEvents lblSupEmail As Label
    Friend WithEvents txtSupEmail As TextBox
    Friend WithEvents lblSupAddress As Label
    Friend WithEvents txtSupAddress As TextBox
    Friend WithEvents btnNewSupplier As Button
    Friend WithEvents btnSaveSupplier As Button
    Friend WithEvents pnlSupLeft As Panel
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents pnlAppointment As Panel
    Friend WithEvents pnlApptRight As Panel
    Friend WithEvents grpAppointment As GroupBox
    Friend WithEvents lblApptCode As Label
    Friend WithEvents txtApptCode As TextBox
    Friend WithEvents lblApptStatus As Label
    Friend WithEvents cboApptStatus As ComboBox
    Friend WithEvents lblApptPatient As Label
    Friend WithEvents cboApptPatient As ComboBox
    Friend WithEvents lblDentist As Label
    Friend WithEvents cboDentist As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblType As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblStart As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblReason As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnNewAppt As Button
    Friend WithEvents btnSaveAppt As Button
    Friend WithEvents btnCancelAppt As Button
    Friend WithEvents pnlApptLeft As Panel
    Friend WithEvents dtpFilterDate As DateTimePicker
    Friend WithEvents chkAllDates As CheckBox
    Friend WithEvents cboFilterStatus As ComboBox
    Friend WithEvents btnToday As Button
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents pnlPatients As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblBirth As Label
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblRegistered As Label
    Friend WithEvents txtRegistered As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblEmergName As Label
    Friend WithEvents txtEmergName As TextBox
    Friend WithEvents lblEmergNum As Label
    Friend WithEvents txtEmergNum As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnArchive As Button
    Friend WithEvents pnlClinicalRecord As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblPatient As Label
    Friend WithEvents cboPatient As ComboBox
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabMedical As TabPage
    Friend WithEvents lblAllergies As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents lblMedications As Label
    Friend WithEvents txtMedications As TextBox
    Friend WithEvents lblConditions As Label
    Friend WithEvents txtConditions As TextBox
    Friend WithEvents lblSurgeries As Label
    Friend WithEvents txtSurgeries As TextBox
    Friend WithEvents lblFamilyHistory As Label
    Friend WithEvents txtFamilyHistory As TextBox
    Friend WithEvents lblOtherNotes As Label
    Friend WithEvents txtOtherNotes As TextBox
    Friend WithEvents btnSaveMedical As Button
    Friend WithEvents lblMedicalUpdated As Label
    Friend WithEvents tabVisits As TabPage
    Friend WithEvents dgvVisits As DataGridView
    Friend WithEvents grpVisit As GroupBox
    Friend WithEvents lblVisit As Label
    Friend WithEvents dtpVisit As DateTimePicker
    Friend WithEvents lblVisitDentist As Label
    Friend WithEvents cboVisitDentist As ComboBox
    Friend WithEvents lblNextVisit As Label
    Friend WithEvents dtpNextVisit As DateTimePicker
    Friend WithEvents lblComplaint As Label
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents lblDiagnosis As Label
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents lblClinicalNotes As Label
    Friend WithEvents txtClinicalNotes As TextBox
    Friend WithEvents lblRecommendations As Label
    Friend WithEvents txtRecommendations As TextBox
    Friend WithEvents btnNewVisit As Button
    Friend WithEvents btnSaveVisit As Button
    Friend WithEvents grpTreat As GroupBox
    Friend WithEvents lblTreatProcedure As Label
    Friend WithEvents cboTreatProcedure As ComboBox
    Friend WithEvents lblTreatTooth As Label
    Friend WithEvents txtTreatTooth As TextBox
    Friend WithEvents lblTreatQty As Label
    Friend WithEvents numTreatQty As NumericUpDown
    Friend WithEvents lblTreatPrice As Label
    Friend WithEvents numTreatPrice As NumericUpDown
    Friend WithEvents lblTreatDiscount As Label
    Friend WithEvents numTreatDiscount As NumericUpDown
    Friend WithEvents lblTreatStatus As Label
    Friend WithEvents cboTreatStatus As ComboBox
    Friend WithEvents btnAddTreatment As Button
    Friend WithEvents btnRemoveTreatment As Button
    Friend WithEvents dgvTreatments As DataGridView
    Friend WithEvents tabChart As TabPage
    Friend WithEvents dgvChart As DataGridView
    Friend WithEvents grpChart As GroupBox
    Friend WithEvents lblChartTooth As Label
    Friend WithEvents txtChartTooth As TextBox
    Friend WithEvents lblSurface As Label
    Friend WithEvents cboSurface As ComboBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents lblChartNotes As Label
    Friend WithEvents txtChartNotes As TextBox
    Friend WithEvents btnNewChart As Button
    Friend WithEvents btnSaveChart As Button
    Friend WithEvents btnDeleteChart As Button
    Friend WithEvents pnlProcedures As Panel
    Friend WithEvents pnlProcRight As Panel
    Friend WithEvents grpProcedure As GroupBox
    Friend WithEvents lblProcCode As Label
    Friend WithEvents txtProcCode As TextBox
    Friend WithEvents lblProcStatus As Label
    Friend WithEvents cboProcStatus As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents lblDuration As Label
    Friend WithEvents numDuration As NumericUpDown
    Friend WithEvents btnNewProcedure As Button
    Friend WithEvents btnSaveProcedure As Button
    Friend WithEvents pnlProcLeft As Panel
    Friend WithEvents dgvProcedures As DataGridView
    Friend WithEvents pnlAuditlog As Panel
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents pnlStaff As Panel
    Friend WithEvents pnlStaffRight As Panel
    Friend WithEvents grpStaff As GroupBox
    Friend WithEvents lblStaffCode As Label
    Friend WithEvents txtStaffCode As TextBox
    Friend WithEvents lblStaffStatus As Label
    Friend WithEvents cboStaffStatus As ComboBox
    Friend WithEvents lblStaffFirstName As Label
    Friend WithEvents txtStaffFirstName As TextBox
    Friend WithEvents lblStaffLastName As Label
    Friend WithEvents txtStaffLastName As TextBox
    Friend WithEvents lblStaffContact As Label
    Friend WithEvents txtStaffContact As TextBox
    Friend WithEvents lblStaffEmail As Label
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents lblLicense As Label
    Friend WithEvents txtLicense As TextBox
    Friend WithEvents btnNewStaff As Button
    Friend WithEvents btnSaveStaff As Button
    Friend WithEvents grpUsers As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnToggleActive As Button
    Friend WithEvents pnlStaffLeft As Panel
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents pnlBillingpayments As Panel
    Friend WithEvents pnlInvoiceRight As Panel
    Friend WithEvents grpInvoice As GroupBox
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents lblInvoiceStatus As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents numDiscount As NumericUpDown
    Friend WithEvents lblInvoicePatient As Label
    Friend WithEvents cboInvoicePatient As ComboBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents btnNewInvoice As Button
    Friend WithEvents btnSaveInvoice As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents grpItems As GroupBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents cboProcedure As ComboBox
    Friend WithEvents lblItemDesc As Label
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents numUnitPrice As NumericUpDown
    Friend WithEvents lblItemDiscount As Label
    Friend WithEvents numItemDiscount As NumericUpDown
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents grpPayments As GroupBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents cboMethod As ComboBox
    Friend WithEvents lblPayAmount As Label
    Friend WithEvents numPayAmount As NumericUpDown
    Friend WithEvents lblPayNotes As Label
    Friend WithEvents txtPayNotes As TextBox
    Friend WithEvents btnReceive As Button
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents pnlInvoiceLeft As Panel
    Friend WithEvents cboStatusFilter As ComboBox
    Friend WithEvents dgvInvoices As DataGridView
End Class
