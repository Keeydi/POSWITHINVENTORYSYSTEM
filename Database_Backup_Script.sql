-- =============================================
-- Database Backup Script for POS System
-- Database: MYDB
-- Server: DESKTOP-GB785JE\SQLEXPRESS01
-- =============================================

-- Full Database Backup
BACKUP DATABASE [MYDB] 
TO DISK = 'C:\Backup\MYDB_Full_Backup_' + CONVERT(VARCHAR(8), GETDATE(), 112) + '_' + REPLACE(CONVERT(VARCHAR(8), GETDATE(), 108), ':', '') + '.bak'
WITH 
    FORMAT,
    INIT,
    NAME = 'MYDB Full Database Backup',
    SKIP,
    NOREWIND,
    NOUNLOAD,
    STATS = 10;

-- =============================================
-- Individual Table Backups (if needed)
-- =============================================

-- Backup Users Table
SELECT * INTO MYDB_Users_Backup FROM [MYDB].[dbo].[Users];

-- Backup Employees Table  
SELECT * INTO MYDB_Employees_Backup FROM [MYDB].[dbo].[Employees];

-- Backup Products Table
SELECT * INTO MYDB_Products_Backup FROM [MYDB].[dbo].[Products];

-- Backup Categories Table
SELECT * INTO MYDB_Categories_Backup FROM [MYDB].[dbo].[Categories];

-- Backup Inventory Table
SELECT * INTO MYDB_Inventory_Backup FROM [MYDB].[dbo].[Inventory];

-- Backup Transactions Table
SELECT * INTO MYDB_Transactions_Backup FROM [MYDB].[dbo].[Transactions];

-- Backup Transaction_Items Table
SELECT * INTO MYDB_Transaction_Items_Backup FROM [MYDB].[dbo].[Transaction_Items];

-- Backup Stock_In Table
SELECT * INTO MYDB_Stock_In_Backup FROM [MYDB].[dbo].[Stock_In];

-- Backup Defects Table
SELECT * INTO MYDB_Defects_Backup FROM [MYDB].[dbo].[Defects];

-- Backup Pending_Transactions Table
SELECT * INTO MYDB_Pending_Transactions_Backup FROM [MYDB].[dbo].[Pending_Transactions];

-- Backup User_Logs Table
SELECT * INTO MYDB_User_Logs_Backup FROM [MYDB].[dbo].[User_Logs];

-- =============================================
-- Export Data to CSV Files (Alternative Method)
-- =============================================

-- Note: To export to CSV, you would need to use SQL Server Management Studio
-- or PowerShell scripts. Here are the table names to export:

/*
Tables to Export:
1. Users
2. Employees  
3. Products
4. Categories
5. Inventory
6. Transactions
7. Transaction_Items
8. Stock_In
9. Defects
10. Pending_Transactions
11. User_Logs
*/

-- =============================================
-- Verification Queries
-- =============================================

-- Check table row counts
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
-- Create Backup Directory (Run this first)
-- =============================================

-- Create backup directory if it doesn't exist
-- EXEC xp_create_subdir 'C:\Backup'

PRINT 'Backup script completed successfully!';
PRINT 'Backup file location: C:\Backup\MYDB_Full_Backup_[timestamp].bak';
PRINT 'Individual table backups created in the same database with _Backup suffix';
