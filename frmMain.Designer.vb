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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.pnlCardTodayCaption = New System.Windows.Forms.Label()
        Me.lblTodayCount = New System.Windows.Forms.Label()
        Me.pnlCardPending = New System.Windows.Forms.Panel()
        Me.pnlCardPendingCaption = New System.Windows.Forms.Label()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.pnlCardUnpaid = New System.Windows.Forms.Panel()
        Me.pnlCardUnpaidCaption = New System.Windows.Forms.Label()
        Me.lblUnpaidCount = New System.Windows.Forms.Label()
        Me.lblUnpaidAmount = New System.Windows.Forms.Label()
        Me.pnlCardLow = New System.Windows.Forms.Panel()
        Me.pnlCardLowCaption = New System.Windows.Forms.Label()
        Me.lblLowStockCount = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvToday = New System.Windows.Forms.DataGridView()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.pnlProdRight = New System.Windows.Forms.Panel()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.numReorder = New System.Windows.Forms.NumericUpDown()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.numCost = New System.Windows.Forms.NumericUpDown()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cboProdStatus = New System.Windows.Forms.ComboBox()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.grpStock = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboTxType = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.numTxQty = New System.Windows.Forms.NumericUpDown()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtTxRef = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtTxNotes = New System.Windows.Forms.TextBox()
        Me.btnPostStock = New System.Windows.Forms.Button()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.pnlProdLeft = New System.Windows.Forms.Panel()
        Me.chkLowStock = New System.Windows.Forms.CheckBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.tabSuppliers = New System.Windows.Forms.TabPage()
        Me.pnlSupRight = New System.Windows.Forms.Panel()
        Me.grpSupplier = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cboSupStatus = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtSupContact = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtSupPhone = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtSupEmail = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtSupAddress = New System.Windows.Forms.TextBox()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.pnlSupLeft = New System.Windows.Forms.Panel()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.pnlAppointment = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.cboDentist = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCancelAppt = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtRegistered = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtEmergName = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtEmergNum = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.pnlClinicalRecord = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPatient = New System.Windows.Forms.ComboBox()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabMedical = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMedications = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConditions = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSurgeries = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFamilyHistory = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOtherNotes = New System.Windows.Forms.TextBox()
        Me.btnSaveMedical = New System.Windows.Forms.Button()
        Me.lblMedicalUpdated = New System.Windows.Forms.Label()
        Me.tabVisits = New System.Windows.Forms.TabPage()
        Me.dgvVisits = New System.Windows.Forms.DataGridView()
        Me.grpVisit = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.dtpVisit = New System.Windows.Forms.DateTimePicker()
        Me.label10 = New System.Windows.Forms.Label()
        Me.cboVisitDentist = New System.Windows.Forms.ComboBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.dtpNextVisit = New System.Windows.Forms.DateTimePicker()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtComplaint = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtClinicalNotes = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.txtRecommendations = New System.Windows.Forms.TextBox()
        Me.btnNewVisit = New System.Windows.Forms.Button()
        Me.btnSaveVisit = New System.Windows.Forms.Button()
        Me.grpTreat = New System.Windows.Forms.GroupBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.cboTreatProcedure = New System.Windows.Forms.ComboBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txtTreatTooth = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.numTreatQty = New System.Windows.Forms.NumericUpDown()
        Me.label19 = New System.Windows.Forms.Label()
        Me.numTreatPrice = New System.Windows.Forms.NumericUpDown()
        Me.label20 = New System.Windows.Forms.Label()
        Me.numTreatDiscount = New System.Windows.Forms.NumericUpDown()
        Me.label21 = New System.Windows.Forms.Label()
        Me.cboTreatStatus = New System.Windows.Forms.ComboBox()
        Me.btnAddTreatment = New System.Windows.Forms.Button()
        Me.btnRemoveTreatment = New System.Windows.Forms.Button()
        Me.dgvTreatments = New System.Windows.Forms.DataGridView()
        Me.tabChart = New System.Windows.Forms.TabPage()
        Me.dgvChart = New System.Windows.Forms.DataGridView()
        Me.grpChart = New System.Windows.Forms.GroupBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.txtChartTooth = New System.Windows.Forms.TextBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.cboSurface = New System.Windows.Forms.ComboBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.txtChartNotes = New System.Windows.Forms.TextBox()
        Me.btnNewChart = New System.Windows.Forms.Button()
        Me.btnSaveChart = New System.Windows.Forms.Button()
        Me.btnDeleteChart = New System.Windows.Forms.Button()
        Me.pnlProcedures = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.numDuration = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvProcedures = New System.Windows.Forms.DataGridView()
        Me.pnlAuditlog = New System.Windows.Forms.Panel()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.pnlStaff = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnSaveStaff = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.GroupBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.btnToggleActive = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.pnlBillingpayments = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.numDiscount = New System.Windows.Forms.NumericUpDown()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.btnNewInvoice = New System.Windows.Forms.Button()
        Me.btnSaveInvoice = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.cboProcedure = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.numUnitPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.numItemDiscount = New System.Windows.Forms.NumericUpDown()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.grpPayments = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cboMethod = New System.Windows.Forms.ComboBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.numPayAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtPayNotes = New System.Windows.Forms.TextBox()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.dgvInvoices = New System.Windows.Forms.DataGridView()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlCardToday.SuspendLayout()
        Me.pnlCardPending.SuspendLayout()
        Me.pnlCardUnpaid.SuspendLayout()
        Me.pnlCardLow.SuspendLayout()
        CType(Me.dgvToday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        Me.TabControl1.SuspendLayout()
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
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAuditlog.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaff.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.grpStaff.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBillingpayments.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.PictureBox1)
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(35, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.pnlDashboard.Controls.Add(Me.label1)
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
        Me.pnlCardToday.Controls.Add(Me.pnlCardTodayCaption)
        Me.pnlCardToday.Controls.Add(Me.lblTodayCount)
        Me.pnlCardToday.Location = New System.Drawing.Point(34, 30)
        Me.pnlCardToday.Name = "pnlCardToday"
        Me.pnlCardToday.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardToday.TabIndex = 17
        '
        'pnlCardTodayCaption
        '
        Me.pnlCardTodayCaption.AutoSize = True
        Me.pnlCardTodayCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlCardTodayCaption.Location = New System.Drawing.Point(14, 12)
        Me.pnlCardTodayCaption.Name = "pnlCardTodayCaption"
        Me.pnlCardTodayCaption.Size = New System.Drawing.Size(100, 13)
        Me.pnlCardTodayCaption.TabIndex = 2
        Me.pnlCardTodayCaption.Text = "Appointments today"
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
        Me.pnlCardPending.Controls.Add(Me.pnlCardPendingCaption)
        Me.pnlCardPending.Controls.Add(Me.lblPendingCount)
        Me.pnlCardPending.Location = New System.Drawing.Point(278, 30)
        Me.pnlCardPending.Name = "pnlCardPending"
        Me.pnlCardPending.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardPending.TabIndex = 18
        '
        'pnlCardPendingCaption
        '
        Me.pnlCardPendingCaption.AutoSize = True
        Me.pnlCardPendingCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlCardPendingCaption.Location = New System.Drawing.Point(14, 12)
        Me.pnlCardPendingCaption.Name = "pnlCardPendingCaption"
        Me.pnlCardPendingCaption.Size = New System.Drawing.Size(106, 13)
        Me.pnlCardPendingCaption.TabIndex = 5
        Me.pnlCardPendingCaption.Text = "Pending confirmation"
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
        Me.pnlCardUnpaid.Controls.Add(Me.pnlCardUnpaidCaption)
        Me.pnlCardUnpaid.Controls.Add(Me.lblUnpaidCount)
        Me.pnlCardUnpaid.Controls.Add(Me.lblUnpaidAmount)
        Me.pnlCardUnpaid.Location = New System.Drawing.Point(522, 30)
        Me.pnlCardUnpaid.Name = "pnlCardUnpaid"
        Me.pnlCardUnpaid.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardUnpaid.TabIndex = 19
        '
        'pnlCardUnpaidCaption
        '
        Me.pnlCardUnpaidCaption.AutoSize = True
        Me.pnlCardUnpaidCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlCardUnpaidCaption.Location = New System.Drawing.Point(14, 12)
        Me.pnlCardUnpaidCaption.Name = "pnlCardUnpaidCaption"
        Me.pnlCardUnpaidCaption.Size = New System.Drawing.Size(83, 13)
        Me.pnlCardUnpaidCaption.TabIndex = 8
        Me.pnlCardUnpaidCaption.Text = "Unpaid invoices"
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
        Me.pnlCardLow.Controls.Add(Me.pnlCardLowCaption)
        Me.pnlCardLow.Controls.Add(Me.lblLowStockCount)
        Me.pnlCardLow.Location = New System.Drawing.Point(766, 30)
        Me.pnlCardLow.Name = "pnlCardLow"
        Me.pnlCardLow.Size = New System.Drawing.Size(236, 100)
        Me.pnlCardLow.TabIndex = 20
        '
        'pnlCardLowCaption
        '
        Me.pnlCardLowCaption.AutoSize = True
        Me.pnlCardLowCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlCardLowCaption.Location = New System.Drawing.Point(14, 12)
        Me.pnlCardLowCaption.Name = "pnlCardLowCaption"
        Me.pnlCardLowCaption.Size = New System.Drawing.Size(100, 13)
        Me.pnlCardLowCaption.TabIndex = 11
        Me.pnlCardLowCaption.Text = "Low-stock products"
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(34, 146)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(163, 20)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Today's appointments"
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
        Me.pnlInventory.Controls.Add(Me.TabControl1)
        Me.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventory.Location = New System.Drawing.Point(220, 56)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlInventory.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlInventory.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabSuppliers)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1680, 1004)
        Me.TabControl1.TabIndex = 2
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
        Me.grpProduct.Controls.Add(Me.Label34)
        Me.grpProduct.Controls.Add(Me.txtProdCode)
        Me.grpProduct.Controls.Add(Me.Label35)
        Me.grpProduct.Controls.Add(Me.txtProdName)
        Me.grpProduct.Controls.Add(Me.Label36)
        Me.grpProduct.Controls.Add(Me.cboCategory)
        Me.grpProduct.Controls.Add(Me.Label37)
        Me.grpProduct.Controls.Add(Me.txtUnit)
        Me.grpProduct.Controls.Add(Me.Label38)
        Me.grpProduct.Controls.Add(Me.numReorder)
        Me.grpProduct.Controls.Add(Me.Label39)
        Me.grpProduct.Controls.Add(Me.numCost)
        Me.grpProduct.Controls.Add(Me.Label40)
        Me.grpProduct.Controls.Add(Me.txtStock)
        Me.grpProduct.Controls.Add(Me.Label41)
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
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(14, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 13)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Product code (blank = auto)"
        '
        'txtProdCode
        '
        Me.txtProdCode.Location = New System.Drawing.Point(14, 44)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(225, 20)
        Me.txtProdCode.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(254, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Product name *"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(254, 44)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(225, 20)
        Me.txtProdName.TabIndex = 13
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(14, 80)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 14
        Me.Label36.Text = "Category *"
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
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(254, 80)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(118, 13)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Unit * (pc, box, bottle...)"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(254, 100)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(225, 20)
        Me.txtUnit.TabIndex = 17
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(14, 136)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 13)
        Me.Label38.TabIndex = 18
        Me.Label38.Text = "Reorder level"
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
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(254, 136)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(65, 13)
        Me.Label39.TabIndex = 20
        Me.Label39.Text = "Unit cost (₱)"
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
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(14, 192)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(197, 13)
        Me.Label40.TabIndex = 22
        Me.Label40.Text = "Current stock (changes via transactions)"
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
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(254, 192)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(37, 13)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Status"
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
        Me.grpStock.Controls.Add(Me.Label26)
        Me.grpStock.Controls.Add(Me.cboTxType)
        Me.grpStock.Controls.Add(Me.Label27)
        Me.grpStock.Controls.Add(Me.numTxQty)
        Me.grpStock.Controls.Add(Me.Label42)
        Me.grpStock.Controls.Add(Me.txtTxRef)
        Me.grpStock.Controls.Add(Me.Label43)
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
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(14, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Type"
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(254, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(46, 13)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Quantity"
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
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(14, 80)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(144, 13)
        Me.Label42.TabIndex = 33
        Me.Label42.Text = "Reference (PO / invoice no.)"
        '
        'txtTxRef
        '
        Me.txtTxRef.Location = New System.Drawing.Point(14, 100)
        Me.txtTxRef.Name = "txtTxRef"
        Me.txtTxRef.Size = New System.Drawing.Size(225, 20)
        Me.txtTxRef.TabIndex = 34
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(254, 80)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(35, 13)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "Notes"
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
        Me.grpSupplier.Controls.Add(Me.Label28)
        Me.grpSupplier.Controls.Add(Me.txtSupName)
        Me.grpSupplier.Controls.Add(Me.Label29)
        Me.grpSupplier.Controls.Add(Me.cboSupStatus)
        Me.grpSupplier.Controls.Add(Me.Label30)
        Me.grpSupplier.Controls.Add(Me.txtSupContact)
        Me.grpSupplier.Controls.Add(Me.Label31)
        Me.grpSupplier.Controls.Add(Me.txtSupPhone)
        Me.grpSupplier.Controls.Add(Me.Label32)
        Me.grpSupplier.Controls.Add(Me.txtSupEmail)
        Me.grpSupplier.Controls.Add(Me.Label33)
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
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(14, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 13)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Supplier name *"
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(14, 44)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(225, 20)
        Me.txtSupName.TabIndex = 45
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(254, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 13)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Status"
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
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(14, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(79, 13)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "Contact person"
        '
        'txtSupContact
        '
        Me.txtSupContact.Location = New System.Drawing.Point(14, 100)
        Me.txtSupContact.Name = "txtSupContact"
        Me.txtSupContact.Size = New System.Drawing.Size(225, 20)
        Me.txtSupContact.TabIndex = 49
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(254, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 13)
        Me.Label31.TabIndex = 50
        Me.Label31.Text = "Contact number"
        '
        'txtSupPhone
        '
        Me.txtSupPhone.Location = New System.Drawing.Point(254, 100)
        Me.txtSupPhone.Name = "txtSupPhone"
        Me.txtSupPhone.Size = New System.Drawing.Size(225, 20)
        Me.txtSupPhone.TabIndex = 51
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(14, 136)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 13)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Email"
        '
        'txtSupEmail
        '
        Me.txtSupEmail.Location = New System.Drawing.Point(14, 156)
        Me.txtSupEmail.Name = "txtSupEmail"
        Me.txtSupEmail.Size = New System.Drawing.Size(465, 20)
        Me.txtSupEmail.TabIndex = 53
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(14, 192)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 54
        Me.Label33.Text = "Address"
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
        Me.pnlAppointment.Controls.Add(Me.Panel4)
        Me.pnlAppointment.Controls.Add(Me.Panel3)
        Me.pnlAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAppointment.Location = New System.Drawing.Point(220, 56)
        Me.pnlAppointment.Name = "pnlAppointment"
        Me.pnlAppointment.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlAppointment.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlAppointment.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.btnCancelAppt)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(610, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1080, 1004)
        Me.Panel4.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label69)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label71)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label72)
        Me.GroupBox1.Controls.Add(Me.cboDentist)
        Me.GroupBox1.Controls.Add(Me.Label73)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label74)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.Label75)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label76)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label77)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Controls.Add(Me.Label78)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1454, 420)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment details"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label69.Location = New System.Drawing.Point(14, 24)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(93, 13)
        Me.Label69.TabIndex = 10
        Me.Label69.Text = "Appointment code"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(14, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(225, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(254, 24)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(37, 13)
        Me.Label70.TabIndex = 12
        Me.Label70.Text = "Status"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled", "No-show"})
        Me.ComboBox2.Location = New System.Drawing.Point(254, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(14, 80)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(47, 13)
        Me.Label71.TabIndex = 14
        Me.Label71.Text = "Patient *"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(14, 100)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox3.TabIndex = 15
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label72.Location = New System.Drawing.Point(254, 80)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(47, 13)
        Me.Label72.TabIndex = 16
        Me.Label72.Text = "Dentist *"
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
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label73.Location = New System.Drawing.Point(14, 136)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(37, 13)
        Me.Label73.TabIndex = 18
        Me.Label73.Text = "Date *"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(14, 156)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(225, 20)
        Me.dtpDate.TabIndex = 19
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label74.Location = New System.Drawing.Point(254, 136)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(96, 13)
        Me.Label74.TabIndex = 20
        Me.Label74.Text = "Appointment type *"
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
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label75.Location = New System.Drawing.Point(14, 192)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(58, 13)
        Me.Label75.TabIndex = 22
        Me.Label75.Text = "Start time *"
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
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label76.Location = New System.Drawing.Point(254, 192)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(48, 13)
        Me.Label76.TabIndex = 24
        Me.Label76.Text = "End time"
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
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label77.Location = New System.Drawing.Point(14, 248)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(44, 13)
        Me.Label77.TabIndex = 26
        Me.Label77.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(14, 268)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(465, 20)
        Me.txtReason.TabIndex = 27
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label78.Location = New System.Drawing.Point(14, 304)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(35, 13)
        Me.Label78.TabIndex = 28
        Me.Label78.Text = "Notes"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(8, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 36)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "New Appointment"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(166, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 36)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel3.Controls.Add(Me.dtpFilterDate)
        Me.Panel3.Controls.Add(Me.chkAllDates)
        Me.Panel3.Controls.Add(Me.cboFilterStatus)
        Me.Panel3.Controls.Add(Me.btnToday)
        Me.Panel3.Controls.Add(Me.dgvAppointments)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 1004)
        Me.Panel3.TabIndex = 4
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
        Me.grpDetails.Controls.Add(Me.Label44)
        Me.grpDetails.Controls.Add(Me.txtCode)
        Me.grpDetails.Controls.Add(Me.Label45)
        Me.grpDetails.Controls.Add(Me.cboStatus)
        Me.grpDetails.Controls.Add(Me.Label46)
        Me.grpDetails.Controls.Add(Me.txtFirstName)
        Me.grpDetails.Controls.Add(Me.Label47)
        Me.grpDetails.Controls.Add(Me.txtMiddleName)
        Me.grpDetails.Controls.Add(Me.Label48)
        Me.grpDetails.Controls.Add(Me.txtLastName)
        Me.grpDetails.Controls.Add(Me.Label49)
        Me.grpDetails.Controls.Add(Me.dtpBirth)
        Me.grpDetails.Controls.Add(Me.Label50)
        Me.grpDetails.Controls.Add(Me.cboGender)
        Me.grpDetails.Controls.Add(Me.Label51)
        Me.grpDetails.Controls.Add(Me.txtContact)
        Me.grpDetails.Controls.Add(Me.Label52)
        Me.grpDetails.Controls.Add(Me.txtEmail)
        Me.grpDetails.Controls.Add(Me.Label53)
        Me.grpDetails.Controls.Add(Me.txtRegistered)
        Me.grpDetails.Controls.Add(Me.Label54)
        Me.grpDetails.Controls.Add(Me.txtAddress)
        Me.grpDetails.Controls.Add(Me.Label55)
        Me.grpDetails.Controls.Add(Me.txtEmergName)
        Me.grpDetails.Controls.Add(Me.Label56)
        Me.grpDetails.Controls.Add(Me.txtEmergNum)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpDetails.Location = New System.Drawing.Point(476, 9)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(1980, 430)
        Me.grpDetails.TabIndex = 6
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Patient details"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(14, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(67, 13)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "Patient code"
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
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(254, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(37, 13)
        Me.Label45.TabIndex = 9
        Me.Label45.Text = "Status"
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
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(14, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(62, 13)
        Me.Label46.TabIndex = 11
        Me.Label46.Text = "First name *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(14, 100)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(225, 20)
        Me.txtFirstName.TabIndex = 12
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(254, 80)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(67, 13)
        Me.Label47.TabIndex = 13
        Me.Label47.Text = "Middle name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(254, 100)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(225, 20)
        Me.txtMiddleName.TabIndex = 14
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(14, 136)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(63, 13)
        Me.Label48.TabIndex = 15
        Me.Label48.Text = "Last name *"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(14, 156)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(225, 20)
        Me.txtLastName.TabIndex = 16
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(254, 136)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(52, 13)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "Birth date"
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
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(14, 192)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(42, 13)
        Me.Label50.TabIndex = 19
        Me.Label50.Text = "Gender"
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
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(254, 192)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(82, 13)
        Me.Label51.TabIndex = 21
        Me.Label51.Text = "Contact number"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(254, 212)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(225, 20)
        Me.txtContact.TabIndex = 22
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(14, 248)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(32, 13)
        Me.Label52.TabIndex = 23
        Me.Label52.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(14, 268)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 24
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(254, 248)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(73, 13)
        Me.Label53.TabIndex = 25
        Me.Label53.Text = "Registered on"
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
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(14, 304)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(45, 13)
        Me.Label54.TabIndex = 27
        Me.Label54.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(14, 324)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(465, 20)
        Me.txtAddress.TabIndex = 28
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(14, 360)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(128, 13)
        Me.Label55.TabIndex = 29
        Me.Label55.Text = "Emergency contact name"
        '
        'txtEmergName
        '
        Me.txtEmergName.Location = New System.Drawing.Point(14, 380)
        Me.txtEmergName.Name = "txtEmergName"
        Me.txtEmergName.Size = New System.Drawing.Size(225, 20)
        Me.txtEmergName.TabIndex = 30
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(254, 360)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(137, 13)
        Me.Label56.TabIndex = 31
        Me.Label56.Text = "Emergency contact number"
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
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.cboPatient)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(10, 10)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1680, 52)
        Me.pnlTop.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patient"
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
        Me.tabMedical.Controls.Add(Me.Label3)
        Me.tabMedical.Controls.Add(Me.txtAllergies)
        Me.tabMedical.Controls.Add(Me.Label4)
        Me.tabMedical.Controls.Add(Me.txtMedications)
        Me.tabMedical.Controls.Add(Me.Label5)
        Me.tabMedical.Controls.Add(Me.txtConditions)
        Me.tabMedical.Controls.Add(Me.Label6)
        Me.tabMedical.Controls.Add(Me.txtSurgeries)
        Me.tabMedical.Controls.Add(Me.Label7)
        Me.tabMedical.Controls.Add(Me.txtFamilyHistory)
        Me.tabMedical.Controls.Add(Me.Label8)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Allergies"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(480, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Current medications"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Medical conditions"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(480, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Previous surgeries"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Family medical history"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(480, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Other notes"
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
        Me.grpVisit.Controls.Add(Me.label9)
        Me.grpVisit.Controls.Add(Me.dtpVisit)
        Me.grpVisit.Controls.Add(Me.label10)
        Me.grpVisit.Controls.Add(Me.cboVisitDentist)
        Me.grpVisit.Controls.Add(Me.label11)
        Me.grpVisit.Controls.Add(Me.dtpNextVisit)
        Me.grpVisit.Controls.Add(Me.label12)
        Me.grpVisit.Controls.Add(Me.txtComplaint)
        Me.grpVisit.Controls.Add(Me.label13)
        Me.grpVisit.Controls.Add(Me.txtDiagnosis)
        Me.grpVisit.Controls.Add(Me.label14)
        Me.grpVisit.Controls.Add(Me.txtClinicalNotes)
        Me.grpVisit.Controls.Add(Me.label15)
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
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(14, 22)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(75, 13)
        Me.label9.TabIndex = 24
        Me.label9.Text = "Visit date & time"
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
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(214, 22)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(47, 13)
        Me.label10.TabIndex = 26
        Me.label10.Text = "Dentist *"
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
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(424, 22)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(50, 13)
        Me.label11.TabIndex = 28
        Me.label11.Text = "Next visit"
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
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(14, 76)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(79, 13)
        Me.label12.TabIndex = 30
        Me.label12.Text = "Chief complaint"
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
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(306, 76)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(53, 13)
        Me.label13.TabIndex = 32
        Me.label13.Text = "Diagnosis"
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
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label14.Location = New System.Drawing.Point(14, 150)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(69, 13)
        Me.label14.TabIndex = 34
        Me.label14.Text = "Clinical notes"
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
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label15.Location = New System.Drawing.Point(306, 150)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(95, 13)
        Me.label15.TabIndex = 36
        Me.label15.Text = "Recommendations"
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
        Me.grpTreat.Controls.Add(Me.label16)
        Me.grpTreat.Controls.Add(Me.cboTreatProcedure)
        Me.grpTreat.Controls.Add(Me.label17)
        Me.grpTreat.Controls.Add(Me.txtTreatTooth)
        Me.grpTreat.Controls.Add(Me.label18)
        Me.grpTreat.Controls.Add(Me.numTreatQty)
        Me.grpTreat.Controls.Add(Me.label19)
        Me.grpTreat.Controls.Add(Me.numTreatPrice)
        Me.grpTreat.Controls.Add(Me.label20)
        Me.grpTreat.Controls.Add(Me.numTreatDiscount)
        Me.grpTreat.Controls.Add(Me.label21)
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
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label16.Location = New System.Drawing.Point(14, 22)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(63, 13)
        Me.label16.TabIndex = 41
        Me.label16.Text = "Procedure *"
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
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label17.Location = New System.Drawing.Point(252, 22)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(35, 13)
        Me.label17.TabIndex = 43
        Me.label17.Text = "Tooth"
        '
        'txtTreatTooth
        '
        Me.txtTreatTooth.Location = New System.Drawing.Point(252, 42)
        Me.txtTreatTooth.Name = "txtTreatTooth"
        Me.txtTreatTooth.Size = New System.Drawing.Size(70, 20)
        Me.txtTreatTooth.TabIndex = 44
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label18.Location = New System.Drawing.Point(330, 22)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(23, 13)
        Me.label18.TabIndex = 45
        Me.label18.Text = "Qty"
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
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label19.Location = New System.Drawing.Point(398, 22)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(52, 13)
        Me.label19.TabIndex = 47
        Me.label19.Text = "Unit price"
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
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label20.Location = New System.Drawing.Point(496, 22)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(49, 13)
        Me.label20.TabIndex = 49
        Me.label20.Text = "Discount"
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
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label21.Location = New System.Drawing.Point(14, 76)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(37, 13)
        Me.label21.TabIndex = 51
        Me.label21.Text = "Status"
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
        Me.grpChart.Controls.Add(Me.label22)
        Me.grpChart.Controls.Add(Me.txtChartTooth)
        Me.grpChart.Controls.Add(Me.label23)
        Me.grpChart.Controls.Add(Me.cboSurface)
        Me.grpChart.Controls.Add(Me.label24)
        Me.grpChart.Controls.Add(Me.cboCondition)
        Me.grpChart.Controls.Add(Me.label25)
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
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label22.Location = New System.Drawing.Point(14, 22)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(80, 13)
        Me.label22.TabIndex = 58
        Me.label22.Text = "Tooth number *"
        '
        'txtChartTooth
        '
        Me.txtChartTooth.Location = New System.Drawing.Point(14, 42)
        Me.txtChartTooth.Name = "txtChartTooth"
        Me.txtChartTooth.Size = New System.Drawing.Size(110, 20)
        Me.txtChartTooth.TabIndex = 59
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label23.Location = New System.Drawing.Point(134, 22)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(44, 13)
        Me.label23.TabIndex = 60
        Me.label23.Text = "Surface"
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
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label24.Location = New System.Drawing.Point(14, 76)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(51, 13)
        Me.label24.TabIndex = 62
        Me.label24.Text = "Condition"
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
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.label25.Location = New System.Drawing.Point(14, 130)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(35, 13)
        Me.label25.TabIndex = 64
        Me.label25.Text = "Notes"
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
        Me.pnlProcedures.Controls.Add(Me.Panel6)
        Me.pnlProcedures.Controls.Add(Me.Panel5)
        Me.pnlProcedures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProcedures.Location = New System.Drawing.Point(220, 56)
        Me.pnlProcedures.Name = "pnlProcedures"
        Me.pnlProcedures.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlProcedures.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlProcedures.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(480, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1210, 1004)
        Me.Panel6.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label79)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label80)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Label81)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label82)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.Label83)
        Me.GroupBox2.Controls.Add(Me.numPrice)
        Me.GroupBox2.Controls.Add(Me.Label84)
        Me.GroupBox2.Controls.Add(Me.numDuration)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1510, 330)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Procedure details"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label79.Location = New System.Drawing.Point(14, 24)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(90, 13)
        Me.Label79.TabIndex = 6
        Me.Label79.Text = "Procedure code *"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(14, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label80.Location = New System.Drawing.Point(254, 24)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(37, 13)
        Me.Label80.TabIndex = 8
        Me.Label80.Text = "Status"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.ComboBox4.Location = New System.Drawing.Point(254, 44)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox4.TabIndex = 9
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label81.Location = New System.Drawing.Point(14, 80)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(92, 13)
        Me.Label81.TabIndex = 10
        Me.Label81.Text = "Procedure name *"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(14, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(465, 20)
        Me.txtName.TabIndex = 11
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label82.Location = New System.Drawing.Point(14, 136)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(60, 13)
        Me.Label82.TabIndex = 12
        Me.Label82.Text = "Description"
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
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label83.Location = New System.Drawing.Point(14, 232)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(99, 13)
        Me.Label83.TabIndex = 14
        Me.Label83.Text = "Standard price (₱) *"
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
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label84.Location = New System.Drawing.Point(254, 232)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(187, 13)
        Me.Label84.TabIndex = 16
        Me.Label84.Text = "Estimated duration (minutes, 0 = none)"
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(8, 350)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 36)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "New Procedure"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(156, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 36)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel5.Controls.Add(Me.dgvProcedures)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(10, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(470, 1004)
        Me.Panel5.TabIndex = 4
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
        Me.pnlAuditlog.Controls.Add(Me.Label85)
        Me.pnlAuditlog.Controls.Add(Me.dtpFrom)
        Me.pnlAuditlog.Controls.Add(Me.Label86)
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
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label85.Location = New System.Drawing.Point(23, 10)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(30, 13)
        Me.Label85.TabIndex = 9
        Me.Label85.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(65, 6)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(120, 20)
        Me.dtpFrom.TabIndex = 10
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label86.Location = New System.Drawing.Point(197, 10)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(20, 13)
        Me.Label86.TabIndex = 11
        Me.Label86.Text = "To"
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
        Me.pnlStaff.Controls.Add(Me.Panel9)
        Me.pnlStaff.Controls.Add(Me.Panel8)
        Me.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStaff.Location = New System.Drawing.Point(220, 56)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStaff.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlStaff.TabIndex = 28
        '
        'Panel9
        '
        Me.Panel9.AutoScroll = True
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel9.Controls.Add(Me.grpStaff)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(480, 10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1210, 1004)
        Me.Panel9.TabIndex = 3
        '
        'grpStaff
        '
        Me.grpStaff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStaff.Controls.Add(Me.Label87)
        Me.grpStaff.Controls.Add(Me.TextBox3)
        Me.grpStaff.Controls.Add(Me.Label88)
        Me.grpStaff.Controls.Add(Me.ComboBox5)
        Me.grpStaff.Controls.Add(Me.Label89)
        Me.grpStaff.Controls.Add(Me.TextBox4)
        Me.grpStaff.Controls.Add(Me.Label90)
        Me.grpStaff.Controls.Add(Me.TextBox5)
        Me.grpStaff.Controls.Add(Me.Label91)
        Me.grpStaff.Controls.Add(Me.TextBox6)
        Me.grpStaff.Controls.Add(Me.Label92)
        Me.grpStaff.Controls.Add(Me.TextBox7)
        Me.grpStaff.Controls.Add(Me.Label93)
        Me.grpStaff.Controls.Add(Me.cboPosition)
        Me.grpStaff.Controls.Add(Me.Label94)
        Me.grpStaff.Controls.Add(Me.txtLicense)
        Me.grpStaff.Controls.Add(Me.Button5)
        Me.grpStaff.Controls.Add(Me.btnSaveStaff)
        Me.grpStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.grpStaff.Location = New System.Drawing.Point(8, 8)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(1527, 300)
        Me.grpStaff.TabIndex = 5
        Me.grpStaff.TabStop = False
        Me.grpStaff.Text = "Staff member"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label87.Location = New System.Drawing.Point(14, 24)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(124, 13)
        Me.Label87.TabIndex = 6
        Me.Label87.Text = "Staff code (blank = auto)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label88.Location = New System.Drawing.Point(254, 24)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(37, 13)
        Me.Label88.TabIndex = 8
        Me.Label88.Text = "Status"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Active", "Inactive", "Suspended"})
        Me.ComboBox5.Location = New System.Drawing.Point(254, 44)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox5.TabIndex = 9
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label89.Location = New System.Drawing.Point(14, 80)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(62, 13)
        Me.Label89.TabIndex = 10
        Me.Label89.Text = "First name *"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(14, 100)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label90.Location = New System.Drawing.Point(254, 80)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(63, 13)
        Me.Label90.TabIndex = 12
        Me.Label90.Text = "Last name *"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(254, 100)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(225, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label91.Location = New System.Drawing.Point(14, 136)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(82, 13)
        Me.Label91.TabIndex = 14
        Me.Label91.Text = "Contact number"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(14, 156)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(225, 20)
        Me.TextBox6.TabIndex = 15
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label92.Location = New System.Drawing.Point(254, 136)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(32, 13)
        Me.Label92.TabIndex = 16
        Me.Label92.Text = "Email"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(254, 156)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(225, 20)
        Me.TextBox7.TabIndex = 17
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label93.Location = New System.Drawing.Point(14, 192)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(51, 13)
        Me.Label93.TabIndex = 18
        Me.Label93.Text = "Position *"
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
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label94.Location = New System.Drawing.Point(254, 192)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(82, 13)
        Me.Label94.TabIndex = 20
        Me.Label94.Text = "License number"
        '
        'txtLicense
        '
        Me.txtLicense.Location = New System.Drawing.Point(254, 212)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(225, 20)
        Me.txtLicense.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(14, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 32)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "New Staff"
        Me.Button5.UseVisualStyleBackColor = False
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
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.Controls.Add(Me.dgvUsers)
        Me.Panel10.Controls.Add(Me.btnResetPassword)
        Me.Panel10.Controls.Add(Me.btnToggleActive)
        Me.Panel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(8, 318)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1527, 220)
        Me.Panel10.TabIndex = 24
        Me.Panel10.TabStop = False
        Me.Panel10.Text = "Login accounts (Administrator and Front Desk)"
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel8.Controls.Add(Me.dgvStaff)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(10, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(470, 1004)
        Me.Panel8.TabIndex = 4
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
        Me.pnlBillingpayments.Controls.Add(Me.Panel2)
        Me.pnlBillingpayments.Controls.Add(Me.Panel1)
        Me.pnlBillingpayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillingpayments.Location = New System.Drawing.Point(220, 56)
        Me.pnlBillingpayments.Name = "pnlBillingpayments"
        Me.pnlBillingpayments.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBillingpayments.Size = New System.Drawing.Size(1700, 1024)
        Me.pnlBillingpayments.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel2.Controls.Add(Me.grpInvoice)
        Me.Panel2.Controls.Add(Me.grpItems)
        Me.Panel2.Controls.Add(Me.grpPayments)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(480, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1210, 1004)
        Me.Panel2.TabIndex = 3
        '
        'grpInvoice
        '
        Me.grpInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInvoice.Controls.Add(Me.Label65)
        Me.grpInvoice.Controls.Add(Me.txtInvoiceNo)
        Me.grpInvoice.Controls.Add(Me.Label66)
        Me.grpInvoice.Controls.Add(Me.txtStatus)
        Me.grpInvoice.Controls.Add(Me.Label67)
        Me.grpInvoice.Controls.Add(Me.numDiscount)
        Me.grpInvoice.Controls.Add(Me.Label68)
        Me.grpInvoice.Controls.Add(Me.ComboBox1)
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
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label65.Location = New System.Drawing.Point(14, 22)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(60, 13)
        Me.Label65.TabIndex = 7
        Me.Label65.Text = "Invoice no."
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
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label66.Location = New System.Drawing.Point(154, 22)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(37, 13)
        Me.Label66.TabIndex = 9
        Me.Label66.Text = "Status"
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
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(274, 22)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(65, 13)
        Me.Label67.TabIndex = 11
        Me.Label67.Text = "Discount (₱)"
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
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label68.Location = New System.Drawing.Point(14, 76)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(47, 13)
        Me.Label68.TabIndex = 13
        Me.Label68.Text = "Patient *"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(380, 21)
        Me.ComboBox1.TabIndex = 14
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
        Me.grpItems.Controls.Add(Me.Label60)
        Me.grpItems.Controls.Add(Me.cboProcedure)
        Me.grpItems.Controls.Add(Me.Label61)
        Me.grpItems.Controls.Add(Me.txtItemDesc)
        Me.grpItems.Controls.Add(Me.Label62)
        Me.grpItems.Controls.Add(Me.numQty)
        Me.grpItems.Controls.Add(Me.Label63)
        Me.grpItems.Controls.Add(Me.numUnitPrice)
        Me.grpItems.Controls.Add(Me.Label64)
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
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label60.Location = New System.Drawing.Point(14, 22)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(226, 13)
        Me.Label60.TabIndex = 23
        Me.Label60.Text = "Procedure (optional - fills description and price)"
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
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label61.Location = New System.Drawing.Point(14, 76)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(67, 13)
        Me.Label61.TabIndex = 25
        Me.Label61.Text = "Description *"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(14, 96)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(220, 20)
        Me.txtItemDesc.TabIndex = 26
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label62.Location = New System.Drawing.Point(242, 76)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(23, 13)
        Me.Label62.TabIndex = 27
        Me.Label62.Text = "Qty"
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
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label63.Location = New System.Drawing.Point(300, 76)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(52, 13)
        Me.Label63.TabIndex = 29
        Me.Label63.Text = "Unit price"
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
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(398, 76)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(49, 13)
        Me.Label64.TabIndex = 31
        Me.Label64.Text = "Discount"
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
        Me.grpPayments.Controls.Add(Me.Label57)
        Me.grpPayments.Controls.Add(Me.cboMethod)
        Me.grpPayments.Controls.Add(Me.Label58)
        Me.grpPayments.Controls.Add(Me.numPayAmount)
        Me.grpPayments.Controls.Add(Me.Label59)
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
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(14, 22)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(50, 13)
        Me.Label57.TabIndex = 37
        Me.Label57.Text = "Method *"
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
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label58.Location = New System.Drawing.Point(174, 22)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(66, 13)
        Me.Label58.TabIndex = 39
        Me.Label58.Text = "Amount (₱) *"
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
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label59.Location = New System.Drawing.Point(294, 22)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(35, 13)
        Me.Label59.TabIndex = 41
        Me.Label59.Text = "Notes"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboStatusFilter)
        Me.Panel1.Controls.Add(Me.dgvInvoices)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 1004)
        Me.Panel1.TabIndex = 4
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.TabControl1.ResumeLayout(False)
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
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAuditlog.ResumeLayout(False)
        Me.pnlAuditlog.PerformLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaff.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBillingpayments.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents pnlCardTodayCaption As Label
    Friend WithEvents lblTodayCount As Label
    Friend WithEvents pnlCardPending As Panel
    Friend WithEvents pnlCardPendingCaption As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents pnlCardUnpaid As Panel
    Friend WithEvents pnlCardUnpaidCaption As Label
    Friend WithEvents lblUnpaidCount As Label
    Friend WithEvents lblUnpaidAmount As Label
    Friend WithEvents pnlCardLow As Panel
    Friend WithEvents pnlCardLowCaption As Label
    Friend WithEvents lblLowStockCount As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvToday As DataGridView
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabProducts As TabPage
    Friend WithEvents pnlProdRight As Panel
    Friend WithEvents grpProduct As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents numReorder As NumericUpDown
    Friend WithEvents Label39 As Label
    Friend WithEvents numCost As NumericUpDown
    Friend WithEvents Label40 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents cboProdStatus As ComboBox
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents grpStock As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cboTxType As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents numTxQty As NumericUpDown
    Friend WithEvents Label42 As Label
    Friend WithEvents txtTxRef As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtTxNotes As TextBox
    Friend WithEvents btnPostStock As Button
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents pnlProdLeft As Panel
    Friend WithEvents chkLowStock As CheckBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents tabSuppliers As TabPage
    Friend WithEvents pnlSupRight As Panel
    Friend WithEvents grpSupplier As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtSupName As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cboSupStatus As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtSupContact As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSupPhone As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSupEmail As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtSupAddress As TextBox
    Friend WithEvents btnNewSupplier As Button
    Friend WithEvents btnSaveSupplier As Button
    Friend WithEvents pnlSupLeft As Panel
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents pnlAppointment As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label69 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label71 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label72 As Label
    Friend WithEvents cboDentist As ComboBox
    Friend WithEvents Label73 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label74 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label75 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label76 As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Label77 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCancelAppt As Button
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents Label44 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents Label50 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtRegistered As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtEmergName As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents txtEmergNum As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnArchive As Button
    Friend WithEvents pnlClinicalRecord As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPatient As ComboBox
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabMedical As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMedications As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConditions As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSurgeries As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFamilyHistory As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOtherNotes As TextBox
    Friend WithEvents btnSaveMedical As Button
    Friend WithEvents lblMedicalUpdated As Label
    Friend WithEvents tabVisits As TabPage
    Friend WithEvents dgvVisits As DataGridView
    Friend WithEvents grpVisit As GroupBox
    Friend WithEvents label9 As Label
    Friend WithEvents dtpVisit As DateTimePicker
    Friend WithEvents label10 As Label
    Friend WithEvents cboVisitDentist As ComboBox
    Friend WithEvents label11 As Label
    Friend WithEvents dtpNextVisit As DateTimePicker
    Friend WithEvents label12 As Label
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents label13 As Label
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents label14 As Label
    Friend WithEvents txtClinicalNotes As TextBox
    Friend WithEvents label15 As Label
    Friend WithEvents txtRecommendations As TextBox
    Friend WithEvents btnNewVisit As Button
    Friend WithEvents btnSaveVisit As Button
    Friend WithEvents grpTreat As GroupBox
    Friend WithEvents label16 As Label
    Friend WithEvents cboTreatProcedure As ComboBox
    Friend WithEvents label17 As Label
    Friend WithEvents txtTreatTooth As TextBox
    Friend WithEvents label18 As Label
    Friend WithEvents numTreatQty As NumericUpDown
    Friend WithEvents label19 As Label
    Friend WithEvents numTreatPrice As NumericUpDown
    Friend WithEvents label20 As Label
    Friend WithEvents numTreatDiscount As NumericUpDown
    Friend WithEvents label21 As Label
    Friend WithEvents cboTreatStatus As ComboBox
    Friend WithEvents btnAddTreatment As Button
    Friend WithEvents btnRemoveTreatment As Button
    Friend WithEvents dgvTreatments As DataGridView
    Friend WithEvents tabChart As TabPage
    Friend WithEvents dgvChart As DataGridView
    Friend WithEvents grpChart As GroupBox
    Friend WithEvents label22 As Label
    Friend WithEvents txtChartTooth As TextBox
    Friend WithEvents label23 As Label
    Friend WithEvents cboSurface As ComboBox
    Friend WithEvents label24 As Label
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents label25 As Label
    Friend WithEvents txtChartNotes As TextBox
    Friend WithEvents btnNewChart As Button
    Friend WithEvents btnSaveChart As Button
    Friend WithEvents btnDeleteChart As Button
    Friend WithEvents pnlProcedures As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label79 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label81 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label82 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents Label84 As Label
    Friend WithEvents numDuration As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvProcedures As DataGridView
    Friend WithEvents pnlAuditlog As Panel
    Friend WithEvents Label85 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label86 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents pnlStaff As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents grpStaff As GroupBox
    Friend WithEvents Label87 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label88 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label89 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Label94 As Label
    Friend WithEvents txtLicense As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnSaveStaff As Button
    Friend WithEvents Panel10 As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnToggleActive As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents pnlBillingpayments As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grpInvoice As GroupBox
    Friend WithEvents Label65 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents numDiscount As NumericUpDown
    Friend WithEvents Label68 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents btnNewInvoice As Button
    Friend WithEvents btnSaveInvoice As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents grpItems As GroupBox
    Friend WithEvents Label60 As Label
    Friend WithEvents cboProcedure As ComboBox
    Friend WithEvents Label61 As Label
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents Label63 As Label
    Friend WithEvents numUnitPrice As NumericUpDown
    Friend WithEvents Label64 As Label
    Friend WithEvents numItemDiscount As NumericUpDown
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents grpPayments As GroupBox
    Friend WithEvents Label57 As Label
    Friend WithEvents cboMethod As ComboBox
    Friend WithEvents Label58 As Label
    Friend WithEvents numPayAmount As NumericUpDown
    Friend WithEvents Label59 As Label
    Friend WithEvents txtPayNotes As TextBox
    Friend WithEvents btnReceive As Button
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboStatusFilter As ComboBox
    Friend WithEvents dgvInvoices As DataGridView
End Class
