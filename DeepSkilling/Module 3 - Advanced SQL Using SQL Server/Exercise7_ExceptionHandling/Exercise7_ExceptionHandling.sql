USE AdvancedSQLDB;
GO

BEGIN TRY
    BEGIN TRANSACTION;

    INSERT INTO Customers
    VALUES
    (
        1,
        'Duplicate Customer',
        'North'
    );

    COMMIT TRANSACTION;
END TRY

BEGIN CATCH
    ROLLBACK TRANSACTION;

    PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR);

    PRINT 'Error Message: ' + ERROR_MESSAGE();
END CATCH;