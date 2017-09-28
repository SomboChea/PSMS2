/*
 Navicat Premium Data Transfer

 Source Server         : MS SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 13004206
 Source Host           : localhost:1433
 Source Catalog        : PSMS2
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 13004206
 File Encoding         : 65001

 Date: 28/09/2017 17:22:21
*/


-- ----------------------------
-- Table structure for Customers
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type IN ('U'))
	DROP TABLE [dbo].[Customers]
GO

CREATE TABLE [dbo].[Customers] (
  [CusID] int IDENTITY(1,1) NOT NULL,
  [CusCode] AS ('CUS'+right('0000'+CONVERT([nvarchar](5),[CusID]),(5))) PERSISTED NOT NULL,
  [CusLNKH] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [CusFNKH] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [CusLNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [CusFNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Gender] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Address] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Phone] nvarchar(13) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Phone2] nvarchar(13) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Email] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Balance] float(53) NULL,
  [Status] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Emp_ID] int NULL,
  [Acc_Opendate] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Customers] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Employee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type IN ('U'))
	DROP TABLE [dbo].[Employee]
GO

CREATE TABLE [dbo].[Employee] (
  [EmpID] int IDENTITY(1,1) NOT NULL,
  [EmpCode] AS ('EMP'+right('0000'+CONVERT([nvarchar](5),[EmpID]),(5))) PERSISTED NOT NULL,
  [EmpLNKH] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [EmpFNKH] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [EmpLNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [EmpFNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Gender] nvarchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [IDCard] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Address] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Phone] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Email] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [PosID] int NULL,
  [Salary] int NULL,
  [JoinDate] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Image] varbinary(max) NULL
)
GO

ALTER TABLE [dbo].[Employee] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Invoice
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice]') AND type IN ('U'))
	DROP TABLE [dbo].[Invoice]
GO

CREATE TABLE [dbo].[Invoice] (
  [InvoiceNo] int IDENTITY(1,1) NOT NULL,
  [InvoiceCode] AS ('INV'+right('0000'+CONVERT([nvarchar](5),[InvoiceNo]),(5))) PERSISTED NOT NULL,
  [CusID] int NULL,
  [EmpID] int NULL,
  [Date] datetime2(7) NULL,
  [TotalPrice] float(53) NULL,
  [Payment] float(53) DEFAULT ((0)) NOT NULL,
  [PaymentVerify] int NULL,
  [Profits] float(53) NULL,
  [Balance] float(53) NULL
)
GO

ALTER TABLE [dbo].[Invoice] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for InvoiceDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[InvoiceDetail]
GO

CREATE TABLE [dbo].[InvoiceDetail] (
  [InvoiceNo] int NOT NULL,
  [PID] int NOT NULL,
  [Quantity] int NULL,
  [Saleprice] float(53) NULL,
  [Amount] int NULL
)
GO

ALTER TABLE [dbo].[InvoiceDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Model
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Model]') AND type IN ('U'))
	DROP TABLE [dbo].[Model]
GO

CREATE TABLE [dbo].[Model] (
  [MID] int IDENTITY(1,1) NOT NULL,
  [MCode] AS ('M'+right('0000'+CONVERT([nvarchar](5),[MID]),(5))) PERSISTED NOT NULL,
  [Description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Model] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Phone_Type
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Phone_Type]') AND type IN ('U'))
	DROP TABLE [dbo].[Phone_Type]
GO

CREATE TABLE [dbo].[Phone_Type] (
  [PTypeID] int IDENTITY(1,1) NOT NULL,
  [PTypeCode] AS ('PT'+right('0000'+CONVERT([nvarchar](5),[PTypeID]),(5))) PERSISTED NOT NULL,
  [Description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Phone_Type] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Position
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type IN ('U'))
	DROP TABLE [dbo].[Position]
GO

CREATE TABLE [dbo].[Position] (
  [PosID] int IDENTITY(1,1) NOT NULL,
  [PosCode] AS ('POS'+right('0000'+CONVERT([nvarchar](5),[PosID]),(5))) PERSISTED NOT NULL,
  [PosName] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
)
GO

ALTER TABLE [dbo].[Position] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Product
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type IN ('U'))
	DROP TABLE [dbo].[Product]
GO

CREATE TABLE [dbo].[Product] (
  [PID] int IDENTITY(1,1) NOT NULL,
  [PCode] AS ('P'+right('0000'+CONVERT([nvarchar](5),[PID]),(5))) PERSISTED NOT NULL,
  [PName] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [PSize] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Color] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Quantity] int DEFAULT ((0)) NOT NULL,
  [MID] int NULL,
  [PTypeID] int NULL,
  [TID] int NULL,
  [Saleprice] float(53) NULL,
  [Unitprice] float(53) NULL,
  [Image] varbinary(max) NULL
)
GO

ALTER TABLE [dbo].[Product] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Purchase
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Purchase]') AND type IN ('U'))
	DROP TABLE [dbo].[Purchase]
GO

CREATE TABLE [dbo].[Purchase] (
  [PurID] int IDENTITY(1,1) NOT NULL,
  [PurCode] AS ('PUR'+right('0000'+CONVERT([nvarchar](5),[PurID]),(5))) PERSISTED NOT NULL,
  [Date] datetime NULL,
  [Payment] float(53) NULL,
  [Balance] float(53) DEFAULT ((0)) NULL,
  [SuID] int NULL,
  [EmpID] int NULL,
  [Total] float(53) NULL
)
GO

ALTER TABLE [dbo].[Purchase] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for PurchaseDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[PurchaseDetail]
GO

CREATE TABLE [dbo].[PurchaseDetail] (
  [PurID] int NOT NULL,
  [PID] int NOT NULL,
  [Quantity] int NULL,
  [Unitprice] float(53) NULL,
  [Saleprice] float(53) NULL,
  [Amount] float(53) NULL
)
GO

ALTER TABLE [dbo].[PurchaseDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Supplier
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Supplier]') AND type IN ('U'))
	DROP TABLE [dbo].[Supplier]
GO

CREATE TABLE [dbo].[Supplier] (
  [SuID] int IDENTITY(1,1) NOT NULL,
  [SuCode] AS ('SU'+right('0000'+CONVERT([nvarchar](5),[SuID]),(5))) PERSISTED NOT NULL,
  [SuLNKH] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [SuFNKH] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [SuLNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [SuFNEN] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Gender] nvarchar(7) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Address] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Phone] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Phone2] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Email] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Fax] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Fax2] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Balance] float(53) NULL
)
GO

ALTER TABLE [dbo].[Supplier] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for sysdiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sysdiagrams]') AND type IN ('U'))
	DROP TABLE [dbo].[sysdiagrams]
GO

CREATE TABLE [dbo].[sysdiagrams] (
  [name] sysname NOT NULL,
  [principal_id] int NOT NULL,
  [diagram_id] int IDENTITY(1,1) NOT NULL,
  [version] int NULL,
  [definition] varbinary(max) NULL
)
GO

ALTER TABLE [dbo].[sysdiagrams] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Type
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Type]') AND type IN ('U'))
	DROP TABLE [dbo].[Type]
GO

CREATE TABLE [dbo].[Type] (
  [TID] int IDENTITY(1,1) NOT NULL,
  [TCode] AS ('T'+right('0000'+CONVERT([nvarchar](5),[TID]),(5))) PERSISTED NOT NULL,
  [Description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Type] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Users
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type IN ('U'))
	DROP TABLE [dbo].[Users]
GO

CREATE TABLE [dbo].[Users] (
  [UID] int IDENTITY(1,1) NOT NULL,
  [UCode] AS ('U'+right('0000'+CONVERT([nvarchar](5),[UID]),(5))) PERSISTED NOT NULL,
  [UName] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Password] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- View structure for viewCustomer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewCustomer]') AND type IN ('V'))
	DROP VIEW [dbo].[viewCustomer]
GO

CREATE VIEW [dbo].[viewCustomer] AS SELECT c.CusCode Code,CONCAT(c.CusLNKH,' ',c.CusFNKH) CustomerNameKH, CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,c.Gender,c.Address,c.Phone,c.Balance,c.Status,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,c.Acc_Opendate OpenDate
FROM Customers c
LEFT JOIN Employee e
ON c.Emp_ID = e.EmpID
GO


-- ----------------------------
-- View structure for viewCustomerDetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewCustomerDetails]') AND type IN ('V'))
	DROP VIEW [dbo].[viewCustomerDetails]
GO

CREATE VIEW [dbo].[viewCustomerDetails] AS SELECT c.CusCode AS Code, CONCAT(c.CusLNEN, ' ', c.CusFNEN)  AS CustomerName, CONCAT(c.CusLNKH, ' ', c.CusFNKH) AS CustomerNameKH, c.Gender, c.Address, c.Phone, c.Phone2, c.Email, c.Balance, c.Status,  CONCAT(e.EmpLNEN, ' ', e.EmpFNEN)  AS EmployeeName, c.Acc_Opendate FROM Customers AS c INNER JOIN Employee AS e ON c.Emp_ID = e.EmpID
GO


-- ----------------------------
-- View structure for viewCustomerReports
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewCustomerReports]') AND type IN ('V'))
	DROP VIEW [dbo].[viewCustomerReports]
GO

CREATE VIEW [dbo].[viewCustomerReports] AS SELECT i.InvoiceCode Code,c.CusID,c.CusCode ,p.PName ProName,p.PCode ProCode,id.Quantity Quantity,id.Saleprice Price,id.Amount Amount,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,c.Phone Phone,c.Address Address,format(i.Date,'dd-MMM-yyyy hh:mm:ss tt') Date
FROM InvoiceDetail id
INNER JOIN Product p
ON id.PID = p.PID
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
INNER JOIN Customers c
ON i.CusID = c.CusID;
GO


-- ----------------------------
-- View structure for viewCustomerReports2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewCustomerReports2]') AND type IN ('V'))
	DROP VIEW [dbo].[viewCustomerReports2]
GO

CREATE VIEW [dbo].[viewCustomerReports2] AS SELECT i.InvoiceCode Code,c.CusCode ,i.TotalPrice Amount,i.Profits,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,c.Phone Phone,c.Address Address,format(i.Date,'dd-MMM-yyyy hh:mm:ss tt') Date
FROM Invoice i
INNER JOIN Customers c
ON i.CusID = c.CusID;
GO


-- ----------------------------
-- View structure for viewEmployee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewEmployee]') AND type IN ('V'))
	DROP VIEW [dbo].[viewEmployee]
GO

CREATE VIEW [dbo].[viewEmployee] AS SELECT e.EmpCode Code,CONCAT(e.EmpLNKH,' ',e.EmpFNKH) EmployeeNameKH,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,e.Gender Gender,e.IDCard IDCard,e.Address Address,e.Phone Phone,e.Email Email,p.PosName PositionName,e.Salary Salary,e.JoinDate JoinDate
FROM Employee e
INNER JOIN Position p
ON e.PosID = p.PosID
GO


-- ----------------------------
-- View structure for viewEmployeeDetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewEmployeeDetails]') AND type IN ('V'))
	DROP VIEW [dbo].[viewEmployeeDetails]
GO

CREATE VIEW [dbo].[viewEmployeeDetails] AS SELECT e.EmpCode Code,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,CONCAT(e.EmpLNKH,' ',e.EmpFNKH) EmployeeNameKH,e.Gender,e.IDCard NationalID,e.Address,e.Phone,e.Email,p.PosName PositionName,e.Salary,e.JoinDate
FROM Employee e
INNER JOIN Position p
ON e.PosID = p.PosID
GO


-- ----------------------------
-- View structure for viewEmployeeReportInvoice
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewEmployeeReportInvoice]') AND type IN ('V'))
	DROP VIEW [dbo].[viewEmployeeReportInvoice]
GO

CREATE VIEW [dbo].[viewEmployeeReportInvoice] AS SELECT i.InvoiceCode Code,e.EmpCode,p.PName ProName,p.PCode ProCode,id.Quantity Quantity,id.Saleprice Price,id.Amount Amount,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,e.Phone Phone,e.Address Address,e.Email,format(i.Date,'dd-MMM-yyyy hh:mm:ss tt') Date
FROM InvoiceDetail id
INNER JOIN Product p
ON id.PID = p.PID
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
INNER JOIN Customers c
ON i.CusID = c.CusID
INNER JOIN Employee e
ON i.EmpID = e.EmpID
INNER JOIN Position ps
ON ps.PosID = e.PosID
GO


-- ----------------------------
-- View structure for viewEmployeeReportPurchase
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewEmployeeReportPurchase]') AND type IN ('V'))
	DROP VIEW [dbo].[viewEmployeeReportPurchase]
GO

CREATE VIEW [dbo].[viewEmployeeReportPurchase] AS SELECT p.PurCode Code,e.EmpCode,format(p.Date,'dd-MMM-yyyy hh:mm:ss tt') Date,pp.PCode ProCode,pp.PName ProName,pd.Quantity Quantity,pd.UnitPrice,pd.Amount Amount, p.Payment Paid,p.Balance Balance,CONCAT(s.SuLNEN,' ',s.SuFNEN) SupplierName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,e.Phone Phone,e.Address Address,e.Email,p.Total
FROM PurchaseDetail pd
INNER JOIN Purchase p
ON pd.PurID = p.PurID
INNER JOIN Product pp
ON pp.PID = pd.PID
INNER JOIN Supplier s
ON p.SuID = s.SuID
INNER JOIN Employee e
ON p.EmpID = e.EmpID
GO


-- ----------------------------
-- View structure for viewIncome
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewIncome]') AND type IN ('V'))
	DROP VIEW [dbo].[viewIncome]
GO

CREATE VIEW [dbo].[viewIncome] AS Select format([Date],'yyyy-MM-dd hh:mm tt') DATETIME,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) CustomerName,TotalPrice,(TotalPrice-Profits) Cost,Profits from Invoice I INNER JOIN Customers C on C.CusID=I.CusID INNER JOIN Employee E on E.EmpID=I.EmpID;
GO


-- ----------------------------
-- View structure for viewInvoice
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoice]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoice]
GO

CREATE VIEW [dbo].[viewInvoice] AS SELECT i.InvoiceCode Code,p.PName ProductName,p.PCode ProCode,id.Quantity Quantity,id.Saleprice Price,id.Amount Amount,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,c.Phone Phone,c.Address Address,i.Date Date
FROM InvoiceDetail id
INNER JOIN Product p
ON id.PID = p.PID
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
INNER JOIN Customers c
ON i.CusID = c.CusID
INNER JOIN Employee e
ON i.EmpID = e.EmpID
GO


-- ----------------------------
-- View structure for viewInvoice2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoice2]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoice2]
GO

CREATE VIEW [dbo].[viewInvoice2] AS SELECT
dbo.Invoice.InvoiceCode,
dbo.Invoice.[Date],
Concat(dbo.Customers.CusLNEN,' ',dbo.Customers.CusFNEN) 'CustomerName',
Concat(dbo.Employee.EmpLNEN,' ',dbo.Employee.EmpFNEN) 'EmployeeName',
Concat(dbo.Customers.CusLNKH,' ',dbo.Customers.CusFNKH) 'CustomersNameKH',
Concat(dbo.Employee.EmpLNKH,' ',dbo.Employee.EmpFNKH) 'EmployeeNameKH',
dbo.Invoice.TotalPrice,
dbo.Invoice.Payment AS Paid,
dbo.Invoice.Balance,
dbo.Invoice.PaymentVerify

FROM
dbo.Invoice
INNER JOIN dbo.Customers ON dbo.Invoice.CusID = dbo.Customers.CusID
INNER JOIN dbo.Employee ON dbo.Invoice.EmpID = dbo.Employee.EmpID
GO


-- ----------------------------
-- View structure for viewInvoice3
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoice3]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoice3]
GO

CREATE VIEW [dbo].[viewInvoice3] AS SELECT i.InvoiceCode Code,i.Date Date,p.PName ProductName,p.PCode ProCode,id.Quantity Quantity,id.Saleprice Price,id.Amount Amount,i.Payment Paid,i.Balance,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,c.Phone Phone,c.Address Address,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName
FROM InvoiceDetail id
INNER JOIN Product p
ON id.PID = p.PID
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
INNER JOIN Customers c
ON i.CusID = c.CusID
INNER JOIN Employee e
ON i.EmpID = e.EmpID
GO


-- ----------------------------
-- View structure for viewInvoice4
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoice4]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoice4]
GO

CREATE VIEW [dbo].[viewInvoice4] AS SELECT
dbo.Invoice.InvoiceCode,
dbo.Invoice.[Date],
dbo.Invoice.TotalPrice,
dbo.Invoice.Payment AS Paid,
dbo.Invoice.Balance,
Concat(dbo.Customers.CusLNEN,' ',dbo.Customers.CusFNEN) 'CustomerName',
Concat(dbo.Employee.EmpLNEN,' ',dbo.Employee.EmpFNEN) 'EmployeeName'

FROM
dbo.Invoice
INNER JOIN dbo.Customers ON dbo.Invoice.CusID = dbo.Customers.CusID
INNER JOIN dbo.Employee ON dbo.Invoice.EmpID = dbo.Employee.EmpID
GO


-- ----------------------------
-- View structure for viewInvoiceWeekly
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoiceWeekly]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoiceWeekly]
GO

CREATE VIEW [dbo].[viewInvoiceWeekly] AS select Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date,convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date,sum(TotalPrice) AS TotalPrice from Invoice group BY YEAR(Date),MONTH(date),DATEPART(ww, date)
GO


-- ----------------------------
-- View structure for viewPurchase
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewPurchase]') AND type IN ('V'))
	DROP VIEW [dbo].[viewPurchase]
GO

CREATE VIEW [dbo].[viewPurchase] AS SELECT p.PurCode Code,p.Date PurDate,pp.PName ProductName,pd.Quantity Quantity,pd.Unitprice,pd.Amount Amount, p.Payment Paid,p.Balance Balance,CONCAT(s.SuLNEN,' ',s.SuFNEN) SupplierName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,p.Total
FROM PurchaseDetail pd
INNER JOIN Purchase p
ON pd.PurID = p.PurID
INNER JOIN Product pp
ON pp.PID = pd.PID
INNER JOIN Supplier s
ON p.SuID = s.SuID
INNER JOIN Employee e
ON p.EmpID = e.EmpID
GO


-- ----------------------------
-- View structure for viewPurchase2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewPurchase2]') AND type IN ('V'))
	DROP VIEW [dbo].[viewPurchase2]
GO

CREATE VIEW [dbo].[viewPurchase2] AS SELECT

dbo.Purchase.PurCode Code,

dbo.Purchase.[Date],
dbo.Purchase.Total,
dbo.Purchase.Payment AS Paid,
dbo.Purchase.Balance,
Concat(dbo.Supplier.SuLNEN,' ',dbo.Supplier.SuFNEN) As SupplierName,
Concat(dbo.Employee.EmpLNEN,' ',dbo.Employee.EmpFNEN) AS EmployeeName,
Concat(dbo.Supplier.SuLNKH,' ',dbo.Supplier.SuFNKH) As SupplierNameKH,
Concat(dbo.Employee.EmpLNKH,' ',dbo.Employee.EmpFNKH) AS EmployeeNameKH

FROM
dbo.Purchase
INNER JOIN dbo.Employee ON dbo.Purchase.EmpID = dbo.Employee.EmpID
INNER JOIN dbo.Supplier ON dbo.Purchase.SuID = dbo.Supplier.SuID
GO


-- ----------------------------
-- View structure for viewPurchase3
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewPurchase3]') AND type IN ('V'))
	DROP VIEW [dbo].[viewPurchase3]
GO

CREATE VIEW [dbo].[viewPurchase3] AS SELECT

dbo.Purchase.PurCode Code,

dbo.Purchase.[Date],
dbo.Purchase.Total,
dbo.Purchase.Payment AS Paid,
dbo.Purchase.Balance,
Concat(dbo.Supplier.SuLNEN,' ',dbo.Supplier.SuFNEN) As SupplierName,
Concat(dbo.Employee.EmpLNEN,' ',dbo.Employee.EmpFNEN) AS EmployeeName

FROM
dbo.Purchase
INNER JOIN dbo.Employee ON dbo.Purchase.EmpID = dbo.Employee.EmpID
INNER JOIN dbo.Supplier ON dbo.Purchase.SuID = dbo.Supplier.SuID
GO


-- ----------------------------
-- View structure for viewPurchaseByDate
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewPurchaseByDate]') AND type IN ('V'))
	DROP VIEW [dbo].[viewPurchaseByDate]
GO

CREATE VIEW [dbo].[viewPurchaseByDate] AS SELECT CONVERT
	( DATE, p.Date ) AS DateNote,
	SUM ( pd.Quantity ) AS Quantity,
	SUM ( pd.UnitPrice ) AS UnitPrice,
	SUM ( pd.Amount ) AS Amount,
	SUM ( p.Payment ) AS Paid,
	SUM ( p.Balance ) AS Balance,
	SUM ( p.Total ) AS TotalPrice,
	s.SuID,
	e.EmpID 
FROM
	PurchaseDetail pd
	INNER JOIN Purchase p ON pd.PurID = p.PurID
	INNER JOIN Supplier s ON p.SuID = s.SuID
	INNER JOIN Employee e ON p.EmpID = e.EmpID 
GROUP BY
	CONVERT ( DATE, DATE ),
	s.SuID,
	e.EmpID
GO


-- ----------------------------
-- View structure for viewRevenue
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewRevenue]') AND type IN ('V'))
	DROP VIEW [dbo].[viewRevenue]
GO

CREATE VIEW [dbo].[viewRevenue] AS SELECT i.InvoiceCode
FROM InvoiceDetail id
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
GO


-- ----------------------------
-- View structure for viewStock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewStock]') AND type IN ('V'))
	DROP VIEW [dbo].[viewStock]
GO

CREATE VIEW [dbo].[viewStock] AS SELECT p.PCode AS Code,
					p.PName AS ProductName,
					p.PSize AS PSize,
					p.Color AS Color,
					p.Quantity AS Quantity,
					m.Description AS Brand,
					pt.Description AS PhoneType,
					t.Description AS Type,
					p.Saleprice AS SalePrice,
					p.Unitprice AS UnitPrice
FROM Product AS p
INNER JOIN Model AS m
ON p.MID = m.MID
INNER JOIN Phone_Type AS pt
ON p.PTypeID = pt.PTypeID
INNER JOIN Type AS t
ON p.TID = t.TID
GO


-- ----------------------------
-- View structure for viewStock2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewStock2]') AND type IN ('V'))
	DROP VIEW [dbo].[viewStock2]
GO

CREATE VIEW [dbo].[viewStock2] AS SELECT p.PCode AS PCode,
					p.PName AS PName,
					p.PSize AS PSize,
					p.Color AS Color,
					p.Quantity AS Quantity,
					m.Description AS Brand,
					pt.Description AS PhoneType,
					t.Description AS Type,
					p.Saleprice AS SalePrice,
					p.Unitprice AS UnitPrice,
					p.Image AS Image
FROM Product AS p
INNER JOIN Model AS m
ON p.MID = m.MID
INNER JOIN Phone_Type AS pt
ON p.PTypeID = pt.PTypeID
INNER JOIN Type AS t
ON p.TID = t.TID
GO


-- ----------------------------
-- View structure for viewStockIn
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewStockIn]') AND type IN ('V'))
	DROP VIEW [dbo].[viewStockIn]
GO

CREATE VIEW [dbo].[viewStockIn] AS SELECT pc.PurCode,p.PCode,p.PName,p.PSize,p.Color,m.Description AS Brand,pt.Description AS PType,t.Description AS Type,pcd.Quantity,pcd.UnitPrice,(pcd.Unitprice*pcd.Quantity) TotalPrice,pc.Payment,pc.Balance,CONCAT(s.SuLNEN,' ',s.SuFNEN) SupplierName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,CONVERT(date,pc.Date) Date,CONVERT(time,pc.Date) Time
FROM PurchaseDetail pcd
INNER JOIN Product p
ON pcd.PID = p.PID
INNER JOIN Model m
ON p.MID = m.MID
INNER JOIN Phone_Type pt
ON p.PTypeID = pt.PTypeID
INNER JOIN Type t
ON p.TID = t.TID
INNER JOIN Purchase pc
ON pc.PurID = pcd.PurID
INNER JOIN Supplier s
ON pc.SuID = s.SuID
INNER JOIN Employee e
ON pc.EmpID = e.EmpID
GO


-- ----------------------------
-- View structure for viewStockOut
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewStockOut]') AND type IN ('V'))
	DROP VIEW [dbo].[viewStockOut]
GO

CREATE VIEW [dbo].[viewStockOut] AS SELECT i.InvoiceCode,p.PCode,p.PName,p.PSize,p.Color,m.Description AS Brand,pt.Description AS PType,t.Description AS Type,id.Quantity,id.SalePrice,(id.SalePrice*id.Quantity) TotalPrice,i.Payment,i.Balance,i.PaymentVerify,i.Profits,CONCAT(c.CusLNEN,' ',c.CusFNEN) CustomerName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,CONVERT(date,i.Date) Date,CONVERT(time,i.Date) Time
FROM InvoiceDetail id
INNER JOIN Invoice i
ON id.InvoiceNo = i.InvoiceNo
INNER JOIN Product p
ON id.PID = p.PID
INNER JOIN Model m
ON p.MID = m.MID
INNER JOIN Phone_Type pt
ON p.PTypeID = pt.PTypeID
INNER JOIN Type t
ON p.TID = t.TID
INNER JOIN Employee e
ON i.EmpID = e.EmpID
INNER JOIN Customers c
ON i.CusID = c.CusID
GO


-- ----------------------------
-- View structure for viewSupplier
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewSupplier]') AND type IN ('V'))
	DROP VIEW [dbo].[viewSupplier]
GO

CREATE VIEW [dbo].[viewSupplier] AS SELECT SuCode AS Code,CONCAT(SuLNKH,' ',SuFNKH) SupplierNameKH,CONCAT(SuLNEN,' ',SuFNEN) SupplierName,Gender,Address,Phone,Phone2,Email,Fax,Fax2,Balance
FROM Supplier
GO


-- ----------------------------
-- View structure for viewSupplierReports
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewSupplierReports]') AND type IN ('V'))
	DROP VIEW [dbo].[viewSupplierReports]
GO

CREATE VIEW [dbo].[viewSupplierReports] AS SELECT p.PurCode Code,s.SuCode,format(p.Date,'dd-MMM-yyyy hh:mm:ss tt') Date,pp.PName ProName,pd.Quantity ProQty,pd.UnitPrice,pd.Amount Amount, p.Payment Paid,p.Balance Balance,CONCAT(s.SuLNEN,' ',s.SuFNEN) SupplierName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,p.Total,s.Address,s.Phone,s.Email
FROM PurchaseDetail pd
INNER JOIN Purchase p
ON pd.PurID = p.PurID
INNER JOIN Product pp
ON pp.PID = pd.PID
INNER JOIN Supplier s
ON p.SuID = s.SuID
INNER JOIN Employee e
ON p.EmpID = e.EmpID
GO


-- ----------------------------
-- Procedure structure for sp_upgraddiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upgraddiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_upgraddiagrams]
GO

CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagrams]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagramdefinition
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagramdefinition]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagramdefinition]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_creatediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_creatediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_creatediagram]
GO

CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
GO


-- ----------------------------
-- Procedure structure for sp_renamediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_renamediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_renamediagram]
GO

CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_alterdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_alterdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_alterdiagram]
GO

CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_dropdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_dropdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_dropdiagram]
GO

CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
GO


-- ----------------------------
-- Function structure for fn_diagramobjects
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_diagramobjects]') AND type IN ('FN', 'FS', 'FT', 'IF', 'TF'))
	DROP FUNCTION[dbo].[fn_diagramobjects]
GO

CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
GO


-- ----------------------------
-- Primary Key structure for table Customers
-- ----------------------------
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [PK__Customer__2F187130B2F4C763] PRIMARY KEY CLUSTERED ([CusID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [PK__Employee__AF2DBA79EB345F7B] PRIMARY KEY CLUSTERED ([EmpID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Invoice
-- ----------------------------
ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [PK__Invoice__D796B226D2C8DA27] PRIMARY KEY CLUSTERED ([InvoiceNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table InvoiceDetail
-- ----------------------------
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [PK__InvoiceD__CBC1C7740D09FD3B] PRIMARY KEY CLUSTERED ([InvoiceNo], [PID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Model
-- ----------------------------
ALTER TABLE [dbo].[Model] ADD CONSTRAINT [PK__Model__C797348A85EE01B6] PRIMARY KEY CLUSTERED ([MID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Phone_Type
-- ----------------------------
ALTER TABLE [dbo].[Phone_Type] ADD CONSTRAINT [PK__Phone_Ty__CD06245F8565AA0E] PRIMARY KEY CLUSTERED ([PTypeID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Position
-- ----------------------------
ALTER TABLE [dbo].[Position] ADD CONSTRAINT [PK__Position__67572BB3199E95D2] PRIMARY KEY CLUSTERED ([PosID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Product
-- ----------------------------
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [PK__Product__C5775520580AAF4E] PRIMARY KEY CLUSTERED ([PID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Purchase
-- ----------------------------
ALTER TABLE [dbo].[Purchase] ADD CONSTRAINT [PK__Purchase__DA08B2314CB4A4EA] PRIMARY KEY CLUSTERED ([PurID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PurchaseDetail
-- ----------------------------
ALTER TABLE [dbo].[PurchaseDetail] ADD CONSTRAINT [PK__Purchase__C65FC76377BB0FC6] PRIMARY KEY CLUSTERED ([PurID], [PID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Supplier
-- ----------------------------
ALTER TABLE [dbo].[Supplier] ADD CONSTRAINT [PK__Supplier__C36716DBFF5DD312] PRIMARY KEY CLUSTERED ([SuID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table sysdiagrams
-- ----------------------------
ALTER TABLE [dbo].[sysdiagrams] ADD CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED ([principal_id] ASC, [name] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table sysdiagrams
-- ----------------------------
ALTER TABLE [dbo].[sysdiagrams] ADD CONSTRAINT [PK__sysdiagr__C2B05B61B0F3FA1E] PRIMARY KEY CLUSTERED ([diagram_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Type
-- ----------------------------
ALTER TABLE [dbo].[Type] ADD CONSTRAINT [PK__Type__C456D72997F90BB1] PRIMARY KEY CLUSTERED ([TID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [PK__Users__C5B19602FE348084] PRIMARY KEY CLUSTERED ([UID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [FK_Employee_Position] FOREIGN KEY ([PosID]) REFERENCES [Position] ([PosID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Invoice
-- ----------------------------
ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [FK_Invoice_Employee] FOREIGN KEY ([EmpID]) REFERENCES [Employee] ([EmpID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [FK_Invoice_Customers] FOREIGN KEY ([CusID]) REFERENCES [Customers] ([CusID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table InvoiceDetail
-- ----------------------------
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [FK_InvoiceDetail_Product] FOREIGN KEY ([PID]) REFERENCES [Product] ([PID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY ([InvoiceNo]) REFERENCES [Invoice] ([InvoiceNo]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table Product
-- ----------------------------
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [FK_Product_Model] FOREIGN KEY ([MID]) REFERENCES [Model] ([MID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Product] ADD CONSTRAINT [FK_Product_Phone_Type] FOREIGN KEY ([PTypeID]) REFERENCES [Phone_Type] ([PTypeID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Product] ADD CONSTRAINT [FK_Product_Type] FOREIGN KEY ([TID]) REFERENCES [Type] ([TID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Purchase
-- ----------------------------
ALTER TABLE [dbo].[Purchase] ADD CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY ([SuID]) REFERENCES [Supplier] ([SuID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Purchase] ADD CONSTRAINT [FK_Purchase_Employee] FOREIGN KEY ([EmpID]) REFERENCES [Employee] ([EmpID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PurchaseDetail
-- ----------------------------
ALTER TABLE [dbo].[PurchaseDetail] ADD CONSTRAINT [FK_PurchaseDetail_Product] FOREIGN KEY ([PID]) REFERENCES [Product] ([PID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[PurchaseDetail] ADD CONSTRAINT [FK_PurchaseDetail_Purchase] FOREIGN KEY ([PurID]) REFERENCES [Purchase] ([PurID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

