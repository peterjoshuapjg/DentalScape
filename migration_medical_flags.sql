-- Run once on an existing DentalClinicDB (new installs get these columns from DentalClinicDB.sql)
USE DentalClinicDB;

ALTER TABLE tblMedicalHistory
    ADD COLUMN HasDiabetes TINYINT(1) NOT NULL DEFAULT 0 AFTER OtherNotes,
    ADD COLUMN HasHypertension TINYINT(1) NOT NULL DEFAULT 0 AFTER HasDiabetes,
    ADD COLUMN HasHeartDisease TINYINT(1) NOT NULL DEFAULT 0 AFTER HasHypertension,
    ADD COLUMN HasAsthma TINYINT(1) NOT NULL DEFAULT 0 AFTER HasHeartDisease,
    ADD COLUMN HasPregnant TINYINT(1) NOT NULL DEFAULT 0 AFTER HasAsthma,
    ADD COLUMN HasSmoker TINYINT(1) NOT NULL DEFAULT 0 AFTER HasPregnant,
    ADD COLUMN HasBleedingDisorder TINYINT(1) NOT NULL DEFAULT 0 AFTER HasSmoker;
