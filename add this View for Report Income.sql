Create VIEW [dbo].[viewInvoiceWeekly] AS 
 select Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date,convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date,sum(TotalPrice)  from Invoice group BY YEAR(Date),MONTH(date),DATEPART(ww, date)
GO

