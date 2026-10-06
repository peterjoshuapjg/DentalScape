-- DentalClinicDB: MariaDB/MySQL (XAMPP) database dump

CREATE DATABASE IF NOT EXISTS DentalClinicDB
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE DentalClinicDB;

CREATE TABLE tblRoles (
    RoleID INT NOT NULL AUTO_INCREMENT,
    RoleName VARCHAR(50) NOT NULL,
    Description VARCHAR(255) NULL,
    CONSTRAINT PK_tblRoles PRIMARY KEY (RoleID),
    CONSTRAINT UQ_tblRoles_RoleName UNIQUE (RoleName)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblStaff (
    StaffID INT NOT NULL AUTO_INCREMENT,
    StaffCode VARCHAR(20) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    ContactNumber VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    Position VARCHAR(50) NOT NULL,
    LicenseNumber VARCHAR(50) NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblStaff PRIMARY KEY (StaffID),
    CONSTRAINT UQ_tblStaff_StaffCode UNIQUE (StaffCode),
    CONSTRAINT CK_tblStaff_Status CHECK (Status IN ('Active','Inactive','Suspended'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblUsers (
    UserID INT NOT NULL AUTO_INCREMENT,
    StaffID INT NOT NULL,
    Username VARCHAR(50) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    RoleID INT NOT NULL,
    IsActive TINYINT(1) NOT NULL DEFAULT 1,
    CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    LastLogin DATETIME NULL,
    CONSTRAINT PK_tblUsers PRIMARY KEY (UserID),
    CONSTRAINT UQ_tblUsers_Username UNIQUE (Username),
    CONSTRAINT UQ_tblUsers_StaffID UNIQUE (StaffID),
    CONSTRAINT FK_tblUsers_Staff FOREIGN KEY (StaffID) REFERENCES tblStaff(StaffID),
    CONSTRAINT FK_tblUsers_Role FOREIGN KEY (RoleID) REFERENCES tblRoles(RoleID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblPatients (
    PatientID INT NOT NULL AUTO_INCREMENT,
    PatientCode VARCHAR(20) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE NULL,
    Gender VARCHAR(20) NULL,
    ContactNumber VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    Address VARCHAR(255) NULL,
    EmergencyContactName VARCHAR(100) NULL,
    EmergencyContactNumber VARCHAR(20) NULL,
    RegistrationDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblPatients PRIMARY KEY (PatientID),
    CONSTRAINT UQ_tblPatients_PatientCode UNIQUE (PatientCode),
    CONSTRAINT CK_tblPatients_Status CHECK (Status IN ('Active','Inactive','Archived'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblMedicalHistory (
    MedicalHistoryID INT NOT NULL AUTO_INCREMENT,
    PatientID INT NOT NULL,
    Allergies TEXT NULL,
    CurrentMedications TEXT NULL,
    MedicalConditions TEXT NULL,
    PreviousSurgeries TEXT NULL,
    FamilyMedicalHistory TEXT NULL,
    OtherNotes TEXT NULL,
    HasDiabetes TINYINT(1) NOT NULL DEFAULT 0,
    HasHypertension TINYINT(1) NOT NULL DEFAULT 0,
    HasHeartDisease TINYINT(1) NOT NULL DEFAULT 0,
    HasAsthma TINYINT(1) NOT NULL DEFAULT 0,
    HasPregnant TINYINT(1) NOT NULL DEFAULT 0,
    HasSmoker TINYINT(1) NOT NULL DEFAULT 0,
    HasBleedingDisorder TINYINT(1) NOT NULL DEFAULT 0,
    UpdatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tblMedicalHistory PRIMARY KEY (MedicalHistoryID),
    CONSTRAINT UQ_tblMedicalHistory_Patient UNIQUE (PatientID),
    CONSTRAINT FK_tblMedicalHistory_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblAppointmentTypes (
    AppointmentTypeID INT NOT NULL AUTO_INCREMENT,
    TypeName VARCHAR(100) NOT NULL,
    Description TEXT NULL,
    DefaultDuration INT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblAppointmentTypes PRIMARY KEY (AppointmentTypeID),
    CONSTRAINT UQ_tblAppointmentTypes_TypeName UNIQUE (TypeName),
    CONSTRAINT CK_tblAppointmentTypes_Status CHECK (Status IN ('Active','Inactive')),
    CONSTRAINT CK_tblAppointmentTypes_Duration CHECK (DefaultDuration IS NULL OR DefaultDuration > 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblAppointments (
    AppointmentID INT NOT NULL AUTO_INCREMENT,
    AppointmentCode VARCHAR(20) NOT NULL,
    PatientID INT NOT NULL,
    DentistID INT NOT NULL,
    AppointmentDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NULL,
    AppointmentTypeID INT NOT NULL,
    Status VARCHAR(30) NOT NULL DEFAULT 'Pending',
    Reason VARCHAR(255) NULL,
    Notes TEXT NULL,
    CreatedBy INT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tblAppointments PRIMARY KEY (AppointmentID),
    CONSTRAINT UQ_tblAppointments_AppointmentCode UNIQUE (AppointmentCode),
    CONSTRAINT FK_tblAppointments_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID),
    CONSTRAINT FK_tblAppointments_Dentist FOREIGN KEY (DentistID) REFERENCES tblStaff(StaffID),
    CONSTRAINT FK_tblAppointments_Type FOREIGN KEY (AppointmentTypeID) REFERENCES tblAppointmentTypes(AppointmentTypeID),
    CONSTRAINT FK_tblAppointments_CreatedBy FOREIGN KEY (CreatedBy) REFERENCES tblUsers(UserID),
    CONSTRAINT CK_tblAppointments_Status CHECK (
        Status IN ('Pending','Confirmed','Completed','Cancelled','No-show')
    ),
    CONSTRAINT CK_tblAppointments_Time CHECK (EndTime IS NULL OR EndTime > StartTime),
    INDEX IX_tblAppointments_PatientID (PatientID),
    INDEX IX_tblAppointments_DentistDate (DentistID, AppointmentDate, StartTime),
    INDEX IX_tblAppointments_Status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblDentalRecords (
    DentalRecordID INT NOT NULL AUTO_INCREMENT,
    PatientID INT NOT NULL,
    AppointmentID INT NULL,
    DentistID INT NOT NULL,
    VisitDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ChiefComplaint TEXT NULL,
    Diagnosis TEXT NULL,
    ClinicalNotes TEXT NULL,
    Recommendations TEXT NULL,
    NextVisitDate DATE NULL,
    CONSTRAINT PK_tblDentalRecords PRIMARY KEY (DentalRecordID),
    CONSTRAINT FK_tblDentalRecords_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID),
    CONSTRAINT FK_tblDentalRecords_Appointment FOREIGN KEY (AppointmentID) REFERENCES tblAppointments(AppointmentID),
    CONSTRAINT FK_tblDentalRecords_Dentist FOREIGN KEY (DentistID) REFERENCES tblStaff(StaffID),
    INDEX IX_tblDentalRecords_PatientID (PatientID),
    INDEX IX_tblDentalRecords_VisitDate (VisitDate),
    INDEX IX_tblDentalRecords_AppointmentID (AppointmentID),
    INDEX IX_tblDentalRecords_DentistID (DentistID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblDentalChart (
    DentalChartID INT NOT NULL AUTO_INCREMENT,
    PatientID INT NOT NULL,
    ToothNumber VARCHAR(10) NOT NULL,
    ToothCondition VARCHAR(100) NULL,
    Surface VARCHAR(50) NULL,
    Notes TEXT NULL,
    UpdatedBy INT NULL,
    UpdatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tblDentalChart PRIMARY KEY (DentalChartID),
    CONSTRAINT FK_tblDentalChart_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID),
    CONSTRAINT FK_tblDentalChart_UpdatedBy FOREIGN KEY (UpdatedBy) REFERENCES tblUsers(UserID),
    INDEX IX_tblDentalChart_PatientTooth (PatientID, ToothNumber)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblProcedures (
    ProcedureID INT NOT NULL AUTO_INCREMENT,
    ProcedureCode VARCHAR(20) NOT NULL,
    ProcedureName VARCHAR(100) NOT NULL,
    Description TEXT NULL,
    StandardPrice DECIMAL(10,2) NOT NULL,
    EstimatedDuration INT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblProcedures PRIMARY KEY (ProcedureID),
    CONSTRAINT UQ_tblProcedures_ProcedureCode UNIQUE (ProcedureCode),
    CONSTRAINT UQ_tblProcedures_ProcedureName UNIQUE (ProcedureName),
    CONSTRAINT CK_tblProcedures_Price CHECK (StandardPrice >= 0),
    CONSTRAINT CK_tblProcedures_Duration CHECK (EstimatedDuration IS NULL OR EstimatedDuration > 0),
    CONSTRAINT CK_tblProcedures_Status CHECK (Status IN ('Active','Inactive'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblTreatmentPlans (
    TreatmentPlanID INT NOT NULL AUTO_INCREMENT,
    PatientID INT NOT NULL,
    DentistID INT NOT NULL,
    PlanDate DATE NOT NULL DEFAULT (CURDATE()),
    Diagnosis TEXT NULL,
    TotalEstimatedCost DECIMAL(10,2) NOT NULL DEFAULT 0,
    Status VARCHAR(30) NOT NULL DEFAULT 'Proposed',
    Notes TEXT NULL,
    CONSTRAINT PK_tblTreatmentPlans PRIMARY KEY (TreatmentPlanID),
    CONSTRAINT FK_tblTreatmentPlans_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID),
    CONSTRAINT FK_tblTreatmentPlans_Dentist FOREIGN KEY (DentistID) REFERENCES tblStaff(StaffID),
    CONSTRAINT CK_tblTreatmentPlans_Cost CHECK (TotalEstimatedCost >= 0),
    CONSTRAINT CK_tblTreatmentPlans_Status CHECK (
        Status IN ('Proposed','Approved','In Progress','Completed','Cancelled')
    ),
    INDEX IX_tblTreatmentPlans_PatientID (PatientID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblTreatmentPlanItems (
    PlanItemID INT NOT NULL AUTO_INCREMENT,
    TreatmentPlanID INT NOT NULL,
    ProcedureID INT NOT NULL,
    ToothNumber VARCHAR(10) NULL,
    Quantity INT NOT NULL DEFAULT 1,
    EstimatedPrice DECIMAL(10,2) NOT NULL,
    Status VARCHAR(30) NOT NULL DEFAULT 'Planned',
    ScheduledDate DATE NULL,
    CONSTRAINT PK_tblTreatmentPlanItems PRIMARY KEY (PlanItemID),
    CONSTRAINT FK_tblTreatmentPlanItems_Plan FOREIGN KEY (TreatmentPlanID) REFERENCES tblTreatmentPlans(TreatmentPlanID),
    CONSTRAINT FK_tblTreatmentPlanItems_Procedure FOREIGN KEY (ProcedureID) REFERENCES tblProcedures(ProcedureID),
    CONSTRAINT CK_tblTreatmentPlanItems_Quantity CHECK (Quantity > 0),
    CONSTRAINT CK_tblTreatmentPlanItems_Price CHECK (EstimatedPrice >= 0),
    CONSTRAINT CK_tblTreatmentPlanItems_Status CHECK (
        Status IN ('Planned','Scheduled','In Progress','Completed','Cancelled')
    ),
    INDEX IX_tblTreatmentPlanItems_Plan (TreatmentPlanID),
    INDEX IX_tblTreatmentPlanItems_Procedure (ProcedureID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblTreatmentRecords (
    TreatmentRecordID INT NOT NULL AUTO_INCREMENT,
    DentalRecordID INT NOT NULL,
    ProcedureID INT NOT NULL,
    DentistID INT NOT NULL,
    ToothNumber VARCHAR(10) NULL,
    Quantity INT NOT NULL DEFAULT 1,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) NOT NULL DEFAULT 0,
    TotalAmount DECIMAL(12,2) AS ((Quantity * UnitPrice) - Discount) STORED,
    TreatmentStatus VARCHAR(30) NOT NULL DEFAULT 'Completed',
    Notes TEXT NULL,
    CONSTRAINT PK_tblTreatmentRecords PRIMARY KEY (TreatmentRecordID),
    CONSTRAINT FK_tblTreatmentRecords_DentalRecord FOREIGN KEY (DentalRecordID) REFERENCES tblDentalRecords(DentalRecordID),
    CONSTRAINT FK_tblTreatmentRecords_Procedure FOREIGN KEY (ProcedureID) REFERENCES tblProcedures(ProcedureID),
    CONSTRAINT FK_tblTreatmentRecords_Dentist FOREIGN KEY (DentistID) REFERENCES tblStaff(StaffID),
    CONSTRAINT CK_tblTreatmentRecords_Quantity CHECK (Quantity > 0),
    CONSTRAINT CK_tblTreatmentRecords_UnitPrice CHECK (UnitPrice >= 0),
    CONSTRAINT CK_tblTreatmentRecords_Discount CHECK (Discount >= 0 AND Discount <= (Quantity * UnitPrice)),
    CONSTRAINT CK_tblTreatmentRecords_Status CHECK (
        TreatmentStatus IN ('Planned','In Progress','Completed','Cancelled')
    ),
    INDEX IX_tblTreatmentRecords_DentalRecord (DentalRecordID),
    INDEX IX_tblTreatmentRecords_Procedure (ProcedureID),
    INDEX IX_tblTreatmentRecords_Dentist (DentistID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblInvoices (
    InvoiceID INT NOT NULL AUTO_INCREMENT,
    InvoiceNumber VARCHAR(30) NOT NULL,
    PatientID INT NOT NULL,
    AppointmentID INT NULL,
    InvoiceDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    SubTotal DECIMAL(10,2) NOT NULL DEFAULT 0,
    Discount DECIMAL(10,2) NOT NULL DEFAULT 0,
    TotalAmount DECIMAL(10,2) NOT NULL DEFAULT 0,
    AmountPaid DECIMAL(10,2) NOT NULL DEFAULT 0,
    Balance DECIMAL(10,2) AS (TotalAmount - AmountPaid) STORED,
    Status VARCHAR(30) NOT NULL DEFAULT 'Unpaid',
    CONSTRAINT PK_tblInvoices PRIMARY KEY (InvoiceID),
    CONSTRAINT UQ_tblInvoices_InvoiceNumber UNIQUE (InvoiceNumber),
    CONSTRAINT FK_tblInvoices_Patient FOREIGN KEY (PatientID) REFERENCES tblPatients(PatientID),
    CONSTRAINT FK_tblInvoices_Appointment FOREIGN KEY (AppointmentID) REFERENCES tblAppointments(AppointmentID),
    CONSTRAINT CK_tblInvoices_Amounts CHECK (
        SubTotal >= 0 AND Discount >= 0 AND TotalAmount >= 0 AND AmountPaid >= 0
    ),
    CONSTRAINT CK_tblInvoices_Status CHECK (
        Status IN ('Unpaid','Partially Paid','Paid','Void')
    ),
    INDEX IX_tblInvoices_Patient (PatientID),
    INDEX IX_tblInvoices_Status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblInvoiceItems (
    InvoiceItemID INT NOT NULL AUTO_INCREMENT,
    InvoiceID INT NOT NULL,
    TreatmentRecordID INT NULL,
    Description VARCHAR(255) NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) NOT NULL DEFAULT 0,
    TotalAmount DECIMAL(12,2) AS ((Quantity * UnitPrice) - Discount) STORED,
    CONSTRAINT PK_tblInvoiceItems PRIMARY KEY (InvoiceItemID),
    CONSTRAINT FK_tblInvoiceItems_Invoice FOREIGN KEY (InvoiceID) REFERENCES tblInvoices(InvoiceID),
    CONSTRAINT FK_tblInvoiceItems_Treatment FOREIGN KEY (TreatmentRecordID) REFERENCES tblTreatmentRecords(TreatmentRecordID),
    CONSTRAINT CK_tblInvoiceItems_Quantity CHECK (Quantity > 0),
    CONSTRAINT CK_tblInvoiceItems_Price CHECK (UnitPrice >= 0),
    CONSTRAINT CK_tblInvoiceItems_Discount CHECK (Discount >= 0 AND Discount <= (Quantity * UnitPrice)),
    INDEX IX_tblInvoiceItems_Invoice (InvoiceID),
    INDEX IX_tblInvoiceItems_Treatment (TreatmentRecordID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblPaymentMethods (
    PaymentMethodID INT NOT NULL AUTO_INCREMENT,
    MethodName VARCHAR(50) NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblPaymentMethods PRIMARY KEY (PaymentMethodID),
    CONSTRAINT UQ_tblPaymentMethods_MethodName UNIQUE (MethodName),
    CONSTRAINT CK_tblPaymentMethods_Status CHECK (Status IN ('Active','Inactive'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblPayments (
    PaymentID INT NOT NULL AUTO_INCREMENT,
    InvoiceID INT NOT NULL,
    PaymentReference VARCHAR(30) NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentMethodID INT NOT NULL,
    ReceivedBy INT NOT NULL,
    Notes TEXT NULL,
    CONSTRAINT PK_tblPayments PRIMARY KEY (PaymentID),
    CONSTRAINT UQ_tblPayments_PaymentReference UNIQUE (PaymentReference),
    CONSTRAINT FK_tblPayments_Invoice FOREIGN KEY (InvoiceID) REFERENCES tblInvoices(InvoiceID),
    CONSTRAINT FK_tblPayments_Method FOREIGN KEY (PaymentMethodID) REFERENCES tblPaymentMethods(PaymentMethodID),
    CONSTRAINT FK_tblPayments_ReceivedBy FOREIGN KEY (ReceivedBy) REFERENCES tblUsers(UserID),
    CONSTRAINT CK_tblPayments_Amount CHECK (Amount > 0),
    INDEX IX_tblPayments_Invoice (InvoiceID),
    INDEX IX_tblPayments_Method (PaymentMethodID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblSuppliers (
    SupplierID INT NOT NULL AUTO_INCREMENT,
    SupplierName VARCHAR(100) NOT NULL,
    ContactPerson VARCHAR(100) NULL,
    ContactNumber VARCHAR(30) NULL,
    Email VARCHAR(100) NULL,
    Address VARCHAR(255) NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblSuppliers PRIMARY KEY (SupplierID),
    CONSTRAINT UQ_tblSuppliers_SupplierName UNIQUE (SupplierName),
    CONSTRAINT CK_tblSuppliers_Status CHECK (Status IN ('Active','Inactive'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblProductCategories (
    CategoryID INT NOT NULL AUTO_INCREMENT,
    CategoryName VARCHAR(100) NOT NULL,
    Description VARCHAR(255) NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblProductCategories PRIMARY KEY (CategoryID),
    CONSTRAINT UQ_tblProductCategories_CategoryName UNIQUE (CategoryName),
    CONSTRAINT CK_tblProductCategories_Status CHECK (Status IN ('Active','Inactive'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblProducts (
    ProductID INT NOT NULL AUTO_INCREMENT,
    ProductCode VARCHAR(30) NOT NULL,
    ProductName VARCHAR(100) NOT NULL,
    CategoryID INT NOT NULL,
    Unit VARCHAR(30) NOT NULL,
    CurrentStock INT NOT NULL DEFAULT 0,
    ReorderLevel INT NOT NULL DEFAULT 0,
    UnitCost DECIMAL(10,2) NOT NULL DEFAULT 0,
    Status VARCHAR(20) NOT NULL DEFAULT 'Active',
    CONSTRAINT PK_tblProducts PRIMARY KEY (ProductID),
    CONSTRAINT UQ_tblProducts_ProductCode UNIQUE (ProductCode),
    CONSTRAINT FK_tblProducts_Category FOREIGN KEY (CategoryID) REFERENCES tblProductCategories(CategoryID),
    CONSTRAINT CK_tblProducts_Stock CHECK (CurrentStock >= 0),
    CONSTRAINT CK_tblProducts_Reorder CHECK (ReorderLevel >= 0),
    CONSTRAINT CK_tblProducts_Cost CHECK (UnitCost >= 0),
    CONSTRAINT CK_tblProducts_Status CHECK (Status IN ('Active','Inactive')),
    INDEX IX_tblProducts_Category (CategoryID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblProductSuppliers (
    ProductSupplierID INT NOT NULL AUTO_INCREMENT,
    ProductID INT NOT NULL,
    SupplierID INT NOT NULL,
    SupplierProductCode VARCHAR(50) NULL,
    LastPurchasePrice DECIMAL(10,2) NULL,
    IsPreferred TINYINT(1) NOT NULL DEFAULT 0,
    CONSTRAINT PK_tblProductSuppliers PRIMARY KEY (ProductSupplierID),
    CONSTRAINT FK_tblProductSuppliers_Product FOREIGN KEY (ProductID) REFERENCES tblProducts(ProductID),
    CONSTRAINT FK_tblProductSuppliers_Supplier FOREIGN KEY (SupplierID) REFERENCES tblSuppliers(SupplierID),
    CONSTRAINT UQ_tblProductSuppliers_ProductSupplier UNIQUE (ProductID, SupplierID),
    CONSTRAINT CK_tblProductSuppliers_Price CHECK (LastPurchasePrice IS NULL OR LastPurchasePrice >= 0),
    INDEX IX_tblProductSuppliers_Supplier (SupplierID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblInventoryTransactions (
    TransactionID BIGINT NOT NULL AUTO_INCREMENT,
    ProductID INT NOT NULL,
    TransactionType VARCHAR(20) NOT NULL,
    Quantity INT NOT NULL,
    TransactionDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Reference VARCHAR(100) NULL,
    PerformedBy INT NOT NULL,
    Notes TEXT NULL,
    CONSTRAINT PK_tblInventoryTransactions PRIMARY KEY (TransactionID),
    CONSTRAINT FK_tblInventoryTransactions_Product FOREIGN KEY (ProductID) REFERENCES tblProducts(ProductID),
    CONSTRAINT FK_tblInventoryTransactions_User FOREIGN KEY (PerformedBy) REFERENCES tblUsers(UserID),
    CONSTRAINT CK_tblInventoryTransactions_Type CHECK (
        TransactionType IN ('Stock In','Stock Out','Adjustment In','Adjustment Out','Expired','Damaged')
    ),
    CONSTRAINT CK_tblInventoryTransactions_Quantity CHECK (Quantity > 0),
    INDEX IX_tblInventoryTransactions_ProductDate (ProductID, TransactionDate)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tblAuditLogs (
    AuditLogID BIGINT NOT NULL AUTO_INCREMENT,
    UserID INT NULL,
    Action VARCHAR(100) NOT NULL,
    EntityName VARCHAR(100) NULL,
    RecordID VARCHAR(50) NULL,
    OldValue TEXT NULL,
    NewValue TEXT NULL,
    IPAddress VARCHAR(45) NULL,
    Timestamp DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tblAuditLogs PRIMARY KEY (AuditLogID),
    CONSTRAINT FK_tblAuditLogs_User FOREIGN KEY (UserID) REFERENCES tblUsers(UserID),
    INDEX IX_tblAuditLogs_Timestamp (Timestamp),
    INDEX IX_tblAuditLogs_UserID (UserID),
    INDEX IX_tblAuditLogs_Entity (EntityName, RecordID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO tblRoles (RoleID, RoleName, Description) VALUES
(1, 'Administrator', 'Full system access: manages everything including staff, accounts, prices, inventory, clinical records and audit logs'),
(2, 'Front Desk', 'Front-desk access: patient registration, appointments, invoices and payments only');

INSERT INTO tblStaff (StaffID, StaffCode, FirstName, LastName, Position) VALUES
(1, 'ADM-001', 'Clinic', 'Administrator', 'Administrator'),
(2, 'FD-001', 'Front', 'Desk', 'Front Desk');

INSERT INTO tblUsers (UserID, StaffID, Username, PasswordHash, RoleID) VALUES
(1, 1, 'admin', 'SET_PASSWORD_FIRST', 1),
(2, 2, 'frontdesk', 'SET_PASSWORD_FIRST', 2);

INSERT INTO tblAppointmentTypes (TypeName, Description, DefaultDuration) VALUES
('Consultation', 'Initial or follow-up dental consultation', 30),
('Dental Cleaning', 'Routine dental cleaning', 60),
('Tooth Extraction', 'Dental extraction appointment', 60),
('Dental Filling', 'Dental filling procedure', 60),
('Root Canal', 'Root canal treatment', 90),
('Orthodontic Adjustment', 'Braces/orthodontic adjustment', 30),
('Follow-up', 'Follow-up consultation or treatment', 30);

INSERT INTO tblPaymentMethods (MethodName) VALUES
('Cash'),
('GCash'),
('Bank Transfer'),
('Debit/Credit Card');

INSERT INTO tblProductCategories (CategoryName, Description) VALUES
('Consumables', 'Disposable dental supplies'),
('Medications', 'Dental medicines and related items'),
('PPE', 'Personal protective equipment'),
('Cleaning Supplies', 'Clinic cleaning and sanitation supplies'),
('Dental Materials', 'Materials used during dental procedures');

INSERT INTO tblProcedures
    (ProcedureCode, ProcedureName, Description, StandardPrice, EstimatedDuration) VALUES
('PR-001', 'Dental Consultation', 'General dental consultation', 500.00, 30),
('PR-002', 'Dental Cleaning', 'Routine dental cleaning', 800.00, 60),
('PR-003', 'Dental Filling', 'Composite or standard dental filling', 1200.00, 60),
('PR-004', 'Tooth Extraction', 'Basic tooth extraction', 1500.00, 60),
('PR-005', 'Root Canal', 'Root canal treatment', 8000.00, 90),
('PR-006', 'Orthodontic Adjustment', 'Routine orthodontic adjustment', 1000.00, 30);

CREATE VIEW vwPatientBalances AS
SELECT
    p.PatientID,
    p.PatientCode,
    p.FirstName,
    p.LastName,
    IFNULL(SUM(i.TotalAmount), 0) AS TotalBilled,
    IFNULL(SUM(i.AmountPaid), 0) AS TotalPaid,
    IFNULL(SUM(i.Balance), 0) AS OutstandingBalance
FROM tblPatients p
LEFT JOIN tblInvoices i
    ON p.PatientID = i.PatientID
    AND i.Status <> 'Void'
GROUP BY
    p.PatientID,
    p.PatientCode,
    p.FirstName,
    p.LastName;

CREATE VIEW vwAppointmentDetails AS
SELECT
    a.AppointmentID,
    a.AppointmentCode,
    a.AppointmentDate,
    a.StartTime,
    a.EndTime,
    a.Status,
    p.PatientCode,
    CONCAT(p.FirstName, ' ', p.LastName) AS PatientName,
    CONCAT(s.FirstName, ' ', s.LastName) AS DentistName,
    apt.TypeName AS AppointmentType
FROM tblAppointments a
INNER JOIN tblPatients p ON a.PatientID = p.PatientID
INNER JOIN tblStaff s ON a.DentistID = s.StaffID
INNER JOIN tblAppointmentTypes apt ON a.AppointmentTypeID = apt.AppointmentTypeID;

CREATE VIEW vwLowStockProducts AS
SELECT
    p.ProductID,
    p.ProductCode,
    p.ProductName,
    c.CategoryName,
    p.CurrentStock,
    p.ReorderLevel,
    p.Unit
FROM tblProducts p
INNER JOIN tblProductCategories c ON p.CategoryID = c.CategoryID
WHERE p.Status = 'Active'
  AND p.CurrentStock <= p.ReorderLevel;
