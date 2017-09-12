IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewPurchase]') AND type IN ('V'))
	DROP VIEW [dbo].[viewPurchase];

GO

CREATE VIEW viewPurchase
AS
SELECT p.PurCode PurCode,p.Date PurDate,pp.PName ProName,pd.Quantity Quantity,pd.Unitprice,pd.Amount Amount, p.Payment Payment,p.Balance Balance,CONCAT(s.SuLNEN,' ',s.SuFNEN) SupplierName,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) EmployeeName,p.Total
FROM PurchaseDetail pd
INNER JOIN Purchase p
ON pd.PurID = p.PurID
INNER JOIN Product pp
ON pp.PID = pd.PID
INNER JOIN Supplier s
ON p.SuID = s.SuID
INNER JOIN Employee e
ON p.EmpID = e.EmpID;

GO