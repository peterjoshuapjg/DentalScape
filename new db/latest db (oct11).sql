-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 11, 2026 at 08:25 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tblauditlogs`
--

INSERT INTO `tblauditlogs` (`AuditLogID`, `UserID`, `Action`, `EntityName`, `RecordID`, `OldValue`, `NewValue`, `IPAddress`, `Timestamp`) VALUES
(0, 1, 'Login', 'tblUsers', '1', NULL, NULL, 'DESKTOP-QB0QSD4', '2026-10-08 13:16:08'),
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
(43, 1, 'Export Report', 'Reports', NULL, NULL, 'October 2026 patient balance report', '192.168.1.10', '2026-10-08 11:30:00');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
(0, 1, 'Stock In', 50, '2026-10-08 20:44:18', NULL, 1, NULL),
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
(56, 44, 'Stock In', 20, '2026-10-01 09:44:00', 'PO-202610-005', 1, 'October opening stock');

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
(0, 9, NULL, 'Dental Crown', 1, 10000.00, 2000.00),
(1, 1, 1, 'Dental Consultation', 1, 500.00, 0.00),
(2, 2, 2, 'Dental Cleaning', 1, 800.00, 0.00),
(3, 3, 3, 'Dental Filling', 1, 1200.00, 0.00),
(4, 4, 4, 'Root Canal', 1, 8000.00, 0.00),
(5, 5, 5, 'Tooth Extraction', 1, 1500.00, 0.00),
(6, 6, 6, 'Orthodontic Adjustment', 1, 1000.00, 0.00),
(7, 7, 7, 'Dental Consultation', 1, 500.00, 0.00),
(8, 8, 8, 'Dental Cleaning', 1, 800.00, 0.00),
(9, 9, 9, 'Root Canal', 1, 8000.00, 0.00),
(10, 10, 10, 'Gum Treatment', 1, 2500.00, 0.00);

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
(0, 'INV-00011', 5, NULL, '2026-10-08 20:52:37', 0.00, 0.00, 0.00, 0.00, 'Unpaid'),
(1, 'INV-202610-001', 1, 1, '2026-10-01 09:15:00', 500.00, 0.00, 500.00, 500.00, 'Paid'),
(2, 'INV-202610-002', 2, 2, '2026-10-01 10:20:00', 800.00, 0.00, 800.00, 800.00, 'Paid'),
(3, 'INV-202610-003', 3, 3, '2026-10-02 13:30:00', 1200.00, 0.00, 1200.00, 600.00, 'Partially Paid'),
(4, 'INV-202610-004', 4, 4, '2026-10-03 10:35:00', 8000.00, 0.00, 8000.00, 3000.00, 'Partially Paid'),
(5, 'INV-202610-005', 5, 5, '2026-10-03 15:10:00', 1500.00, 0.00, 1500.00, 1500.00, 'Paid'),
(6, 'INV-202610-006', 6, 6, '2026-10-04 10:40:00', 1000.00, 0.00, 1000.00, 1000.00, 'Paid'),
(7, 'INV-202610-007', 7, 7, '2026-10-05 10:10:00', 500.00, 0.00, 500.00, 500.00, 'Paid'),
(8, 'INV-202610-008', 8, 8, '2026-10-06 14:15:00', 800.00, 0.00, 800.00, 800.00, 'Paid'),
(9, 'INV-202610-009', 1, 9, '2026-10-07 10:45:00', 16000.00, 0.00, 16000.00, 16000.00, 'Paid'),
(10, 'INV-202610-010', 2, 10, '2026-10-07 15:10:00', 2500.00, 0.00, 2500.00, 2500.00, 'Paid');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
(0, 'PAT-00009', 'Peter Joshua', 'Finis', 'Galang', '2002-04-17', 'Male', '09495924039', 'joshua@gmail.com', 'San Pedro Laguna', 'Mother', '09123456789', '2026-10-08 13:18:04', 'Active'),
(1, 'PAT-00001', 'John', 'Michael', 'Santos', '1999-02-14', 'Male', '09181230001', 'john.santos@gmail.com', 'Muntinlupa City', 'Maria Santos', '09181230002', '2026-10-01 08:10:00', 'Active'),
(2, 'PAT-00002', 'Angela', 'Marie', 'Cruz', '2001-06-21', 'Female', '09181230003', 'angela.cruz@gmail.com', 'Las Pinas City', 'Ramon Cruz', '09181230004', '2026-10-01 09:00:00', 'Active'),
(3, 'PAT-00003', 'Harvey', 'Ischei', 'Elloso', '2006-05-29', 'Male', '09181230005', 'harvey.elloso@gmail.com', 'San Pedro Laguna', 'Liza Elloso', '09181230006', '2026-10-02 10:15:00', 'Active'),
(4, 'PAT-00004', 'Sofia', 'Anne', 'Reyes', '1998-11-03', 'Female', '09181230007', 'sofia.reyes@gmail.com', 'Biñan Laguna', 'Carlos Reyes', '09181230008', '2026-10-02 13:20:00', 'Active'),
(5, 'PAT-00005', 'Miguel', 'Antonio', 'Garcia', '1995-08-17', 'Male', '09181230009', 'miguel.garcia@gmail.com', 'Cavite City', 'Elena Garcia', '09181230010', '2026-10-03 08:30:00', 'Active'),
(6, 'PAT-00006', 'Jasmine', 'Louise', 'Tan', '2003-01-12', 'Female', '09181230011', 'jasmine.tan@gmail.com', 'Parañaque City', 'Kevin Tan', '09181230012', '2026-10-03 11:45:00', 'Active'),
(7, 'PAT-00007', 'Daniel', 'Luis', 'Mendoza', '1997-09-25', 'Male', '09181230013', 'daniel.mendoza@gmail.com', 'Bacoor Cavite', 'Rosa Mendoza', '09181230014', '2026-10-05 09:10:00', 'Active'),
(8, 'PAT-00008', 'Camille', 'Grace', 'Navarro', '2000-12-08', 'Female', '09181230015', 'camille.navarro@gmail.com', 'Imus Cavite', 'Paolo Navarro', '09181230016', '2026-10-06 14:00:00', 'Active');

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
) ;

--
-- Dumping data for table `tblpayments`
--

INSERT INTO `tblpayments` (`PaymentID`, `InvoiceID`, `PaymentReference`, `ReferenceNumber`, `PaymentDate`, `Amount`, `PaymentMethodID`, `ReceivedBy`, `Notes`) VALUES
(0, 9, 'PAY-00011', NULL, '2026-10-08 20:55:21', 12000.00, 2, 2, NULL),
(1, 1, 'PAY-202610-001', NULL, '2026-10-01 09:16:00', 500.00, 1, 2, 'Paid in full.'),
(2, 2, 'PAY-202610-002', NULL, '2026-10-01 10:21:00', 800.00, 2, 2, 'Paid in full via GCash.'),
(3, 3, 'PAY-202610-003', NULL, '2026-10-02 13:31:00', 600.00, 1, 2, 'Partial payment.'),
(4, 4, 'PAY-202610-004', NULL, '2026-10-03 10:36:00', 3000.00, 2, 2, 'Initial root canal payment.'),
(5, 5, 'PAY-202610-005', NULL, '2026-10-03 15:11:00', 1500.00, 1, 2, 'Paid in full.'),
(6, 6, 'PAY-202610-006', NULL, '2026-10-04 10:41:00', 1000.00, 4, 2, 'Paid in full.'),
(7, 7, 'PAY-202610-007', NULL, '2026-10-05 10:11:00', 500.00, 1, 2, 'Paid in full.'),
(8, 8, 'PAY-202610-008', NULL, '2026-10-06 14:16:00', 800.00, 2, 2, 'Paid in full via GCash.'),
(9, 9, 'PAY-202610-009', NULL, '2026-10-07 10:46:00', 4000.00, 3, 2, 'Partial bank transfer.'),
(10, 10, 'PAY-202610-010', NULL, '2026-10-07 15:11:00', 2500.00, 2, 2, 'Paid in full via GCash.');

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
(30, 'PR-030', 'Retainer', 'Fabrication and fitting of an orthodontic retainer', 5000.00, 60, 'Active'),
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
(44, 'PRD-044', 'Cheek Retractor (Sterilizable)', 5, 'Piece', 20, 5, 180.00, 'Active'),
(1, 'PRD-001', 'Cotton Rolls', 1, 'Pack', 50, 10, 80.00, 'Active'),
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
(44, 44, 3, 'SUP3-PRD-044', 165.60, 1),
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
(3, 'Prime Dental Materials', 'Carlo Bautista', '09190000003', 'sales@primedental.ph', 'Quezon City', 'Active'),
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
(11, 5, 10, NULL, 1, 2500.00, 'Planned', '2026-10-08'),
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
(5, 8, 4, '2026-10-06', 'Gingival inflammation', 3300.00, 'Active', 'Cleaning and gum treatment recommended.'),
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `StaffID`, `Username`, `PasswordHash`, `RoleID`, `IsActive`, `CreatedAt`, `LastLogin`, `FailedAttempts`, `LockedUntil`) VALUES
(1, 1, 'owner', 'SET_PASSWORD_FIRST', 1, 1, '2026-10-07 13:51:15', '2026-10-11 13:16:18', 0, NULL),
(2, 2, 'frontdesk', 'SET_PASSWORD_FIRST', 2, 1, '2026-10-07 13:51:15', '2026-10-11 14:19:56', 0, NULL),
(3, 3, 'dentist.richelle', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-01 07:40:00', '2026-10-11 14:03:50', 3, '2026-10-11 14:27:06'),
(4, 4, 'dentist.maria', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-01 07:45:00', '2026-10-11 14:21:59', 0, NULL),
(5, 5, 'juan.delacruz', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-11 14:02:06', NULL, 0, NULL),
(6, 6, 'angela.reyes', 'SET_PASSWORD_FIRST', 3, 1, '2026-10-11 14:02:06', NULL, 0, NULL),
(7, 7, 'it', 'SET_PASSWORD_FIRST', 4, 1, '2026-10-11 14:02:06', '2026-10-11 14:20:43', 0, NULL);

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
-- Indexes for table `tblproductcategories`
--
ALTER TABLE `tblproductcategories`
  ADD PRIMARY KEY (`CategoryID`),
  ADD UNIQUE KEY `UQ_tblProductCategories_CategoryName` (`CategoryName`);

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
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
