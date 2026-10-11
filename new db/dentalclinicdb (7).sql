-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 11, 2026 at 07:08 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dentalclinicdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblappointments`
--

CREATE TABLE `tblappointments` (
  `AppointmentID` int(11) NOT NULL,
  `AppointmentCode` varchar(20) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `DentistID` int(11) NOT NULL,
  `AppointmentDate` date NOT NULL,
  `StartTime` time NOT NULL,
  `EndTime` time DEFAULT NULL,
  `AppointmentTypeID` int(11) NOT NULL,
  `Status` varchar(30) NOT NULL DEFAULT 'Pending',
  `Reason` varchar(255) DEFAULT NULL,
  `Notes` text DEFAULT NULL,
  `CreatedBy` int(11) DEFAULT NULL,
  `CreatedAt` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblappointments`
--

INSERT INTO `tblappointments` (`AppointmentID`, `AppointmentCode`, `PatientID`, `DentistID`, `AppointmentDate`, `StartTime`, `EndTime`, `AppointmentTypeID`, `Status`, `Reason`, `Notes`, `CreatedBy`, `CreatedAt`) VALUES
(1, 'APT-202610-001', 1, 3, '2026-10-01', '09:00:00', '09:30:00', 1, 'Completed', 'Initial consultation', 'Patient reports tooth sensitivity.', 2, '2026-10-01 08:15:00'),
(2, 'APT-202610-002', 2, 4, '2026-10-01', '10:00:00', '11:00:00', 2, 'Completed', 'Routine cleaning', 'Routine preventive visit.', 2, '2026-10-01 09:05:00'),
(3, 'APT-202610-003', 3, 3, '2026-10-02', '13:00:00', '14:00:00', 4, 'Completed', 'Cavity treatment', 'Cavity on upper molar.', 2, '2026-10-02 10:20:00'),
(4, 'APT-202610-004', 4, 4, '2026-10-03', '09:00:00', '10:30:00', 5, 'Completed', 'Tooth pain', 'Persistent pain on tooth 16.', 2, '2026-10-02 13:25:00'),
(5, 'APT-202610-005', 5, 5, '2026-10-03', '14:00:00', '15:00:00', 3, 'Completed', 'Tooth extraction', 'Loose molar scheduled for extraction.', 2, '2026-10-03 08:35:00'),
(6, 'APT-202610-006', 6, 6, '2026-10-04', '10:00:00', '10:30:00', 6, 'Completed', 'Braces adjustment', 'Monthly orthodontic adjustment.', 2, '2026-10-03 11:50:00'),
(7, 'APT-202610-007', 7, 3, '2026-10-05', '09:30:00', '10:00:00', 1, 'Completed', 'Dental check-up', 'General examination.', 2, '2026-10-05 09:15:00'),
(8, 'APT-202610-008', 8, 4, '2026-10-06', '13:00:00', '14:00:00', 2, 'Completed', 'Dental cleaning', 'Routine cleaning and polishing.', 2, '2026-10-06 14:05:00'),
(9, 'APT-202610-009', 1, 3, '2026-10-07', '09:00:00', '10:30:00', 5, 'Completed', 'Root canal', 'Follow-up root canal treatment.', 2, '2026-10-06 10:00:00'),
(10, 'APT-202610-010', 2, 4, '2026-10-07', '14:00:00', '15:00:00', 7, 'Completed', 'Follow-up', 'Post-cleaning follow-up.', 2, '2026-10-07 09:00:00'),
(11, 'APT-202610-011', 3, 5, '2026-10-08', '09:00:00', '10:00:00', 4, 'Confirmed', 'Dental filling', 'Treat tooth 36.', 2, '2026-10-07 15:00:00'),
(12, 'APT-202610-012', 5, 6, '2026-10-08', '14:00:00', '16:00:00', 3, 'Confirmed', 'Wisdom tooth extraction', 'Evaluate impacted tooth 48.', 2, '2026-10-07 15:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `tblappointmenttypes`
--

CREATE TABLE `tblappointmenttypes` (
  `AppointmentTypeID` int(11) NOT NULL,
  `TypeName` varchar(100) NOT NULL,
  `Description` text DEFAULT NULL,
  `DefaultDuration` int(11) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblappointmenttypes`
--

INSERT INTO `tblappointmenttypes` (`AppointmentTypeID`, `TypeName`, `Description`, `DefaultDuration`, `Status`) VALUES
(1, 'Consultation', 'Initial or follow-up dental consultation', 30, 'Active'),
(2, 'Dental Cleaning', 'Routine dental cleaning', 60, 'Active'),
(3, 'Tooth Extraction', 'Dental extraction appointment', 60, 'Active'),
(4, 'Dental Filling', 'Dental filling procedure', 60, 'Active'),
(5, 'Root Canal', 'Root canal treatment', 90, 'Active'),
(6, 'Orthodontic Adjustment', 'Braces/orthodontic adjustment', 30, 'Active'),
(7, 'Follow-up', 'Follow-up consultation or treatment', 30, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblauditlogs`
--

CREATE TABLE `tblauditlogs` (
  `AuditLogID` bigint(20) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `Action` varchar(100) NOT NULL,
  `EntityName` varchar(100) DEFAULT NULL,
  `RecordID` varchar(50) DEFAULT NULL,
  `OldValue` text DEFAULT NULL,
  `NewValue` text DEFAULT NULL,
  `IPAddress` varchar(45) DEFAULT NULL,
  `Timestamp` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblauditlogs`
--

INSERT INTO `tblauditlogs` (`AuditLogID`, `UserID`, `Action`, `EntityName`, `RecordID`, `OldValue`, `NewValue`, `IPAddress`, `Timestamp`) VALUES
(1, 1, 'Login', 'tblUsers', '1', NULL, NULL, '192.168.1.10', '2026-10-01 07:55:00'),
(2, 2, 'Login', 'tblUsers', '2', NULL, NULL, '192.168.1.11', '2026-10-01 08:00:00'),
(3, 2, 'Create Patient', 'tblPatients', '1', NULL, 'PAT-00001 John Santos', '192.168.1.11', '2026-10-01 08:10:00'),
(4, 2, 'Create Patient', 'tblPatients', '2', NULL, 'PAT-00002 Angela Cruz', '192.168.1.11', '2026-10-01 09:00:00'),
(5, 2, 'Create Appointment', 'tblAppointments', '1', NULL, 'APT-202610-001', '192.168.1.11', '2026-10-01 08:15:00'),
(6, 2, 'Create Appointment', 'tblAppointments', '2', NULL, 'APT-202610-002', '192.168.1.11', '2026-10-01 09:05:00'),
(7, 3, 'Create Dental Record', 'tblDentalRecords', '1', NULL, 'Initial consultation', '192.168.1.12', '2026-10-01 09:05:00'),
(8, 2, 'Create Invoice', 'tblInvoices', '1', NULL, 'INV-202610-001', '192.168.1.11', '2026-10-01 09:15:00'),
(9, 2, 'Receive Payment', 'tblPayments', '1', NULL, 'PAY-202610-001 500.00', '192.168.1.11', '2026-10-01 09:16:00'),
(10, 1, 'Stock Stock In', 'tblInventoryTransactions', '1', '0', '60', '192.168.1.10', '2026-10-01 07:50:00'),
(11, 2, 'Create Patient', 'tblPatients', '3', NULL, 'PAT-00003 Harvey Elloso', '192.168.1.11', '2026-10-02 10:15:00'),
(12, 2, 'Create Appointment', 'tblAppointments', '3', NULL, 'APT-202610-003', '192.168.1.11', '2026-10-02 10:20:00'),
(13, 3, 'Add Treatment', 'tblTreatmentRecords', '3', NULL, 'Dental Filling', '192.168.1.12', '2026-10-02 13:30:00'),
(14, 2, 'Receive Payment', 'tblPayments', '3', NULL, 'PAY-202610-003 600.00', '192.168.1.11', '2026-10-02 13:31:00'),
(15, 2, 'Create Patient', 'tblPatients', '4', NULL, 'PAT-00004 Sofia Reyes', '192.168.1.11', '2026-10-02 13:20:00'),
(16, 2, 'Create Patient', 'tblPatients', '5', NULL, 'PAT-00005 Miguel Garcia', '192.168.1.11', '2026-10-03 08:30:00'),
(17, 2, 'Create Patient', 'tblPatients', '6', NULL, 'PAT-00006 Jasmine Tan', '192.168.1.11', '2026-10-03 11:45:00'),
(18, 2, 'Create Appointment', 'tblAppointments', '4', NULL, 'APT-202610-004', '192.168.1.11', '2026-10-02 13:25:00'),
(19, 4, 'Create Dental Record', 'tblDentalRecords', '4', NULL, 'Pulpitis on tooth 16', '192.168.1.12', '2026-10-03 09:10:00'),
(20, 2, 'Create Invoice', 'tblInvoices', '4', NULL, 'INV-202610-004', '192.168.1.11', '2026-10-03 10:35:00'),
(21, 2, 'Receive Payment', 'tblPayments', '4', NULL, 'PAY-202610-004 3000.00', '192.168.1.11', '2026-10-03 10:36:00'),
(22, 2, 'Create Treatment Plan', 'tblTreatmentPlans', '2', NULL, 'Pulpitis treatment plan', '192.168.1.11', '2026-10-03 10:40:00'),
(23, 1, 'Stock Stock Out', 'tblInventoryTransactions', '8', '50', '38', '192.168.1.10', '2026-10-03 09:20:00'),
(24, 2, 'Create Appointment', 'tblAppointments', '6', NULL, 'APT-202610-006', '192.168.1.11', '2026-10-03 11:50:00'),
(25, 4, 'Add Treatment', 'tblTreatmentRecords', '6', NULL, 'Orthodontic Adjustment', '192.168.1.13', '2026-10-04 10:30:00'),
(26, 2, 'Receive Payment', 'tblPayments', '6', NULL, 'PAY-202610-006 1000.00', '192.168.1.11', '2026-10-04 10:41:00'),
(27, 2, 'Create Patient', 'tblPatients', '7', NULL, 'PAT-00007 Daniel Mendoza', '192.168.1.11', '2026-10-05 09:10:00'),
(28, 2, 'Create Patient', 'tblPatients', '8', NULL, 'PAT-00008 Camille Navarro', '192.168.1.11', '2026-10-06 14:00:00'),
(29, 3, 'Create Dental Record', 'tblDentalRecords', '7', NULL, 'Routine check-up', '192.168.1.12', '2026-10-05 09:40:00'),
(30, 4, 'Create Dental Record', 'tblDentalRecords', '8', NULL, 'Dental cleaning', '192.168.1.12', '2026-10-06 13:10:00'),
(31, 2, 'Create Invoice', 'tblInvoices', '8', NULL, 'INV-202610-008', '192.168.1.11', '2026-10-06 14:15:00'),
(32, 2, 'Receive Payment', 'tblPayments', '8', NULL, 'PAY-202610-008 800.00', '192.168.1.11', '2026-10-06 14:16:00'),
(33, 3, 'Create Appointment', 'tblAppointments', '9', NULL, 'APT-202610-009', '192.168.1.12', '2026-10-06 10:00:00'),
(34, 3, 'Create Dental Record', 'tblDentalRecords', '9', NULL, 'Root canal in progress', '192.168.1.12', '2026-10-07 09:10:00'),
(35, 2, 'Create Invoice', 'tblInvoices', '9', NULL, 'INV-202610-009', '192.168.1.11', '2026-10-07 10:45:00'),
(36, 2, 'Receive Payment', 'tblPayments', '9', NULL, 'PAY-202610-009 4000.00', '192.168.1.11', '2026-10-07 10:46:00'),
(37, 4, 'Update Dental Chart', 'tblDentalChart', '9', NULL, 'Tooth 14 root canal in progress', '192.168.1.13', '2026-10-07 10:20:00'),
(38, 2, 'Create Appointment', 'tblAppointments', '10', NULL, 'APT-202610-010', '192.168.1.11', '2026-10-07 09:00:00'),
(39, 2, 'Create Invoice', 'tblInvoices', '10', NULL, 'INV-202610-010', '192.168.1.11', '2026-10-07 15:10:00'),
(40, 2, 'Receive Payment', 'tblPayments', '10', NULL, 'PAY-202610-010 2500.00', '192.168.1.11', '2026-10-07 15:11:00'),
(41, 2, 'Create Appointment', 'tblAppointments', '11', NULL, 'APT-202610-011', '192.168.1.11', '2026-10-07 15:00:00'),
(42, 2, 'Create Appointment', 'tblAppointments', '12', NULL, 'APT-202610-012', '192.168.1.11', '2026-10-07 15:30:00'),
(43, 1, 'Export Report', 'Reports', NULL, NULL, 'October 2026 patient balance report', '192.168.1.10', '2026-10-08 11:30:00'),
(44, 1, 'Login', 'tblUsers', '1', NULL, NULL, 'DESKTOP-QB0QSD4', '2026-10-08 13:16:08'),
(45, 1, 'Login', 'tblUsers', '1', NULL, NULL, 'DESKTOP-BNS75JM', '2026-10-12 00:28:55'),
(46, 1, 'Upload Medical Image', 'tblMedicalImages', '3', NULL, 'CBCT / 3D Scan - PAT-00005_CBCT___3D_Scan_20261011.jpg', 'DESKTOP-BNS75JM', '2026-10-12 00:29:26'),
(47, 1, 'Print Medical Image', '1', NULL, NULL, NULL, 'DESKTOP-BNS75JM', '2026-10-12 00:31:43'),
(48, 1, 'Print Medical Image', '1', NULL, NULL, NULL, 'DESKTOP-BNS75JM', '2026-10-12 00:32:13'),
(49, 1, 'Print Medical Image', '1', NULL, NULL, NULL, 'DESKTOP-BNS75JM', '2026-10-12 00:32:48'),
(50, 1, 'Login', 'tblUsers', '1', NULL, NULL, 'DESKTOP-BNS75JM', '2026-10-12 00:45:11'),
(51, 1, 'Upload Medical Image', 'tblMedicalImages', '4', NULL, 'Occlusal X-ray - images (1).jpg', 'DESKTOP-BNS75JM', '2026-10-12 00:45:32');

-- --------------------------------------------------------

--
-- Table structure for table `tbldentalchart`
--

CREATE TABLE `tbldentalchart` (
  `DentalChartID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `ToothNumber` varchar(10) NOT NULL,
  `ToothCondition` varchar(100) DEFAULT NULL,
  `Surface` varchar(50) DEFAULT NULL,
  `Notes` text DEFAULT NULL,
  `UpdatedBy` int(11) DEFAULT NULL,
  `UpdatedAt` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbldentalchart`
--

INSERT INTO `tbldentalchart` (`DentalChartID`, `PatientID`, `ToothNumber`, `ToothCondition`, `Surface`, `Notes`, `UpdatedBy`, `UpdatedAt`) VALUES
(1, 1, '14', 'Cavity', 'Occlusal', 'Early caries; sensitivity reported.', 1, '2026-10-01 09:10:00'),
(2, 2, '24', 'Healthy', 'Whole tooth', 'No abnormal findings.', 4, '2026-10-01 10:15:00'),
(3, 3, '36', 'Filled', 'Occlusal', 'Composite restoration completed.', 3, '2026-10-02 13:25:00'),
(4, 4, '16', 'Root canal', 'Whole tooth', 'Root canal treatment initiated.', 4, '2026-10-03 10:00:00'),
(5, 5, '46', 'Extracted', 'Whole tooth', 'Extraction completed.', 4, '2026-10-03 15:00:00'),
(6, 6, '11', 'Orthodontic appliance', 'Whole tooth', 'Braces present and stable.', 4, '2026-10-04 10:25:00'),
(7, 7, '11', 'Healthy', 'Whole tooth', 'No caries observed.', 3, '2026-10-05 10:00:00'),
(8, 8, '26', 'Healthy', 'Whole tooth', 'Mild gingival inflammation noted.', 4, '2026-10-06 13:50:00'),
(9, 1, '14', 'Root canal in progress', 'Whole tooth', 'Working length established.', 3, '2026-10-07 10:20:00'),
(10, 2, '16', 'Healthy', 'Whole tooth', 'No new lesion observed.', 4, '2026-10-07 14:45:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbldentalrecords`
--

CREATE TABLE `tbldentalrecords` (
  `DentalRecordID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `AppointmentID` int(11) DEFAULT NULL,
  `DentistID` int(11) NOT NULL,
  `VisitDate` datetime NOT NULL DEFAULT current_timestamp(),
  `ChiefComplaint` text DEFAULT NULL,
  `Diagnosis` text DEFAULT NULL,
  `ClinicalNotes` text DEFAULT NULL,
  `Recommendations` text DEFAULT NULL,
  `NextVisitDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbldentalrecords`
--

INSERT INTO `tbldentalrecords` (`DentalRecordID`, `PatientID`, `AppointmentID`, `DentistID`, `VisitDate`, `ChiefComplaint`, `Diagnosis`, `ClinicalNotes`, `Recommendations`, `NextVisitDate`) VALUES
(1, 1, 1, 3, '2026-10-01 09:05:00', 'Tooth sensitivity', 'Early caries on tooth 14', 'Sensitivity to cold; no swelling.', 'Restore tooth 14 and maintain oral hygiene.', '2026-10-05'),
(2, 2, 2, 4, '2026-10-01 10:10:00', 'Routine cleaning', 'Mild plaque and calculus', 'General scaling and polishing completed.', 'Brush twice daily and return for routine cleaning.', '2026-10-08'),
(3, 3, 3, 3, '2026-10-02 13:10:00', 'Cavity', 'Occlusal caries on tooth 36', 'Caries removed and restoration planned.', 'Avoid sugary snacks and return for filling.', '2026-10-08'),
(4, 4, 4, 4, '2026-10-03 09:10:00', 'Severe tooth pain', 'Pulpitis on tooth 16', 'Pain reproduced during testing.', 'Proceed with root canal treatment.', '2026-10-07'),
(5, 5, 5, 5, '2026-10-03 14:10:00', 'Loose tooth', 'Non-restorable tooth 46', 'Extraction completed without complication.', 'Follow post-extraction instructions.', '2026-10-07'),
(6, 6, 6, 6, '2026-10-04 10:10:00', 'Orthodontic follow-up', 'Stable orthodontic treatment', 'Wire and elastic ligatures adjusted.', 'Continue orthodontic hygiene.', '2026-10-08'),
(7, 7, 7, 3, '2026-10-05 09:40:00', 'Dental check-up', 'No active caries', 'Oral examination completed.', 'Continue preventive care.', '2026-10-08'),
(8, 8, 8, 4, '2026-10-06 13:10:00', 'Cleaning', 'Mild gingival inflammation', 'Scaling and polishing completed.', 'Improve flossing and return for review.', '2026-10-08'),
(9, 1, 9, 3, '2026-10-07 09:10:00', 'Persistent tooth pain', 'Pulpal infection on tooth 14', 'Root canal initiated; working length established.', 'Complete root canal and return for restoration.', '2026-10-08'),
(10, 2, 10, 4, '2026-10-07 14:10:00', 'Follow-up', 'Improved gingival health', 'Healing satisfactory after cleaning.', 'Maintain oral hygiene.', '2026-10-08');

-- --------------------------------------------------------

--
-- Table structure for table `tblinventorytransactions`
--

CREATE TABLE `tblinventorytransactions` (
  `TransactionID` bigint(20) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `TransactionType` varchar(20) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `TransactionDate` datetime NOT NULL DEFAULT current_timestamp(),
  `Reference` varchar(100) DEFAULT NULL,
  `PerformedBy` int(11) NOT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblinventorytransactions`
--

INSERT INTO `tblinventorytransactions` (`TransactionID`, `ProductID`, `TransactionType`, `Quantity`, `TransactionDate`, `Reference`, `PerformedBy`, `Notes`) VALUES
(1, 1, 'Stock In', 65, '2026-10-01 08:01:00', 'PO-202610-001', 1, 'October opening stock'),
(2, 1, 'Stock Out', 15, '2026-10-03 11:00:00', 'APT-202610-001', 2, 'October procedure usage'),
(3, 2, 'Stock In', 80, '2026-10-01 08:02:00', 'PO-202610-001', 1, 'October opening stock'),
(4, 2, 'Stock Out', 30, '2026-10-04 12:00:00', 'APT-202610-002', 2, 'October procedure usage'),
(5, 3, 'Stock In', 125, '2026-10-01 08:03:00', 'PO-202610-001', 1, 'October opening stock'),
(6, 3, 'Stock Out', 25, '2026-10-05 13:00:00', 'APT-202610-003', 2, 'October procedure usage'),
(7, 4, 'Stock In', 112, '2026-10-01 08:04:00', 'PO-202610-001', 1, 'October opening stock'),
(8, 4, 'Stock Out', 12, '2026-10-06 14:00:00', 'APT-202610-004', 2, 'October procedure usage'),
(9, 5, 'Stock In', 140, '2026-10-01 08:05:00', 'PO-202610-001', 1, 'October opening stock'),
(10, 5, 'Stock Out', 40, '2026-10-07 10:00:00', 'APT-202610-005', 2, 'October procedure usage'),
(11, 6, 'Stock In', 240, '2026-10-01 08:06:00', 'PO-202610-001', 1, 'October opening stock'),
(12, 6, 'Stock Out', 40, '2026-10-02 11:00:00', 'APT-202610-006', 2, 'October procedure usage'),
(13, 7, 'Stock In', 112, '2026-10-01 08:07:00', 'PO-202610-001', 1, 'October opening stock'),
(14, 7, 'Stock Out', 12, '2026-10-03 12:00:00', 'APT-202610-007', 2, 'October procedure usage'),
(15, 8, 'Stock In', 106, '2026-10-01 08:08:00', 'PO-202610-001', 1, 'October opening stock'),
(16, 8, 'Stock Out', 6, '2026-10-04 13:00:00', 'APT-202610-008', 2, 'October procedure usage'),
(17, 9, 'Stock In', 120, '2026-10-01 08:09:00', 'PO-202610-001', 1, 'October opening stock'),
(18, 9, 'Stock Out', 20, '2026-10-05 14:00:00', 'APT-202610-009', 2, 'October procedure usage'),
(19, 10, 'Stock In', 104, '2026-10-01 08:10:00', 'PO-202610-001', 1, 'October opening stock'),
(20, 10, 'Stock Out', 4, '2026-10-06 10:00:00', 'APT-202610-010', 2, 'October procedure usage'),
(21, 11, 'Stock In', 110, '2026-10-01 08:11:00', 'PO-202610-002', 1, 'October opening stock'),
(22, 11, 'Stock Out', 10, '2026-10-07 11:00:00', 'APT-202610-011', 2, 'October procedure usage'),
(23, 12, 'Stock In', 37, '2026-10-01 08:12:00', 'PO-202610-002', 1, 'October opening stock'),
(24, 12, 'Stock Out', 7, '2026-10-02 12:00:00', 'APT-202610-012', 2, 'October procedure usage'),
(25, 13, 'Stock In', 20, '2026-10-01 09:13:00', 'PO-202610-002', 1, 'October opening stock'),
(26, 14, 'Stock In', 200, '2026-10-01 09:14:00', 'PO-202610-002', 1, 'October opening stock'),
(27, 15, 'Stock In', 200, '2026-10-01 09:15:00', 'PO-202610-002', 1, 'October opening stock'),
(28, 16, 'Stock In', 200, '2026-10-01 09:16:00', 'PO-202610-002', 1, 'October opening stock'),
(29, 17, 'Stock In', 20, '2026-10-01 09:17:00', 'PO-202610-002', 1, 'October opening stock'),
(30, 18, 'Stock In', 50, '2026-10-01 09:18:00', 'PO-202610-002', 1, 'October opening stock'),
(31, 19, 'Stock In', 20, '2026-10-01 09:19:00', 'PO-202610-002', 1, 'October opening stock'),
(32, 20, 'Stock In', 20, '2026-10-01 09:20:00', 'PO-202610-002', 1, 'October opening stock'),
(33, 21, 'Stock In', 20, '2026-10-01 09:21:00', 'PO-202610-003', 1, 'October opening stock'),
(34, 22, 'Stock In', 30, '2026-10-01 09:22:00', 'PO-202610-003', 1, 'October opening stock'),
(35, 23, 'Stock In', 20, '2026-10-01 09:23:00', 'PO-202610-003', 1, 'October opening stock'),
(36, 24, 'Stock In', 30, '2026-10-01 09:24:00', 'PO-202610-003', 1, 'October opening stock'),
(37, 25, 'Stock In', 30, '2026-10-01 09:25:00', 'PO-202610-003', 1, 'October opening stock'),
(38, 26, 'Stock In', 20, '2026-10-01 09:26:00', 'PO-202610-003', 1, 'October opening stock'),
(39, 27, 'Stock In', 20, '2026-10-01 09:27:00', 'PO-202610-003', 1, 'October opening stock'),
(40, 28, 'Stock In', 30, '2026-10-01 09:28:00', 'PO-202610-003', 1, 'October opening stock'),
(41, 29, 'Stock In', 20, '2026-10-01 09:29:00', 'PO-202610-003', 1, 'October opening stock'),
(42, 30, 'Stock In', 50, '2026-10-01 09:30:00', 'PO-202610-003', 1, 'October opening stock'),
(43, 31, 'Stock In', 100, '2026-10-01 09:31:00', 'PO-202610-004', 1, 'October opening stock'),
(44, 32, 'Stock In', 10, '2026-10-01 09:32:00', 'PO-202610-004', 1, 'October opening stock'),
(45, 33, 'Stock In', 20, '2026-10-01 09:33:00', 'PO-202610-004', 1, 'October opening stock'),
(46, 34, 'Stock In', 500, '2026-10-01 09:34:00', 'PO-202610-004', 1, 'October opening stock'),
(47, 35, 'Stock In', 30, '2026-10-01 09:35:00', 'PO-202610-004', 1, 'October opening stock'),
(48, 36, 'Stock In', 30, '2026-10-01 09:36:00', 'PO-202610-004', 1, 'October opening stock'),
(49, 37, 'Stock In', 10, '2026-10-01 09:37:00', 'PO-202610-004', 1, 'October opening stock'),
(50, 38, 'Stock In', 15, '2026-10-01 09:38:00', 'PO-202610-004', 1, 'October opening stock'),
(51, 39, 'Stock In', 10, '2026-10-01 09:39:00', 'PO-202610-004', 1, 'October opening stock'),
(52, 40, 'Stock In', 10, '2026-10-01 09:40:00', 'PO-202610-004', 1, 'October opening stock'),
(53, 41, 'Stock In', 20, '2026-10-01 09:41:00', 'PO-202610-005', 1, 'October opening stock'),
(54, 42, 'Stock In', 20, '2026-10-01 09:42:00', 'PO-202610-005', 1, 'October opening stock'),
(55, 43, 'Stock In', 30, '2026-10-01 09:43:00', 'PO-202610-005', 1, 'October opening stock'),
(56, 44, 'Stock In', 20, '2026-10-01 09:44:00', 'PO-202610-005', 1, 'October opening stock'),
(57, 1, 'Stock In', 50, '2026-10-08 20:44:18', NULL, 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblinvoiceitems`
--

CREATE TABLE `tblinvoiceitems` (
  `InvoiceItemID` int(11) NOT NULL,
  `InvoiceID` int(11) NOT NULL,
  `TreatmentRecordID` int(11) DEFAULT NULL,
  `Description` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 1,
  `UnitPrice` decimal(10,2) NOT NULL,
  `Discount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `TotalAmount` decimal(12,2) GENERATED ALWAYS AS (`Quantity` * `UnitPrice` - `Discount`) STORED
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblinvoiceitems`
--

INSERT INTO `tblinvoiceitems` (`InvoiceItemID`, `InvoiceID`, `TreatmentRecordID`, `Description`, `Quantity`, `UnitPrice`, `Discount`) VALUES
(1, 1, 1, 'Dental Consultation', 1, 500.00, 0.00),
(2, 2, 2, 'Dental Cleaning', 1, 800.00, 0.00),
(3, 3, 3, 'Dental Filling', 1, 1200.00, 0.00),
(4, 4, 4, 'Root Canal', 1, 8000.00, 0.00),
(5, 5, 5, 'Tooth Extraction', 1, 1500.00, 0.00),
(6, 6, 6, 'Orthodontic Adjustment', 1, 1000.00, 0.00),
(7, 7, 7, 'Dental Consultation', 1, 500.00, 0.00),
(8, 8, 8, 'Dental Cleaning', 1, 800.00, 0.00),
(9, 9, 9, 'Root Canal', 1, 8000.00, 0.00),
(10, 10, 10, 'Gum Treatment', 1, 2500.00, 0.00),
(11, 9, NULL, 'Dental Crown', 1, 10000.00, 2000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblinvoices`
--

CREATE TABLE `tblinvoices` (
  `InvoiceID` int(11) NOT NULL,
  `InvoiceNumber` varchar(30) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `AppointmentID` int(11) DEFAULT NULL,
  `InvoiceDate` datetime NOT NULL DEFAULT current_timestamp(),
  `SubTotal` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Discount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `TotalAmount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `AmountPaid` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Balance` decimal(10,2) GENERATED ALWAYS AS (`TotalAmount` - `AmountPaid`) STORED,
  `Status` varchar(30) NOT NULL DEFAULT 'Unpaid'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblinvoices`
--

INSERT INTO `tblinvoices` (`InvoiceID`, `InvoiceNumber`, `PatientID`, `AppointmentID`, `InvoiceDate`, `SubTotal`, `Discount`, `TotalAmount`, `AmountPaid`, `Status`) VALUES
(1, 'INV-202610-001', 1, 1, '2026-10-01 09:15:00', 500.00, 0.00, 500.00, 500.00, 'Paid'),
(2, 'INV-202610-002', 2, 2, '2026-10-01 10:20:00', 800.00, 0.00, 800.00, 800.00, 'Paid'),
(3, 'INV-202610-003', 3, 3, '2026-10-02 13:30:00', 1200.00, 0.00, 1200.00, 600.00, 'Partially Paid'),
(4, 'INV-202610-004', 4, 4, '2026-10-03 10:35:00', 8000.00, 0.00, 8000.00, 3000.00, 'Partially Paid'),
(5, 'INV-202610-005', 5, 5, '2026-10-03 15:10:00', 1500.00, 0.00, 1500.00, 1500.00, 'Paid'),
(6, 'INV-202610-006', 6, 6, '2026-10-04 10:40:00', 1000.00, 0.00, 1000.00, 1000.00, 'Paid'),
(7, 'INV-202610-007', 7, 7, '2026-10-05 10:10:00', 500.00, 0.00, 500.00, 500.00, 'Paid'),
(8, 'INV-202610-008', 8, 8, '2026-10-06 14:15:00', 800.00, 0.00, 800.00, 800.00, 'Paid'),
(9, 'INV-202610-009', 1, 9, '2026-10-07 10:45:00', 16000.00, 0.00, 16000.00, 16000.00, 'Paid'),
(10, 'INV-202610-010', 2, 10, '2026-10-07 15:10:00', 2500.00, 0.00, 2500.00, 2500.00, 'Paid'),
(11, 'INV-00011', 5, NULL, '2026-10-08 20:52:37', 0.00, 0.00, 0.00, 0.00, 'Unpaid');

-- --------------------------------------------------------

--
-- Table structure for table `tblmedicalhistory`
--

CREATE TABLE `tblmedicalhistory` (
  `MedicalHistoryID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `Allergies` text DEFAULT NULL,
  `CurrentMedications` text DEFAULT NULL,
  `MedicalConditions` text DEFAULT NULL,
  `PreviousSurgeries` text DEFAULT NULL,
  `FamilyMedicalHistory` text DEFAULT NULL,
  `OtherNotes` text DEFAULT NULL,
  `HasDiabetes` tinyint(1) NOT NULL DEFAULT 0,
  `HasHypertension` tinyint(1) NOT NULL DEFAULT 0,
  `HasHeartDisease` tinyint(1) NOT NULL DEFAULT 0,
  `HasAsthma` tinyint(1) NOT NULL DEFAULT 0,
  `HasPregnant` tinyint(1) NOT NULL DEFAULT 0,
  `HasSmoker` tinyint(1) NOT NULL DEFAULT 0,
  `HasBleedingDisorder` tinyint(1) NOT NULL DEFAULT 0,
  `UpdatedAt` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblmedicalhistory`
--

INSERT INTO `tblmedicalhistory` (`MedicalHistoryID`, `PatientID`, `Allergies`, `CurrentMedications`, `MedicalConditions`, `PreviousSurgeries`, `FamilyMedicalHistory`, `OtherNotes`, `HasDiabetes`, `HasHypertension`, `HasHeartDisease`, `HasAsthma`, `HasPregnant`, `HasSmoker`, `HasBleedingDisorder`, `UpdatedAt`) VALUES
(1, 1, 'None', 'None', 'None', 'None', 'No significant family history', 'No known dental medication issues.', 0, 0, 0, 0, 0, 0, 0, '2026-10-01 08:20:00'),
(2, 2, 'Penicillin', 'Cetirizine', 'Allergic rhinitis', 'None', 'Hypertension in father', 'Avoid penicillin-based medication.', 0, 0, 0, 0, 0, 0, 0, '2026-10-01 09:10:00'),
(3, 3, 'None', 'None', 'None', 'Appendectomy', 'None', 'No significant history.', 0, 0, 0, 0, 0, 0, 0, '2026-10-02 10:25:00'),
(4, 4, 'None', 'Losartan', 'Hypertension', 'None', 'Hypertension in mother', 'Monitor blood pressure before lengthy treatment.', 0, 1, 0, 0, 0, 0, 0, '2026-10-02 13:30:00'),
(5, 5, 'Latex', 'None', 'None', 'None', 'None', 'Use latex-free gloves.', 0, 0, 0, 0, 0, 0, 0, '2026-10-03 08:40:00'),
(6, 6, 'None', 'None', 'Asthma', 'None', 'Asthma in family', 'Bring inhaler to appointments.', 0, 0, 0, 1, 0, 0, 0, '2026-10-03 11:55:00'),
(7, 7, 'None', 'None', 'None', 'None', 'Diabetes in family', 'Routine dental history.', 0, 0, 0, 0, 0, 0, 0, '2026-10-05 09:20:00'),
(8, 8, 'None', 'None', 'None', 'None', 'None', 'No known conditions.', 0, 0, 0, 0, 0, 0, 0, '2026-10-06 14:10:00');

-- --------------------------------------------------------

--
-- Table structure for table `tblmedicalimages`
--

CREATE TABLE `tblmedicalimages` (
  `ImageID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `ImageType` varchar(50) NOT NULL,
  `ImagePath` varchar(255) NOT NULL,
  `OriginalFileName` varchar(255) DEFAULT NULL,
  `DateUploaded` datetime NOT NULL DEFAULT current_timestamp(),
  `UploadedBy` int(11) DEFAULT NULL,
  `ImageData` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblmedicalimages`
--

INSERT INTO `tblmedicalimages` (`ImageID`, `PatientID`, `ImageType`, `ImagePath`, `OriginalFileName`, `DateUploaded`, `UploadedBy`, `ImageData`) VALUES
(1, 5, 'Panoramic X-ray', '5\\20261011_202245_54927f16.jpg', 'images.jpg', '2026-10-11 20:22:28', 1, NULL),
(2, 8, 'Other', '8\\20261011_204535_6f4456bb.jpg', 'images (1).jpg', '2026-10-11 20:45:28', 1, NULL),
(3, 5, 'CBCT / 3D Scan', '5\\20261012_002926_d7342caf.jpg', 'PAT-00005_CBCT___3D_Scan_20261011.jpg', '2026-10-12 00:29:22', 1, NULL);
INSERT INTO `tblmedicalimages` (`ImageID`, `PatientID`, `ImageType`, `ImagePath`, `OriginalFileName`, `DateUploaded`, `UploadedBy`, `ImageData`) VALUES
(4, 1, 'Occlusal X-ray', '', 'images (1).jpg', '2026-10-12 00:45:28', 1, 0xffd8ffe000104a46494600010100000100010000ffe201d84943435f50524f46494c45000101000001c800000000043000006d6e74725247422058595a2007e00001000100000000000061637370000000000000000000000000000000000000000000000000000000010000f6d6000100000000d32d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000964657363000000f0000000247258595a00000114000000146758595a00000128000000146258595a0000013c00000014777470740000015000000014725452430000016400000028675452430000016400000028625452430000016400000028637072740000018c0000003c6d6c756300000000000000010000000c656e5553000000080000001c007300520047004258595a200000000000006fa2000038f50000039058595a2000000000000062990000b785000018da58595a2000000000000024a000000f840000b6cf58595a20000000000000f6d6000100000000d32d706172610000000000040000000266660000f2a700000d59000013d000000a5b00000000000000006d6c756300000000000000010000000c656e5553000000200000001c0047006f006f0067006c006500200049006e0063002e00200032003000310036ffdb00430001010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101ffdb00430101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101ffc000110801d6028d03011100021101031101ffc4001f000002020203010101000000000000000005060407000801090a03020bffc4006e1000000107090602060407070f070b0207010003051121314104065161718191a1f01525b1c1d1e107350208131445f109163255263642657275821217528592b5d20a242734373846737695a2a5b2b4c21822445456577428394762648494a4b6c5e2869619296366a6d5f4ffc40014010100000000000000000000000000000000ffc40014110100000000000000000000000000000000ffda000c03010002110311003f00f7f04184184184184184022569147a37d00f4a5c90f464802d01967a60ab40455e88e22e531a414b4e9f589f0de6d80fa3b4c1232dfdcabf712005b869111584142bac58a20a093deb8490100f466e4dafdd007f0bfe755158036860d8415ccb3d6a3c595f96a3d1f56cfbe97544034cfacd78b4af87eabae9b98a50845ff94878d5f787a1fc9f47fa241cff00ca17c6dfbcf31fe9100e33eb27e362fcca2cfed0a39f26348241df58cf1b03e24e5b9f5374b82dc41c1df584f1ac1a138fd1078b0015550e8dab208e7bd617c6cfbcaaff00a05ae734305524187bc7ef1b3fed25ff00d60b676f98c0237efebe35ff00da31d5e4091ff291f1fbfed27fb8103bcd5f1dfc6cd9a1b4a723bff03c70b4816d3deb27e362312401f591400c0de00a55800186842499f1fbc6cffb497ed047d0fa1b85041cff00ca33c6bffb461fe71907420743de34f8b5b37697d64a94090d6a920a76757ac678d88dff00091634ed0e9452be80093ff293f1f91a8dfc760ff383a90b6e60641923f59af1f925fe1b7fac3a347410510619f59af1f99f86dfeb09069b8c0014d208d2cf5a8f1f91bfe1b2dafda120b1d18d312049ff009547ac7ffdb5fe30da105294fd036b201bff002a9f591ffbc8ff0058a3ba10043deb6deb44dfec902aa768482fbe8a9cd2052967adefad17fded7fac240b54354ba040b692f5d9f5b452bf7da5397bc240e70afb902d9ef5d9f5b457f75a67f9412080d91642e8902dcb3d79fd6d3fef695ffea0905838e4162882939edf481fae3235248d46237c6cd9f6ce090dfa5322d200923f5f4f5d8496cd5f8fc90d9dfe5048597ac290b557906d1207d783d6d1248cde5e2d241e0cfac1205d9d816d20bd50feb6beb21bb3fb245bf84121b6e81036a7bd687c7e46ff00e9207fce150901b967acd78d8afee91feb05b8198770790539393d6dbd643e1be240ff00fb818cb5ac8f4020d669e1ebc1eb6936ff00f4d8900177e304817f3d5a0b9327d7bbd71a7224b7978d80c5ff0084120646aaba905a292f5bdf5b4468ff0076cb7f082f6dce20187bd713d6d1bfd9b121ff00ee09069cea9c40b72cf5c4f5b4ff00beca7fc20b60e604305901243fad7fada2499fbf60bffed00d6ae5471206433eb35eb68ffdfb120aff002829e7c1b5103b21fd64fd68bfefb1201ffea17579560cac082da43f8fde3f2491bfddb7ff00f2067ce19b96406e45eb0beb21b4bfbad0c5f3818f80e9640ec67d66bc6c46ff00e96b6857b43e43cb8103248fd6bfc5affbc887de185ee8590207f46fac9f89092ff0dabf307f406b14aea0da81f1ff00c481f329ecafe31b17a1aab20769678ef3db66ac67b307f385e11d0901291f8e13dbfed25fb434d1b235103b237c629ec20afac80200fd5c231690619f1de723beb27418862de4f20e249eb1538fd267a538d1c2e60800e829bc6c06543fac2a4d25f1247d9d41d1ecb207e9278ce90f49be92411be955e9000f10174584057f7e20fcdd97420fb99f16ff003923c578bb9468bc824fefb21f7923b2e841cfefabf9c51ffca20e0f78c48dfbc91f0b70bf0c830cf8b68dfbc91f73ddce2c6500b202467c5446fde48ff9d7904614104835e29a305829247be956a80a5d590319bf1126e0a95e98fa36005c2ea5951011914f59b72f0ff9a93910b983e92f8af85240cc68f00836b674e60bae920924184184184184184184184184184102532e3721f403d295fa401e88bbd2f4418c7b18e20d6c9f9e3f231183b366d7f5fcbd5fdbea000062d80f05b9e3539a1a993aa71ce49c7bca724e448003b67841ff0035318b2049190a351bf0dda1fac2d0a97f3b08149252e49000bb411a32690043321c9763d765b9c08249990a37b4183c2969012f615e7d8830c98e6de8ccd55522411f64d597720907a431b743cdbc8823fb0af3ec4116472166a0bba0ea18e2025b26acbb9012f63e8e97d482a549229c1c2e7872b4806ed50d9a8dd9b1b7ade241939243bb57a6adf871201b33a1fb5cc824cb0c43583942b88d8a01207f9aa7d1bb376685d503f4cb20415bcf690ecd49560b6bf9b828ad8415ba48769237ad94c47bd4415b994aef2496b118872b0824a1cfa4b69528f0ab88727a9ac88494fcb91b55917419cdd610201e97235cc8d8c570e2a7904648cb96166ac8be8638814a587f5d9ea1b54d84014b685591024a465cb0b35645f431c40932c97737dfa155e40a47bef277356abb408359a75273694e4829b1a5e316b20b20b2267c9f768a4bbd6f8c431a482e39927d1b1d3bb6234ac036ad0e9646eedbd6ece9a327903fa60fed3492df4530b2eee4045312efbb7cc63dbb9053b3a64292cde3a7d2c20d54f157cb82ce44140cc34e6f2d502c5c716398241b56923ef4963c1818722009efc35644013dbef2f9aa8ed632b20764733f382bb594c732064327d24baf40fab9d2416d4c930d496d2658e6e56d2aa4580ed350fef2da4bd9e0eedac5ab107f32636924b692375541fc7208df121de5e5f01be3f30a1500e4ca97f9bd792855cc82e29abf7931f7dca5dcc85e21642365cfaee82db8c799046964e3fbcea7e3d179d0404d0338f69765f66bad6905c4652bab74c1881005914b9a92a976f551003964b9aba835d32206599ff957105a06539cd5969772e040c87939cd40ab14c558b6561490493295b30636a7d0b083c824ed4fd1c3b900d3c9ce6a0558a62ac5b2b0a4801fb7ab2ee418412bdf9228cafb864ad28822ed6af3ec403a5938d24fda54e2de37bd8419239c691462c21a175d86220ff353c469c88df2d497605fce920da999fe3b23525e96cf9c6b478a95efeb10f4456d6b330011001160b0083610c9ef425be808833d10bc8269061061061061061061025ceb9e2809968dda697977a26fd1507ee3d1010f4bd3958a94a600fa2350839c00300d1d9e1e2a4e4f120548dddf37ead537aed205c32f0b478100c3d2185cdbddcaf55240b693fc9d50409292319658bb3c88069012f6de8e97d0839f32b6f5ad7fecf1b48247b88579904d20f99e31b4babef7fcc1941061941f258aed5b576a9b50d04048ca2b50f95148d0a2025ee757fa4419ec2bcfb106bc789061255611a2c8f320ade4721f2db0430e54ad94903b24bf56db057182dcaa2a20c46c85c345cb8b3b70205cf71de517574f1cd759031a1e5cbe1c3178d20e20929231f5920dcfe76b0482ae9c9bb7768ad9569aa6de20a20a70cecdbeb5fcdee8dc4124f256cc18ca9f4a822f205b3c7d9ae148db58a808169331d7f088029e4e2351a8dadfa105f206d2409278fed2e8fb9df316d040b693fc9d50415ba60fbb0e0ced9902d9efbcefeece6343480224a5c1b3124926d5a52f8bef20d39494bb79235c3b41255e238f4a40361d1a7f66a36a7d0bcba414e020b466a98da5503eb682a2fd5821b4689f2b46ddc081d4f1fd5b9deaea20c92cd9bb351a92fbc2ba94aa2da4814a7225776f5657f2a183120d279e12ef32b726679906aea34c6f3492314cda5f2cafc8836ae6d9f49a4a6ddd66768d2b783564034f386c0e24014cf9985a24168cdb975b776f93eb206391cbb697e6f50afae98c6105a2813e9146a35241b499566ad35ea206491cbb93aed02ee207640a5766a37f38243fdc033d2ab102523308d5e9518d7645640c887426d2da4ce4f50e82f8a881d91a7f2cb076791036994aeed86a39be0d61024ef24952eb54203c325e40ed2397ecd56a3a65b6905c664feed753f37e6ab8830c1fda4fe8ea79b94a20c3d21ddaab6982dc148adb7b1a41ca212bb31248d17fc95d5e4163cb0c6ace9956d2037239731758ebae64047dfabf4757104a332e859a0e4ce6411bd8a4abc4839209064ff36746e4bae90202478fe9ba15c623154417258fb8388102410499198d777a86c5361006e91bee1e224068c9f66b85216d60b020b67c3ef189273292228c4908cbd1e20af700fb40b0105fa222b50c5cf52c0837bd0a9d464e3477a290467a612d917a62af4055e8888a816ef49e3435742c480f906106106106102078813f66ff0087137121396717a7e8fa062446d7fb90f4400e4ac540a0f405420e11580aff007220a006809075307bc4d9c9e36ce4494e4496ef9bcc47a3d1f6b882c8409fbb1ee11e31160369e78da1c0806fbc0d218874201b2c310d60f582a2362c40812658621ac1ca15c46c5009046f76ab5fca2093eee340601d48237b0d9ad5d5dea72d505901b33bcbb8e83b9049d93565dc83364d597720204053ddaad7f288219040961f46bacbbe79d00d20a6e783c6ce44082664e28dde5086b8b1c180469c87f76d1c29ac3176401250328492491b4055c1582fa90043c9cde5b362b76a8771734190c46fe4403658a46796d9dd5552b20409c8b4923541f0f8e9572c828af6de8e97d08024b0febb39616ad918871ec3e257fe569ff3201b3aa42a146dda1e4bb8812b76ae1ee1fb4beae205b332ec976b956db9c0816e58ff0087b83881056f390f8a4be25405d66aa205b961f46ecda2b88dfaad44152cf6976ed146af1bd4a7b1f409050278c6f246718055406036905fc92da5b351af5aea5e717b98f20b6911bb51af0d51a7906c84d53fb4b66a4b55d8c83ee5103ffb0de5f3553dec6d440c878fed254367f7d55c4128f487692abb9f43f4ab8352a71fc44835e13c8afab6931497de10a60e7f75dc12667ce4d9a92f32dde90b1ba5aba105cbefc15e640a1233fb4d2558435c1a416d21cfecd5416ac9508bf5106d919f8eb17ac1500b562040c88d3ead3f4b80860d2076469f5deeac73cc0080dfbf6cdd2d4ae3db00b210263696cdda4dd9ecab4a82954103a9e57c356fa97d7b90732c97335055d07d0d7104691a73e183af9e02406d247fcb556f5175b0a94e1206d46eedecfd522211020b45027fcb6180715d194220c92c3228d490e3d6ac8830f4bb96618c30a8816cf4be0dddfa50f0a29a082e340a7369236ce2f765a590113df67548101391bc6d0e20412bd88d7881011f6f565dc806cb0feace9956d20c327f4cd0ae10182a212b6b579f620e25895ddab6f00c74b790571ec2bcfb101a332ee790631c2a203678feaccaf57500c33b49785ab50d2ce5410463d2e8dedbddcaf5504175f84de25a47c394906d30019bf2f10f4a5e22a5fa3e943d205ada0b150d6a71076248b97235248ff412120f483d291cb7d11f483d200fdc80ac07d1115008805cbb080b906106100d964b4ca36427a5d2ef483d09348fd0f69e9fa400bf480015e807a4202200bff9cc6c56b6343a4ff59af1dc7c5a9ea929b48e148482684df0001f48015b40401a2a6a96202200b1556c205c9847ff0006f76eb51739a417f4d53fbb7356aaaf110206e32f0b4781045963c2d1e224010f1fd3742b8c462a88043cf1b43810648df70f1120927e1773208c64c375c680b2a05890123327146e37d8db39ac8190f18d5b95cbe8218664392ec7aecb7381011f71abd1d5e4014f187f4c439862030201bec7d1d2fa902dcb0feace9956d20add3c7ee7d1dc62dba02c0493c7f933ab725d74010123db3766eccaeee8a17d0abc806a1d2b558ac3a0aec610249e456f2da40f88a81ede355e40c87a5e8dd9bfabc46d0758eada40b6792ba8fce9a02959024cb25db37cb6abf07b83220494f228525bcddf26d217d241574b24292d9abf886037f0b4816cca55248c496cd4961ce156808094b3792ff375baa1b5ad6e20a9531f9c959e5d8802fb61fce380100c96ff004b99024a48c679e2fcb32049496ed5c5ced356a6af320a2a784bbeb20eed49797eb9bed5d040a536e428dda6afbc3e4a864c20bfa4683d9892fcde9080bdab0ab4ea482da404851a92ddb4431107d0a8f320bb26720c36686f2f2f52b20e0aa2c81059064fed246a4981bbc55ae24127dba91a8d0e9ae0f06b414037cb7434decc56b20d789f863796b285753042820d669d4f49583c008124ca2b690f99e6383a8ee2416d19970a4b66a34479b3ad3d1a41886f31bc38903ffbb55afe51032233f2b54903bc8df70f11207543987e1d87a0d6d79032236428dda41963d5ca5c2f07f46cbf66ebab74a206d3f1fdb2041964bbeedf882482f7c38e20b20346779ff17ea3c977b081fd11e597f5206c91f99fa36fa24169a34fef246fc86d60fc96e72818fdbed249824baa95cf4d6100d3cf1b438100d91c858aac75d73207699e7f66eedc7590b16241719931a6681508041700926515ab74c08890499618e5ca2abd4aa174100d9198d59d32ad8411a58f0b478890463261dd300e63888c0824fbb8d018075205b4c1fd6954dab62da2a08e7bcb06c0201864fe99a15c20305441da472ee7aeb9c480d99785a3c0816e58e0b078090493c7dfd711e41800448367bd5e7c5bf4d1c91099538447dc65c21e923a5ec548e5c0b59bf487d20167a4b105802fd1f4bf73e97fce001f44437d883083083453d75fc610993328265237cfe780282a9000b6b6a80042aa56221d439edda8d1586f1f88057a7296a15d00417678332e1d9c92468bd8ebc71d3082f543eeda742e5682a207f91bc6d0e204128cbc2d1e04114f18d5b95cbe82037ddc281c07a9067bb850380f5208fee215e64047ddaad7f28806fb6f474be8419233e92e0cb154e0345640ddedeacbb90453d2ee590e11c6b20092c3f1d62f58ae21628448026d6af3ec4037dbed275d93df55640933d8f8235aad54d7b7890257995b7ad6bff678da404767d79902dfb96eda9f9e0e8d31590291e4aecdd56ae7a68900e43a57cc9da1b5cc6d00415b4e4de5a0d56bbc806a34fad1bbcabf941d92c830ceed5411e90f92e9bc82b79d7215ba0c6f767320ab8f4843e25b4177d1aa58404a471de56f21e0d5f520add3d2ef86a4b782c6c10f95e4034c9f46ecdda596ace95024cb25db4b54ab0c6e12008923eede56f76846d6e0215b2625de67db3efd0828b4c18ff5854d52a300a204125186366ecd8c751d56241b3333f796f21056b969a40ff2d90ef3b2952ee5b482d9431fd9a8d87f5fc23a178d404164ff0083692496b20ad9745e11bdbed29b68d062a98d54415f2159004966cd496ccd58dae8510527e24799de41acd397cad2577020add0ff0076b3a58fe96903fa0643bc42dd54bb1a406cc98de4aa75885c2148b081911b2e492f66a9953439684082c843987e3c5bdf2207646a29bd1c2dcdf531640fe64c6cdb5906b95ab081fcf1f46a351bb4a3708c74bb88324663cb716dcdee1701036a625c08c46ebae195415b994aab66ecda288afb5ea06903b1ef2da0521e61c94115103b4c33ea66b052d57da4168a3643f76ab837e436b081911ae1d7e48103b193fbb7e585f6b6a208c64cef3ef8c3b51501cf710af3202264c3ba601cc71118103fa065dc6b53eb677207632619ae348d9502808091e31ab33b97d0016e46635ddcb0b16c8c424cb0c72e5155ea550ba082348cc6bbb96162d918847963ee0e20415fa48c2b4fd2e20183083118f1b0789061e30dd71a06ca854241cfb7ab2ee406b6a7e961dc830f1fd3742b8c462a8849f780a4711e8414e78913abeadecdd9a1bc3cc7a842cee241dc9780be22fa1e24f86b37a71fa63fd7c3e80c8122020cf7df47ed0ae86800f720bb88231d3c000cc3af45d7410747be2ccfff00df67c5a9c69100ddc8e50239b044b035d4835e67222be27f7805578b402e15f606df0acfef2490f65ae8f900906c8193eeeb80f21c042240ec8d3f96583b3c88097bcd7afe49049f7e1ab2208c652a8c75baa6ebdc4118f2551ba6d962edb5820419ef0148e23d083f041fa3df675481047f6de8e97d08383ce1b038907ebdf82bcc8061f85dcc8231e30dd71a06ca854241cfb0af3ec4156cea3fbca8b3435c571081056e9231b3596b9aa8069b9904943a738f5c6d76002003671cb925b342c075a2f7ab220ab8f4ba37b6f772bd541049439fb5ba5b62e7e0d1502da48c2351a92da40f6afa3ae5e302008924b6d306d9d455810648e5db4b76bb27e9cd208d3aad15a3e3aea2ac882af3295d9b6f652c814524637928377b78b98e85c0408098301fac02caefa231c0816fddaad7f288102587d1af73edd05105448148fc2ee6415ba6640fe77d3a7d640a52390a4925fc5ccca380106234f6d3496cd164017a78bfa906c3cdbdd936f668b62b53740e16d64168984aed21de510aab1703482db43985f992b6788d5a15903afb7da536dd42c1f165f7d1610621cc7e0da4aed2e8ba2a7b40127cb68761c1ac20adbc49f85ddc88357a7218d99b4924d1c2de40b85840928131f7972b71cdb5341fcf1f7f5c4790600112024878fe9103fc8e428df32574c2b847905908d31e5ba7e0d502fa0903fa34c24b6908ab77e78dfc622c07732bf8929d5aba7620189e4b6d2d9a8d8e0ae8aa6d6b1600c930c76924bf57c2fc17d05a41265895de5650ebf4d730832472162ab1d75cc81bbcb6dbd6b5ff00b3c2d206c9aa62ec83258103b48cff0099471566a51036cdb31b4d2742b98599746036c8cfa91ab8a3e8d6a024048cb82c1e240d9ee2356441c9931a66815080417006446c8766b15aeddd4d207691a57a8fcf863401018205ff006f565dc808104720092c785a3c44814a58639728aaf52a85d0411a467f5d9cb1b56d84031247d7a7695111c1a4010c9f775c0790e0211209840065895e95eb80d2a2092929c7b351bb49255298e569ac5d441af1b57eb24e5da4926ecff2f10c63f2a0837e3d4b7c4ef4a6c788677c3a480aa413b7d0f4bd34739a90f443f7400301fdd002842b5809076e841aedeb3f3fbd1f0e3c129ed3943f723e90a3851f21f4823e9a4c3f7023429820014285441d054d59d43b3769452092870a31e241641e3fb491bdfe799004993bb6726a02395905d041b7b233eb46af3d29581049919fd9af50077562a667681b3d2e85ba1e6ce44034f25750f95348d0a201bb42ac882299fb3aa4480dfbf0d591032c8e5cdd2d8bbe0fa5af20247e3fb64037d8fa3a5f5209278c6accee5f4008d2331ab7ae7530839f710af32088411cf1fe4ceadc975d004152cb0c6f2683740d50ab17d440933ae40e567dc80248de368710201b2c33b4b693fa64aeeda48100c98f321b96bbf4cbc824a04fd83c7060e759056e9e976f24959c1b16515bdcd2052f6f565dc806c8cfa499b35aed686d5903b4b25df1256ad5637b082b74918de4b49797869edeeb205b9c83e5a92c56190ac72205219086f2d9abcdba6ba920ab8f1f49514b1cc1869f05384021e456acd3420240b698308d0c30aaa7716ada409338fcb47662d6db1c37f7b8816d263b351bb4bcbdad5715ad9d5640808d977c483ef2873e772c082d1993bc9892bec86a0417a9f85dcc82db43a507e24bca9cf20510364d490eed4905623853df9901b43cbbf06d6d65bcef2049496cdddbdaa7e94e8902dcf0d9a93d46c5670604082819d48addaab6b1f95f40905286515b37792b38f1bf4006a5863696f2c3555e40fe8cfcad524168a3507bb2ae6dad60bb96da882c840a291b75dde97298e7103b19972311a8dddaca45ea7eab205bf7efbca9e7f2a975903248e422ada5f9b71ca8a15161032cc9dda8d49249773ac0aada157831a18fa37692e15c1aecc780bc8192588a567a5e60c68b624118f18d3740a8c422b803b4db31bc6cc9d7066ec41b92520de4af9474cac808a3651b3524da30a74da224168988dfc88247c4b54905806237f22027ee215e640748219e30fe988730c40604187a5092d9ae6b5b6bc6fa5ab53008148cce3de5bc9fd59a6042240ec652b660c6d4fa161079067bc0d218874208d2c3fa0c45c168bab01710043ce1b0389029193fbc9746b11bc468061062663afe1102d999742cd07267320c3c9ce4bcf4bb97020ab93f3e366d3b438b5614e1d4481013095494e4492d25e5f9554f56838809204ffc37e1f78b15abc830f78a9fbdbf89132672237cc11f3911eec6cbbe641e9810e90f452e8c46cbc01412e4648524000c64bcd7a474014d5007ee5841d6c7d28539367f84d3766d87c7d283e8ff00240007320e9264694fab9b37f568e9ef83d770105d736e75d75306fed89032194afe12231250a68a5f6a8836f6467f5d9ea0b54c8c419258f0b4788907c8830807904c917f479100c3ce1b0389037234fab4fd2e021834818ccfd9d5224187becea9020c3df67548104a9198523559696bc4830f4861736f772bd5490453df675481025260fdacd2d917bb0602c1491b2176b05f2a8816d331d7f0882b79198d0e00f1b01f5083c806a60fdeccb54b5b5b0149252e7557c16cc21c8809231e360f120ade78487e24a886baa81d440148f48796418c70a8823a48c6cd68e1488ea8e041c48d2bbb61b3e8705e0d5d705448100f4b97fabfa72c960b7900d494877688d16d783f9902d19456cdb3bad440849231bc925f21b1a1f25bdea01b2d57c3280b155c340a20514c20d24ca857dad208db0d1bf12876b2da3015056e99908249df0fafb6040a52c41a3766a382849697ab56406e6ac8766ce41fbb874aa60ecd441764da976f2a3685bc6b6e6a20b44c46fe440fe81fc5b1b478104933e5bb3558d7aa54a510294b243bcb8395207d4d63e30a882ae9c92ede55fc3975bc389054b3c0feed50474b70e22ab0816ccef246d375778696f2053f6e9256cdad50a7ad75ad440fc78c796d0cbc5d68dca06105a33265dbcb66a948e5c6f6b834b07b481b4c98da49205b367b1cb0f9e4d12064fac68d9b48da521e5eae1a5d8e5904946ca11be64e485aba69c9dc0809c8e71b91a8dcaa7681f020b466d8fe0e7de0bd72a483843cbb79236b7bb210b3120bf8cc879e618c30a8839332146f1b7e7ca1120347914af2d07bc819258635ddea0b14c8c4249931a6e857088c15106591bee1e224068f1866b8d216542b020b450327ddb6e96c10c470206d32f0b478100d3c6356e572fa08679950ec78b5a4048f1846af570d0c739a2b20a292521de785b0d02eaa8824a365c9246a3419a68b9cdeac7901246cea4685eed45f40f120643c95d59a68c008024e44e2351a8da2d66af18354241577d6447503974201a9e9e23e5baeab8f5204091cea493eee6155b454a208c984aa4b511eb53b2204991c8007692492492116eb4ca18d208d2d4e237e1965aac9bc8081fd0fbb519fc5bb407592d40a8044434c27e273694e4da41f79031f76a878907ab9f55d9d1e8a7bd5f7c2a4a082d735a448e60337406cfa7ffe82ae20eb8be96696fee7d1f0d517ff005ff465e03724402da083a864bbc7f5623ff9b881724738d2536d2752f152efe041b20809c68c492351b6dd9554aef20dd89ab2eda48c46a48598d6cd382820b48cfdad50241f120132c3fab7ae7534823193ecd70a42dac1604044cf95ea8120948d31d830eefb2b2025e5b65cefe970b081b646e1b038010152015eee140e03d480dc93cbb0e24118f1fd5995eaea000e58ebc3801057092de51adb83c1b76641f9204b4c1f763dc3a860e20ade45fd1e441193c7ed1e183033ac8128f7dad50041c48de368710201a98316334a641eec580b08db291dfc2c848123c53fc5b1b078905708d3ff00836c88c7bf05595855f2c3e931149237fcdd0c6367c882421e71ed24687e6f57517479e404a492e46a491b1d663db10ade589ca3e1f5e1f2200864c00a9248d5f10a82211203664c37692bcbf18083c82b94c7c4f54102ca6366e5a52e1aa4812533e5a3a87a44119032e496d25ad68f47c756696b20bb26e6cdda7d6e55fd964160ef2d2c81f502603ea4a4bef047aa0d8423d6e20252331b3600ad6a39902da6240926249b667af99054a78c3d263e5f9bd9a790204e4de50becbef5ac82348e6aecd6a4bfcdf406854a0020ab92463f091243f0ff0087f676b020248dddbbc9bd7e5a120b226da73f36ab96b9e20fe874e6cd524b66d91e0d5900d3c63696d20f30d058fe6159061e3e92d9afa02bc29a420406d0061248d46ef2f304845ba62ee8348361e649fddb465cc741884946c8411a92463bccf800d3a7b4836ad0e7d68dd76a623740823234c760c3bbecac81d646ebc780901d3df6b5401049f608efe1060040451a611bf307b56fb7ad2a06d3c6356e572fa083b21e5dc57c71165b9901b327f4cd0ae10182a2118f1fd5995eaea0128cbc2d1e041c4b0c6adeb9d4d20a093df8c816071206d9279761c4801c8d15d6bd701a5441c9e90ecdeae8d98c2e20409d9020483263566572fa0029a4bccfd1b04808994524b4d1c74a8c14048f1fd9a8d0636816059a5003e04140999724d249252de3876d3080dc921b36ab155c5efb880df89c95d9b36dabda090e6b554a8e42e68698260fa36c88d4f677a8083d54fd1e32d097faa8786c7a206927e8ff00f3e77d2ff8848345fe968fc64f093f56cbff009c883a8f9e07f545945cb11b482aef781a4310e840db33a750a352428d0f2fc96bbdcc64083b29f0353bb4a6d8fe6f5d16eb16905fc78fb35c291b6b15010463c7f933ab725d74010648cc73e7155ea552aa08089e70d81c4823a365ce0a2e5c19db89032239e16f320364126467f5d9ea0b54c8c4190c9fd5b95eaea2118fc7f6c80d99785a3c08024b0fe8311705a2eac05c40a52c97ed25ea3a6596900d3321c9763d765b9c08024b0feadeb9d4d20ade721fbf0ed45aca9a0b664c699a05420105c002260c58cd29907bb1602c16cc986eb8d016540b120c91a0db8e7aa162a62c8099e90a3577df564fb881453c634ab19c995800bc482aef108525b3766af053f835abcd641571931bb5f4fc9d92ef20409618fc24da578d8dc8636d840b69e93fd5b492e345511ecca0806cb25df76d6ea7e54d6b205b491f4955f9c00321871a082a54c25924292146024b6787e6f87c9a3681036a1d389246ed2846a175156624128ca6d25b4a2f1020913ab796cdddbfc60e56b55856e9831b35bf0f6319a0cde403919e5893b3a90364cf4aecdf896b50a94f50105d9233f1d62e50ae016a80481fe47e5a9286d06bdd43196e9440dbf9b5be5b9698f5900d91a73768a35cc6bb4dc2d2052f7e6eccd9b0e7c6e7900d3c8ad9bbcb670ff9bc68f9c0177ac829c9d495d9a92da492f2f682c63ce877620d5d964f1de5ff00fb08f050d2ee440112538d2292f897984343def20c9929c9c8929c8f486ef56829631cda9aa07f43ce39c8dd36baea7d6f20b690e954966ba57d78d4d20b690e7f76ed21eea6af842040ec78c2bcb43360f5e312064f0f76924a95aa9772564b6103aa7f696d2d5ce6d3550417fcc39731717d20cf9d943c81d4c98d9a9265a0b0186b4c202664fb35c290b6b058101b3c7dfd711e41800448099e78da1c0808a34c3f8e71e4140d441641e3fc99d5b92eba00823fb0af3ec4044ccb9b85ac6e70a1aa202464feaccef57500248e785bcc824cb0feace9956d20a29247f7924ba8f25fca22040ca8df2e1d440824c8df70f112088998ebf84414a260fef349670eb9503078728d31b49a185021aa38902dec50d7ee7a901a9648548d5b7153ed20a71307f66d6ea79a941d8814a5863e2601a6add7468510129ab215e01aa5591055de30273792351bff0050a5e0d88c157da4140a78fda3c3060675907a98fa3abfbd1bc34ff1a9efe71120d30fa5b0efee671f86c01f76ac2f4988871a1910120e9d7c43976f2ca16fca141054bedeacbb90493c7d9ae148db58a80836f7d5c3c4dd9a92d9a92492fe1fad5a041d947bf57e8eae2095233fcf9c1772d74aa9202265c160f120534c4bb82f8620cb32202481f2c1b44819246e1b0380101c91bee1e224044824993ecd70a42dac1604120f386c0e2404cccba37b2e7f3b974102924bccef0ff848231931a6681508041700fd100b497e55e4152a4914ceaf1666fa9a4187a429246a37abf5903081012489da5d28bf4abc8249931b37abaf7fc81949061f8fed902dcb23fb2401c8290f10de1facf90102948cc7e0dd1b4524daecd0418c120a71312e146a4bcb548f482d9ffb7df660a17bc0227a5c92492351bf3b63558b209336f696cdd9bb35da50b9f0a6c208e263f06f792ee8e4a67c882b696189b7f12b6fe8ca40005ee201b2c9c736d1abed455a68101240cbf76a49255abb66ff009080e33e2a4db497c3414356b4c2034652a8d9c6ada5b3c0750605afbc8024b2428d5ecd5aec771e35d040110c8a146a481d846dbb88905b533cfa4ace55da340af1705d864c375c680b2a058904946c851bb352492f882ba0afab783414a43e597872203723308de0db154e2345640a53d92bbb776daeb416cd29a41a4fe2126d24b574ac3200668082814c6f249d1b42c829cd52f3aa806d3c8946a3411aabac502f434d040c933e5e8d46ed3fd590b75c0830ccbbe1b68ab0f9b06f207f327f76e7df4170905a287976ed46d4f7e4216e0417aa052bb491a925defd3b54836cdb31b3551da15694ad2882e39649f6974bed503f1b44824cc34aecd496cc07c5942ef5b0836411a633cf07e599049f770a0701ea41f8203f237dc3c44818e466356f5cea6104af7ede517574f1cd7590361e3fbb7e55b2eb5959061990c6cd0726f32025ec7d1d2fa903248cc6ace9956c208d2c785a3c44829df89a46de840da4120814a721fbf018d421a0c416e59373fce18bbe4b208c6507b351b9aafa6bc88069e30fe988730c40604034f1fd3742b8c462a88503e2418ddbf21bdc1d6a204191cb924929b76a4fac3af17035a34fecd46a4925f77f97aa0da999e2241a989e4aed24924926f0b6a6bfa394408092973c28b9706f7e041eae7e8e3942bd513c35ff001a9dc923e9543aa5e21a5bf4b77e32786dfab7d1fe7220e97fc43f31c381054c923eab9f50e59009067bc0d21887420649b695d9b3911a9288d36c6f764a151076e3e1ef88c8d4923411a914906d16ea8ef4903f9e9c7b378ba95eab209265389252f4fed7c6820e7df82bcc80d2365cfaee82db8c7990321e97371b5adca34b16406e467f43883c2c175622f202464fe99a15c20305440d993ecd70a42dac1604036722711a8de18d5a6900d40a5369236e8687bd840c92c75e1c008148fc7f6c830f1f7f5c479060011201bedbd1d2fa100d3db378515bb4a7c48074b1f7071020ad8f1ff32aedce9cae208d2c3f1d62e502a2162c008069e3fab73bd5d44229e70d81c48239e33bb3be10ef4d41abd3c65dbcec6c45d6aeacd44114f1fddad1f2f7a3fad0d1aea6106b7a60fed2da5756a759482881926b4dc496cdda492c2bb59a1610499627366a4b93559d17d159053b3aa7524924927ecf1e4a7dd11a56041aef397cc87eef6d2e8baed2c806c8e429249c38d76abb38818e4695dddb3446c8dbceba4812f6524b796cdd75be92090813e9246d68f04964c706a95905d9234af4af5c4685903ba04c23525e5afe9a075d4101a43184923124afcdb8ad78db0c482f54398da536d243053d588e9f409046966ed9b7f9c1201c5a2e5e9f1201a87456ed007e78bad0bc4833ddc680c03a905153da5c921da5b32eaadc417a506a5cf04abd96064b00e77d44152cb0fed2496d2d69cc16e440c867696cdad7157ce9545ca890364db44ecdfe30bb4a66641606c3d9a9257de19f01207f9622b69a482847ecfda0a835acba0e1a48091e3fbcb66c17f2b9e04176a1cc6cd46837782435ab60417121cc7e0ddb6b717861590322352ade8e06e4ead8b201b2c31f121aba0338a88361e67a5568ceebc6a6e9641641e5fc354a50682ab083833f675489032c8cc6bbb96162d918849332e859a0e4ce6406ccc8735dae5db6e70203865e168f02035233faecf505aa64620c88d30ab9d50e598890337b88579902d4e40d9b4db7e84456a20a4918e1b47810321e976583d5659944823199746f65cfe772e8208dee215e6404ccfdad5024114f4861736f772bd54900d48c8563663d62ea5af2052492296b7f2b86004149f88521b23453a5e6c20a2e61cb9429246ffd431aaa85d91071e20a7066dcdb1b68d29ed7e241aa7edeacbb90059c87eec7bd3636b607ac3fa33bfbcf3c34ff001a9dfe71f4c834cbe96c35fba9c7e1b087ddaa0b926201c296c44083a519f87f7924a03d2d600361d8029c4c18b19a5320f762c0580d46cb9c145cb833b71203e41b728d4ead1a8d492355b4366f98445d1a3bd640ed23f135248d4907d645243f386bbd22241b0e81f1351c9246ecdc2cd522ab6016d21faffc4404cca576624b210800282146aa20352c3f1d62e502a2162c00806a1e71a925f3b58fa23c1e16d234faef75639e6004126587feedefcc5b7664034f4861736f772bd54904a407d90d44818cf1866b8d216542b020524918ee18f67595902d9e3fc99d5b92eba00833d8579f6208c79e36870205b3c95b706b6a752a083c81493121759abad6308234b242c5561ae99102d9e70d81c48249931a6e857088c1510093a92bb351b5d55b08359e47bc9269267980d4f5c1ba1590713aa43b351b83354fcc4829c91a2b796cd0f30486f07aefced5a964049312e494da75fd1cc65f80106bc27a5c92da5b4996b6c83150ced0529c921da48dda48d496be71b6912040f32b6f5ad7fecf1b48249e972351a21b35bd1f8f1201b23946d2eb7d8a07e36810464f1f49391bac14c0c236004329572be1ee5dfd082c846ca3696f2c2e63a97a882e39b689d9b42d61c6d5bdf9105a278ffe0da4a291c6176a30203730cfeed49558aa2e015423610493de628eb798101b91cbbe1bf775d0bb512052497ddae835c16a94f5c55d410275ecdd9bb36cbb885ad20d429c88346d8d00631fdf5120a4d307f792345ed56cfec390105b4650628d46c1690d3596f5a424a48fecdd9a08ef2f5b6a0bf15ae973560da8d976f3f9adabbe8cde406e6da5452292493b67a3d996ae53881fe4663692494ed9ccb6eaeb206404aef2f32f2f5aa1844046f20d909b72e5cdbd9af486adaa18ad80490262d1e18b032a882d19620f76af9ab3f99064dbdda93f32a755db4c56a20bb11a7dfc328f21a02b20368e7059c881d8f7960d80403646fb8788903fc93cbb0e2411bddc680c03a9012919fd7672c6d5b6100b4519f95aa480c10264ea3fbb75ca3732b534126468ae76614b58d6900d3c611aac7adab1a235104b20fcfb75799329aa9a3ab22041c9e78da1c082490453321e790e11c6b20089290baabe2a6610e44149f89d21b73f9e37106aea04c7e12249bac39090539e2a25b698361a1ab89053bedeacbb900d4979706a2241eb2be8d03eaf53bf0cc69389d0c125e98d03fc220d19fa613f193c26fd5fe97f3a7a641d284fc3fbc924bf9eeda9f95a2f20adcf1fd5b9deaea215bfbf6cd495ea5301f97ce040c7efd5fa3ab883647c374e6d29b7b3019b3d835374bc8624049247f79237b2ad5ddc58c20bd66d9ff2da75680052f7c1a41b572297a4be1ba6d555d41067b04924fcca872dd746b5502c20b451a636923766d8af9d0fadb6901246a29cccac16eaba881dfdf82bcc80d48cfc758b942b805aa012095ed86bc00816a452ede63a1bd4d20b22467f5674cab6100d4918771ce1cc291a8814bddc281c07a900d49b82d0e04017db0d78010241e9742dd0f367220cf6f565dc823248c2b4fd2e2018308168cfd9d5224128cf977ed73120aba7e4bb766cd7eb5d062080819b710d423ae2403678487692487eeff93559f761004333576924f697c42fd3a2ac0082b79e08ada40a4957c62da9abaea20a2a58830497993de2cd307a90294ea90ecd46ad1acfbc02deb61055c7915f31c16be03710129618ddb44bf55d34d2f205243eedde6223a72b805af203723de5e65152d75d1929c415b9e90c2e6deee57aa920b6a6a9f5cdb0fbc11d8d4b1e041764db3fb4ab5b70a695d041761931bb57ab7a8856b016a83f281fc5a495fc88259e30b0da51852111af5690499186edda576990beb000702d9e30fe988730c4060415bcf631feb0b54b5d0cada4149cea9b9f76ddd1f63407990538929a8b9c8a758e6671207f9648568d46db6d70b595b5e4036468aeb5eb80d2a208c64c6f2f9c63d18da0081b50c6366d7a1843e6f20bb26dc857f3d50fe4411a47373f092aad573ac87cc36ae67a0f7605a40da78fa35df2d42ea9a0c88d9c7bb6dc4236550839a411bde6bd7f2481926dce3de5b3687d2fd56d05ac82ec414be1c717e440c92c8fec901247485436e3d60ea5af206d332166163199c286a88249e31c9bd599aaaa0480923643bcf1b63a15575903fc8cc6bbbd43629b080113df675481020ce4334ea975cccde401bdc42bcc82219423f696ac6da00ab29202478c69ba05462115c0024b242bb7ae9b17aded01b2c310d60e50ae236280481911a615a7e97000c58412258ebc380102e1e90f2cc708635902078848ada536d24ba921c7415d641a066671afeb22487f57d148f0e548906aa4f04aed249591a39dc4013de0690c43a1046491fddbcfbf401a9500f5a9f468185fa9df866141c4e8e292f4c290fe09068bfd323e61e11fe8cbff009c4483a529f928de4ba6b57c36b0e80ea882a5961fd767a86d536100529618d0602e1b41f50038823199764bb5cab6dce0417678272ede49246d36f4be241724e441f0a57ab637302d9f064c6d2bab57cf1bc837866d22974de0bd3b85040ed2390b5550ebae640c92331aeee5858b6462048cc85b85ad6650a5aa201a78fb75c280b6b158906193edd70a06dac1424053df82bcc81665de6770f320b8d1a7dfc328f21a02b2064f76ab5fca205b4918771ce1cc291a882b749fe4ea820092c785a3c44816cf485b8dac6671a18b205cf89fed72203478c726f5666aaa81205b3d21d9ada74ad56e201a98973add5f6b584149cea9d5b492546cf1066436b3502009f59125b361da852b4f205bfad5b4924cc6dd42c71036994aa31d6ea9baf71054b3a8c6f256b25da2dadad020a724663f09366e176ae20ab93d2149ed249237e1eb6d20feadcd40415bcb642a0d9b0e3c04806a60c24ac86aaa858c7901b46985e9da5400706100449cb9daa1ddaa510207966f26c5b733516103fccf97bf2efdc82e3409edd8e8d1dc34e20bb10e7f76b15d20f1b281b848190f7e2da491acb6bad70a6c6348234db976d246ecdfbbd705ea9f9a880dcb376cdb473ee60dfae44034f18ddbf28c7ab1b401054b3d8c24924dfbbf51b15a59024a4836923459ab382ea20a93dc525b4b69555ae9b1d0a230206532e0b07890291f8fed9046919886b07ac5701b5422406e45e6837f120da29928ade5b4e9eca0adb7beb208bfe12fed106c8a012a08d46d4fd64be0e201a983f6b34b645eec180b0e1032eddb0a5aa052c80e48e5dc9d768177102dcb25db35248d48e81fc08361e61ceada76dfdd74905b523976d266b27f4558416448cc43583940a80dab00206df63e8e97d4833d8fa3a5f5206d4698dda3c5bf285101a1a04a46ebc78090113df675481029cb0c6adeb9d4d20e7d88d7881067b11af1020192c31a0c05c3683ea00710043c7d1aef96a1754d01a79e3687020c46cb9c14dea833b7020252c75e1c00824fb1f474bea40813ab76a3525fab5ee07639ad441d504ea3ff0056f69237f392429835afe380906b34b0f8f99872e2eb6d6b88097bc0d218874201a9170d9c883d7e7a80237dd3d52bc2532a5a91b2ff0049c0e1979e00700ff0448340fe9997784b6a4b8890747d3f3cc7d2fe2fe0414e248faf4ed2a223834814924e0d7e489003f7eafd1d5c41604c3976cd9c88c8b398d5acc836893c7d27b37698babf9d3528836f7d5766aed29b7b4a090bc750bc83762472162ab1d75cc818fd8579f6209464c69ba15c2230544231e70d81c4838f6f565dc823fb0af3ec4124f485b8dac6671a18b208d2c90f37dfa155e40ed3561fa2040edef35ebf92403258ebc380105709231bcb1569e17add60902da49e1afca1208c64c6accae5f40052964879befd0aaf209264fb35c290b6b05810049c87f66b9bcd58e30a882819d29ce8bee372831020a05032eda492492495432d8bb591049964b9aba835d32201c8df897e907220c327f66a359602c421ad308061e4e6d26434dd50e810291941ef2da4a08b39d2ad288024e4317e7c55d1614bc29c4920de9246d9d044785c409139107bb57e5fa1832ec080e48cc6ed46bc2beede150b48124cc8779636f55d31a4806a4914bd71a5cab5840c88730a46ebbd110be2417f4cfde5b351bf783e9f9f5ac082ed96227666cdad1ba8af5690104698dda92665dd5739f159024cd5f897eb2fe9105809831bb51b7c430776ac8324727fc1b1e8db1ebbb31178204b1c160f0120403d3736923561cd420cd053790201ef32d9af5c1bdef656c62c021e31bc97ab7a08d4a01628069e90c6dd0f36f2208c7914b6fde1cd7a5d6b202488456f246ed3502e38b55a5b0836d26798d51d2f5b6b208c9241ecd9c9b4bef08f0c4480923539bcc28ee3856ea9c40c92c4ab51a0cb9803c5641191a7f790f067ce14c068684af7e0da4b6e76685f59031a4a45b4aebebb63dc824cd53ff56d24fd3aa658d8905d8814ad2bc198bfbb2820d9943cbb766a98af9c6b5903f9931ab73b97d04091931ab32b97d001b645e5637f020fc904bf780a4711e84034c9866b8d236540a0208c78c726f5666aaa81201b2c3fab3a655b4816e592e6e96d55f17d2d79024a624e291f9475a8902dcb25c9246ae1ad3aab48232065c92da5bc9cf1669ca55414905c465c160f1208dedeacbb905713da5d9dd011e7c6b20ea3bc72976cd9c89346afcc0756ab2634835e0c9f66b85216d60b0209065c160f1201c93fc9d5041eccbd40ff00bd27c18ff25fd2fe75499075bbf4d17d8f08ff004521fce6041d12cfdf32f47f8bbf9b0082b83cf1b438102ccb1d78700205d963ee0e2040451b2ed9a92da4e1e34d14906ec48cfed2994b46f980baa5d57d7d43b4df07e6e7d5bf0da6da347cc366a92105842865f7b54017648cc6bbbd43629b0801f20faa48c6edb60cadec50e2040a5ee757fa4406e4720d9ab8d568857ac8824fbcd7afe4901332f0b47810454c48782b8600db3220c91bc6d0e2040da64fe9ba05422105c03ec409898316b74a645eec5a0a05b328ad59a604008077b0af3ec400e5921e5ae99408148f6edf9f187720409e12eebcc57c97dc8352fc429c7f0d4656b1e9aa0170205b43eed46dfc291e745c403bdb0d7801045409f5a49e2ab562b83c3b101b4918771ce1cc291a882934c4bb66a491a9206b5a2d63b9905d932643b491bb4843abe9e238540b691450ed2d9cb5735f60cab20529622b959852c6b5840813a9148db6da35160d4040b87a43bb46ea74aca88900bd8614060240cb2c9aa8dd9bf7833e7732a8102923a6e7de5677a14b757106905c7354c06d24685b48f0ba3d442fe9c88ada5b346db758d441ca34c6ed4976e373c414e5b882be9abf12fd65fd220b727248376a35fcfac18be6400e466376a491a3a015dfd6e20523263566572fa00463d21492f0b1dacc82a59c921de4bd316fc7890297bb8d01807520c4f18b078e2c1caa208c8790824ab5f976755c00cb56e07643cdc0abf38447987020d879928ad9af5eab8071c140a5e2acbb66abe7d16a20933564292fab68d4941da8bdcf5ad8404d2528d9bb368802f4ce0f02091233fbc94fa9fd158d8b209492f310d404819379ff00eb6440c68731b4b692c74fc5b1b4806a052a9246a4a2ea5ba75b4308373e64a54366a35d18c307294417648e5cdd2d8bbe0fa5af202464fbbae03c870108903b48cfeed60b342c582f07564010f1f6eb85016d62b120c3c7dbae1405b58ac480da34fe5960ecf2205b493c35f94240b7ec1249275d0771805748a8830f48796418c70a88231e30cd71a42ca8560403bd8579f6200664c6f2553ac42e10a45840ec78fe9ba15c623154406cb0c72e5155ea550ba082ae4f1fde50a20177655e41d2c7ac24e3da5e244e446fdde92d9fdd41ac082a591cb99a8aee8be86b880efbf0579904449fe4ea820f665ea07fde93e0c7f92fe97f3aa4c83ad5fa6a3ed782bfa490ff007f3641d124f63fbcbfcdf5391b5b18ac296ac2b83df6b540102d4b1d78700200a79e36870208bef0348621d083787d574ffd64492351a92a46be1c9a41dc6ccf0da540ab77d5ac695905ba4108c9fd599deaea0035309c46870c95cb4d205b3338f1eac56ab5a84806cb27524be1d6daaaf4240c936cfb3790dd685fdd74903f993e8da28639a30d3e2a70812201c79e36870209064fb75c281b6b050901120e4f1866b8d216542b0204620f8fb1f474bea401124615a7e97100c184152ceaddb40ea2a63e2f20a4d3d2e523769e7aea16106aeef249ce4bac78eaeb480c902a48cff99471566a51064db90a92435aed72fe6be4406d27f93aa0829c9c721da48d49420ad3d57be04164780f2eddb9c20e560d8d241644e441a925b4b2118d6c85d7c02b749185defac73c84082ae4c22aaad816bbad8c20088731ad2a9b56d5341404925217557c54cc21c8824cb0c7ddda853702ebb0806a4642b1b31eb1752d7903fccf41ef2180ae9562d0e2d1b082e34c18761d83a062e20068d31bb524ccbbaae73e2b205c99e3f8c91d9e92c611588d18905b49293fe0da342ef9b54db5b50b481490f1fd120cf7146a352491d3705d8d658411e5920ddabe0fd68482ad49485fac55ceb205b3c8af98e0b5f01b88021e90eeebc6d6e6ba54da4824a3643b351a01a1a4395a40ec87ebff001106c44db90eed1fbc1aac6cc69890513e2dfc3bf5923bfe120b226dc8b69a3766b3cb5507f4d2d441ca7914928f158600af9900c9198d9a9246d3985b7db99032278c695633932b001789014f86ea8203281bf780ea0d559c08190cc8725d8f5d96e7020b450e1b3766e2db38df5905c6612bb352543441f58b32bd6f2076333a91b7f5d3ad115103b235380927b9ecd44793482519785a3c08241930dd71a02ca8162406482390473c63937ab335554090463d216636359946962c8069e90e783d7659944806cb0c43583d60a88d8b10204932637965db4378901b491ff2d55bd45d6c2a5384802248faae7d43964024152a652be6492a5dcae551c4483a34f138f8a4fc489c892fce490abe4d77210205b310fd8206491c3f6883125e561facb90907b29fa3d7fbcefc11ff0027257fcf49320eb4fe9b7ffd0b7e9cbbfdfbd020e8727bf997ff0001fcd8240832c3fa0c45c168bab017102d902d9e3efeb88f20c00224037db7a3a5f420da2f5399c608df1691a8d492b78379b285d0ce241dea4c33ea4924ac07a833682b320bb0c43f608229efb3aa40829df13a43bcb76f3ac196aa87100443cdc55ccd56cac3320b211a8a553caf188101bf73abfd220c33b4b8d353f4b74080da1e5dc57c71165b990369e31c9bd599aaaa04806983fb35fd5f4f37ad640d867ecea91208c79c36071204e20fb1efb5aa008121247d7a7695111c1a41adfe2425766e237b6dd664152f99cdbabe215e96b6722040141ecdcd6a53af8f16bc814a59f76fc8711060f05dc11a4721f335d4eec41251a83f893aa6aa36bf3e2189230bd3b4a880e2c205bd87bb523651669ad6620b7e09bff8cc78106dece4456d246adf160368d5144482933d21e590631c2a20a9530637953a0baf18c0816f67d7990648d13bca8add9f6203626366b95010d47990129198da692d5d6471c02e346a2811a8dd38751f9049964858aac35d32209336ff00172726a004153786ee9eff00ac790905a297fc5c1bb810039b721da48d46fcc4022f66a240ed2c457c48755b6f6e10201d2c7dc1c408146588ae56e1435ad6902d9e45598b1b5be950c1c40a47a431b743cdbc88310e8af2d5f0bdbaa0482d140a0f576b4c20b47d8fa3a5f520a4e7e48524929c88de4f183fb5e40c936bcc7d3d4081fe7222b76b5f5e9a3c58e20493c8ab716b2b752a18b881b8f7960d8041c1e90eed5d6e15551a73a480da34c2ef75619e62040ff23456d2de54eb070b5a40712495d9a8d46fe6fc2b8a94d79058fefdb491b7294d1767f289004f6de8e97d081fe61cb98b8be9067ceca1e4176239e16f3206d32634dd0ae11182a21c48dd78f012095eee140e03d4833ddc281c07a900449fe4ea82049964e3d994d23cb54b48021e9e28dfd5fd9cbd4300928d90bb582f95440b6923fdc71eceb6a205b491f770ca1cc690ac8281f10939bb1257b1c11bf4e20e93d3095da539524921fbc920cb2d5d24120cfd9d52240ca665ccc2c6b72852d51045491fda48d586b5f27107b3dfa3f8e87a5ea91e0c2d6c9ae388a5526ba2241d697d371e5fe0c7f8d97ffbe1b20e85277f98fa3fab641fcda240812c3f1d62f58ae21628448024b23fb240a52c3f1d62f58ae2162844816cccb99858d6e50a5aa206df0de71fd5bf11e6dce4da40b47a491eaaf0d32041e9490f2efc5b493378236ba5cb6d4fa482ec919fd59d32ad84127de0291c47a10294e490afe7aa1fcc8249930dd71a02ca8162404a46635ddea1b14d840097bb850380f5208840751cf0b7990321930cd71a46ca8140403659215dbd74d8bd6f68648cfebb39636adb08012963af0e004093ef0148e23d08249e3efeb88f20c0022415ba4e5ced50eed5288347bc6c97249229246a351bf7956a0550b6e9441694d54102366decdcd6ef95191024279150ec3dba640a3b26acbb90732341b31cb542816c51046f61f9b72fff000201a9245796bdcbadf1af516064b2408dd9bb37e568e0a1e0d2040f0a907b3769477977bf90ad5586c8193edd70a06dac14240933924365fdf38baa20a70f4843e24fbe8d52c208d2c90b15586ba644017dc436929b9dba07d4404767d79901b328ad5ba6044482d033bc91bfabec60b75c56403925e5c1a8890049aa7d25bc91baaf05b16c20529846366cf69c8ede02a5c74e0a481fe751fddbb37372e377059064cf3028c468bba8eaaa6851059064369750d7cc59410463d2185cdbddcaf55240b72c31cb94557a9542e820499618d59d32ada40932c90f2d74ca0406e4663cb6cf90510ea20e20b45026011bb4b15aa88f5ecb203678c6accee5f4005c96a2b695fd015634750048919fde5c99daf6b2b20bd4c86d246d15af4dc96b20524948549346e10d0d6b20267a43bb63460bc7e7410493321ddb8d3a5654c081f90e8acc2cbedaeda1a0ec8dfcdb53dcbf95ef201b397f16d25b4950b6145c411a64cbf7774edcc81a8820c8e757d5b4960d6500fb5aa66041b1f36d2bbb769054b7f3be820b8d1bf9371064b0c6830170da0fa801c418621fb04048f18d3342b8c062a8856f3912d7e756abb1a14e2625dc57c3016db9105269eda492e196aeb482db9b738f66a377935caa79bc79d04120f4bb96618c30a8812524957b73b419aaab20d30f1fa756cd9933912546d06ada35ad8ce841d4bc8de368710206c91baf1e024070c9fd5b95eaea2119247f76f3efd006a5403d9a7d1e9fde7be0d7ea7977f394a083ae4fa6fbfb43c18fd397ff00bf1a20e82a7879887f177f3681056f2c97737dfa155e40a492de5dddaa806024010f1fe4ceadc975d004013de0690c43a1046961ff002dd9b62c7836f1ca8120f45de004eafaede09cc94907982391a8f5630a5f5906d5a352aba795e1002025efdbc9e0ea96ee10b2a6904949fe4ea820252390b74b6aef8ba963c80f107dccbc2d1e04120cc859858c6670a1aa2023ec2bcfb101020f89e90f2c8318e1510049649f66f4bad58bb0b04806a4939bbb8e78e74544083b791b40e04090989d4926f6063590d2e860297b74924b6947a8b94342e3d0835e278c87694f646d40b732975d4905d87cc6cd46d6c5ad5dd63990043be5d7fa5c00814bdceaff004880299fb5aa048388246ce604187a43bb70d50aa2141020260fdcdcf54b195341fcf20f66ecd0fbc11bbc298d967cc80948df70f1120089ede48d62b8c3882da40812c452f3d2f306301b02005bb74a20f848e42bb3ae990a1ed0926643cf30c6185440da8d31bb478b7e50a20343409234c79969b66818f7ac231ed9bb35279ad74d4c5296eaeb2009353ccd2967520524698fec9092f975105c735090364eaf867ed1032a1fcb51a8e67c9b000e4190903790103f0bb9902025df7720205296ff004b990032065469855cea872cc4480d9990c6cd0726f320369170d9c880dccf90ed3fe308aa36b9e4152cb11408d9c892a1dad362e20b69027efc3b0c38c01a1253d216c2f7eb54104633e5de97ecf10203664c335c691b2a0501036a34c65960ecf220246237f2208c9e90fe0da46a567405cc55c4093e12cb961b3757aa80ae87ac82e349c85daa1ddaa510207b8ed249568fc141c74f20b8d0296d9b0631b729dac88368a6a9f555975bd6c20643c634cd0ae3018aa211ccfdad50240b53a92ba160b7255441452612b5d4c1b5dd2c69055c994e70eb62ace8c0c46985deeac33cc40831307ec6e96c83dd834140b7233e9275b77cf3a0184035306168dd76a6017c483aa9f5c6f11949246cc946feb048520f01ef7106a5c8dc3607002064919fd7672c6d5b610064f780a4711e84192c70583c0483da87d1ddfde71e097f93d2cfe79489075a3f4e1797f827face5dfce1e89079f89ec7f797f16a3eeddb52d59e0e0aba587e3ac5ca05442c58010043c7f4dd0ae3118aa20b678faeff002f7378baaa19500d3f1fdb201bedbd1d2fa107719ea4f3e3fb1ba37f37eef48694b16bc6b20eca50f2e5f0e18bc6907103b199766bb1eab2dce040cb2d4aecd46b75ae16810549f5e369311bbbeb8c5a0399036c8e5db49763f0e0fe2a7103fa04fda1c3068675903ffb0ddbf35d1dad65641c48dd78f0120fb907efddc281c07a902da4a5cf0a2e5c1bdf8105033da5d9dd011e7c6b205b332ecd763d565b9c082324bf2af2009b551a8dda431ceeadd92882939b7b4a727891b4beef60b28b417451170905b49e3fbca14402eecabc806c8cfc758b942b805aa01201a9170d9c8814e58fb838810712331ab3a655b0831312e759abad63481250e8ada53911a20bc14b5475703d6176789121dda8dfcdef1e116772040327f56e57aba8864b0fc758b940a8858b0020409618f32ab95165e215ac8024b0c43583d60a88d8b10201a8731bcbf3782d556ad1b54b206ef608efe106004067dbd59772028873eada4ccabb6ee8f205a9d467662376971a20bcd61020c9ab27da515e9ebd372040491fd9be24235fa741dd842a0372c977996d2f87a998fcf8d240db30cc6d3de4e5dd5e971bc81fcc986eb8d016540b1209240a49e3f68f0c1819d6408078c3fa621cc31018100d9198d5bd73a98406e46f1b4388103648dd78f0120949170d9c882c899ee0b799020f8b521d9a9246a4bef1aeaa28e22411101f68350206549bc2c0e2411e46fb87889031c8cfeace9956c202522fe8f22064327f9b3a3725d748101395fe2da46c1e2041adde1b9fde5fc6550dcfea35906d5f9950ec78b5a41251c8ad9a185af6e9e411922f1b79905ebe1e27376e3ae439524171fbc0d218874201a92976cd5b57aadc1d9a24152ce44e29fa7d94dabb5a1af13c139f0d72b8f35634560a48e785bcc82c89198ddbb4819a6d957cc814a587f97282ee5ae85d24038cf9985a2415ff008b53c51b3266da492492f2f47f7e0ae2c20e866724ea19ed3d9253915e61e5e2ff00eb0c7b104991cb9ba5b177c1f4b5e406e467e3ac5ca15c02d50090321970583c48249e3fbb7fcde1d854cbb3a03da57d1c1fde6fe0dfea7487f3c24083ad7fa71bcbfc18fd297ffbefa041e7be7b1fde431dda8ffe6d73043e7120aba587e3ac5eb15c42c50890299e78da1c0816658ebc38010473ce1b038900d32f0b478106f57a8dcf1d9a92494c97fc411f585e0baa9b483b9599e9cf86b95c179ab0a6b07f91ce35b74d6871647904991a536902be748f15448100f18046a4abd39424168a065ae1b1dd42e8d24164234fbf8651e43405640fe8d973829bd50676e0406483932e0b078901396ff4b99056f3a8f6cdd71ef152c835c2721fda51676b32c481211a7f66b6c7b5511d3732092923ebd3b4a888e0d2040f61e641a8c33050f20202732766ef27eadbdf554406a58621ac1ca15c46c5009046f76ab5fca208d2c70583c04814a46635674cab6104a20514c1fbd996a96b6b6032785721da492049757501c562416d4f03009246e360806b4a20a2a46e1b0380101b3c6369235b973a98e8d640812c31aeee58d8b6c20010fc7f6c83245fd1e4406d1a617a7695001c184048f1866b8d216542b020c9198d777a86c5361003739243b491b5f67b68f99053933d2bb39248d46fddfe60c57505e818024036751ffec9136f8eb1602a348106788495d9a92fd60b7ad6bd295cc836426d98d9a8d4685dd16a6d3183dad0932c3fcb941772d742e9208fedeacbb9057e98e9ff000902dcb0c6830170da0fa801c4192331a1c01e3603ea107901b91bee1e2240c923310d60f58ae036a84483122e1b39105b487316b34a6c5cfc582b01de2a22b694db52bcbf2b42a055e4152221f772120b00f7960d8041c48cc73e7155ea552aa0808c8dd78f01202e405e46fb87889032a4bcb7d2bf8106bbf86d21da539125f77a3d2707deeaaf5906ccc8fccb693078e43a17905a3ec11bb35f1cd6b5aa88d95308101246379767f58511ac08092225db35241aa58417f236726d2d41cca1516f5008c91972c2cd5917d0c710527393797968b357c1cf20a04f18f316e7d8824993fab72bd5d441b5232e50db8f583e963c8100c9fde5566ac2bb4230206e33b376645c345595307ae241d397ae978e1f592727ef6e8d496ef47f98d74a35777c8834cc827c8cfebb39636adb0803248cfc758bd60a805ab10206432f0b478104a967968da8ff00f6883db07d1c9e807a1ea6fe0c80450c9018fdf29008907593f4eb1dfdca2fc130fce32eca5fe800d3466c7b03cf34fc3fbca9dda8fafe1b7478c560a0a95252e7eb1573ac816cf1f7f5c47906001120092c3faecf50daa6c20034f4b998d8c6e71a18b2008792bf21c54ae0179037786f3ffea4cf69b7393f396f0167f68378338b483d09787b38d1b3951a8d492c3786cf486a9c833020b6924f0d7e50901240cb5c363ba85d1a480da45c36722009234aecde837c43bf0207f43a572a34eaeca082c846a555ae143d763482c8919fd7672c6d5b61002724f31c38101a497e55e41af13c25db497ac874e69056e78c6adcae5f4101a7e6e6d2b46ed0d96100e3d21d9a16032e10ecb6f520a267b25638e7471b044818fc2af2cf46dea40dd2c3fbc96c585fc19a8900d3d2ecf172adb3289046f6de8e97d080248df70f11209278ff0026756e4bae802040491f569fa5c44316905d9e1bc8548dbfb5abb9640db2c3fab7ae75348281031bc924f155fd157b332029f0dd50415f24de16071201beee340601d480948cc6bbb96162d9188648cfebb39636adb08032193fab33bd5d403f040c041ab681ddd3d9268d7ef27e3aa96411a754bbfb24cdb779945f1bf4c208d3ab794f646afef172b59da41bb064c6ed46abeede015c7a3c48069f85dcc8071e78da1c0812131d3fe1201a64c699a05420105c03e2413cc9f6eb85036d60a1206d46fe4dc401657e638f020bd502e1b478901a966f29b6dd2a3deb5906aefb8ef249235bae54da0f6ac2c891bee1e22404483991baf1e02406cc43f6080948cfeadeb9d4c2092924aaf5c6972ec69024cc931bc924b7a41240aa6c1d2c5e14905ed237dc3c4481f8f49d25b37e4d7b2e6f4610044398bd996a86b6b6012961846a95ad0daa58aa9200a665c9246a4a0165cfcd42a63d840d829cda59ad4a75f1e0d7102d4b1d78700204149cdcda7a8e3490202625028ef9c75a810294b271ecd6b28e7ca3cc809204fb95f10d594e64152f8fde2da37c3799292490af686cdddedffa7b786a241d159f96824924929c892f304824b6850a745638e2411bdb7a3a5f4203664feadcaf5751064919fd767a82d5323106533f6b54090493cf1b438107b82fa3dbfbcf7c11ff00260eff003aa4083ab0fa77bcbfc17ff192ff00f7df4083cf3cf7f32ffe03f9b0482ad3c63937ab335554090291e3fab73bd5d440224ff2754102d9f8fed900d3c7f4dd0ae3118aa2036587f97282ee5ae85d241d9dfa90f8efbb7f7b79c9e608f5a426f0243fea1a6baa072883b83469fda48dabb3057ae2411cf7dad50040d88797ed346bf40a6a970b31882da60c5edcf54b1b5b006a04fecd830754e75aa2d0bb10e95aac561d05763082f5439fb5ba5b62e7e0d150361970583c4802ce497291b6fcc2b8b577bda1aca98976d26ae3c56d78907c101f643512062f615e7d881067547f484835527e1fd9bbb525aa9ccaeb5d6000ff00e1c797236ee2040ec983fbcaa8e802d6e4a5102d9e3fc99d5b92eba00823fb7ab2ee419edeacbb904849fe4ea820aba5bbcba29bae6bb08366502d9b68d46bb76d1ab9cda5a4120828c4f7e320dbe97012093f0cfdae640909378581c483258fb838810619785a3c0830cbc2d1e04048f386c0e24126472e6e96c5df07d2d79032235e3afca020d669d67f66f892afbc3bea2040a53d8ffe124dbfd65475101f905e0c923de5e242342fa33d5a41b7b2c75e1c008069e3edd70a02dac5624038f7dad50040912c7dc1c408239e78da1c08389198d59d32ad84124f3c6d0e040c8873f6334b6c1cfc182b08dedf797cd5476b195905d88d3f9e783f2cc818ccb82c1e241acf3a8c6cd9c89273338f2c1b02076439fd6954d8a62da0a029efc15e6402ccbc2d1e0406a46ebc7809032993fa66857080c151008983f6374b641eec1a0a037354c2aacbadeb6905b48dde4a83dfa6296c56440da923fbb6c8b2b7b5418090620643c2a5e6dec4124f48796638431ac816e59216e96c55f0752c79004969f4923469d5d5535bc832593c776b736063566f20088d4e6d2ecdd6343c816e722276950b58f1b56f76641abbe2127366a491a8c7ea953ddf2200892f1351b3251bb4926926d7477b14b8107541e3978c492f1b2727c43eafa3fcbf55dcbcc829396eed546ce4b7ad4dbded201bedd25b49eceebd54d2036665cdc2d6373850d5103748df70f112075919fd0e20f0b05d588bc80a107b79fa3b7fbcefc18fd492ff00e7a48907563f4f2797782ffa72ff00f7ff004083cf24ea3e292ff36a3c07fcda34561a590538923eab9f50e590090291f85dcc816cf1f7f5c47906001120164017dfabf4757100e3d2ecb07aacb328901240cf1494db492327223777a411e92ddf40ae16f5b883d12fab178e08df16a64a3525fda090d9bb3e7023ff00f6f7469a9c41b4697f2cbfa10029aa95d9a925385631eefae37009032cea86cdaad531dca2a7b4812bd87c4aff00c9d3be640fd32baffc441b2136d2bd1817d3762406d2538f37f16f062b17855d3c278875afa072c081490e8a497318c6abea8c40819246637973677bd8da880d9f8fed9055d390fed2a5ca7d3d385241abbe33487696cd490b7a398f1535c40c930e5fb351a8db740e587c880dcb25ca49299829f6900d961fd59d32ada4118c9fd5b95eaea212bdb0d780107092976ecc2c8681755440808d30b9c88d0d0bece214b8836a8cf960582403be1baa0828a9d7e663687220cf6fbb3be76c698aa040b72c7dc1c408239e78da1c082419785a3c0830f3c6d0e04124c9fe6ce8dc975d204118f3c6d0e040c936cfdd8046b11d0e0140f8a863664f69b7f9c359bc03e4415c4fcfc659b5fac87fe120b1fc3d0da5e2450c575a02d82c836d258ebc380100d327dbae140db582848126587f5d9ea1b54d840069e78da1c083258635ddcb1b16d8402348cc6ace9956c20c32634cd02a10082e00c72375e3c048393263792f56f510ad600d585c68e785bcc81b51ae1d7e4810515e2418fc2446ab58ae8ca110e10d0d7f04825fb61af0020e0c9fd3342b84060a881b32e0b078901b327ddd701e4380844816e587f97282ee5ae85d24168cd5317e63928482d14398bd996a86b6b604a4cc75fc2206c32639b7a33355548900e963ee0e204033de6bd7f24802260feeda7111c5980d3438126587d1bdeb1ce2bada415bce441a4b66ed29b7dd7df4b59004333e369237f3823d6c853ab82c0d0cf59c974f6da536e7223525b3d1e90ddc900903f068d0e6035c241a19e274f84924b66a376924120d5f5c287f020a70cbc2d1e040b72c97357506ba644124ccba37b2e7f3b974101332f0b478103f193fab72bd5d441b50e7ee665aa1aca9a0dc41ed7fe8dd39fbbf53df08dcc45a41d5a612143083acafa78cf4db0991e12824fdff00686d297ece0f47dcb670002400129b4ff74b052803ecb16b587eebf74201e7293be69fc5c8ff00e6d120ab9331d7f088106587f5674cab690294b0febb3d436a9b08004964b99a82ae83e86b88024b0fc758bd62b8858a11208dedbd1d2fa100d20dacf55df1c125e12f8908dffb3f38148f4858034d5da241e84a6acf146ce44623766a4b4f68a954d9890469c87f668ad1b5ebb2ec203735671ed246ef2eabd642e207f46a297ae14b9563081b4c43f60830ca7366f10e0a1769e2c205b492752492fcdeae34dfa8901b43a285bb4be7d3a103f1970583c482299f330b448099efb3aa4081053061d8760e818b8829cf15515f812921fbbd437e9e4081e1b9fda48de0c5069b0011c88191310fd22009ef0148e23d0830c9fd599deaea019ef0148e23d0824cb0fa91abcf4b5e0400e67fe32a3754906cc100f20a767bf9885fc080648cfeed5b5417f16ea240b72c7dc1c408227f38eb5d883e1eee340601d48249e31a66857180c5510c33bc9b529ebd55059046961f8eb17281510b160040c881f331b04829cf1cbcc91a9278ed2872e6a5422415bcf63e21f525254dcae5a6903ff86e63f0db9e8155b971a8836ad247ddc328731a42b200a7bed6a8020513f0bb9900ef6c35e0041c907e4ccbb9e638431ac8237bc0d21887420372387ed1049919fde5c99daf6b2b20b8e45fd1e440da8d3fbb7bbba4698542415378b460776b74bb2cd3001690e7ec6696d839f8305606cc98d3340a84020b804648bc6de640491a9556b850f5d8d209264ff36746e4bae90205b961fd0622e0b45d580b88361e6a7960da1c881fcc9fddaea7e6fcd571046f32d0d3733052881b4c9fd3342b84060a887279e3687020afd307feed017502de836762052494ea58ef2eaceeace240a465388d4959485aaad7dc81da467f76adaa0bf8b75120a07d86cd4924beef48332571b6a5106bc78d88a46a4bc379c88dfbbd1a2907adecb5f990747a7a5db4837933a0e94dc88232492ab5bb9dc101205b327dbae140db582848190c9fd599deaea0048c9fd5b95eaea20ec8d30bbdd5867988103f1970583c480ecafcbb1e241ed77e8c5fef2ff07ff56243f9de5c41d617d3edf8b5e09feb24ff00fbf9b20f3bd3a8fef2fe2d47dbe5afaae5d8415ba60c5add29917bb168282b748bc6de6408078fe99a05460115c0027bc052388f4201a78fb35c291b6b150100d3cf1b4381004961fd0622e0b45d580b880948e5ccd457745f435c41d82f803eb8a92993b366dcf6f2ff00bc21ee16b6041d99237c639b73dbcb5248f487c43cc7b8d411562416d78569cda492f32fd60f5617d1c581b21234e237696cc76cfbeba05acb2f0604949ce9fbb2be62e56561046f32d051737052881b4cc851aac6d7eb2206d919f46badbfe59502c203664fbbae03c870108906248c770c7b3acac8021e3ecd70a46dac5404012586356f5cea69029cea90824a6da4b511c62a852c6806a9f86e7f66a4b66ba8a793ed207f9c87eec421508e870052f7caff00d120cf7ed99056d0d6b9fee482319785a3c080948cf8ecd492371e39372a88234c33ff00848b1cb1804285106cc993ecd70a42dac1604010c9fd3342b84060a8854be2179963c482299f2bd50240b878fb75c280b6b158904020fc48cfc758b942b805aa01208d2c3fa0c45c168bab01710648cfe871078582eac45e41878fbfae23c830008903220ba7220a6fd63ff1703f5923b81055d3abf16e655bc8482d2f07ff001d5276070f44836892eebf98100d3be5d7fa5c008126587f5d9cb0b56c8c406fbc0d218874208d2c3fa0c45c168bab0171049f781a4310e84192378da1c4080d988dfc882348bccc6df4bfe120b88cb82c1e240dc873fad2a9b14c5b41415ff8abe59e95bd0812a6df9705dc408194f3c6d0e0400d247d77beb0cf2002093233fa1c41e160bab1179049327f56e57aba88043c7f6924b663e9a439335120d999aa7d5470b9abd4481b4f1fe4ceadc975d00412646635ddea1b14d840194f7dad500400cf2711adb830158e11ac8100f4e346ab51188f1a6a5b41013d2e46a496b8f3056ab0c02b740984923524b1c5ea78da140856241764b0ff002e505dcb5d0ba482a5493c35f9424140cea7ce3fd5a91ff6883a199c92e46ed2490317b4920cbacc6ab1400a52c785a3c4482348cc6870078d80fa841e406fdfb66e595aad52406e46b49f17317c6bcc81fd1a7d7a7695011c5a40fe8cfcad52406e587f76adaa1bb8375020f6d5f45f9cfdd7a95f840b502a46987b1e9b485755441d617f5407f8b3e087eb04f7f3922083ce4a78fef26fc411a8f8fe6dba34d4409278fbfae23c8300089055e998ebf84415fa48ff0071c7b3ada8816e591fd9201a7a5dcb21c238d64010f4bb3c5cab6cca2411376e9441fa332ee790631c2a207f312eda57c55935f8aa04176787b3a83cb7696cff00bbf783be50d090769bea43219c9b4a724e4492492090de5b3d1fa5d83f25086f54cf524a7224b988ae3a67320bd4f1866b8d216542b02052332e8decb9fcee5d040ec652a8c46bf98dedd0b6f02536d2bb4925152bb6a37103e107ecf1fddb9f7d05c040b69378581c4833dbeed74740fbb25c4816931e5c91bb88906a1c8cc0a36725ac5f0a5bc058c20b0131bc91ae1f94355b18415b7bc0d218874202292f2e0d44483991bee1e224048f1850ed2842b88d5ab48064d4fc63d53e8106d1993ecd70a42dac16040b867ed6a8120abbc42f31465a1c40805c8dd78f01205d963ee0e204030fc7f6c83245fd1e4419eed56bf94418621fb04114f7d9d52040da81f3149581c4482b8f1ca43b4a64a49bf778e4b590514983ff00d8de6dfeb2473d81cc2a5bf8905a5e0ffe3aa4ff00567a3c448366525e5c1a88904533e5dfb5cc4816e591fd9208e4034f7dad50041867ed6a8120e246f1b4388104a32f0b47810707a5ccda55305c3cf9b28885c6873fad2e8b56c5b0160c88d3ebbdd58e7980102078b47ff06d7f9cbaf0b316102dcdbf2e0bb881012964bb96ba65020524c4b95c38e0e0a01e4192c972ade9a6c5eb730024b271ecdd731e8e5101b9aa7fe25f7829701d2b315106c3cc34e6ec1a599374108a881db68559101b919fd7672c6d5b610036665dcf20c63854415bcf6976cd46eab82c074d120d783c9cddbdb95742997902924938db6ee2c17bdbd41926dcf1da49246235620905d6ea2b20b69247fb8e3d9d6d440809178dbcc835c27e25766cdb9ca9201f2f46a43a7c95d083a06961fde69249bb7924190c619d4c5100d3c7f56e77aba8846f6de8e97d0809193eeeb80f21c042240db2375e3c0481da46fb8788905908d3ead3f4b80860d2037efdbb524ff8753566305d4a20f6d5f459fa7fbbf528f09eaf453dfcf72de8d0ee41d627f5417f8b7e0a7eb148f120f37e9e7a3bf57237f9b848121247f3cf17e599020245c36722040491fee38f675b51024cb0feace9956d205bf6de8e97d08231e70d81c48077b7ab2ee4113df86ac880e2352abd70a5cbb5a40edefdb372cad56a920ef9bd4b52bfd84e6da4be21383783561a6c57c083763c3ddda92496d36ed0af908f2a6820bcc828c9c89c492352556abe6aa01c41864fa49243cb955c2b20b8e6deed76ba3bfe751c42d191cb95674d32143981c1005491fcb2c5d9e44013de0291c47a100b4f79605a041aac9df31f4afe0406cccb9b85ac6e70a1aa20afbe25aa48198f1fda48de02a56982fa5d01208c873f6b74b6c5cfc1a2a06efcdac73d9afdce640908793ecd9edd456219b2ab700da2327f4cd0ae10182a200482a89ed2eda6924708d638c288f57b0231f85dcc816e5bfd2e6418665d1bd973f9dcba082348dc360700202a410cf1f7f5c479060011209841f64398b9b9ea8632a6804f180c7e04a4a88e34ac0600e052c83599307ff0251a19681d52d55ad6240ffe129ffc36fe2db2b82f85e41b56983fbb6b8e802d6e4b51004919fd767a82d5323108c7e1773201e402cf1f7f5c47906001120cda15644118cbd2367312093ef35ebf924127cca8763c5ad206d9aa9cf86f65f26b6b6e216421e5cfb757d8d6902078a87f76f2b32cf1790049b52eddbd2c1a34a5a8830f2551bacdae73e1781024a492bbcacadb7d0eadaa2008989e28dda42b85f4f7bdb1204140ca125392725ed15eabeaa20d8f91882351bc9efbc561f36ac81910e9c146e0b1782ac6dfcc82e346cbb69af1a9e1ae4240c88d973eabe2b6e11e441253d3af66f96bdc34f0746b20d789d53ad5b4b693611e2ce2414e09fddbbb59642f0bb05102e1ede5bb59ad602a7103acc841ecd496d2495b6db9f120b45329ce3d6d5d9d5a0112f2eddabe01c71b41e41a2beb2f38feadf86d393f383dab56b081074c3edbd1d2fa102d9e9772c8708e359049327dbae140db5828480dc8cfeace9956c207691c3f6881de46fb8788903f193fab72bd5d4409193ff83692fe2fd3fbb1ae687b83fa2c7fbc9fc26fd14f7f3dcb483ac4fea843f123c13fd629ff00fed441e6ba721f01d9abfbb51ffcdba82e9a48102587f5d9cb0b56c8c4125252e78537aa0defc48102587f56f5cea690294b0c43583942b88d8a012052961fe5ca0bb96ba17490053df6b54010453d2e8dedbddcaf5504037db7a3a5f42025239773d75ce240db2c972eceba6c1eb7b43bddf564977f613f0ddb5b595b176d841d8bcd51f2d492faf152c23d482da43cb97c3862f1a41c414527bf18d25fb5c4809edd46a351bf9c58cd6a951003434ea496d246ef28b17f3a482f59b72e5fcb543b990581b53f470ee40b47d2bb4ac18396dd511208def95ffa240a53d939b351b5415ced57678106b7ceade5486a2a6ba2e204891cf10f2d60ecf1175340e0baec20654c4b9df9c331e4b6d1cc833dfb66e7958ad5240490f2ee2be388b2dcc81b7df2bff44816d247f796d20babbc68111b4482ec43a5776e8469651cc0806a465cb0b35645f431c41571e976d149515e83541064b0fc758b940a8858b00201441fb326356e772fa084532e0b078904933f675489061efb3aa40809a39e16f320368730fc78b7be440b5e2dfe2424ad1e641a9b2cfee6e92fcdf5e6f6535903af8632ff00c3746bbcbaa11eb8906da248feed7bf542c6b7571205b327f4cd0ae10182a206cf386c0e2401658fb8388102d7b6f474be84118f386c0e241864c335c691b2a050104b3df11bb9107e0cb82c1e2411cf7996edd330c5b710590879d4a46aeee4c7b58bf91024f89d3a91bb36147265e2a8524081fbe06edf2dabbbd6ef9a880224a7f8ecd73e300e4d52ef020ab8f4b92492496f2495d46be54101b13092ff0037f753ede2c6301fe679f46a391aede090cf26f362c82c891a57690b3542f0d090625e5dbb57c038e3683c80978633e3e1a924965738390906c819976cd653a5eaa710294e94e706c4735e0f120a29247f69ed28bfb58b8f269024a052bbb7668d8c5e9d7103b203f39d3552da9592c80e1e4e6f2edcaaa14db8832472ede5d5d9b1902091390feeda38535862ec803a9ff5de9f1f8b73251acf882420cd5c369075c07a5ccc6c63738d0c5902dfbc052388f42023feb05ddaef151032c8dd78f01206d46bc75f94040fc8686bf8240efef0148e23d080d99977e0da49df0f758b0aa0da95707b84fa2a7d3fddfa93785157a29dcd372ee95107587fd5109e0f4663f8240f524a70b6dd922acf92c201e67275cbbcb42846a3c5a14232b71056e92973abba2b6630e640b678fb75c280b6b1589028cb1d78700200b2c31aeee58d8b6c200a492319658bb3c881493121d9b058af1a75020523c7f933ab725d7401061e3fc99d5b92eba00830f1fe4ceadc975d0040da8d976ecf94177519b883b95f5399c7b4bc1346a355f8be92d2abd38483b44f0c67182491a8d0c2abd953571207f329cde5b354f64615f6c5a415bf8a9e63b491b7eba52b20add1a955d3caf08010321990eed0496d2a600b86a920b22473c7666ad73a8a14da082d19ab3e368c14b7870a5582d6e8901b964b98bac35d32201a652bbb525a0bebe6d20d784f4f2fac8925a3525bbd1f7a861001b844816e592ee6fbf42abc82939c921f320b1b83c078d84093357c54d9bf837391bb3f92fb54416899f11a6daab6eaea2fac80921e71f4b430a87120b012538f76a99bbdb0d5caac83895a73692351a92d0f4ed59036c8e752357e6548f1e9490469cb38feedafa518b691208a67ecea91201c7a5cdc6d6b728d2c5907ebdf82bcc8247bf0579907e08393ce1b038907dc81a0838919fd7672c6d5b610049f1525cb9b692b7a77caa20d67f603f52525db3a56eae2a51011f0f4ff00e1b4dbf2ff002da99c833120dc73de58360102d19da5756af939d0bc8089997eedd7c94c6c29208fef0348621d083e44108f18d599dcbe80010f1fe4ceadc975d004118f1f6eb85016d62b120e3dfabf475710727a5ccc6c63738d0c59049332e859a0e4ce640813d8fed2d9ac5eb419288021e31a66857180c551093b0d88dd51183ae7404802c8e5f36d1b39525f7862b1f972205a4c4e90da492ae8e43a60905808cf2d475dc0082d0439846b6d5eaaac18d710469c895f86daba54201cd641577b0496d2da48df30ad578db9bd441b5730e78ed246ef21de03066ae6b320909e78581c082a6961ff00325d7dc7be00415ba1cc3f1e2def9103b194aea1f2a281a564118f4e3d9ba55155383c6040db324f824ab52dd5c15a0e419e2a4e3462351add5f1c41961079f5f1c67c7d76f121249268ecf1d9e8faf1865120a4e592ee5ae994082299fb3aa44823c8cfeace9956c207646987f1ce3c8281a881fe46fb87889036a34ff61c3bbeda88190c9fe6ce8dc975d2040c9233ff0083692fe2f6b388f420f71df44dfa7fbbf514f06868309e0ff5e4b75a5907585fd5167e24f801fe51a7ff00d8449079819c87eaf86a3d4c8ecdb7ad94824cb1d78700205b3c7f56657aba802d9e975982fdff000ec4034f4b998d8c6e71a18b205a3df6754810053c63937ab3355540902924a42eaaf8a998439102610433f1fdb2093234aaf2d2b216b019020ecefd40e7fef29c932524cda0a4823f54df163483b7a9872e496d20d405dce8a882c8496d2da5b4918ba28a7e7cd840dbefdb491a1b4adb78d8f120aba5935766a4b76d9563d9e241192495ddb05620caa3f22064919fddaa72e1a5f1b081d9027d9cfbaee72ae690590665ccc2c6b72852d51054be2d4f1d9a8d046a37cc121d3436c0835e10262ec3b8c78c0581644b0c6adeb9d4d20523ce1b038906a5cf631b36727eb06eb8c5f0208c66430b9973f9dcba4824a34fa491b393ccf272abd46820b8d1d28492491a92083d54ae0c877a0824a1f696f24636e5d173f17901246257e1a92f3047d4d7af4b5b481fe472eddbd5f9b70206d332e46b990b1abe3c56e201a7a5d960f559665120cf781a4310e840c9233faecf505aa646207c83e722fe8f220947bed6a8020e0f1fd5995eaea011a467f43883c2c175622f2040f1512bf8369217e745975e41af12c3ff0081292ef6e11645b40101243eed494c9493474c0b2e85441b6923972d1abe4a737e751046327f56677aba8067bc052388f420252378da1c40809fb7ab2ee400e58634180b86d07d400e2052497eb2b62be105b974d6411fdb0d780100c3c7dfd711e4180044806c8cfeace9956c20e7df82bcc81476aed29c8ef2f0e0310cc02e20932c4af4ab5c4285900d494e446a345d0e5534835e1313ab66a492492833a0871cd4409336e5c929c939366b7ef048e868a85d1120dc743b91d7ff00b204175c8b76f55ebe4ab4812671cbb79747fcfbc1640b664c375c680b2a058905b5e1b9fd9a92c58b5581c482f548c85416eac83a86b8828a9d463ccb41a8d3106b0835e1033abe1b5d40a1d2a817903b48e5dc9d768177104991cdc49248379281b15d71bf4d20bb1026366237eefd9f0532d85d5b1441d627ae97ac2ecd46a4a6da37cc12145222bb458fb300ea5cccbb9e418c70a88229047203723310d60f58ae036a84481fe466356f5cea61036a34c2f4ed2a00383081b4c43f60809fb61af00203264feed497f17d4bb86e880d841eeafe89f31ec3d46fc2177fcef4672395f933912945a41d5cff005469fdcdfc01ff002953fc51241e5e12fe661fab641fcdc2409092973c28b9706f7e040b72c3f1d62f58ae2162844814e58fb8388100c961fd0622e0b45d580b8816cf1fe4ceadc975d00411bdbfde5657960a7328680043c7dfd711e4180044802248c6d283d975ccea34a88100f1fd3742b8c462a8867b6f474be84171fabdf89bfbdbf8b536d23f0ff2f48a99e6af01ec41e9026aa5b696cdd9b5e56906c399f2efdae6240a2665c9255d73db9baf20f8eddd2fb90282677951aa078fcc81b5032d5a35e0d6b5f753542b207f469855cea872cc4482c8919886b07281501b560041aa9e211f4924a7224bf37d37fced8500a5233fbc96c58ddc59a8105a264fed246b33d398f8d640a492ddabc180cad9d5706105153da423392904823c76852f5474ab5e14e23539b3525bcb5680b6f6d8f1207649cbb79237ef04851550168d7c882da40a551b75dda87adaf71062365c8dda60eb2f1759736920093db76a491a9246ff0018511586b0202532678ed2ddbb497c6fd50c6810591b5abcfb1046332ede37058c5dcaa16c7a88249e4ac6c6f7558d0a8081911a7fb0e1ddf6d440da64fb35c290b6b0581033900a491f5defac33c8008067b7ab2ee41ccb0febb3d436a9b080515e274e3de7b373edc01b509055d231da536d270b0157d96e441265be5b36d25f77b057d5faa1841b44814aeec46a482fe7c74c20372c3faecf50daa6c2011a46639f38aaf52a955040d041f633f6b5409045f79af5fc920404c4bb82f8620cb3220523d2e85ba1e6ce44117dfabf475710473d2ee590e11c6b20add253c5ff00782418d7ea95aaf12092813ff7932a8eb366000cccbb796346979d30200a9e3ede7dd773977b4835dd252ed9bb4925f77ba9cd516905dbe1348525f56c2722497b412036b1f46ac20bfa6af9985dc082d13d2ecb07aacb32890204b0feace9956d201a64fbbae03c8701089058087976f317f372dbc1b020bf4cce3da5c5d42b551056d3d7e27790694488fecd9c9bcb8e959106c3cc9d9b38eeaa958b1b43081da5be26f86f327697d649c88f47fb83367a455cdb4f0510693fac57af3cc946a312536e646f0487c3de320d7059074d5392752467b2492539125bc120915b21a874208c64ff0036746e4bae902019efc3b494ccadd0bab2095237dc3c4481b645fd1e440ec8d70ebf24081b4cbc2d1e0406cccbb9e418c70a88097bcd7afe4901291f96a4bf8bff009cc083de67d149fde2de0a7eaf4c7f3dcbc83aabfea8ff00fb9bf803fe524e1e08820f2ea9e3fe5bfab51e1fead7430bd62240812c785a3c44816d26e0b43810294b7fa5cc8021e70d81c48029e78da1c083e0410d247fb8e3d9d6d4402c817531bca9d0b95a0a882b83cf1b4381003491f1f337511cf164083bcbf52df585464f69908dde41f5826f86cf48694c0f91076f536e5fb4d1abd3fe70b45c40a5390ffd5bd438e142984010c9f149d8ba031d360c20524c25766c6bbb4b20779932eda48d16aa3537a59c48361a6d98aa91d2b310c1e40ec9e976cd46ab98e9960f50d1e4c27125b492234aaeb30558411a467ee486b8da40da87977c35a0fe4e75441193d22785afe837c2820a9125b4b69236c83ef8aa98baa20d43f1fe42929b73d919b33cbe7033e7d2188904946cb52428d46ac06eafac2acc2fe9aa7dd70f766438010124c1fde5ae78bc29a80191246369236aecd056b810693a7a78ce4f0967b6d2f87a40005208fe9a7d4241b0f36fc699b7393cb524ca3aaef78d82a20b20ccea8df8b32536b2097b774bee41632052b1ec3dba640d9b53f4b0ee40ee652a8dd9ba7b195db055424035252e785172e0defc0806999766bb1eab2dce04012724e3d9ac4936abe001a7106ae994e24a724e414975fed05558d240ec92dda8dd9b98d148059f3201a64c6d29b6937358a70e9ce1685240dbe15ce9ddbf56feeeb15aa7178a882e33d2e8dedbddcaf550406cc9f6eb85036d60a1203664fe9ba05422105c024fbf0579900449255c3c2e78f3b4829c4cce3106a357a65d9db40296d6af3ec4118f4e3cb15beca799054b3f3c5446cdb477996f0d0b038c2a20ab902954924b792b783727aa98d316bc82fe43cb97369240c75cfaa0ab975900d409ff009fc8710555590124c43f448359a7e487796cdfbc1777c8836d2472009b736d1a8dfbbd1a8fc17ae4d20b6a6786cc46824d250eeb62f069012961fd767a86d5361004996255db374b7f410a418f208b2c75e1c0081de6aef25dca8b94f551aac0da492a9246a4a978fca2d54454411beb923524bde506f3e220b790525e2a1f46a35248d497de0d50e39a8482a69f9e3ba37c3746eec496f0f878f1efcc83a979f93e2724e449a49249249241209097ef0482aaa1cdd2858b04133f6b540904932f0b47810463df6b540107123310d60e502a036ac00819247b491b7b16ba554069ce6103748df70f112063327f4dd02a11082e0048ccba37b2e7f3b974103248cc73e7155ea552aa0808101691f9724bf8bf88107bd0fa29ff00bc57c11fd5e9effea44b10755dfd523ff736f007fca39c3c11241e545307d24b46b1e8e47ff36ad775219902da48faef7d619e4004092923eab9f50e5900902d9e97371b5adca34b164017db0d780100c3d2e8dedbddcaf5504034f4bb96618c30a8833db7a3a5f4208c79c36071201a78fb75c280b6b15890204e490bd248dbd7c39e151020193ecd70a42dac16040ffe0ff8a892f04e7b23672237cbd2092de08fff00d8202a5107a40f575f1fa6dce446a31248d496d047a469487f680681eaac8378b76ce446c3672b560064415b24915b357b360f47af574082af9d5bc51bb4b3a402ae75d6b2023e0c98490237694700a687db6906da2352ade8e06e4ead8b2049f10a78291bb374dd445e4140cb0feed68b342d502f17d4411a472e559d34c850e603248e5cc5d63aeb990321ede5f3e31ec415726243b352416baed299990515eb1520da532769237cc26fa494aa306d3835c4145190dd936d25f7824f4dae1735e41b21357768c39d8eb94f81064ea8fe8890322052bbb51b8e9eaaa9505041abbe39a0f69237f57dd5e9fc84350925bb9248d492376857b3e034e4bea040da8df1727b235bb4981755f3b482c840f8b7391e92de117bb9f48906d5f86fe34a35248dde5bbdced08c6cbc082e33fe26a3766f6cacce98101246f89a8d0f2d0d0474f5b01e40cbfbe287dda1fca120afff007d40d9bdaae9d6a20409ed3e12538c51aed9efd0d8406d026376c6988dfdd771064b0ff995bf31a63d005e41266dfe2e24afe0240a46776a4b76f9823c60fcaa631ef62882d192788caf32f30c73ad6e632d20b46473c51bc19c39054ca0824fd77467de390f5201b2cf1366dafccb50b83355640a498f11a6da37e23ad0869801aa93dbc5b11f2d10f9f0c7320ab8f78b73911adddea5e874d5b2c0404f78b739125469adadfdc82b796271e92da5b4354aafce00041b45e1e9f52356cf9dc3de0a6905eb2c976ed5d2ae148b06ac9840110295de4f1a1fa6d440c92c97335055d07d0d71055a6643b4e7b4db57de77b832cad020dad4f20f795d4037559071b5766eec76ac664a7ac56d0247938cbb150eac8a80801fbf57e8eae20e4f1f6eb85016d62b120b6e67f9705dc4480625dd7f3020a953121e0ae18036cc8834e7d71a754e49b68d9928d46a495ae301065841d7d26271ed2de2924924120900d46cac1588054a64f8a4b792a1a5b5545b8103248bfa3c880d9e3edd70a02dac5624036587e3ac5ca05442c580101291bee1e2240448197de0690c43a1012327dbae140db5828480d48dd78f012039233f1d62e50ae016a80480d993fcd9d1b92eba408194c7e2da4ad47f1f4883de47d115fde0fe0a7f8a9cdffd4a9320ead3faa4cfee6fe00ff94938b822483caa278f823583f7623dbfc5aa1af3754408078ff26756e4bae80205b96ff4b9902dcb23fb240b7ef35ebf92400c8239e3fc99d5b92eba00830830c46fe44014f7dad5004114fc7f6c82ae4c2287e1bf2ebd0816cf2d7bcaba696d4e5b882c8f0b3c629ede09a4b694db496eff00bbd21fda01d74a8107689e12fd2928d9b7f8c9f83ff786ef197c819f2cc45e41db8f863eb0be1b78d932768cda4923f680fe7001e7dad20adfc483ef46a37864fb6342882f69aa83fab736d1d7e3ae6240d92c4e6cd46829d5f2e31c88127dbed2f325d2dab0ef4bc82b79647f648069e3fa6681518045700c43a56d7ae8c280d4081b5252e497c34705be388297c9a4092923fb4c548dcd5533415348126754dc4924a6da491ac1148235d6b5c0d85c41acc8d31b351a8d82411e924872a2a0f9105eb3725dc636053a52aa208d3d8fe82dab4da05812664cb948d086cf66b4bbd840b7e2ac877724924f15598aafa6c20eba2587f768fe6f6aacaecc841a40b7b42ac8823194aa4be1a1c5bdd75f520bd7c3d9d5f7962036f6011b40483642469ce7ce3c977103b21e5cfb35758c610590652aa46f4065dcc60b1a48100cbd23facf989046919f49716db0e94d4d20252c4e023776c74fbe9c482321d2bbce1c30c316c1a0466aa73764e4b2cd5b17904743a54526fec2aa58a53f320929ef2dda5d3b8aaebc82c840f96ed2e9d85575e4011232e5859ab22fa18e2049491f770ca1cc690ac82b79f89570591c561c4829348a71ead5a1c803a1056e994e3fadad1ed5b1c40807a756d2abae9d89061e4aeedeccbdaea0837cfc2bf2d46fed70120b8d3c63f06d4ad3d80bd4182a205c407c36fe44045252e78537aa0defc481266dcbbf0d66d05292baee9cc83762784bb66a4b6924bcba8af56ab020abb6aed2492c290554d57220252c9772d74ca04034c9fd3740a84420b803699785a3c082e343b51bb359469422bbd80403527f93aa08124cc8769a484214b280b03ba883a84f5ccf1191a92f16beadfc3e6fa35701febfd2f3510698a612bb49e23b3f9b3ba9c4118c46fe440da64feadcaf57510fd907da46635674cab6104932f0b47810112095edd1dfc2e24048c9f775c0790e0211206d332e6e16b1b9c286a8809193fab33bd5d400d7bf0d591032c8fcad23ff00b870120f7cff0044e7f78af827faa92dff00d429720ea9bfaa56fee47e09ff0094c93ff6d1441e4ed2e7fcb6a46a3dd0e0acc798254b1f707102051961fd767a86d5361005b3c7f56657aba802d9e3ecd70a46dac5404036592e55bd34d8bd6e600d3c3b4ba0ebe62da48231e3efeb88f20c002241864fbbae03c8701089049f781a4310e841f220573c7f933ab725d74010043c6356e572fa08043d21e590631c2a200879148dd5bab214103ff84b3e27b786f393694c9496cfa3787f584bfa406a5107677357d7811a92d9c13d91a9047a43ff009097d5dc58c8b541db8cb3c5446a491b36d248cde009046b32a46a6604012469cda492de5060b94bef1a22c5905908d3ead3f4b80860d20499d461492ab01a62b1bab781056e983fad2a9b56c5b454119032d70d8eea1746920643e95ddb7ead0a02d205b46cbb66a4b693878d345240ec78fa367274eb47317bc8347a7225766cf6492305e8f4946e1d616059081976d25d9cf9fcaa0373a8feed56b363577d01009330d48dd368b14de4b20933aa41bb925e61cfaea920eac931b491a929c88d7ecf495115be8085040807a5dcb21c238d64126467f5d9cb1b56d8402e399f28de566590f3b482ec46cbbeed5716fc82d6905a336e71fde4fd539b0162c20b44ccbb69a369c9f7e0f536c205b96251492fd610b14faa3079066f246a37692be24fd0554283220a71333e36924b79311f6e74d765640db35271f992497e5ed7f7bd440110338d7b4bf38706c70a081b50338f66db8e87388905912c3fb491bbb45c2d0d373aa820769b72e5eed493783f95eb02008923ff0076eabb8598b5e408099f2d1d43d220a727e2557a65e100a5ac20d6f9c938e80c14eca203a7855c792bb4999362da020241864ff36746e4bae9020227bcb06c020ecabc1990fe0da3927686301ed120b6d3fb3766eae7329ae820ab50e95aea68d8fe96b481b530635a5d16adaa60ac35dd1b2e5f8908d7799555c34d60a8836b272255249249e02ed45b4d0d6901b46987f1ce3c8281a880dfb885799049d9f5e640ed36cc6d27b392f0c235905a067ecea91201c9290bc68b9716f7e24093e244e346f84be12ce49ec92056cf46a41216e562c02b20f2f0989d5f5da7224a7224be2092cb97759048917f47910327b08de8fe1d838103248cc6870078d80fa841e4127ddc680c03a904a32f0b478107c0827993edd70a06dac1424048c9f66b85216d60b020252370d81c0080e19785a3c080d193ecd70a42dac160404bde0291c47a1032234feed497eb247b1aac3360e6a020fe80bf455497d144fa88f809e9fa4dda3372592d06abeda6522030a83e4a20ea93faa58fee25e09ff94a91e28920f2512c3fe5bfab640eb814fd3845e4092983eec7b8750c1c40932c3fab3a655b4816e587f56f5cea6902d9e3fa66815180457000878feadcef575108fefc15e641c1e3fa6e857188c55108bedeacbb9067b7ab2ee41c9e3ecd70a46dac5404034f3c6d0e041f0208a7bed6a8020052c75e1c00807188dfc881b4ca77692bef1af41a072883d00fa9a4f846f8b5e09a351bbbfeb04dfdde9067f5fd4a0aec78906ccc8e42ab7a6991a1cc07691bc6d0e2041193d21da48dfd5c10e59d50ac829c4f7ddac53a1f3cc2c5100d3261bae34059502c48091930cd71a46ca8140401131bb69d0bd7a0ac8024c29c69246a49248d6ecfc6ba286ba9bc3af19f93ff006978d892477e72d41aacdb5106df4cf705bcc818e7547f444824787b286fff00708fcee6852a20784998496cd494060a0ca241d6f4f09abb4a724e4492fcbdcd0639b6f3a56b20a2a5921e6fbf42abc830c98e6de8ccd555224168cc331e656ea96c698b5c417f1931e5aca202ae2ac5f150903fa3643bb31b23a15575903fcda452e9bc17a770a082aef12107f56c3692376870d698f020933aa71fe0da3766a4bf5800aa87842ac48357a754e3046ecc8f4adeb6e57103f48e75237eaded2b6f7af506100d46ce3ddb36ff00380a98ab9601a6103b2352829252d5e65ad5b5105ebb711bbb51ba8b560a1072c82da469f468295f3b69a2d205b49b82d0e04152cf04ad4e7f7a46ab9641abb3c0fa4924dd29faec41451e3fc99d5b92eba008021e3ffabfe595eaea0048cbc2d1e040ff0036d07b4a9d5540d2b20ecee64a0f66a351a8d84356b7b8901a9efe59787fc4414ec8cfebb3d416a991885907a5dbbaf1b599ae9536920d783c6366cf646b5aee83d9ad5b883689247fcb79dc2a7e9e22f20248d3f9e783f2cc81fd1a7d77bab1cf300206c32e0b07890374d545681a0ccd759019203a8d90ed249031575023a7dc41d42fd2ade386cd46cdbf0966dfc40172f1d39781074d481300bd9b0c97abc81fe46f1b4388103248dd78f0120643263566572fa00727bed6a80208bb42ac8824c8cfc758b942b805aa0120fd9010203265c160f12039eee340601d4809193edd70a06dac142406cc9fd3740a84420b803219fc5a48feb290107f420fa2ad21b43d417d5c07fea3323657ff000096491bff0089e41d64ff00545a8ada5e09f84aefc6548f1455ad6317c883c73ceaddb0f86a3eb863da0c20ae2587f5d9ea1b54d840170f7dad50040912c972ade9a6c5eb730021f8fed90043c7d9ae148db58a808069e78da1c0839f6f565dc8229e3fa668151804570095edeacbb90483f0bb9900f201e410bde0291c47a10453ce1b038900e20c33218d9a0e4de641b7bea67eb1892f04bc5a46ed2fc4f9e09147a3d203ff00dc94ec62c20f4a47a428d492351b38d1be5e90ecd70c69b88231931a668150804170035ec2bcfb1054e9e4529250bfad356641c1e456acd3420240b47becea9020abe721fbf0ed45aca9a0126d98f3256976bb176241d66a603697ac84e4aeae54c56ba483b0599e6354db4dea00b08094ea3f4d61d8559866412667a55493eeac6b6694416d248feedd9b7056ba01e1733020d039fa7feadf8901ff00f7035620cca95e9a41454ea90ac769235b900f1a2f20afcf1f496cd8a3ed65b630047b8105ff00e18cdb493776a4120fd516b3106906ccfd5cd9bb3769319cf4a16e2404bdfb66e96a571ed8036a052b4ab06e2ed2a8208d3c0c235248d49235bbc6176a95b083551032109b692fab692496d047a43fac31a61a690294fc9b88dd9aa0fbc86bf70173d6f57120adfc4f976cd9928dd9ccd9e92d39a0ca68120092c976cc9b736d243f76a91fad62b20bfa67a57694c946a4dbe657b020160f4a81fd0f2eda492da4a577aaab2a20d87439fb5ba5b62e7e0d150043c95524b17836feb058524118f18da5e6543a9854cba1600056e7a677f9be8e835e4d08906b37885301248d490a491be5ebf951a50d6415b1990ed25d773e97e97703721e6e6d3eed732c07905fd33e6e8fd6446fddec6d9d48373d0e7ee665aa1aca9a11a784bdfa846ab58a20ab8f4ba16e879b391037237cb8751020ad93c63f0911a921f8724aeb7e4ab98b0bd0f7960d8041290e7ec6696d839f8305616ca1a1afe09036c8dd78f0120b010e7f5a5d16ad8b602c24c8cc24925ac2d753cc80dcf09c68df0de6da492493047f96ed0b816c7e6ba083c97f8cde237efd9e2d4f69ec921ddfb49208f47ffe01b056af205b9198d777a86c5361006491bc6d0e2040da8d319e783f2cc80d9931ab32b97d00234b0fe8311705a2eac05c4034f1fd3742b8c462a8861e3fa6e857188c5510e0cb82c1e2404cc43f608091931a668150804170064327f4dd02a11082e006e46f1b43881031903348ff0017125fc5fc0083dfd7d0fa73da7a82782c341a9c99ce44a7420d5afa7526d84e3f00a658c643395202342c3d100bfecac2ba083c5978b483d9a92b11a8f7afb520a66441af12c7dc1c408126587f5d9ea1b54d84016e587e3ac5ca05442c580102dcb25cbb3ae9b07aded00878fe99a05460115c0231e976583d56599448069e3fab73bd5d44249e9746f6deee57aa8208a67ecea9120e7de0291c47a1067bc052388f4208c78fe9ba15c623154433db7a3a5f420f87bf0579907e4f386c0e2411bdbd5977208d2c31bb79b7bf06d441deefd1a7eb6c33926dfef273d927b42704dfddc8fda01fdbf20bdcdd501db8cb107f76f97e2e646ad030816bdbd5977205d4ff00d91d448168f386c0e240a4923fbb79f7e80352a014524a5cf0a2e5c1bdf81049439f0d9a92490d34e8540041d624d5de5e3f4f64907c3f18ab4f5dc41d904c993eeda2ee2d11c5d708102dcea4b6f24975e7ac8806a065dbca14405f1d56417f7bf0d59106a17ac248776fd64473a40928f110a354890538879abb4b66ecdf2f485bc196baf5b0816d3b31f66a4d1a8c66994715c58f20dab9a92146a351bb35fb3ef5d70007536903b248ff0096eba51632a682e1e78da1c082448cfebb39636adb0801a4f3c2c0e041acfe2a18f89235a9047dea773bd640a499976d29b6ade0df88532fb72e804144f893b37eada311a8dc45ea73754369065f7e46ce4f0de64fde08fddd7e17de14105a332766fef6c92ed4d5c9b9105c7e1ec9f76f66e42b665583482ec4698ddbaadebb6231a458010823901146386d1e04035332146eaf64195b3a06a5cf1977d5b9c9b4b66a3f67ed2d0bf1a60f20b44f271189246ed2f87d0f0a33208d30e7c2352539125b355bbf775b5afbf220da240cbb854bcdbd88234ea3f4d61d8559866409278fe99a05460115c01fe649fd59852ee6b10049f1264208dde4315b29557f32076f0dd39f5911b553ff0050a9bd881fe4721e7aeb9c481f901f6835020b4919217ea97f7ad640c923d9a8daeb5718b98dcc81b5032f46a336959439adb83aa9441d4bfd259eb27b366dfd4946b270ce0dded684811fab9f410749e8190f0a979b7b10361970583c4819a46fb87889031993fa6e8150884170093edadda160536dd6624030806fbf57e8eae20e6467d24eb6ef9e74030824fbe57fe89013f7e0af3202264fbbae03c87010890327b7ab2ee40c9239773d75ce24048ccbb9e638431ac81d90e7ff0006e727f17e1b49fa58d5020f7e1f441185fa8078260a704e51c53728ac28ac83f1f4a9cd509c9e09237d1fe024a5fe8da3fb9f446d8877020f17beb45e1d6cd49796a8366a3c418fbd8e5b6820eb553dbb697d5d5f5d040832c3faece585ab64620b47becea90205c3c7dbae1405b58ac4816e587e3ac5eb15c42c5089044201e7a5d0b743cd9c8830f1fe4ceadc975d004124ccb9b85ac6e70a1aa20e3dbd597720cf6f565dc823988dfc8833dbd5977208c65e168f02092659f9c3b2f173286b88234b1f7071020c32f0b478104940ceb9c9e1b4f646cf699292d9c909bfbc3ff1f4e822117907ab5f539f59a9b7e3f78708d4933687c411ff00f4f904be8b355106c84e541f1b3a630e215ba48fa3456bf959451690291e4aa3759b5ce7c2f0205b4f1fddaa5bb4d50306f11020a0524f0d7e5090464f4bb66cc9492487eec484301aa8b6b5907599eac63f5927b4f649412092ff00e4369354fd5641dabc8cc6bbbd43629b080514983ea497e70d305aad3d6419233fa1c41e160bab117905b5233fbb6bd50aef51055d3f379235248d49797a411a90ddeca4759106a5cc99d48dddbbcfcbbffb542bc1ce205b333ffeb278b4200bd9ea650a75bc5d05906dea04fed2ad79d99903b2612de5a2aa61c5b7005a159004327f56e57aba8867bf0d59105812cf2cf4acf488280f12115bb525bc9b56ada69a44835be64cea46fd499c88d4979823d24342d4ec750685053925c91f897c41b7bdb162f929c4175cdbd9a8d9937aba83b82a214103fcf6972366df86e8dd9df10d9f5c6ba194d1685b7327cb91ba8fa4417e19f2bd502409478feaccaf575008c665d1bd973f9dcba080da21d7f31201a9e3f6071c1a39d641a85e334b9248d46ab43ae641409e9f293146a491bb4b770fc3f1aed8d2a6105ebeaea63f06e7224820926db0776656a20dea9a92e53e2d6766f2208c9f976f25d71571a698902d993eeeb80f21c042241644cf3eee7829fa700b8824cf631bb7790ab4fe58d641a4f30e7ba47c25f1b125326727904f0de08f480b582ce15907688874aa3766e87836fae8102036869d536f69799318af9bdfa510494ff8802e8530a7b10201e9f0cf32666a01d45816ac8313de382366dcdb492492492f2f4682921c5ec18f520f3c7e2d788c92f16bc49494f649797ed2480a3fff006090102da35e3afca0206391baf1e0240cd237dc3c44808fb7ab2ee419edeacbb90053df6b5401045327ddd701e4380844830c9f775c0790e02112093ef0348621d0809193edd70a06dac142406e472e46f1b5e2bc9cd7901bf7e1ab220366237f2203664feaccef575006e43cbb76a4ac47d2bf33c792eb20fe83ff0043e7f781f82ffe2d39fce5e9905cfeba082fac73251c8da7d21f4b162b25907979f5c6f075a3bb5c8dd2f422361079e3f19a6afd5b4924a9b542a75b8e441acd2dfe9732052961fd7672c2d5b23100878fbfae23c830008902dfbe57fe8900ef6c35e00419ed86bc008229e3fab32bd5d4024993fa66857080c1510e7db0d7801045f781a4310e8419ef0348621d0833de0690c43a104af6c35e004114c9fd5b95eaea212bdb0d7801067b61af00208a78feedaf25e15d8108905fdeabbeb0a92f007c4846a4812490fa9e904923d1f3811fff004006fcf84083d48cdbf1511b3da64a35248d496d004823590d3db831c41498cf15a477932d6478bf8a880da34c6d2d00a82c0d62c08c9e3173e9ee116dd116056e6507f1275106872c2f20d27f5c7f188664cc9fa928d56d09c2b47f0bc38bdc4081ea2a83fc099c939124b1da092d9e8fbb2a9441d8299976ee490b39dd48370a8828a491f5defac33c80080248cff3e705dcb5d2aa482d140cbb76c68883a3aac812678386de641d594e4da53727b4e446fe72b2965f6bc81b7c2b3eb9ecfc3b0006842950761d371d773020754979706a2240b878c6accee5f400fc105848df2b0fdae0240813ae43723ebeec5bb4d20eb36592e09b7e244e49b6dde0bd9ece1d38441493d2eda53911a8c5797b823ae02d20bf8ca0f69ecd46f97bb785e3c34a205bf16a786f29b736ddb3f31a54c68ad940106f0cc331bb5596b800e2416d1e33bb3be10ef4d40a5ec369357577adeb54544118f22bf58e2d656ea5431710124098b038e2d1caa20e1331d7f08834ebc79f2cbc79906ac106e1780263fb1ba4ff003824a95d63ab2920da29b92eea0bb8237e550106267cc8751f48806993fa6e815088417007f9aa7d492ab01a20b1beb70103fa78c7cbe6180aeba88340bd71a63ed299336e7b237cc26fa4811ff9c3dc142fefc0835e667fadecf69928dd9a9254e0d9fbbf68c6bd54e53481b4cfae5b7e21b43b7365a412659ebb21f76a45219ac6d5368205b967ae9ce4497c369870e7c9824140cfcf1a67bf8908dd9a92dde8f5797aff00b7ecaeb6d8b20afe46ebc78090337b11af102035233faecf505aa64620ca67ed6a8120e3de0690c43a1061e3fab32bd5d40027b7f32d69d172aa680d3c7f933ab725d7401048f6f565dc825199773c8318e151049327f56677aba801b327f4cd0ae10182a206cccb9b85ac6e70a1aa2036665d1bd973f9dcba080d9997330b1adca14b5440dc879706cd493d8a0af595441fd0dfe86539fbbfa3dbc11a8dce5ce7224fa575106d97ac99a5cdb47ffeafa7e97a382be4fea41d367ac87865b491a926d81943be241e627d69fc2cd9a92495f8662cbaaa083a8e9d521d9a927b3582eb55749056f2c3fa0c45c168bab01710043c7d9ae148db58a808021e3fa6681518045700087a5d9e2e55b665120c3c7f56e77aba8846f6de8e97d0824993fab33bd5d4023fbf05799071edbd1d2fa106193fa6e8150884170093ef0148e23d0833de0291c47a10707becea902095ef35ebf92418621fb0419ef35ebf92403658b49f07b17c6ac8837cfd547d6f7f7b7468f86f3d925bbffc1f4839634d17906f51ef5a1993f7923dbf9c21473aa040343d783c374624b660ce447ff9c3862d1e0406e59eb5f32525fe1223dbf9c2b6e8082a54c7aeccc946ed21da4290487e6ff9387400041d6ff8853fe7278b53d92539125f10623d1ecb6ca79090773de12cd546cc9f0de64cdb5fc376837febe95cfb5a4164248fad1a927e2bb1e1a8d241499f85dcc8069e3fa668151804570076439f7e3dc7a8d6c790294ea3f76419ac08340fc7e90ecdf123697c3d208daf1a28e440b7e1b9ff00c3646dad88359558cbd4f20eca66d9fddd664ebc337621689990eeebc2d62ef5d0b6bd4403bd8579f6201e40d53561fa40403674a0faabb0dca1c4483a9ff596908a367b235243f10c3bae8b4829cf6ff126aa9d5440ee67c469c9952e50b1b55307102921cc249253da6ded2f882491fd34189076f53564ff000d7ae9ef580105c69231b351b9ae80c95cc8103de0690c43a107267ed6a81206340986f2ecabdebbd840b69e90f0a97937b1069378d5e5baa0483556587f56f5cea6906f4f827bb7c3846b9e2f7f0754f5105da873efc38b3b664119252e785172e0defc0824a33f2b54905a28d0f893ed75ea0e34e20c93927523766abe4c7ea0fb4349bc544aa4e724c99ec8efcda290a2db3e7020ea876aed27d0222a56a9bc83932f0b47810492020411fdbd5977202265c160f120392378da1c4080d993fcd9d1b92eba4080d993fab33bd5d4030f1fd5b9deaea2034f4b9b8dad6e51a58b201b2c972ade9a6c5eb730021e9746f6deee57aa8209264feadcaf5751024665ccc2c6b72852d51049f7caff00d12025233fab3a655b080dc8cfc758b942b805aa012064919fd767a82d53231064332ecd763d565b9c081b10e7d48d4937eef062f8a9965ab120fe8a9f4367fe6f0f00bf5627ff00fa992e41b67eb13f8b88ff00d2f4b87a241a2d3c26e02491add5aa16c211890749feb81e07a91a92496cd1bf4d1b861410799bf1fa607d5b49249572ddc6ba0057120d1e493835f92240b678fe99a05460115c016fdb7a3a5f4201bedeacbb9047f6f565dc833dbd597720cf6f565dc822993fa66857080c1510c3c7f4cd02a3008ae0124c9f6eb85036d60a120e3dfabf4757107ebdbd5977209078ff0026756e4bae8020c3c7f933ab725d740104bf7e0af320fc993ecd70a42dac16041865c160f1208c411bddc3ef30c40830f4851af646c6ab8f1538838f71abd1d5e412a470fda20bb3c1f90fd64f12264a37ef09c88f8f5553166241e805241f0dfbbf67e863105c01c4012587f76a4afaabc9f4056e20a7258635ddcb1b16d840021e30fe988730c4060406d1a7d5a7e97010c1a40b6983eb496bb5301ba041aa9eb4521fc5b492ac00c4793ec5105033265df8488d7b05748b380ea820ed17c3dde56da23759f220d863be5d7fa5c0082ae49cb9daa1ddaa5100d3d2ee598630c2a2036814aef246f206338d50060524168a48fe5962ecf220ebebd71a63ed3993f5911bb4377ae1dbb9075e28d3eab9d50659809012f781a4310e840c9e1518da5e244db8ecf492f4d65b74483ba79a089046a37f383a9efa08b80da7a5dc6b53ea67720adcf4bb3c5cab6cca241864feaccef5750076409f6f3eebb9cbbda40492461573ea0cb21120eba3d670c6cdddb052d1e90c434b20d4b3c7f933ab725d74010760be1b9ffec6f36e1bb6c8b98be17905b48d3ead3f4b80860d20932c3fcb941772d742e920248d70ebf2408192592e6a351b1d66c1bea701291a2fcc91a92c7e573abac814e724ce46a366dce44908ed0dda9177eade80c120e85e5df8c691fd6490e2241cfbc0d218874209641f7327dbae140db58284839202265c160f1202464feaccef575003865e168f0202264ff36746e4bae90208c7a5ccc6c63738d0c5900d3c7f56657aba80033ce1b0389073edbd1d2fa107079c36071209464feaccef575002464feadcaf5751026406bdb7a3a5f4206591bee1e224068c9f66b85216d60b020b2103bc91a9277c3fabae6af020fe8a1f4311cfddfd1e9e08d46e72e739127d34f10dc8f1f7cb51d6fa5fed7a441a9a79e3687020d4af1cbc3ffac88c492d743b27bacc0221e66fd717c08d9bb4d48db1f5e85dc083a07f10907b3524936d8fefc5aca8829c3c7f56e77aba882d9e3edd70a02dac5624034f1fd5995eaea011bde6bd7f24833685591046f780a4711e84118ccbb9e418c70a8824fbf05799061e97678b956d9944833df82bcc8097bf0d591067bf0d591048f7e1ab220fd19785a3c0824fb7ab2ee4114f1fd3340a8c022b804a208dec46bc40824fb7ab2ee419edeacbb904720bf3d517fbbf4db8ecfda0e8f1be9545441dfc278fe976379b2b10078102d9e3fbb7e55b2eb59590249e31a6e81518845700092c31aeee58d8b6c201191af1d7e50100448b86ce44140facb48bf0266d87e7253068a8393ac20d2791cbf66a451bfac91edbf9fcaa0ee9fc3790ecd9b68d72d208dda11c9f0ba0a207ef867ecf320ab48079e3fc99d5b92eba0082348cfebb39636adb0805b5edf693d7101d4391024cea90236722352537125e5e9046ecfc01615416ac5c41d2327907f5267224a6da4fe1c92155ba0d2d641f920d92f5459b9f593c4849249ff57d690bb80e58a883b5f327d9ae1485b582c0806cea3f76419ac08103dbd5977202464fe9ba05422105c0191032e5eaac7b54406e587f5d9ea1b54d8403577d68a6afd64f0df6923778242686f0a7fac0474041d621e3efeb88f20c002241d9078567ff00b1ba36bb75c1f6a82d1469f5deeac73cc00809903648cc6870078d80fa841e40c9edfcb47508e42b0e6241892973f58ab9d64156f8e538c26df84b391254a3520da35a6107435233e92496f2fe30751d06d8524048ccbb25dae55b6e70209264fbbae03c8701089061887ec1049327f56e57aba8867bc0d21887420368d973b582f954404bdb7a3a5f42092665d92ed72adb7381047f7e0af320187a5d0b743cd9c8823fb7ab2ee4113df86ac883f5ed86bc00824fb7ab2ee4044c9f66b85216d60b02037239773d75ce240c864ff36746e4bae902037233f1d62f582a016ac4081b7df2bff4481fd032edda918797db772c98e0fe8a9f4287fe6e9f037f4273ff00f5224883757c7c32028c47285c3e9060360906affb0af3ec409498456d285b669ce17107551eb69e07fd6446a4b76c7bd96b5c16283ca57ad7783bf56d24921ceaed800836041d58a78c6cd492483950b8c5fa79020fbc052388f4208d2c3fab7ae7534806fb7ab2ee41878ff26756e4bae80208c78fb75c280b6b1589073edeacbb9067b7ab2ee41c19785a3c0824fbe57fe89048f6f565dc825199773c8318e151049f780a4711e84127de6bd7f24830f1f7f5c47906001120cf79af5fc92098411c83e6621fb04187e3fb6419ef35ebf924171fab4a7366f8d936e3b4377d5c5ae555c43bef4c4bf76a35f9e979d24036592ee5ae9940830cef25c6c663a15d64012588ae56e1435ad6900432634cd02a10082e00352463b863d9d6564140fac81ffec6eac99de8a7910698786e8309ede244c99b6fda09247ed0ff00c05d11b0483ba7f6f0fbbd1b43951782a8ac824a4a5dbb4430b8230c5d62882b8f6f565dc8234b1f7071020f8103ea065db491bcafd50352c81693d2d78dafea37c6820ebebd6a267351be242363bbd20c6b2143e820d4b3d2eddb0a1c00e8eb98107651ea9735466df86db495bc27824b687fee0116d708b6d20dbe439fb5ba5b62e7e0d1502da4a5dbc8430bc631c5f6a880710113c7d9ae148db58a80830ccb9b85ac6e70a1aa206e3cf1b438100c46c8769249268d056f046823ed5ac2db2b20e9f3c549b9f5267b4e49b692f87a4b77d72064021535a41bb1e06cb7fb1ba3aad286aa20a20b8cccba37b2e7f3b9741032199742cd0726732064327ddd701e43808448069e4aea3f3a680a5641cfbf06d25b73b342fac8349bd793c4754db46cc946ff0084092f2fff00d801ff002a05c41d6b48cc6bbbd43629b0804832e0b078907264fe9ba05422105c03ec41f1f6de8e97d0824fbf05799012919f8eb17285700b54024124c9fd3342b84060a8848f7eafd1d5c403bde0690c43a1046f79af5fc9201a665dcf20c638544127de0291c47a106193fab33bd5d4024999746f65cfe772e8202464fe99a15c203054409193fcd9d1b92eba4080d993fab33bd5d40190ccb99858d6e50a5aa2024665cdc2d6373850d51059081972e6da4bf8bff9ca3846a120fe8fbf4229d5fd1c7e07316a19cc0f0fbea5140106f578f7e528affc707fb3e8906abcb23fb24014f7dad500414df8913391b3911a3cf562803081079ecf5def57adda91496a30c2f020f2a7e3bccefab892496a8a637c174106981e4e73502ac531562d9585241176a7e961dc839f7e0af3208c7a5dcb30c6185441cfbf05799067bf05799067bf05799048f7e0af32092665d1bd973f9dcba0824999766bb1eab2dce04124c9fd3342b84060a886199773cc7086359012f7caff00d12091edeacbb9072665cdc2d6373850d5104af7e0af32091efc15e6411646ebc780904a327f56677aba8067bc052388f420c9125426dce59b73911bf0f4923d2153abcbb907a01f0de7ff00d76f0dd1a92fcdac6f48b82ac0808fbf0d59104a91cb976f5d32343da1276ee97dc8069e3fa66815180457001d2cf2cf4acf4883597d62cfff00637cdaa564c1b6f72c814bd4866a8ce49ed3927233f07d1bff00cfc5ad50f07ac083b0492798e1c0823ce43f7e1da8b59534124c43f608099e78da1c0820107d51b2ed9a9206aefa4474ebc824a60c5edcf54b1b5b02ae9d535427b786f3da6dfe6dda0b7ebb10751c8790ed2492366dbd21b4b67bfb3dc1435c0b20ee790e8ad9a8d9b68d46fc3d1a8fb5cb8d793d8204164234fe5960ecf220533df6b5401012f615e7d88247b0af3ec4038f3c6d0e040ea81de6feaee8bd2880948cfecd4950ce4a1c2aade41d78fafb4d5d9b3d91b391ff005811bdaa7b05ea61046f5699d5b4a6da491afd9f4dd805e217906d5fb6f474be841c9997ef2d7cd6d6c692022652bf20c54ae2179066d5d9b5ad98b79f78100d4f4f146cc99b6929c9391243a5b86a6e6d52883a6af13a7c24bc489ec929c9f0f66cea3dc2e7f18580a4411fd8579f620906237f220c327f9b3a3725d7481067b7ab2ee4123dbd5977208fedeacbb9012327f4dd02a11082e01f0f7e0af320167a5ccc6c63738d0c590463d2ee590e11c6b20e3df86ac883f5ed86bc00824fb7ab2ee41c1997330b1adca14b544048c9f66b85216d60b02093b53f4b0ee41cfd6b46d038f720e3eb52468c83a1012329c492d5666fd3481fd0295497d5b9c8dfbbe23c70d08907f4c4fa0825897957d19be051d95807b5f789dc0d52d5b7a50353004473ac83b2af1c7cb11ffa7e9ffc441aae79c36071200b2c7dc1c40814658635ddea0b14c8c4350bc7ef0911b3911a92b2ad7ca870792ef5f6f557146ed2496cd1f88b767eb2b5cb20f37fe244c7494db4970557639b7730a53dbd59772091b7525a11ea404feb205019742093b5aaff0047b9049f7e1ab22091efc3564419efc3564404cc9fe6ce8dc975d20419edeacbb9012327f4dd02a11082e006e592e46eedfcdfcb975552419efc35644124c9fd3342b84060a886193fa66857080c151095edeacbb907064fb75c281b6b0509049311bf9106193fcd9d1b92eba408247b0af3ec41c9e30cd71a42ca856041bc3ea7fe348a3525f52124925fddf1a99c34a20ec5e592eff37e4c6907ebdf82bcc8226d6af3ec40376a7e8e1dc823249388df2dda5aa9cf586241a97eb513c7664db46cdaf88242bd5437906c87a81a291bfbd2cf6497de0926f1d0b02e20dab310fd820529c7e677f5201b2378da1c4083f641f83c7f76d792f0aec08448069e31ab33b97d001b8f7960d804031048ade492fce08d4856b52e1a52e2f20ea5fc3d9b9ff9517d5b50eef9ec907b56a490e74d172843b569618524959696bc480d9e3edd70a02dac5624118cc879e438471ac80d9970583c482419f2c0b04802cb0c6bbb96362db0801243cb95c3860e1a05c412258ebc380106b87afe22b69784c8d9c8f484df4923e3ff0040aaf52f8107589e03cfff00ab73db79797a460ed62ae41d94999c68d5e3653a6bed68493d3a91adbf3684716b63410043d3e35c71cc1cd020499c9e34cdb9b7bc92492b51f4b18bd760d1ef16bc694978b2925797cdf47fc3fef00ab38c082b020e3db0d7801070665dcf31c218d641cfb61af00208bef0348621d08231e9746f6deee57aa82093ef0348621d08236d0ab220c332e8decb9fcee5d04187a5d1bdb7bb95eaa08077bf05799067bf057990707a5dcb30c6185441cfbf05799070792ba8fce9a0295900ddba8dd0875201a7a756a00a7f11bea20c332e49a498cc38468d308192466356f5cea61036c8df70f11203465c160f120b6d0263f06e727f17d2bf32a3bada21607f4b9fa097ff00362fabff00f8d9e1fcfa7483b2cf1c7cb11ffa7e9ffc441ad278c6accee5f4005b3c61bae340d950a848024b0c6830170da0fa801c40b69845576af1ea0ab5a41d5dfada7ab9a367223525bb7ef0ac7908845d01b83c7cfae9faabfd5b4924925b35543f410f93043a469d537366a4bcb462ea2d53e1d08124f186eb8d036542a1208c78c699a15c603154406fbb55afe51073efc92a8808994e36fc541ab20a12092652bab34c18090123295d5ba60c408257bf05799011332e8decb9fcee5d04048f25750f95348d0a2091efd5fa3ab88257b7ab2ee4123dbd5977209464fe9ba05422105c024fbc052388f42093ef35ebf92418621fb04048c9fd3342b84060a8849327dbae140db58284824c8cfecd5a491bbbd208f5b74df9c5a41bb1e187ad46edfab93dbf8bd21c574b55f2020d9046f89a8d49796ce447f45f4c5ef2034667feed5e5cafcd4403a593ff00f8bed52ed1e761004964eaf892495f9be875fc88340fc72f103eb24e4ddac4723f77869f4d2fa483b71f52d41ff601da5f7806d11ac6e6ab28106c31970583c4817131e641fa5cc80923643bb4069b742ee64124cc85b85ad6650a5aa20c3c619ae3485950ac0814a5bfd2e6404a467f56f5cea610324cf90fe120074d46e15c483acc91c8766faec24bf596d1e74f66414241d8ccb7cc925fb5c40838964b956f4d362f5b9812519f95aa480d19fb3aa44839f710af3200841887f331d40832587f97282ee5ae85d2415bfada18da5e09ce40fcd8b5a9707eae20e88a46e1b0380105d881f1c2724db46ecdf30536b80b7a62d2064fdfdc5fb37f8bff00e814b9cb5dd151024a63c629c89201f87d393c1aa736c89055c7a5092497992485218b1f475b9ac0cf79af5fc920c3c7dfd711e41800448231e3fab73bd5d4422107e8f4bb96618c30a883e1efc15e641f93c7d9ae148db58a80830f1f66b85236d62a02019efd5fa3ab88237bf0d5910473d2ecb07aacb32890463d2e8dedbddcaf55041176a7e961dc8239e4e32ec543ab22a020087a71e58adf653cc806fb7492496caf1b080919785a3c080d1970583c4819a46fb8788903648cc43583d62b80daa11206491bee1e2240db2331a1c01e3603ea107905b536cc7e0da4a3f8bfa6a83e55343fa5efd03c643ffe1a3e0900c1213cc714f1fa1547c9c41d8ff8d1e5c8ff00f19e97120d693f1fdb20092c75e1c008021e31a66857180c55105a3ce1b0389020cea418a491a925fce0faa88d1020e8d3d77bd55d1b3911a92492351b0d54e087720f205eb51e0424a65249241b3755c5b4b6920eb353121d9ab6eace5d48029e78da1c083e0410cfc7f6c821907c0f386c0e241865c160f120fd7bfa4a91c3ff00c4808994e72582ad5b156a9958d2406feb18ed2f9757aeeb8824994e73565a5dcb810123295d47e745214288096d0ab22095b53f470ee4043dfabf4757104a332e859a0e4ce64124ccb9b85ac6e70a1aa2025ef0148e23d0833df82bcc8097bc0d2188742027bb74a202323972491a92dda927c6f05f55a882d140f8d33911a21b4b78a3f4bd0305a41607efe136f5fba20afe7278b69249291a8d6a3c1b0ae1aac829c49bc2c0e241dfc7aa5eedf0066dbfcb16aefc0198905a26651bc9fbbd9447e6f550e20c3c7f933ab725d7401049919ffce4c62a316d35af424120cb82c1e241cfb6f474be840352461dc738730a46a200e406267a577964c6d6ca3a28834327b6edf5c69b6928241ac554bd035e41bd5390fef3d42da3000a480719fb5aa0480d48cc73e7155ea552aa080dfbc052388f4208fefc15e6400e592e55bd34d8bd6e6046327f4cd0ae10182a2035247fb8e3d9d6d44093eb08955f84b393f56da0badda51074552375e3c0480b9042f770a0701ea41878feadcef575108dedbd1d2fa1045f6f565dc8393c7d9ae148db58a808237b7ab2ee4118ccb99858d6e50a5aa208fed86bc0083f3efc3564411cf4bb2c1eab2cca24017df82bcc8229e97371b5adca34b1640365895e56634b5ac6900d3d38f1e8c56ae5890043d38f0eb9b043e441176b24a9cc7a1061010202c67ed6a8120346237f2203467ecea9120659198d7772c2c5b23106491b86c0e0040db2387ed1036c8de36871020b6a6d98fc1b9c9fc5f076f2629acbaf20fe96ff0041599fff0096978140b74a2778be94f1faaa20ec7bc64f2e47fe97a5c40835c0f18d5b95cbe82010f18d3740a8c422b80043c61bae340d950a848021e30fe988730c40604010f386c0e2414e789de1fa3671a36d62e8a1d48fc883cd27afe7aa86d2da49246a36866cfe4ce3cc83c9c78f1e1224a6e24d25bb468c6f753dd81a7278c699a15c60315443e2401c830823906107c0f386c0e241f7201e7e177320c20c2094692820f0101ae2bae9e21002025f58ff00f572ff00f12022667529f6d8b6707901291ce386942c1ef650406cca719760b1d5b05810123295f9062a5710bc80948e5ccd457745f435c4048ccba1668393399012332ee790631c2a2024665d1bd973f9dcba0824fbf0d59104af6c35e004127dbd5977208b2c3fab3a655b483b95f5339f1b4fc2446a3769f976efd9e3a52c82f5f7caff00d12035b53f4b0ee4128ca57e418a95c42f2092652b660c6d4fa161079046da1564418792bf21c54ae017900d96257a57ae034a8806c8d39e5b70697aa41c41acde270ffe52132525fac1eee31d34836893c955249f9ab434f7208d234af51f9f0c680206edb41afdcf420e0f256cc18ca9f4a822f208db561e5fcee8ae9d080d3d2ee598630c2a20c332e6ed2ada2e0e7cdb44416f6aef282dcbd42195641a97eba5e2aecd9b7f5251a93de13830d9f66b8a83ad6919fd767a82d53231093edbd1d2fa100df6f565dc833dbd5977208c7a5ccc6c63738d0c59045f7e1ab2208fefc35644118f4ba37b6f772bd541061e9746f6deee57aa8208bb53f4b0ee4014f2563637baac685404036589c6ea23a6c6b5902dcb2756a2dca23d08021e4e24bbc74caa8158104020fbfb11af1020226237f220904124cb82c1e2404cc43f60809fb11af1020226237f2206d91bc6d0e20406cc98e6de8ccd5552240c922fe8f2206d91baf1e0240da64c699a05420105c03643c1398e929edb491a8d66f29bf582c12441fd39be8acf0efd1f0f3d463c129ac26bd2937bb231232df6601f784bce9e5b7f4557106dc78bde5a8fff0019e97020d72f6235e204030fc7f6c8021e70d81c48024b0c6adeb9d4d201b2c31a0c05c3683ea007102d9e31c9bd599aaaa048352fc72f0751d3d91a92ddaed298cf95641e52bd7dbd4b525bc927b35575d8052e8b883cd278b5e1ca4a6da4a15d146a969050479e3687020047becea9020fc9047208e4048cfd9d522411483e079c36071208c418411c8308308308247b7ab2ee4128d255220e1110a5420a0c5fc7320346539c960ab56c55aa65634901b91a71b8e5aa560b6288190ca56dc1aca9d42c22f2024652b660c6d4fa161079012332e661635b94296a88097bf6ed78beb53f8c2dada4124c9fd3740a84420b8049f780a4711e8417afabdf8d3fbd34e4de4bfabe90f30a24038fc82e20ed7cf4f146a491bf5911b173307d7862419239f1a8aed75b00532a064fae08da448249e9c68dfbca8e0b55f8524187a75c710cbe5790043d38dbe654b6e06d0ca48231e9c68d5e1653a6bec60648d39cf9c792ee20d5df15278a37f7ec991bcd7e6307e62ef9d021b0d239c6b4979979865d60de040cfefc15e640436e0d5fc91fe89046964ea5ecd54306e64120f2711ae8bb35e56100efad28caff00d12052964ea493eee635594d6b20499e1e2da37c379b6924904705683e441d58cf69f292f1227224a7224bff00f8240c655dc8037b61af002019b42ac88231e97678b956d9944823fbf0579900c3d2e85ba1e6ce44118f25756e9a31120c3c9ce5c35a6100d3c9ce236f4eaf5102d9e9d50866df936a20087a71a4b4f1d03e872da4034f4b924bc2c76b32086418404083ec67ed6a8120fd104f32f0b4781049311bf9101020304138c9fd3342b84060a881b32e0b078901b310fd8206491c3f6881b646f1b4388103248cfebb3d416a991883b4d541a4a7ba491a8d46b921aecc7402241eafbe8bbfa3f3692351a9249237e248f4824768551d416041ede3c1c41c866cf8713626fa215ee689907a324f417ffa82be64103c59f2d477e90f0020a04fc2ee64010f18d5b95cbe82034f18d599dcbe80034f1866b8d216542b0205b3c6356e572fa08049618d59d32ada403658639728aaf52a85d041a2beb23e00a367b4db49681bd69805100f23bebe1ea69f56f6924b66e345155d01801079daf10a647d5b492499c8716e761053878c3fa621cc31018104320c208e41c9e70d81c4838208e418411cc46fe4418418411c8308308308308308089997370b58dce14354406e4695eba0e37b081924695ea3f3e18d00406cccbb25dae55b6e70202464feadcaf5751092665dcf31c218d6412bdbd597720b8a61f8c7393c371d9aada137feefa58e5d590b0836f66df8fd36e72233ccb67e180b331ea40ec67c4646a497bcd54b343f350106199d5ada14501c0200d2092667fb15b4ba3c6f6711a08231e9ff00170bd517735ac816e593e3f396acd2ef6804fdf6d1b36f790a4a80e3a5d641a853c3c46494e4f1211b3dbeeff2f5880402abb4a20dbd40f88df5911a8d497c419c7106d222cc82c843f88c92d52c6bdb6862e20247a7fa4b1eede9454e208df5e0691c408069e9e3f9caf8b3a386d208c7a7f2351bf128045fdf215905393dbd61766fe2df9835b637e562c5e41a973aa7c4e49ec92da4926fe6f5d74e111b5840bbefc15e6402cf25756e9a311208c792ba87ca9a4685100dda1564411a5938d6dd35a3c5b0e40b67a71e58adf653cc8069e9c78f462b572c48021e4aea3f3a680a56411483932e0b078904f20fdfbc052388f420fc101020fb19fb5aa04830cfdad5024128824101132e0b078901133f67548904a3261dd300e63888c080d9930dd71a02ca81624048cb82c1e240c923310d60e502a036ac00819246ebc780903748df70f11206c40a2925395248d46a35e900d08514aba0907a37fa337e8ed494f69c936d249246eefdde29048ecfa78f0bc83d9e787be1fcdbf09664a366dcdb46ecefbc038ad788806641bfde19fe25213ff0e3fed8902cf8b3e5a8efd21e004144fb0af3ec4038f186eb8d036542a1201c7bed6a80200678c69ba05462115c0021e30dd71a06ca85424010f187f4c439862030201879c36071205c4948b695d7d76c7b9075d1eb45eaca8d9ec8d4900237e50855d083c817af27a96a4a6da4925b351a90f8873639979074333de63a4a6da47e7764e20adcf187f4c439862030208a7becea9020c33f675489061efb3aa408239e31a6e815188457008c65c160f120e0823fb0af3ec418418411c830830830830830830830830d1e10150e5ad3c142f034652ba8fce8a4285103248d2bd2ad700a54406cca5756e983102024652b6e0d654ea161179012332ecd763d565b9c08257b7477f04310202323972491abd9a92480aebc711d0101b333aa722bcc920a6f1eab65f410463c95497de49057eb0c143c2d50d61c6d4497de32f208e652a92fbc9211b17d14db48237b7ab2ee4124cb82c1e24124ccb9268d16a4b67b9d6636e6406cccf89c88d06a4b42ebfe7601bfdf3672d1afe4900d964f89ea920f32d35d4348231e9e33916bda54e40019c29a8816e5895497de4905b190533579004327f4cd0ae10182a2118f4bb2c1eab2cca24034f256dc1ada9d4a820f201a7a5cdc6d6b728d2c5900496257a55ae2142c8021e4adb835b53a95041e4034f1f66b85236d62a0208c4120830824104720904120830808104820c20fbfb11af1020224124c9866b8d236540a0202267ecea912094621fb0406cc986eb8d016540b1203664c69ba15c22305440d9990e4bb1ebb2dce040c92331aeef50d8a6c200c92390ed2496cc46d78bc230120f427f463fd1eb393c489ca8d4924919bbc5bff00b87210742f6107b72f07fc1d9b7e00cc946cdb9b68d524051a8f048241a370d61aa81f88379bc3cfc499b9fabcdf11205df15fcb641fe33d2e004145900f3f0bb9900d3c634cd0ae3018aa2010f18d599dcbe80034f386c0e24010f18d3342b8c062a880d3f1fdb201bec7d1d2fa902da61148d495ce534636a971b883ad7f5a8f55746cf746a48411b0ea11ee2d8907913f5d8f526494db492492408da32d4083a229f931d2536d25bcb1d75a57490564403c8266d0ab2208a7becea90208fec7d1d2fa90463c619ae3485950ac0838208e418411c8308308308308308308308308308308251b96cbc3ec8fa42158523683682032652b6e0d654ea16117901bda9fa38772025233fcf9c1772d74aa92037efc15e6419ef0148e23d08249e9746f6deee57aa8209264feadcaf57510c3d2ecb07aacb3289067bc0d218874209264fe99a15c203054439f6c35e0041f9f7e1ab220cf7e1ab2208fefc35644034f4bb3c5cab6cca2419efc15e64010f2563637baac685404010f27388dbd3abd44010ea6c7d26002d90b69e1c8806fb7ab2ee4184184184184120830824107265c160f120e0824101020c20fb19fb5aa0482499785a3c0824904820904048cfd9d5224050cfdad5024068c9fe6ce8dc975d204044cb82c1e240cd237dc3c4480d234c6d2dda8d46eae7b6de441dea7d1eff47e4e4f122724dbddbb43682491f45ace6041ee7fd5bfd5ea6dfab7cc946a351a8d47fd60d9bbc30b418ae56105ea78fb35c291b6b150104832e0b078906f04c0fc4a9b7fab8df11205bf14bcba4168f0020a488201e70d81c48069e78da1c08069e31ab72b97d04061efb3aa408071e30cd71a42ca85604034f186eb8d036542a1200878c3fa621cc3101810043ce1b038900448a2b690636bc55a79075d1eb53eabc8d9ec8d496ed77e6fd71a45e41e40bd77bd4992536d2492492351bf787c3ee0e8a65e41d0ccf798e929b691f9dd93882ab20c20f8fb1f474bea41878c69ba05462115c0229061047208c79e3687020c3cf1b4381049208e4184184184184184184184184184184184048d25041e02035c575d3c42004044ca7211b2bc7abc40809ed4fd1c3b9048da9fa38772024652b1b5bdd56b46b020cf7caffd12092665cdc2d6373850d51061997370b58dce1435441faf7e0af320fc9997370b58dce1435441faf7e0af32089b5abcfb10043c9546ddd5ecd520c200875363e930016c85b4f0e44037dbd5977208e41208308308308249970583c483820c20e4cb82c1e241f720c209041fb326356e772fa084d20c209041f791bee1e224120cbc2d1e041248089970583c480b907d4c98d5995cbe8006cc98e6de8ccd555224068cfd9d52240710d214924f76a355bc3b757b9641de5fd1f9f47ace4f1227223776ed097a4367886eff00ed0e6c65aa20f763eac9ead936fd5be64a351a8d46a3feb06cdf306f17700b408361cf1f66b85236d62a020c9198d777a86c53610037eed56bf9441b8735ff0014e6e7fe003fda0200de27797a3aff00f640829bf63e8e97d48071e70d81c4807100e3cf1b43810463df6b54010023c6429d355669e4034f1905a96dd555d155024010f19052d7a62d9ab9c211e5bfd2e64010f386c0e24009288ef465e8c1fdd7a400a117af2510759deb7feadb36d3c8d4909cf4645e845a6ce2dc230f4460caa041e39fd76bd5611b3612492f704848c3cc05a68f07fc1450041d20ced9b66a4092ff009a703d25ae905479860415e1efb3aa408229048201e418411c830fc2ee6418411c830830830830830830830830830830830830830830830839347440557b35a7b080a7be0d0388f520fbed2f4a8f4b2ea419b4bd2a3d2cba9066d2f4a8f4b2ea41cfbe0d0388f520cf7c1a0711ea411fdf0681c47a90433c7854b53355d74d740104620c20c2091ec2bcfb1067b7ab2ee4184184184184120830830824106104820fa193c2b52b4d53757bc026106107d8cfdad5024128824193c345239d1deb6101132e0b078907dc824101d326401aba075c9eaae004c80949b787da65ae5ad5ac483bcdfa3d3d4d50fe22cb11f284aa4e4612a96a4bfe71cf62784020d51b1117d14907bc7f561f56f98fe01cca47fa08c46c865e9296a351dfba970fa1e9fa22030587a5e880ab4d20d83974b3d2482ff740216f65d1a7907dcc46fe44068cfd9d5224074cbc2d1e041b7d340c87d5b44387faccdbc46ba3b907ffd9);

-- --------------------------------------------------------

--
-- Table structure for table `tblpatients`
--

CREATE TABLE `tblpatients` (
  `PatientID` int(11) NOT NULL,
  `PatientCode` varchar(20) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) NOT NULL,
  `BirthDate` date DEFAULT NULL,
  `Gender` varchar(20) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `EmergencyContactName` varchar(100) DEFAULT NULL,
  `EmergencyContactNumber` varchar(20) DEFAULT NULL,
  `RegistrationDate` datetime NOT NULL DEFAULT current_timestamp(),
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblpatients`
--

INSERT INTO `tblpatients` (`PatientID`, `PatientCode`, `FirstName`, `MiddleName`, `LastName`, `BirthDate`, `Gender`, `ContactNumber`, `Email`, `Address`, `EmergencyContactName`, `EmergencyContactNumber`, `RegistrationDate`, `Status`) VALUES
(1, 'PAT-00001', 'John', 'Michael', 'Santos', '1999-02-14', 'Male', '09181230001', 'john.santos@gmail.com', 'Muntinlupa City', 'Maria Santos', '09181230002', '2026-10-01 08:10:00', 'Active'),
(2, 'PAT-00002', 'Angela', 'Marie', 'Cruz', '2001-06-21', 'Female', '09181230003', 'angela.cruz@gmail.com', 'Las Pinas City', 'Ramon Cruz', '09181230004', '2026-10-01 09:00:00', 'Active'),
(3, 'PAT-00003', 'Harvey', 'Ischei', 'Elloso', '2006-05-29', 'Male', '09181230005', 'harvey.elloso@gmail.com', 'San Pedro Laguna', 'Liza Elloso', '09181230006', '2026-10-02 10:15:00', 'Active'),
(4, 'PAT-00004', 'Sofia', 'Anne', 'Reyes', '1998-11-03', 'Female', '09181230007', 'sofia.reyes@gmail.com', 'Biñan Laguna', 'Carlos Reyes', '09181230008', '2026-10-02 13:20:00', 'Active'),
(5, 'PAT-00005', 'Miguel', 'Antonio', 'Garcia', '1995-08-17', 'Male', '09181230009', 'miguel.garcia@gmail.com', 'Cavite City', 'Elena Garcia', '09181230010', '2026-10-03 08:30:00', 'Active'),
(6, 'PAT-00006', 'Jasmine', 'Louise', 'Tan', '2003-01-12', 'Female', '09181230011', 'jasmine.tan@gmail.com', 'Parañaque City', 'Kevin Tan', '09181230012', '2026-10-03 11:45:00', 'Active'),
(7, 'PAT-00007', 'Daniel', 'Luis', 'Mendoza', '1997-09-25', 'Male', '09181230013', 'daniel.mendoza@gmail.com', 'Bacoor Cavite', 'Rosa Mendoza', '09181230014', '2026-10-05 09:10:00', 'Active'),
(8, 'PAT-00008', 'Camille', 'Grace', 'Navarro', '2000-12-08', 'Female', '09181230015', 'camille.navarro@gmail.com', 'Imus Cavite', 'Paolo Navarro', '09181230016', '2026-10-06 14:00:00', 'Active'),
(9, 'PAT-00009', 'Peter Joshua', 'Finis', 'Galang', '2002-04-17', 'Male', '09495924039', 'joshua@gmail.com', 'San Pedro Laguna', 'Mother', '09123456789', '2026-10-08 13:18:04', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblpaymentmethods`
--

CREATE TABLE `tblpaymentmethods` (
  `PaymentMethodID` int(11) NOT NULL,
  `MethodName` varchar(50) NOT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblpaymentmethods`
--

INSERT INTO `tblpaymentmethods` (`PaymentMethodID`, `MethodName`, `Status`) VALUES
(1, 'Cash', 'Active'),
(2, 'GCash', 'Active'),
(3, 'Bank Transfer', 'Active'),
(4, 'Debit/Credit Card', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayments`
--

CREATE TABLE `tblpayments` (
  `PaymentID` int(11) NOT NULL,
  `InvoiceID` int(11) NOT NULL,
  `PaymentReference` varchar(30) NOT NULL,
  `ReferenceNumber` varchar(13) DEFAULT NULL COMMENT 'GCash / bank transaction reference: 8-13 digits, online payments only',
  `PaymentDate` datetime NOT NULL DEFAULT current_timestamp(),
  `Amount` decimal(10,2) NOT NULL,
  `PaymentMethodID` int(11) NOT NULL,
  `ReceivedBy` int(11) NOT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblpayments`
--

INSERT INTO `tblpayments` (`PaymentID`, `InvoiceID`, `PaymentReference`, `ReferenceNumber`, `PaymentDate`, `Amount`, `PaymentMethodID`, `ReceivedBy`, `Notes`) VALUES
(1, 1, 'PAY-202610-001', NULL, '2026-10-01 09:16:00', 500.00, 1, 2, 'Paid in full.'),
(2, 2, 'PAY-202610-002', NULL, '2026-10-01 10:21:00', 800.00, 2, 2, 'Paid in full via GCash.'),
(3, 3, 'PAY-202610-003', NULL, '2026-10-02 13:31:00', 600.00, 1, 2, 'Partial payment.'),
(4, 4, 'PAY-202610-004', NULL, '2026-10-03 10:36:00', 3000.00, 2, 2, 'Initial root canal payment.'),
(5, 5, 'PAY-202610-005', NULL, '2026-10-03 15:11:00', 1500.00, 1, 2, 'Paid in full.'),
(6, 6, 'PAY-202610-006', NULL, '2026-10-04 10:41:00', 1000.00, 4, 2, 'Paid in full.'),
(7, 7, 'PAY-202610-007', NULL, '2026-10-05 10:11:00', 500.00, 1, 2, 'Paid in full.'),
(8, 8, 'PAY-202610-008', NULL, '2026-10-06 14:16:00', 800.00, 2, 2, 'Paid in full via GCash.'),
(9, 9, 'PAY-202610-009', NULL, '2026-10-07 10:46:00', 4000.00, 3, 2, 'Partial bank transfer.'),
(10, 10, 'PAY-202610-010', NULL, '2026-10-07 15:11:00', 2500.00, 2, 2, 'Paid in full via GCash.'),
(11, 9, 'PAY-00011', NULL, '2026-10-08 20:55:21', 12000.00, 2, 2, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblprocedurematerial`
--

CREATE TABLE `tblprocedurematerial` (
  `ProcedureMaterialID` int(11) NOT NULL,
  `ProcedureID` int(11) NOT NULL,
  `ProductCode` varchar(30) NOT NULL,
  `QuantityUsed` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblprocedurematerial`
--

INSERT INTO `tblprocedurematerial` (`ProcedureMaterialID`, `ProcedureID`, `ProductCode`, `QuantityUsed`) VALUES
(1, 1, 'PRD-014', 1),
(2, 1, 'PRD-015', 1),
(3, 1, 'PRD-016', 1),
(4, 2, 'PRD-014', 1),
(5, 2, 'PRD-015', 1),
(6, 2, 'PRD-016', 1),
(7, 2, 'PRD-017', 1),
(8, 2, 'PRD-003', 1),
(9, 2, 'PRD-001', 2),
(10, 2, 'PRD-002', 2),
(11, 2, 'PRD-028', 1),
(12, 2, 'PRD-012', 1),
(13, 3, 'PRD-014', 1),
(14, 3, 'PRD-015', 1),
(15, 3, 'PRD-016', 1),
(16, 3, 'PRD-017', 1),
(17, 3, 'PRD-001', 2),
(18, 3, 'PRD-003', 1),
(19, 3, 'PRD-025', 1),
(20, 3, 'PRD-026', 1),
(21, 3, 'PRD-024', 1),
(22, 3, 'PRD-006', 2),
(23, 4, 'PRD-014', 1),
(24, 4, 'PRD-015', 1),
(25, 4, 'PRD-016', 1),
(26, 4, 'PRD-017', 1),
(27, 4, 'PRD-004', 1),
(28, 4, 'PRD-005', 1),
(29, 4, 'PRD-011', 1),
(30, 4, 'PRD-001', 2),
(31, 4, 'PRD-002', 4),
(32, 5, 'PRD-014', 2),
(33, 5, 'PRD-015', 1),
(34, 5, 'PRD-016', 1),
(35, 5, 'PRD-017', 1),
(36, 5, 'PRD-011', 1),
(37, 5, 'PRD-005', 1),
(38, 5, 'PRD-030', 1),
(39, 5, 'PRD-031', 3),
(40, 5, 'PRD-032', 1),
(41, 5, 'PRD-002', 2),
(42, 5, 'PRD-001', 2),
(43, 6, 'PRD-014', 1),
(44, 6, 'PRD-015', 1),
(45, 6, 'PRD-016', 1),
(46, 6, 'PRD-017', 1),
(47, 6, 'PRD-033', 1),
(48, 6, 'PRD-034', 10),
(49, 6, 'PRD-001', 2),
(50, 7, 'PRD-014', 1),
(51, 7, 'PRD-015', 1),
(52, 7, 'PRD-016', 1),
(53, 7, 'PRD-017', 1),
(54, 7, 'PRD-012', 1),
(55, 7, 'PRD-001', 2),
(56, 8, 'PRD-014', 1),
(57, 8, 'PRD-015', 1),
(58, 8, 'PRD-016', 1),
(59, 8, 'PRD-017', 1),
(60, 8, 'PRD-001', 2),
(61, 8, 'PRD-025', 1),
(62, 8, 'PRD-027', 1),
(63, 8, 'PRD-006', 1),
(64, 9, 'PRD-014', 2),
(65, 9, 'PRD-015', 1),
(66, 9, 'PRD-016', 1),
(67, 9, 'PRD-017', 1),
(68, 9, 'PRD-003', 1),
(69, 9, 'PRD-002', 2),
(70, 9, 'PRD-001', 2),
(71, 10, 'PRD-014', 1),
(72, 10, 'PRD-015', 1),
(73, 10, 'PRD-016', 1),
(74, 10, 'PRD-017', 1),
(75, 10, 'PRD-001', 2),
(76, 10, 'PRD-029', 1),
(77, 10, 'PRD-006', 1),
(78, 11, 'PRD-014', 1),
(79, 11, 'PRD-015', 1),
(80, 11, 'PRD-016', 1),
(81, 11, 'PRD-017', 1),
(82, 11, 'PRD-001', 2),
(83, 11, 'PRD-003', 1),
(84, 11, 'PRD-025', 1),
(85, 11, 'PRD-026', 1),
(86, 11, 'PRD-024', 1),
(87, 11, 'PRD-006', 2),
(88, 12, 'PRD-014', 2),
(89, 12, 'PRD-015', 1),
(90, 12, 'PRD-016', 1),
(91, 12, 'PRD-017', 1),
(92, 12, 'PRD-018', 1),
(93, 12, 'PRD-004', 1),
(94, 12, 'PRD-005', 1),
(95, 12, 'PRD-011', 1),
(96, 12, 'PRD-002', 6),
(97, 12, 'PRD-010', 1),
(98, 13, 'PRD-014', 2),
(99, 13, 'PRD-015', 1),
(100, 13, 'PRD-016', 1),
(101, 13, 'PRD-017', 1),
(102, 13, 'PRD-018', 1),
(103, 13, 'PRD-004', 1),
(104, 13, 'PRD-005', 1),
(105, 13, 'PRD-011', 2),
(106, 13, 'PRD-002', 6),
(107, 13, 'PRD-010', 2),
(108, 14, 'PRD-014', 1),
(109, 14, 'PRD-015', 1),
(110, 14, 'PRD-016', 1),
(111, 14, 'PRD-017', 1),
(112, 14, 'PRD-008', 1),
(113, 15, 'PRD-014', 1),
(114, 15, 'PRD-015', 1),
(115, 15, 'PRD-016', 1),
(116, 15, 'PRD-017', 1),
(117, 15, 'PRD-009', 1),
(118, 16, 'PRD-014', 1),
(119, 16, 'PRD-015', 1),
(120, 16, 'PRD-016', 1),
(121, 16, 'PRD-017', 1),
(122, 16, 'PRD-001', 2),
(123, 16, 'PRD-035', 1),
(124, 16, 'PRD-037', 1),
(125, 16, 'PRD-038', 1),
(126, 17, 'PRD-014', 1),
(127, 17, 'PRD-015', 1),
(128, 17, 'PRD-016', 1),
(129, 17, 'PRD-017', 1),
(130, 17, 'PRD-001', 2),
(131, 17, 'PRD-035', 1),
(132, 17, 'PRD-037', 1),
(133, 17, 'PRD-038', 1),
(134, 18, 'PRD-014', 1),
(135, 18, 'PRD-015', 1),
(136, 18, 'PRD-016', 1),
(137, 18, 'PRD-017', 1),
(138, 18, 'PRD-035', 2),
(139, 18, 'PRD-036', 1),
(140, 19, 'PRD-014', 1),
(141, 19, 'PRD-015', 1),
(142, 19, 'PRD-016', 1),
(143, 19, 'PRD-017', 1),
(144, 19, 'PRD-035', 2),
(145, 19, 'PRD-036', 2),
(146, 20, 'PRD-014', 1),
(147, 20, 'PRD-015', 1),
(148, 20, 'PRD-016', 1),
(149, 20, 'PRD-017', 1),
(150, 20, 'PRD-002', 1),
(151, 21, 'PRD-014', 1),
(152, 21, 'PRD-015', 1),
(153, 21, 'PRD-016', 1),
(154, 21, 'PRD-017', 1),
(155, 21, 'PRD-041', 1),
(156, 21, 'PRD-039', 1),
(157, 21, 'PRD-040', 1),
(158, 22, 'PRD-014', 1),
(159, 22, 'PRD-015', 1),
(160, 22, 'PRD-016', 1),
(161, 22, 'PRD-017', 1),
(162, 22, 'PRD-001', 2),
(163, 22, 'PRD-025', 1),
(164, 22, 'PRD-026', 1),
(165, 22, 'PRD-024', 2),
(166, 22, 'PRD-006', 2),
(167, 23, 'PRD-014', 1),
(168, 23, 'PRD-015', 1),
(169, 23, 'PRD-016', 1),
(170, 23, 'PRD-017', 1),
(171, 23, 'PRD-028', 1),
(172, 23, 'PRD-007', 1),
(173, 23, 'PRD-001', 2),
(174, 24, 'PRD-014', 2),
(175, 24, 'PRD-015', 1),
(176, 24, 'PRD-016', 1),
(177, 24, 'PRD-017', 1),
(178, 24, 'PRD-002', 2),
(179, 24, 'PRD-001', 2),
(180, 24, 'PRD-013', 1),
(181, 25, 'PRD-014', 1),
(182, 25, 'PRD-015', 1),
(183, 25, 'PRD-016', 1),
(184, 25, 'PRD-017', 1),
(185, 25, 'PRD-025', 1),
(186, 25, 'PRD-026', 1),
(187, 25, 'PRD-024', 1),
(188, 26, 'PRD-014', 2),
(189, 26, 'PRD-015', 1),
(190, 26, 'PRD-016', 1),
(191, 26, 'PRD-017', 1),
(192, 26, 'PRD-018', 1),
(193, 26, 'PRD-004', 1),
(194, 26, 'PRD-005', 1),
(195, 26, 'PRD-011', 2),
(196, 26, 'PRD-002', 6),
(197, 26, 'PRD-010', 2),
(198, 27, 'PRD-014', 2),
(199, 27, 'PRD-015', 1),
(200, 27, 'PRD-016', 1),
(201, 27, 'PRD-017', 1),
(202, 27, 'PRD-011', 1),
(203, 27, 'PRD-005', 1),
(204, 27, 'PRD-030', 2),
(205, 27, 'PRD-031', 3),
(206, 27, 'PRD-032', 1),
(207, 27, 'PRD-002', 2),
(208, 28, 'PRD-014', 1),
(209, 28, 'PRD-015', 1),
(210, 28, 'PRD-016', 1),
(211, 28, 'PRD-017', 1),
(212, 28, 'PRD-011', 1),
(213, 28, 'PRD-005', 1),
(214, 28, 'PRD-042', 1),
(215, 28, 'PRD-029', 1),
(216, 28, 'PRD-001', 2),
(217, 29, 'PRD-014', 1),
(218, 29, 'PRD-015', 1),
(219, 29, 'PRD-016', 1),
(220, 29, 'PRD-017', 1),
(221, 29, 'PRD-043', 1),
(222, 29, 'PRD-026', 1),
(223, 29, 'PRD-024', 1),
(224, 29, 'PRD-038', 1),
(225, 30, 'PRD-014', 1),
(226, 30, 'PRD-015', 1),
(227, 30, 'PRD-016', 1),
(228, 30, 'PRD-017', 1),
(229, 30, 'PRD-035', 1),
(230, 30, 'PRD-036', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblprocedures`
--

CREATE TABLE `tblprocedures` (
  `ProcedureID` int(11) NOT NULL,
  `ProcedureCode` varchar(20) NOT NULL,
  `ProcedureName` varchar(100) NOT NULL,
  `Description` text DEFAULT NULL,
  `StandardPrice` decimal(10,2) NOT NULL,
  `EstimatedDuration` int(11) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblprocedures`
--

INSERT INTO `tblprocedures` (`ProcedureID`, `ProcedureCode`, `ProcedureName`, `Description`, `StandardPrice`, `EstimatedDuration`, `Status`) VALUES
(1, 'PR-001', 'Dental Consultation', 'General dental consultation', 500.00, 30, 'Active'),
(2, 'PR-002', 'Dental Cleaning', 'Routine dental cleaning', 800.00, 60, 'Active'),
(3, 'PR-003', 'Dental Filling', 'Composite dental filling', 1200.00, 60, 'Active'),
(4, 'PR-004', 'Tooth Extraction', 'Basic tooth extraction', 1500.00, 60, 'Active'),
(5, 'PR-005', 'Root Canal', 'Root canal treatment', 8000.00, 90, 'Active'),
(6, 'PR-006', 'Orthodontic Adjustment', 'Routine orthodontic adjustment', 1000.00, 30, 'Active'),
(7, 'PR-007', 'Dental X-Ray', 'Intraoral dental X-ray examination', 500.00, 15, 'Active'),
(8, 'PR-008', 'Panoramic X-Ray', 'Panoramic radiographic examination of the teeth and jaw', 1000.00, 30, 'Active'),
(9, 'PR-009', 'Dental Crown', 'Placement of a dental crown', 10000.00, 90, 'Active'),
(10, 'PR-010', 'Gum Treatment', 'Treatment for gum inflammation and periodontal problems', 2500.00, 60, 'Active'),
(11, 'PR-011', 'Tooth Restoration', 'Restoration of damaged or decayed tooth', 1500.00, 60, 'Active'),
(12, 'PR-012', 'Surgical Tooth Extraction', 'Surgical removal of a tooth', 4000.00, 90, 'Active'),
(13, 'PR-013', 'Wisdom Tooth Extraction', 'Extraction of an impacted or problematic wisdom tooth', 6000.00, 120, 'Active'),
(14, 'PR-014', 'Dental X-Ray', 'Intraoral dental X-ray examination', 500.00, 15, 'Active'),
(15, 'PR-015', 'Panoramic X-Ray', 'Panoramic radiographic examination of the teeth and jaw', 1000.00, 30, 'Active'),
(16, 'PR-016', 'Dental Crown', 'Placement of a dental crown', 10000.00, 90, 'Active'),
(17, 'PR-017', 'Dental Bridge', 'Replacement of missing teeth using a dental bridge', 20000.00, 120, 'Active'),
(18, 'PR-018', 'Partial Denture', 'Fabrication and fitting of a partial denture', 10000.00, 120, 'Active'),
(19, 'PR-019', 'Complete Denture', 'Fabrication and fitting of a complete denture', 20000.00, 180, 'Active'),
(20, 'PR-020', 'Denture Adjustment', 'Adjustment and fitting of an existing denture', 800.00, 30, 'Active'),
(21, 'PR-021', 'Teeth Whitening', 'Professional teeth whitening procedure', 8000.00, 90, 'Active'),
(22, 'PR-022', 'Composite Veneer', 'Application of composite veneer to improve tooth appearance', 5000.00, 90, 'Active'),
(23, 'PR-023', 'Tooth Polishing', 'Polishing of teeth to remove surface stains', 500.00, 30, 'Active'),
(24, 'PR-024', 'Gum Treatment', 'Treatment for gum inflammation and periodontal problems', 2500.00, 60, 'Active'),
(25, 'PR-025', 'Dental Splint', 'Placement of a dental splint to stabilize teeth', 5000.00, 90, 'Active'),
(26, 'PR-026', 'Odontectomy', 'Surgical removal of an impacted tooth', 8000.00, 120, 'Active'),
(27, 'PR-027', 'Root Canal Re-treatment', 'Repeat root canal treatment for a previously treated tooth', 10000.00, 120, 'Active'),
(28, 'PR-028', 'Pulpotomy', 'Removal of infected pulp from the crown portion of a tooth', 3000.00, 60, 'Active'),
(29, 'PR-029', 'Post and Core', 'Placement of a post and core for tooth restoration', 5000.00, 90, 'Active'),
(30, 'PR-030', 'Retainer', 'Fabrication and fitting of an orthodontic retainer', 5000.00, 60, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblproductcategories`
--

CREATE TABLE `tblproductcategories` (
  `CategoryID` int(11) NOT NULL,
  `CategoryName` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblproductcategories`
--

INSERT INTO `tblproductcategories` (`CategoryID`, `CategoryName`, `Description`, `Status`) VALUES
(1, 'Consumables', 'Disposable dental supplies', 'Active'),
(2, 'Medications', 'Dental medicines and related items', 'Active'),
(3, 'PPE', 'Personal protective equipment', 'Active'),
(4, 'Cleaning Supplies', 'Clinic cleaning and sanitation supplies', 'Active'),
(5, 'Dental Materials', 'Materials used during dental procedures', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblproducts`
--

CREATE TABLE `tblproducts` (
  `ProductID` int(11) NOT NULL,
  `ProductCode` varchar(30) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `CategoryID` int(11) NOT NULL,
  `Unit` varchar(30) NOT NULL,
  `CurrentStock` int(11) NOT NULL DEFAULT 0,
  `ReorderLevel` int(11) NOT NULL DEFAULT 0,
  `UnitCost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblproducts`
--

INSERT INTO `tblproducts` (`ProductID`, `ProductCode`, `ProductName`, `CategoryID`, `Unit`, `CurrentStock`, `ReorderLevel`, `UnitCost`, `Status`) VALUES
(1, 'PRD-001', 'Cotton Rolls', 1, 'Pack', 100, 10, 80.00, 'Active'),
(2, 'PRD-002', 'Dental Gauze', 1, 'Pack', 50, 10, 80.00, 'Active'),
(3, 'PRD-003', 'Saliva Ejector', 1, 'Piece', 100, 20, 5.00, 'Active'),
(4, 'PRD-004', 'Disposable Syringe', 1, 'Piece', 100, 20, 8.00, 'Active'),
(5, 'PRD-005', 'Syringe Needle', 1, 'Piece', 100, 20, 7.00, 'Active'),
(6, 'PRD-006', 'Microbrush Applicator', 1, 'Piece', 200, 30, 6.00, 'Active'),
(7, 'PRD-007', 'Polishing Cup', 1, 'Piece', 100, 20, 12.00, 'Active'),
(8, 'PRD-008', 'X-Ray Sensor Sleeve', 1, 'Piece', 100, 20, 15.00, 'Active'),
(9, 'PRD-009', 'X-Ray Bite Block Cover', 1, 'Piece', 100, 20, 10.00, 'Active'),
(10, 'PRD-010', 'Suture Thread', 1, 'Piece', 100, 20, 35.00, 'Active'),
(11, 'PRD-011', 'Local Anesthetic', 2, 'Cartridge', 100, 20, 45.00, 'Active'),
(12, 'PRD-012', 'Fluoride', 2, 'Tube', 30, 5, 120.00, 'Active'),
(13, 'PRD-013', 'Chlorhexidine Solution', 2, 'Bottle', 20, 5, 180.00, 'Active'),
(14, 'PRD-014', 'Disposable Gloves', 3, 'Pair', 200, 40, 12.00, 'Active'),
(15, 'PRD-015', 'Surgical Mask', 3, 'Piece', 200, 40, 5.00, 'Active'),
(16, 'PRD-016', 'Patient Dental Bib', 3, 'Piece', 200, 40, 4.00, 'Active'),
(17, 'PRD-017', 'Patient Protective Eyewear', 3, 'Piece', 20, 5, 80.00, 'Active'),
(18, 'PRD-018', 'Patient Disposable Gown', 3, 'Piece', 50, 10, 35.00, 'Active'),
(19, 'PRD-019', 'Surface Disinfectant', 4, 'Bottle', 20, 5, 120.00, 'Active'),
(20, 'PRD-020', 'Alcohol', 4, 'Bottle', 20, 5, 90.00, 'Active'),
(21, 'PRD-021', 'Hand Sanitizer', 4, 'Bottle', 20, 5, 100.00, 'Active'),
(22, 'PRD-022', 'Sterilization Pouches', 4, 'Pack', 30, 5, 150.00, 'Active'),
(23, 'PRD-023', 'Instrument Cleaning Solution', 4, 'Bottle', 20, 5, 200.00, 'Active'),
(24, 'PRD-024', 'Composite Resin', 5, 'Syringe', 30, 5, 350.00, 'Active'),
(25, 'PRD-025', 'Etching Gel', 5, 'Syringe', 30, 5, 300.00, 'Active'),
(26, 'PRD-026', 'Bonding Agent', 5, 'Bottle', 20, 5, 450.00, 'Active'),
(27, 'PRD-027', 'Dental Sealant', 5, 'Syringe', 20, 5, 400.00, 'Active'),
(28, 'PRD-028', 'Prophy Paste', 5, 'Tube', 30, 5, 180.00, 'Active'),
(29, 'PRD-029', 'Temporary Filling Material', 5, 'Kit', 20, 5, 500.00, 'Active'),
(30, 'PRD-030', 'Dental Files', 5, 'Piece', 50, 10, 90.00, 'Active'),
(31, 'PRD-031', 'Gutta Percha', 5, 'Piece', 100, 20, 25.00, 'Active'),
(32, 'PRD-032', 'Root Canal Sealer', 5, 'Kit', 10, 3, 650.00, 'Active'),
(33, 'PRD-033', 'Orthodontic Wire', 5, 'Roll', 20, 5, 700.00, 'Active'),
(34, 'PRD-034', 'Elastic Ligature', 5, 'Piece', 500, 100, 5.00, 'Active'),
(35, 'PRD-035', 'Dental Impression Material', 5, 'Pack', 30, 5, 250.00, 'Active'),
(36, 'PRD-036', 'Dental Alginate', 5, 'Pack', 30, 5, 220.00, 'Active'),
(37, 'PRD-037', 'Temporary Crown Material', 5, 'Kit', 10, 3, 900.00, 'Active'),
(38, 'PRD-038', 'Dental Cement', 5, 'Kit', 15, 3, 700.00, 'Active'),
(39, 'PRD-039', 'Whitening Gel', 5, 'Kit', 10, 3, 1200.00, 'Active'),
(40, 'PRD-040', 'Gingival Barrier', 5, 'Kit', 10, 3, 500.00, 'Active'),
(41, 'PRD-041', 'Cheek Retractor', 5, 'Piece', 20, 5, 150.00, 'Active'),
(42, 'PRD-042', 'Calcium Hydroxide', 5, 'Syringe', 20, 5, 300.00, 'Active'),
(43, 'PRD-043', 'Dental Post', 5, 'Piece', 30, 5, 450.00, 'Active'),
(44, 'PRD-044', 'Cheek Retractor (Sterilizable)', 5, 'Piece', 20, 5, 180.00, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblproductsuppliers`
--

CREATE TABLE `tblproductsuppliers` (
  `ProductSupplierID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `SupplierProductCode` varchar(50) DEFAULT NULL,
  `LastPurchasePrice` decimal(10,2) DEFAULT NULL,
  `IsPreferred` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblproductsuppliers`
--

INSERT INTO `tblproductsuppliers` (`ProductSupplierID`, `ProductID`, `SupplierID`, `SupplierProductCode`, `LastPurchasePrice`, `IsPreferred`) VALUES
(1, 1, 1, 'SUP1-PRD-001', 73.60, 1),
(2, 2, 1, 'SUP1-PRD-002', 73.60, 1),
(3, 3, 1, 'SUP1-PRD-003', 4.60, 1),
(4, 4, 1, 'SUP1-PRD-004', 7.36, 1),
(5, 5, 1, 'SUP1-PRD-005', 6.44, 1),
(6, 6, 1, 'SUP1-PRD-006', 5.52, 1),
(7, 7, 1, 'SUP1-PRD-007', 11.04, 1),
(8, 8, 1, 'SUP1-PRD-008', 13.80, 1),
(9, 9, 1, 'SUP1-PRD-009', 9.20, 1),
(10, 10, 1, 'SUP1-PRD-010', 32.20, 1),
(11, 11, 1, 'SUP1-PRD-011', 41.40, 1),
(12, 12, 1, 'SUP1-PRD-012', 110.40, 1),
(13, 13, 1, 'SUP1-PRD-013', 165.60, 1),
(14, 14, 2, 'SUP2-PRD-014', 11.04, 1),
(15, 15, 2, 'SUP2-PRD-015', 4.60, 1),
(16, 16, 2, 'SUP2-PRD-016', 3.68, 1),
(17, 17, 2, 'SUP2-PRD-017', 73.60, 1),
(18, 18, 2, 'SUP2-PRD-018', 32.20, 1),
(19, 19, 2, 'SUP2-PRD-019', 110.40, 1),
(20, 20, 2, 'SUP2-PRD-020', 82.80, 1),
(21, 21, 2, 'SUP2-PRD-021', 92.00, 1),
(22, 22, 2, 'SUP2-PRD-022', 138.00, 1),
(23, 23, 2, 'SUP2-PRD-023', 184.00, 1),
(24, 24, 3, 'SUP3-PRD-024', 322.00, 1),
(25, 25, 3, 'SUP3-PRD-025', 276.00, 1),
(26, 26, 3, 'SUP3-PRD-026', 414.00, 1),
(27, 27, 3, 'SUP3-PRD-027', 368.00, 1),
(28, 28, 3, 'SUP3-PRD-028', 165.60, 1),
(29, 29, 3, 'SUP3-PRD-029', 460.00, 1),
(30, 30, 3, 'SUP3-PRD-030', 82.80, 1),
(31, 31, 3, 'SUP3-PRD-031', 23.00, 1),
(32, 32, 3, 'SUP3-PRD-032', 598.00, 1),
(33, 33, 3, 'SUP3-PRD-033', 644.00, 1),
(34, 34, 3, 'SUP3-PRD-034', 4.60, 1),
(35, 35, 3, 'SUP3-PRD-035', 230.00, 1),
(36, 36, 3, 'SUP3-PRD-036', 202.40, 1),
(37, 37, 3, 'SUP3-PRD-037', 828.00, 1),
(38, 38, 3, 'SUP3-PRD-038', 644.00, 1),
(39, 39, 3, 'SUP3-PRD-039', 1104.00, 1),
(40, 40, 3, 'SUP3-PRD-040', 460.00, 1),
(41, 41, 3, 'SUP3-PRD-041', 138.00, 1),
(42, 42, 3, 'SUP3-PRD-042', 276.00, 1),
(43, 43, 3, 'SUP3-PRD-043', 414.00, 1),
(44, 44, 3, 'SUP3-PRD-044', 165.60, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblroles`
--

CREATE TABLE `tblroles` (
  `RoleID` int(11) NOT NULL,
  `RoleName` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblroles`
--

INSERT INTO `tblroles` (`RoleID`, `RoleName`, `Description`) VALUES
(1, 'Owner', 'Full access to every panel'),
(2, 'Frontdesk', 'Dashboard (no monthly revenue), patients, appointments, billing and payments, clinical records, procedures and prices, inventory'),
(3, 'Dentist', 'Dashboard (no monthly revenue), patients and appointments'),
(4, 'IT', 'Dashboard, accounts and audit logs only');

-- --------------------------------------------------------

--
-- Table structure for table `tblstaff`
--

CREATE TABLE `tblstaff` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Position` varchar(50) NOT NULL,
  `LicenseNumber` varchar(50) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstaff`
--

INSERT INTO `tblstaff` (`StaffID`, `StaffCode`, `FirstName`, `LastName`, `ContactNumber`, `Email`, `Position`, `LicenseNumber`, `Status`) VALUES
(1, 'OWN-001', 'Clinic', 'Owner', '09170000001', 'clinic.owner@dentalscape.com', 'Owner', NULL, 'Active'),
(2, 'FD-001', 'Front', 'Desk', '09170000002', 'frontdesk@dentalscape.com', 'Frontdesk', NULL, 'Active'),
(3, 'DR-001', 'Richelle', 'Paz', '09170000003', 'richelle.paz@dentalscape.com', 'Dentist', 'PRC-0123456', 'Active'),
(4, 'DR-002', 'Maria', 'Santos', '09170000004', 'maria.santos@dentalscape.com', 'Dentist', 'PRC-0234567', 'Active'),
(5, 'DR-003', 'Juan', 'Dela Cruz', '09170000005', 'juan.delacruz@dentalscape.com', 'Dentist', 'PRC-0345678', 'Active'),
(6, 'DR-004', 'Angela', 'Reyes', '09170000006', 'angela.reyes@dentalscape.com', 'Dentist', 'PRC-0456789', 'Active'),
(7, 'IT-001', 'Clinic', 'IT', '09170000007', 'it@dentalscape.com', 'IT', NULL, 'Active'),
(8, 'DA-001', 'Juan', 'Dela Cruz', '09783675263', 'juan@gmail.com', 'Dental Assistant', NULL, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblsuppliers`
--

CREATE TABLE `tblsuppliers` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(100) NOT NULL,
  `ContactPerson` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(30) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblsuppliers`
--

INSERT INTO `tblsuppliers` (`SupplierID`, `SupplierName`, `ContactPerson`, `ContactNumber`, `Email`, `Address`, `Status`) VALUES
(1, 'DentalMed Supply Co.', 'Ramon Villanueva', '09190000001', 'sales@dentalmed.ph', 'Makati City', 'Active'),
(2, 'OralCare Distributors', 'Leah Mendoza', '09190000002', 'orders@oralcare.ph', 'Pasig City', 'Active'),
(3, 'Prime Dental Materials', 'Carlo Bautista', '09190000003', 'sales@primedental.ph', 'Quezon City', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tbltreatmentplanitems`
--

CREATE TABLE `tbltreatmentplanitems` (
  `PlanItemID` int(11) NOT NULL,
  `TreatmentPlanID` int(11) NOT NULL,
  `ProcedureID` int(11) NOT NULL,
  `ToothNumber` varchar(10) DEFAULT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 1,
  `EstimatedPrice` decimal(10,2) NOT NULL,
  `Status` varchar(30) NOT NULL DEFAULT 'Planned',
  `ScheduledDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbltreatmentplanitems`
--

INSERT INTO `tbltreatmentplanitems` (`PlanItemID`, `TreatmentPlanID`, `ProcedureID`, `ToothNumber`, `Quantity`, `EstimatedPrice`, `Status`, `ScheduledDate`) VALUES
(1, 1, 5, '14', 1, 8000.00, 'In Progress', '2026-10-07'),
(2, 1, 9, '14', 1, 10000.00, 'Planned', '2026-10-08'),
(3, 2, 5, '16', 1, 8000.00, 'In Progress', '2026-10-03'),
(4, 2, 9, '16', 1, 10000.00, 'Planned', '2026-10-07'),
(5, 2, 7, '16', 1, 500.00, 'Planned', '2026-10-07'),
(6, 3, 4, '46', 1, 1500.00, 'Completed', '2026-10-03'),
(7, 4, 6, NULL, 1, 1000.00, 'Completed', '2026-10-04'),
(8, 4, 6, NULL, 1, 1000.00, 'Planned', '2026-10-08'),
(9, 4, 6, NULL, 1, 1000.00, 'Planned', '2026-10-08'),
(10, 5, 2, NULL, 1, 800.00, 'Completed', '2026-10-06'),
(11, 5, 10, NULL, 1, 2500.00, 'Planned', '2026-10-08');

-- --------------------------------------------------------

--
-- Table structure for table `tbltreatmentplans`
--

CREATE TABLE `tbltreatmentplans` (
  `TreatmentPlanID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `DentistID` int(11) NOT NULL,
  `PlanDate` date NOT NULL DEFAULT curdate(),
  `Diagnosis` text DEFAULT NULL,
  `TotalEstimatedCost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Status` varchar(30) NOT NULL DEFAULT 'Proposed',
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbltreatmentplans`
--

INSERT INTO `tbltreatmentplans` (`TreatmentPlanID`, `PatientID`, `DentistID`, `PlanDate`, `Diagnosis`, `TotalEstimatedCost`, `Status`, `Notes`) VALUES
(1, 1, 3, '2026-10-01', 'Caries on tooth 14', 18000.00, 'Active', 'Root canal and final crown planned.'),
(2, 4, 4, '2026-10-03', 'Pulpitis on tooth 16', 18500.00, 'Active', 'Root canal, crown and radiographic follow-up planned.'),
(3, 5, 5, '2026-10-03', 'Non-restorable tooth 46', 1500.00, 'Completed', 'Extraction completed.'),
(4, 6, 6, '2026-10-04', 'Orthodontic maintenance', 3000.00, 'Active', 'Continue monthly adjustments.'),
(5, 8, 4, '2026-10-06', 'Gingival inflammation', 3300.00, 'Active', 'Cleaning and gum treatment recommended.');

-- --------------------------------------------------------

--
-- Table structure for table `tbltreatmentrecords`
--

CREATE TABLE `tbltreatmentrecords` (
  `TreatmentRecordID` int(11) NOT NULL,
  `DentalRecordID` int(11) NOT NULL,
  `ProcedureID` int(11) NOT NULL,
  `DentistID` int(11) NOT NULL,
  `ToothNumber` varchar(10) DEFAULT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 1,
  `UnitPrice` decimal(10,2) NOT NULL,
  `Discount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `TotalAmount` decimal(12,2) GENERATED ALWAYS AS (`Quantity` * `UnitPrice` - `Discount`) STORED,
  `TreatmentStatus` varchar(30) NOT NULL DEFAULT 'Completed',
  `Notes` text DEFAULT NULL,
  `MaterialsConsumed` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbltreatmentrecords`
--

INSERT INTO `tbltreatmentrecords` (`TreatmentRecordID`, `DentalRecordID`, `ProcedureID`, `DentistID`, `ToothNumber`, `Quantity`, `UnitPrice`, `Discount`, `TreatmentStatus`, `Notes`, `MaterialsConsumed`) VALUES
(1, 1, 1, 3, NULL, 1, 500.00, 0.00, 'Completed', 'Consultation completed.', 0),
(2, 2, 2, 4, NULL, 1, 800.00, 0.00, 'Completed', 'Cleaning completed.', 1),
(3, 3, 3, 3, '36', 1, 1200.00, 0.00, 'Completed', 'Composite filling completed.', 1),
(4, 4, 5, 4, '16', 1, 8000.00, 0.00, 'In Progress', 'Root canal initiated.', 1),
(5, 5, 4, 5, '46', 1, 1500.00, 0.00, 'Completed', 'Extraction completed.', 1),
(6, 6, 6, 6, NULL, 1, 1000.00, 0.00, 'Completed', 'Orthodontic adjustment completed.', 1),
(7, 7, 1, 3, NULL, 1, 500.00, 0.00, 'Completed', 'Routine check-up completed.', 0),
(8, 8, 2, 4, NULL, 1, 800.00, 0.00, 'Completed', 'Cleaning and polishing completed.', 1),
(9, 9, 5, 3, '14', 1, 8000.00, 0.00, 'In Progress', 'Root canal treatment in progress.', 1),
(10, 10, 10, 4, NULL, 1, 2500.00, 0.00, 'Completed', 'Gum treatment completed.', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `RoleID` int(11) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` datetime NOT NULL DEFAULT current_timestamp(),
  `LastLogin` datetime DEFAULT NULL,
  `FailedAttempts` int(11) NOT NULL DEFAULT 0,
  `LockedUntil` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `StaffID`, `Username`, `PasswordHash`, `RoleID`, `IsActive`, `CreatedAt`, `LastLogin`, `FailedAttempts`, `LockedUntil`) VALUES
(1, 1, 'owner', 'PBKDF2$100000$yRAZlK76qoQmHbg3ShpPew==$STM3gpKF16qCzN67Y6Hs0DsGRJUxfJAgbqUYbT5wmbg=', 1, 1, '2026-10-07 13:51:15', '2026-10-12 01:03:50', 0, NULL),
(2, 2, 'frontdesk', 'PBKDF2$100000$pnakPZJo6KJWJjAkNPsf4w==$lI8rx1akLPEsJJe1IZ1Mr3VKrMFlTBzCotDwwJiB468=', 2, 1, '2026-10-07 13:51:15', '2026-10-11 21:45:01', 0, NULL),
(3, 3, 'dentist.richelle', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-01 07:40:00', '2026-10-11 14:03:50', 3, '2026-10-11 14:27:06'),
(4, 4, 'dentist.maria', 'PBKDF2$100000$GYhVQMkNFHCem9xJaSMHSA==$m6DpcSxlYgLNSeFP83SPSEpsqp1jwVAi7DT4wc4FYvE=', 3, 1, '2026-10-01 07:45:00', '2026-10-11 18:35:08', 2, NULL),
(5, 5, 'juan.delacruz', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-11 14:02:06', NULL, 0, NULL),
(6, 6, 'angela.reyes', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-11 14:02:06', NULL, 0, NULL),
(7, 7, 'it', 'PBKDF2$100000$ynLq3brMoMTCdKT7fhVdEw==$HQFQ7WDqTcmU+CoYZsxz0ACdqibWfGw5OhL68jE1Dbc=', 4, 1, '2026-10-11 14:02:06', '2026-10-11 21:44:05', 0, NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwappointmentdetails`
-- (See below for the actual view)
--
CREATE TABLE `vwappointmentdetails` (
`AppointmentID` int(11)
,`AppointmentCode` varchar(20)
,`AppointmentDate` date
,`StartTime` time
,`EndTime` time
,`Status` varchar(30)
,`PatientCode` varchar(20)
,`PatientName` varchar(101)
,`DentistName` varchar(101)
,`AppointmentType` varchar(100)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwlowstockproducts`
-- (See below for the actual view)
--
CREATE TABLE `vwlowstockproducts` (
`ProductID` int(11)
,`ProductCode` varchar(30)
,`ProductName` varchar(100)
,`CategoryName` varchar(100)
,`CurrentStock` int(11)
,`ReorderLevel` int(11)
,`Unit` varchar(30)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwpatientbalances`
-- (See below for the actual view)
--
CREATE TABLE `vwpatientbalances` (
`PatientID` int(11)
,`PatientCode` varchar(20)
,`FirstName` varchar(50)
,`LastName` varchar(50)
,`TotalBilled` decimal(32,2)
,`TotalPaid` decimal(32,2)
,`OutstandingBalance` decimal(32,2)
);

-- --------------------------------------------------------

--
-- Structure for view `vwappointmentdetails`
--
DROP TABLE IF EXISTS `vwappointmentdetails`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwappointmentdetails`  AS SELECT `a`.`AppointmentID` AS `AppointmentID`, `a`.`AppointmentCode` AS `AppointmentCode`, `a`.`AppointmentDate` AS `AppointmentDate`, `a`.`StartTime` AS `StartTime`, `a`.`EndTime` AS `EndTime`, `a`.`Status` AS `Status`, `p`.`PatientCode` AS `PatientCode`, concat(`p`.`FirstName`,' ',`p`.`LastName`) AS `PatientName`, concat(`s`.`FirstName`,' ',`s`.`LastName`) AS `DentistName`, `apt`.`TypeName` AS `AppointmentType` FROM (((`tblappointments` `a` join `tblpatients` `p` on(`a`.`PatientID` = `p`.`PatientID`)) join `tblstaff` `s` on(`a`.`DentistID` = `s`.`StaffID`)) join `tblappointmenttypes` `apt` on(`a`.`AppointmentTypeID` = `apt`.`AppointmentTypeID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vwlowstockproducts`
--
DROP TABLE IF EXISTS `vwlowstockproducts`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwlowstockproducts`  AS SELECT `p`.`ProductID` AS `ProductID`, `p`.`ProductCode` AS `ProductCode`, `p`.`ProductName` AS `ProductName`, `c`.`CategoryName` AS `CategoryName`, `p`.`CurrentStock` AS `CurrentStock`, `p`.`ReorderLevel` AS `ReorderLevel`, `p`.`Unit` AS `Unit` FROM (`tblproducts` `p` join `tblproductcategories` `c` on(`p`.`CategoryID` = `c`.`CategoryID`)) WHERE `p`.`Status` = 'Active' AND `p`.`CurrentStock` <= `p`.`ReorderLevel` ;

-- --------------------------------------------------------

--
-- Structure for view `vwpatientbalances`
--
DROP TABLE IF EXISTS `vwpatientbalances`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwpatientbalances`  AS SELECT `p`.`PatientID` AS `PatientID`, `p`.`PatientCode` AS `PatientCode`, `p`.`FirstName` AS `FirstName`, `p`.`LastName` AS `LastName`, ifnull(sum(`i`.`TotalAmount`),0) AS `TotalBilled`, ifnull(sum(`i`.`AmountPaid`),0) AS `TotalPaid`, ifnull(sum(`i`.`Balance`),0) AS `OutstandingBalance` FROM (`tblpatients` `p` left join `tblinvoices` `i` on(`p`.`PatientID` = `i`.`PatientID` and `i`.`Status` <> 'Void')) GROUP BY `p`.`PatientID`, `p`.`PatientCode`, `p`.`FirstName`, `p`.`LastName` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblappointments`
--
ALTER TABLE `tblappointments`
  ADD PRIMARY KEY (`AppointmentID`),
  ADD UNIQUE KEY `UQ_tblAppointments_AppointmentCode` (`AppointmentCode`),
  ADD KEY `FK_tblAppointments_Type` (`AppointmentTypeID`),
  ADD KEY `FK_tblAppointments_CreatedBy` (`CreatedBy`),
  ADD KEY `IX_tblAppointments_PatientID` (`PatientID`),
  ADD KEY `IX_tblAppointments_DentistDate` (`DentistID`,`AppointmentDate`,`StartTime`),
  ADD KEY `IX_tblAppointments_Status` (`Status`);

--
-- Indexes for table `tblappointmenttypes`
--
ALTER TABLE `tblappointmenttypes`
  ADD PRIMARY KEY (`AppointmentTypeID`),
  ADD UNIQUE KEY `UQ_tblAppointmentTypes_TypeName` (`TypeName`);

--
-- Indexes for table `tblauditlogs`
--
ALTER TABLE `tblauditlogs`
  ADD PRIMARY KEY (`AuditLogID`),
  ADD KEY `IX_tblAuditLogs_Timestamp` (`Timestamp`),
  ADD KEY `IX_tblAuditLogs_UserID` (`UserID`),
  ADD KEY `IX_tblAuditLogs_Entity` (`EntityName`,`RecordID`);

--
-- Indexes for table `tbldentalchart`
--
ALTER TABLE `tbldentalchart`
  ADD PRIMARY KEY (`DentalChartID`),
  ADD KEY `FK_tblDentalChart_UpdatedBy` (`UpdatedBy`),
  ADD KEY `IX_tblDentalChart_PatientTooth` (`PatientID`,`ToothNumber`);

--
-- Indexes for table `tbldentalrecords`
--
ALTER TABLE `tbldentalrecords`
  ADD PRIMARY KEY (`DentalRecordID`),
  ADD KEY `IX_tblDentalRecords_PatientID` (`PatientID`),
  ADD KEY `IX_tblDentalRecords_VisitDate` (`VisitDate`),
  ADD KEY `IX_tblDentalRecords_AppointmentID` (`AppointmentID`),
  ADD KEY `IX_tblDentalRecords_DentistID` (`DentistID`);

--
-- Indexes for table `tblinventorytransactions`
--
ALTER TABLE `tblinventorytransactions`
  ADD PRIMARY KEY (`TransactionID`),
  ADD KEY `FK_tblInventoryTransactions_User` (`PerformedBy`),
  ADD KEY `IX_tblInventoryTransactions_ProductDate` (`ProductID`,`TransactionDate`);

--
-- Indexes for table `tblinvoiceitems`
--
ALTER TABLE `tblinvoiceitems`
  ADD PRIMARY KEY (`InvoiceItemID`),
  ADD KEY `IX_tblInvoiceItems_Invoice` (`InvoiceID`),
  ADD KEY `IX_tblInvoiceItems_Treatment` (`TreatmentRecordID`);

--
-- Indexes for table `tblinvoices`
--
ALTER TABLE `tblinvoices`
  ADD PRIMARY KEY (`InvoiceID`),
  ADD UNIQUE KEY `UQ_tblInvoices_InvoiceNumber` (`InvoiceNumber`),
  ADD KEY `FK_tblInvoices_Appointment` (`AppointmentID`),
  ADD KEY `IX_tblInvoices_Patient` (`PatientID`),
  ADD KEY `IX_tblInvoices_Status` (`Status`);

--
-- Indexes for table `tblmedicalhistory`
--
ALTER TABLE `tblmedicalhistory`
  ADD PRIMARY KEY (`MedicalHistoryID`),
  ADD UNIQUE KEY `UQ_tblMedicalHistory_Patient` (`PatientID`);

--
-- Indexes for table `tblmedicalimages`
--
ALTER TABLE `tblmedicalimages`
  ADD PRIMARY KEY (`ImageID`),
  ADD KEY `IX_tblMedicalImages_Patient` (`PatientID`,`DateUploaded`),
  ADD KEY `IX_tblMedicalImages_UploadedBy` (`UploadedBy`);

--
-- Indexes for table `tblpatients`
--
ALTER TABLE `tblpatients`
  ADD PRIMARY KEY (`PatientID`),
  ADD UNIQUE KEY `UQ_tblPatients_PatientCode` (`PatientCode`);

--
-- Indexes for table `tblpaymentmethods`
--
ALTER TABLE `tblpaymentmethods`
  ADD PRIMARY KEY (`PaymentMethodID`),
  ADD UNIQUE KEY `UQ_tblPaymentMethods_MethodName` (`MethodName`);

--
-- Indexes for table `tblpayments`
--
ALTER TABLE `tblpayments`
  ADD PRIMARY KEY (`PaymentID`),
  ADD UNIQUE KEY `UQ_tblPayments_PaymentReference` (`PaymentReference`),
  ADD KEY `FK_tblPayments_ReceivedBy` (`ReceivedBy`),
  ADD KEY `IX_tblPayments_Invoice` (`InvoiceID`),
  ADD KEY `IX_tblPayments_Method` (`PaymentMethodID`),
  ADD KEY `IX_tblPayments_MethodRef` (`PaymentMethodID`,`ReferenceNumber`);

--
-- Indexes for table `tblprocedurematerial`
--
ALTER TABLE `tblprocedurematerial`
  ADD PRIMARY KEY (`ProcedureMaterialID`),
  ADD UNIQUE KEY `UQ_tblProcedureMaterial` (`ProcedureID`,`ProductCode`),
  ADD KEY `FK_tblProcedureMaterial_Product` (`ProductCode`);

--
-- Indexes for table `tblprocedures`
--
ALTER TABLE `tblprocedures`
  ADD PRIMARY KEY (`ProcedureID`),
  ADD UNIQUE KEY `UQ_tblProcedures_ProcedureCode` (`ProcedureCode`);

--
-- Indexes for table `tblproductcategories`
--
ALTER TABLE `tblproductcategories`
  ADD PRIMARY KEY (`CategoryID`),
  ADD UNIQUE KEY `UQ_tblProductCategories_CategoryName` (`CategoryName`);

--
-- Indexes for table `tblproducts`
--
ALTER TABLE `tblproducts`
  ADD PRIMARY KEY (`ProductID`),
  ADD UNIQUE KEY `UQ_tblProducts_ProductCode` (`ProductCode`),
  ADD KEY `IX_tblProducts_Category` (`CategoryID`);

--
-- Indexes for table `tblproductsuppliers`
--
ALTER TABLE `tblproductsuppliers`
  ADD PRIMARY KEY (`ProductSupplierID`),
  ADD UNIQUE KEY `UQ_tblProductSuppliers_ProductSupplier` (`ProductID`,`SupplierID`),
  ADD KEY `IX_tblProductSuppliers_Supplier` (`SupplierID`);

--
-- Indexes for table `tblroles`
--
ALTER TABLE `tblroles`
  ADD PRIMARY KEY (`RoleID`),
  ADD UNIQUE KEY `UQ_tblRoles_RoleName` (`RoleName`);

--
-- Indexes for table `tblstaff`
--
ALTER TABLE `tblstaff`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `UQ_tblStaff_StaffCode` (`StaffCode`);

--
-- Indexes for table `tblsuppliers`
--
ALTER TABLE `tblsuppliers`
  ADD PRIMARY KEY (`SupplierID`),
  ADD UNIQUE KEY `UQ_tblSuppliers_SupplierName` (`SupplierName`);

--
-- Indexes for table `tbltreatmentplanitems`
--
ALTER TABLE `tbltreatmentplanitems`
  ADD PRIMARY KEY (`PlanItemID`),
  ADD KEY `IX_tblTreatmentPlanItems_Plan` (`TreatmentPlanID`),
  ADD KEY `IX_tblTreatmentPlanItems_Procedure` (`ProcedureID`);

--
-- Indexes for table `tbltreatmentplans`
--
ALTER TABLE `tbltreatmentplans`
  ADD PRIMARY KEY (`TreatmentPlanID`),
  ADD KEY `IX_tblTreatmentPlans_PatientID` (`PatientID`);

--
-- Indexes for table `tbltreatmentrecords`
--
ALTER TABLE `tbltreatmentrecords`
  ADD PRIMARY KEY (`TreatmentRecordID`),
  ADD KEY `IX_tblTreatmentRecords_DentalRecord` (`DentalRecordID`),
  ADD KEY `IX_tblTreatmentRecords_Procedure` (`ProcedureID`),
  ADD KEY `IX_tblTreatmentRecords_Dentist` (`DentistID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `UQ_tblUsers_Username` (`Username`),
  ADD UNIQUE KEY `UQ_tblUsers_StaffID` (`StaffID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblappointments`
--
ALTER TABLE `tblappointments`
  MODIFY `AppointmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tblappointmenttypes`
--
ALTER TABLE `tblappointmenttypes`
  MODIFY `AppointmentTypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblauditlogs`
--
ALTER TABLE `tblauditlogs`
  MODIFY `AuditLogID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `tbldentalchart`
--
ALTER TABLE `tbldentalchart`
  MODIFY `DentalChartID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbldentalrecords`
--
ALTER TABLE `tbldentalrecords`
  MODIFY `DentalRecordID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblinventorytransactions`
--
ALTER TABLE `tblinventorytransactions`
  MODIFY `TransactionID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `tblinvoiceitems`
--
ALTER TABLE `tblinvoiceitems`
  MODIFY `InvoiceItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tblinvoices`
--
ALTER TABLE `tblinvoices`
  MODIFY `InvoiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tblmedicalhistory`
--
ALTER TABLE `tblmedicalhistory`
  MODIFY `MedicalHistoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tblmedicalimages`
--
ALTER TABLE `tblmedicalimages`
  MODIFY `ImageID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblpatients`
--
ALTER TABLE `tblpatients`
  MODIFY `PatientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblpaymentmethods`
--
ALTER TABLE `tblpaymentmethods`
  MODIFY `PaymentMethodID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblpayments`
--
ALTER TABLE `tblpayments`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tblprocedurematerial`
--
ALTER TABLE `tblprocedurematerial`
  MODIFY `ProcedureMaterialID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=231;

--
-- AUTO_INCREMENT for table `tblprocedures`
--
ALTER TABLE `tblprocedures`
  MODIFY `ProcedureID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tblproductcategories`
--
ALTER TABLE `tblproductcategories`
  MODIFY `CategoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblproducts`
--
ALTER TABLE `tblproducts`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tblproductsuppliers`
--
ALTER TABLE `tblproductsuppliers`
  MODIFY `ProductSupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tblroles`
--
ALTER TABLE `tblroles`
  MODIFY `RoleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblstaff`
--
ALTER TABLE `tblstaff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tblsuppliers`
--
ALTER TABLE `tblsuppliers`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbltreatmentplanitems`
--
ALTER TABLE `tbltreatmentplanitems`
  MODIFY `PlanItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbltreatmentplans`
--
ALTER TABLE `tbltreatmentplans`
  MODIFY `TreatmentPlanID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbltreatmentrecords`
--
ALTER TABLE `tbltreatmentrecords`
  MODIFY `TreatmentRecordID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
