-- =====================================================
-- POPULATE DATABASE WITH SAMPLE PENDING TRANSACTIONS
-- =====================================================
-- This script creates sample pending transactions for testing the POS system

USE MYDB;
GO

-- =====================================================
-- 1. ENSURE SAMPLE PRODUCTS EXIST
-- =====================================================

-- Insert sample categories if they don't exist
IF NOT EXISTS (SELECT * FROM Category WHERE CategoryName = 'Motor Oil')
BEGIN
    INSERT INTO Category (CategoryName, isArchived) VALUES ('Motor Oil', 0);
END

IF NOT EXISTS (SELECT * FROM Category WHERE CategoryName = 'Brake Parts')
BEGIN
    INSERT INTO Category (CategoryName, isArchived) VALUES ('Brake Parts', 0);
END

IF NOT EXISTS (SELECT * FROM Category WHERE CategoryName = 'Filters')
BEGIN
    INSERT INTO Category (CategoryName, isArchived) VALUES ('Filters', 0);
END

IF NOT EXISTS (SELECT * FROM Category WHERE CategoryName = 'Spark Plugs')
BEGIN
    INSERT INTO Category (CategoryName, isArchived) VALUES ('Spark Plugs', 0);
END

IF NOT EXISTS (SELECT * FROM Category WHERE CategoryName = 'Belts')
BEGIN
    INSERT INTO Category (CategoryName, isArchived) VALUES ('Belts', 0);
END

-- Get category IDs for reference
DECLARE @MotorOilID INT = (SELECT CategoryID FROM Category WHERE CategoryName = 'Motor Oil');
DECLARE @BrakePartsID INT = (SELECT CategoryID FROM Category WHERE CategoryName = 'Brake Parts');
DECLARE @FiltersID INT = (SELECT CategoryID FROM Category WHERE CategoryName = 'Filters');
DECLARE @SparkPlugsID INT = (SELECT CategoryID FROM Category WHERE CategoryName = 'Spark Plugs');
DECLARE @BeltsID INT = (SELECT CategoryID FROM Category WHERE CategoryName = 'Belts');

-- Insert sample products if they don't exist
IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'MO001')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@MotorOilID, 'MO001', 'Premium Motor Oil 5W-30', 'Shell', 'Synthetic', 'Liters', 50, 25.00, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'MO002')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@MotorOilID, 'MO002', 'Conventional Motor Oil 10W-40', 'Petron', 'Conventional', 'Liters', 30, 18.50, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'BP001')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@BrakePartsID, 'BP001', 'Brake Pad Set Front', 'Brembo', 'Ceramic', 'Per Piece', 20, 45.00, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'BP002')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@BrakePartsID, 'BP002', 'Brake Fluid DOT 4', 'Castrol', 'Synthetic', 'Liters', 25, 12.75, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'FL001')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@FiltersID, 'FL001', 'Air Filter', 'K&N', 'High Flow', 'Per Piece', 15, 35.00, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'FL002')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@FiltersID, 'FL002', 'Oil Filter', 'Fram', 'Standard', 'Per Piece', 40, 8.50, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'SP001')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@SparkPlugsID, 'SP001', 'Spark Plug Iridium', 'NGK', 'Iridium', 'Per Piece', 60, 15.00, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'SP002')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@SparkPlugsID, 'SP002', 'Spark Plug Copper', 'Bosch', 'Copper', 'Per Piece', 80, 6.50, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'BL001')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@BeltsID, 'BL001', 'Timing Belt', 'Gates', 'Rubber', 'Per Piece', 12, 65.00, 0);
END

IF NOT EXISTS (SELECT * FROM Product WHERE ProductCode = 'BL002')
BEGIN
    INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice, isArchived)
    VALUES (@BeltsID, 'BL002', 'Serpentine Belt', 'Continental', 'Rubber', 'Per Piece', 18, 28.50, 0);
END

-- =====================================================
-- 2. CLEAR EXISTING PENDING TRANSACTIONS (OPTIONAL)
-- =====================================================
-- Uncomment the line below if you want to clear existing pending transactions
-- DELETE FROM Pendingsprod;

-- =====================================================
-- 3. CREATE SAMPLE PENDING TRANSACTIONS
-- =====================================================

-- Pending Transaction #1: Customer wants motor oil and filters
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND001', 'MO001', 'Premium Motor Oil 5W-30', 2, 25.00, 50.00),
    ('PEND001', 'FL001', 'Air Filter', 1, 35.00, 35.00),
    ('PEND001', 'FL002', 'Oil Filter', 1, 8.50, 8.50);

-- Pending Transaction #2: Customer wants brake parts
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND002', 'BP001', 'Brake Pad Set Front', 1, 45.00, 45.00),
    ('PEND002', 'BP002', 'Brake Fluid DOT 4', 2, 12.75, 25.50);

-- Pending Transaction #3: Customer wants spark plugs and belts
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND003', 'SP001', 'Spark Plug Iridium', 4, 15.00, 60.00),
    ('PEND003', 'BL001', 'Timing Belt', 1, 65.00, 65.00),
    ('PEND003', 'BL002', 'Serpentine Belt', 1, 28.50, 28.50);

-- Pending Transaction #4: Customer wants conventional oil and copper spark plugs
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND004', 'MO002', 'Conventional Motor Oil 10W-40', 3, 18.50, 55.50),
    ('PEND004', 'SP002', 'Spark Plug Copper', 6, 6.50, 39.00);

-- Pending Transaction #5: Customer wants multiple items for maintenance
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND005', 'MO001', 'Premium Motor Oil 5W-30', 1, 25.00, 25.00),
    ('PEND005', 'FL002', 'Oil Filter', 2, 8.50, 17.00),
    ('PEND005', 'SP001', 'Spark Plug Iridium', 2, 15.00, 30.00),
    ('PEND005', 'BP002', 'Brake Fluid DOT 4', 1, 12.75, 12.75);

-- Pending Transaction #6: Customer wants brake service parts
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND006', 'BP001', 'Brake Pad Set Front', 2, 45.00, 90.00),
    ('PEND006', 'BP002', 'Brake Fluid DOT 4', 1, 12.75, 12.75),
    ('PEND006', 'FL001', 'Air Filter', 1, 35.00, 35.00);

-- Pending Transaction #7: Customer wants belt replacement
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND007', 'BL001', 'Timing Belt', 1, 65.00, 65.00),
    ('PEND007', 'BL002', 'Serpentine Belt', 1, 28.50, 28.50),
    ('PEND007', 'MO001', 'Premium Motor Oil 5W-30', 1, 25.00, 25.00);

-- Pending Transaction #8: Customer wants spark plug replacement
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND008', 'SP001', 'Spark Plug Iridium', 8, 15.00, 120.00),
    ('PEND008', 'FL002', 'Oil Filter', 1, 8.50, 8.50);

-- Pending Transaction #9: Customer wants mixed items
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND009', 'MO002', 'Conventional Motor Oil 10W-40', 2, 18.50, 37.00),
    ('PEND009', 'SP002', 'Spark Plug Copper', 4, 6.50, 26.00),
    ('PEND009', 'FL001', 'Air Filter', 1, 35.00, 35.00),
    ('PEND009', 'BP002', 'Brake Fluid DOT 4', 1, 12.75, 12.75);

-- Pending Transaction #10: Customer wants premium items
INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal)
VALUES 
    ('PEND010', 'MO001', 'Premium Motor Oil 5W-30', 3, 25.00, 75.00),
    ('PEND010', 'SP001', 'Spark Plug Iridium', 6, 15.00, 90.00),
    ('PEND010', 'FL001', 'Air Filter', 2, 35.00, 70.00);

-- =====================================================
-- 4. VERIFY DATA INSERTION
-- =====================================================

-- Show summary of pending transactions
SELECT 
    TransactionNumber,
    COUNT(*) as ItemCount,
    SUM(SubTotal) as TotalAmount
FROM Pendingsprod 
GROUP BY TransactionNumber 
ORDER BY TransactionNumber;

-- Show all pending transactions
SELECT 
    TransactionNumber,
    ProductCode,
    ProductName,
    Quantity,
    Price,
    SubTotal
FROM Pendingsprod 
ORDER BY TransactionNumber, ProductCode;

SELECT 'Sample pending transactions have been successfully created!' as Status;
SELECT 'Total pending transactions: ' + CAST((SELECT COUNT(DISTINCT TransactionNumber) FROM Pendingsprod) AS VARCHAR(10)) as TransactionCount;
SELECT 'Total pending items: ' + CAST((SELECT COUNT(*) FROM Pendingsprod) AS VARCHAR(10)) as ItemCount;
