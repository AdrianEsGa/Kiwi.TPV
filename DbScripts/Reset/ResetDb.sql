delete from SaleDetails
delete from Sales
DBCC CHECKIDENT ('SaleDetails', RESEED, 0);  
DBCC CHECKIDENT ('Sales', RESEED, 0);  

delete from JokeSaleDetails
delete from JokeSales
DBCC CHECKIDENT ('JokeSaleDetails', RESEED, 0);  
DBCC CHECKIDENT ('JokeSales', RESEED, 0);  


delete from CommandDetails
delete from Commands
DBCC CHECKIDENT ('CommandDetails', RESEED, 0);  
DBCC CHECKIDENT ('Commands', RESEED, 0);  


--delete from BarTables
--DBCC CHECKIDENT ('BarTables', RESEED, 0);  


--delete from Employees
--DBCC CHECKIDENT ('Employees', RESEED, 0);  
