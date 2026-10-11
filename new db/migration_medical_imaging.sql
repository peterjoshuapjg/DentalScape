-- Medical Imaging (X-ray) tab on the Clinical Records panel
-- The app also runs this automatically the first time Clinical Records is opened,
-- so importing it by hand is optional (database: dentalclinicdb).

CREATE TABLE IF NOT EXISTS `tblmedicalimages` (
  `ImageID` int(11) NOT NULL AUTO_INCREMENT,
  `PatientID` int(11) NOT NULL,
  `ImageType` varchar(50) NOT NULL,
  `ImagePath` varchar(255) NOT NULL,          -- relative to ...\DentalScape\MedicalImages\
  `OriginalFileName` varchar(255) DEFAULT NULL,
  `DateUploaded` datetime NOT NULL DEFAULT current_timestamp(),
  `UploadedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`ImageID`),
  KEY `IX_tblMedicalImages_Patient` (`PatientID`,`DateUploaded`),
  KEY `IX_tblMedicalImages_UploadedBy` (`UploadedBy`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
