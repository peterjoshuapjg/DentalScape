-- Run once on an existing DentalClinicDB (new installs already get these from DentalClinicDB.sql)
USE DentalClinicDB;

-- Login attempts: 3 wrong passwords lock the account
ALTER TABLE tblUsers
    ADD COLUMN IF NOT EXISTS FailedAttempts INT NOT NULL DEFAULT 0,
    ADD COLUMN IF NOT EXISTS LockedUntil DATETIME NULL;

-- Materials used by each procedure; consumed automatically when a treatment is tagged Completed
CREATE TABLE IF NOT EXISTS tblProcedureMaterial (
    ProcedureMaterialID INT NOT NULL AUTO_INCREMENT,
    ProcedureID INT NOT NULL,
    ProductCode VARCHAR(30) NOT NULL,
    QuantityUsed INT NOT NULL DEFAULT 1,
    CONSTRAINT PK_tblProcedureMaterial PRIMARY KEY (ProcedureMaterialID),
    CONSTRAINT FK_tblProcedureMaterial_Procedure FOREIGN KEY (ProcedureID) REFERENCES tblProcedures(ProcedureID),
    CONSTRAINT FK_tblProcedureMaterial_Product FOREIGN KEY (ProductCode) REFERENCES tblProducts(ProductCode) ON UPDATE CASCADE,
    CONSTRAINT UQ_tblProcedureMaterial UNIQUE (ProcedureID, ProductCode),
    CONSTRAINT CK_tblProcedureMaterial_Qty CHECK (QuantityUsed > 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Remembers whether a treatment's materials were already taken out of stock
ALTER TABLE tblTreatmentRecords
    ADD COLUMN IF NOT EXISTS MaterialsConsumed TINYINT(1) NOT NULL DEFAULT 0;

-- Treatments that were already Completed before this update are history: do not deduct stock for them
UPDATE tblTreatmentRecords SET MaterialsConsumed = 1 WHERE TreatmentStatus = 'Completed';
