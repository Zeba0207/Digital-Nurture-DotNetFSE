USE AdvancedSQLDB;
GO

WITH Calendar AS
(
    SELECT CAST('2025-01-01' AS DATE) AS CalendarDate

    UNION ALL

    SELECT DATEADD(DAY, 1, CalendarDate)
    FROM Calendar
    WHERE CalendarDate < '2025-01-31'
)

SELECT *
FROM Calendar
OPTION (MAXRECURSION 31);




SELECT * FROM StagingProducts;

MERGE Products AS Target
USING StagingProducts AS Source
ON Target.ProductID = Source.ProductID

WHEN MATCHED THEN
UPDATE SET
    Target.ProductName = Source.ProductName,
    Target.Category = Source.Category,
    Target.Price = Source.Price

WHEN NOT MATCHED THEN
INSERT (ProductID, ProductName, Category, Price)
VALUES
(
    Source.ProductID,
    Source.ProductName,
    Source.Category,
    Source.Price
);

SELECT *
FROM Products;