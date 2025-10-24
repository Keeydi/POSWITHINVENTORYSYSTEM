-- Create PendingTransactions Table for POS System
-- This table stores transactions that are pending completion

USE [POSWITHINVENTORY]
GO

-- Drop table if it exists
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PendingTransactions]') AND type in (N'U'))
DROP TABLE [dbo].[PendingTransactions]
GO

-- Create PendingTransactions table
CREATE TABLE [dbo].[PendingTransactions](
    [PendingID] [int] IDENTITY(1,1) NOT NULL,
    [TransactionNumber] [nvarchar](50) NOT NULL,
    [EmployeeID] [int] NULL,
    [EmployeeName] [nvarchar](100) NULL,
    [CustomerName] [nvarchar](100) NULL,
    [TransactionDate] [date] NOT NULL,
    [TransactionTime] [time](7) NOT NULL,
    [TotalAmount] [decimal](18, 2) NOT NULL,
    [ItemsData] [nvarchar](max) NULL,
    [Status] [nvarchar](20) NOT NULL DEFAULT 'PENDING',
    [CreatedDate] [datetime] NOT NULL DEFAULT GETDATE(),
    [UpdatedDate] [datetime] NULL,
    [Notes] [nvarchar](500) NULL,
    CONSTRAINT [PK_PendingTransactions] PRIMARY KEY CLUSTERED ([PendingID] ASC)
)
GO

-- Create indexes for better performance
CREATE NONCLUSTERED INDEX [IX_PendingTransactions_TransactionNumber] ON [dbo].[PendingTransactions]
(
    [TransactionNumber] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_PendingTransactions_Status] ON [dbo].[PendingTransactions]
(
    [Status] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_PendingTransactions_TransactionDate] ON [dbo].[PendingTransactions]
(
    [TransactionDate] ASC
)
GO

-- Insert sample pending transactions for testing
INSERT INTO [dbo].[PendingTransactions] 
([TransactionNumber], [EmployeeID], [EmployeeName], [CustomerName], [TransactionDate], [TransactionTime], [TotalAmount], [ItemsData], [Status], [Notes])
VALUES
('PEND-20251025-001', 1, 'John Admin', 'Walk-in Customer', '2025-10-25', '10:30:00', 150.75, 
 '[{"Product":"Motor Oil 5W-30","Qty":2,"Price":35.00,"Total":70.00},{"Product":"Oil Filter","Qty":1,"Price":15.75,"Total":15.75},{"Product":"Air Filter","Qty":1,"Price":65.00,"Total":65.00}]', 
 'PENDING', 'Customer requested to hold transaction'),

('PEND-20251025-002', 2, 'Jane Employee', 'Regular Customer', '2025-10-25', '11:15:00', 89.50, 
 '[{"Product":"Spark Plugs","Qty":4,"Price":12.50,"Total":50.00},{"Product":"Brake Fluid","Qty":1,"Price":39.50,"Total":39.50}]', 
 'PENDING', 'Customer went to ATM for cash'),

('PEND-20251025-003', 1, 'John Admin', 'Corporate Client', '2025-10-25', '12:00:00', 450.00, 
 '[{"Product":"Premium Motor Oil","Qty":10,"Price":45.00,"Total":450.00}]', 
 'PENDING', 'Corporate account - awaiting approval'),

('PEND-20251025-004', 3, 'Mike Manager', 'VIP Customer', '2025-10-25', '13:30:00', 275.25, 
 '[{"Product":"Transmission Fluid","Qty":3,"Price":25.00,"Total":75.00},{"Product":"Coolant","Qty":2,"Price":30.00,"Total":60.00},{"Product":"Power Steering Fluid","Qty":2,"Price":35.00,"Total":70.00},{"Product":"Battery","Qty":1,"Price":70.25,"Total":70.25}]', 
 'PENDING', 'VIP customer - special pricing applied'),

('PEND-20251025-005', 2, 'Jane Employee', 'New Customer', '2025-10-25', '14:45:00', 125.00, 
 '[{"Product":"Engine Cleaner","Qty":1,"Price":45.00,"Total":45.00},{"Product":"Fuel Additive","Qty":2,"Price":25.00,"Total":50.00},{"Product":"Tire Shine","Qty":1,"Price":30.00,"Total":30.00}]', 
 'PENDING', 'New customer - first time purchase')

GO

-- Create a view for easy querying of pending transactions
CREATE VIEW [dbo].[vw_PendingTransactions] AS
SELECT 
    pt.PendingID,
    pt.TransactionNumber,
    pt.EmployeeID,
    pt.EmployeeName,
    pt.CustomerName,
    pt.TransactionDate,
    pt.TransactionTime,
    pt.TotalAmount,
    pt.ItemsData,
    pt.Status,
    pt.CreatedDate,
    pt.UpdatedDate,
    pt.Notes,
    DATEDIFF(MINUTE, CAST(pt.TransactionDate AS DATETIME) + CAST(pt.TransactionTime AS DATETIME), GETDATE()) AS MinutesPending
FROM [dbo].[PendingTransactions] pt
WHERE pt.Status = 'PENDING'
GO

-- Create stored procedure to add a new pending transaction
CREATE PROCEDURE [dbo].[sp_AddPendingTransaction]
    @TransactionNumber NVARCHAR(50),
    @EmployeeID INT = NULL,
    @EmployeeName NVARCHAR(100) = NULL,
    @CustomerName NVARCHAR(100) = NULL,
    @TotalAmount DECIMAL(18,2),
    @ItemsData NVARCHAR(MAX) = NULL,
    @Notes NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO [dbo].[PendingTransactions] 
    ([TransactionNumber], [EmployeeID], [EmployeeName], [CustomerName], [TransactionDate], [TransactionTime], [TotalAmount], [ItemsData], [Status], [Notes])
    VALUES 
    (@TransactionNumber, @EmployeeID, @EmployeeName, @CustomerName, CAST(GETDATE() AS DATE), CAST(GETDATE() AS TIME), @TotalAmount, @ItemsData, 'PENDING', @Notes)
    
    SELECT SCOPE_IDENTITY() AS NewPendingID
END
GO

-- Create stored procedure to complete a pending transaction
CREATE PROCEDURE [dbo].[sp_CompletePendingTransaction]
    @PendingID INT,
    @NewTransactionNumber NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[PendingTransactions] 
    SET 
        [Status] = 'COMPLETED',
        [UpdatedDate] = GETDATE(),
        [TransactionNumber] = ISNULL(@NewTransactionNumber, [TransactionNumber])
    WHERE [PendingID] = @PendingID
    
    SELECT @@ROWCOUNT AS RowsAffected
END
GO

-- Create stored procedure to cancel a pending transaction
CREATE PROCEDURE [dbo].[sp_CancelPendingTransaction]
    @PendingID INT,
    @Notes NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[PendingTransactions] 
    SET 
        [Status] = 'CANCELLED',
        [UpdatedDate] = GETDATE(),
        [Notes] = ISNULL(@Notes, [Notes])
    WHERE [PendingID] = @PendingID
    
    SELECT @@ROWCOUNT AS RowsAffected
END
GO

-- Create stored procedure to get pending transactions
CREATE PROCEDURE [dbo].[sp_GetPendingTransactions]
    @EmployeeID INT = NULL,
    @Status NVARCHAR(20) = 'PENDING'
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        pt.PendingID,
        pt.TransactionNumber,
        pt.EmployeeID,
        pt.EmployeeName,
        pt.CustomerName,
        pt.TransactionDate,
        pt.TransactionTime,
        pt.TotalAmount,
        pt.ItemsData,
        pt.Status,
        pt.CreatedDate,
        pt.UpdatedDate,
        pt.Notes,
        DATEDIFF(MINUTE, CAST(pt.TransactionDate AS DATETIME) + CAST(pt.TransactionTime AS DATETIME), GETDATE()) AS MinutesPending
    FROM [dbo].[PendingTransactions] pt
    WHERE (@EmployeeID IS NULL OR pt.EmployeeID = @EmployeeID)
      AND (@Status IS NULL OR pt.Status = @Status)
    ORDER BY pt.CreatedDate DESC
END
GO

PRINT 'PendingTransactions table and related objects created successfully!'
PRINT 'Sample data inserted for testing.'
PRINT 'Use the stored procedures to manage pending transactions:'
PRINT '- sp_AddPendingTransaction: Add new pending transaction'
PRINT '- sp_CompletePendingTransaction: Mark transaction as completed'
PRINT '- sp_CancelPendingTransaction: Cancel a pending transaction'
PRINT '- sp_GetPendingTransactions: Retrieve pending transactions'
