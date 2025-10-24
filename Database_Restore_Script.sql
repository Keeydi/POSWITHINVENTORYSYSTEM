-- =============================================
-- Database Restore Script for POS System
-- Database: MYDB
-- Server: DESKTOP-GB785JE\SQLEXPRESS01
-- =============================================

-- IMPORTANT: Before running this script, make sure to:
-- 1. Stop all applications using the database
-- 2. Backup current database if needed
-- 3. Update the backup file path below

-- =============================================
-- Restore Full Database Backup
-- =============================================

-- Step 1: Set the backup file path (UPDATE THIS PATH)
DECLARE @BackupFilePath NVARCHAR(500) = 'C:\Backup\MYDB_Full_Backup_20241201_143000.bak'

-- Step 2: Check if backup file exists
IF NOT EXISTS (SELECT * FROM sys.dm_os_file_exists(@BackupFilePath))
BEGIN
    PRINT 'ERROR: Backup file does not exist at: ' + @BackupFilePath
    PRINT 'Please update the @BackupFilePath variable with the correct path'
    RETURN
END

-- Step 3: Get backup file information
RESTORE FILELISTONLY FROM DISK = @BackupFilePath

-- Step 4: Restore the database
RESTORE DATABASE [MYDB] 
FROM DISK = @BackupFilePath
WITH 
    REPLACE,
    MOVE 'MYDB' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\MYDB.mdf',
    MOVE 'MYDB_Log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\MYDB_Log.ldf',
    STATS = 10;

PRINT 'Database restore completed successfully!'

-- =============================================
-- Restore Individual Tables (Alternative Method)
-- =============================================

-- If you have individual table backups, you can restore them like this:

/*
-- Restore Users Table
INSERT INTO [MYDB].[dbo].[Users]
SELECT * FROM [MYDB].[dbo].[MYDB_Users_Backup];

-- Restore Employees Table
INSERT INTO [MYDB].[dbo].[Employees]
SELECT * FROM [MYDB].[dbo].[MYDB_Employees_Backup];

-- Restore Products Table
INSERT INTO [MYDB].[dbo].[Products]
SELECT * FROM [MYDB].[dbo].[MYDB_Products_Backup];

-- Restore Categories Table
INSERT INTO [MYDB].[dbo].[Categories]
SELECT * FROM [MYDB].[dbo].[MYDB_Categories_Backup];

-- Restore Inventory Table
INSERT INTO [MYDB].[dbo].[Inventory]
SELECT * FROM [MYDB].[dbo].[MYDB_Inventory_Backup];

-- Restore Transactions Table
INSERT INTO [MYDB].[dbo].[Transactions]
SELECT * FROM [MYDB].[dbo].[MYDB_Transactions_Backup];

-- Restore Transaction_Items Table
INSERT INTO [MYDB].[dbo].[Transaction_Items]
SELECT * FROM [MYDB].[dbo].[MYDB_Transaction_Items_Backup];

-- Restore Stock_In Table
INSERT INTO [MYDB].[dbo].[Stock_In]
SELECT * FROM [MYDB].[dbo].[MYDB_Stock_In_Backup];

-- Restore Defects Table
INSERT INTO [MYDB].[dbo].[Defects]
SELECT * FROM [MYDB].[dbo].[MYDB_Defects_Backup];

-- Restore Pending_Transactions Table
INSERT INTO [MYDB].[dbo].[Pending_Transactions]
SELECT * FROM [MYDB].[dbo].[MYDB_Pending_Transactions_Backup];

-- Restore User_Logs Table
INSERT INTO [MYDB].[dbo].[User_Logs]
SELECT * FROM [MYDB].[dbo].[MYDB_User_Logs_Backup];
*/

-- =============================================
-- Verification After Restore
-- =============================================

-- Check table row counts after restore
SELECT 'Users' as TableName, COUNT(*) as RowCount FROM [MYDB].[dbo].[Users]
UNION ALL
SELECT 'Employees', COUNT(*) FROM [MYDB].[dbo].[Employees]
UNION ALL
SELECT 'Products', COUNT(*) FROM [MYDB].[dbo].[Products]
UNION ALL
SELECT 'Categories', COUNT(*) FROM [MYDB].[dbo].[Categories]
UNION ALL
SELECT 'Inventory', COUNT(*) FROM [MYDB].[dbo].[Inventory]
UNION ALL
SELECT 'Transactions', COUNT(*) FROM [MYDB].[dbo].[Transactions]
UNION ALL
SELECT 'Transaction_Items', COUNT(*) FROM [MYDB].[dbo].[Transaction_Items]
UNION ALL
SELECT 'Stock_In', COUNT(*) FROM [MYDB].[dbo].[Stock_In]
UNION ALL
SELECT 'Defects', COUNT(*) FROM [MYDB].[dbo].[Defects]
UNION ALL
SELECT 'Pending_Transactions', COUNT(*) FROM [MYDB].[dbo].[Pending_Transactions]
UNION ALL
SELECT 'User_Logs', COUNT(*) FROM [MYDB].[dbo].[User_Logs];

-- =============================================
-- Clean Up Backup Tables (Optional)
-- =============================================

-- Uncomment the following lines to remove backup tables after successful restore:

/*
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Users_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Employees_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Products_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Categories_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Inventory_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Transactions_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Transaction_Items_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Stock_In_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Defects_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_Pending_Transactions_Backup];
DROP TABLE IF EXISTS [MYDB].[dbo].[MYDB_User_Logs_Backup];
*/

PRINT 'Restore script completed successfully!';
