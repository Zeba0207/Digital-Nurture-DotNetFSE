USE AdvancedSQLDB;
GO

BEGIN TRANSACTION;

UPDATE Products
SET Price = Price + 500
WHERE ProductID = 1;

UPDATE Products
SET Price = Price + 1000
WHERE ProductID = 2;

COMMIT TRANSACTION;

SELECT ProductID,
       ProductName,
       Price
FROM Products
WHERE ProductID IN (1,2);