-- Generate 50 Pending Transactions for POS System
-- This script creates realistic pending transactions with various scenarios

USE [POSWITHINVENTORY]
GO

-- Clear existing pending transactions (optional - remove if you want to keep existing data)
-- DELETE FROM [dbo].[PendingTransactions]
-- GO

-- Insert 50 pending transactions with realistic data
INSERT INTO [dbo].[PendingTransactions] 
([TransactionNumber], [EmployeeID], [EmployeeName], [CustomerName], [TransactionDate], [TransactionTime], [TotalAmount], [ItemsData], [Status], [Notes])
VALUES

-- Transactions 1-10: Regular customers with various items
('PEND-20251025-001', 1, 'John Admin', 'Maria Santos', '2025-10-25', '08:30:00', 125.50, 
 '[{"Product":"Motor Oil 5W-30","Qty":2,"Price":35.00,"Total":70.00},{"Product":"Oil Filter","Qty":1,"Price":15.50,"Total":15.50},{"Product":"Air Filter","Qty":1,"Price":40.00,"Total":40.00}]', 
 'PENDING', 'Customer requested to hold transaction - went to ATM'),

('PEND-20251025-002', 2, 'Jane Employee', 'Carlos Rodriguez', '2025-10-25', '09:15:00', 89.75, 
 '[{"Product":"Spark Plugs","Qty":4,"Price":12.50,"Total":50.00},{"Product":"Brake Fluid","Qty":1,"Price":39.75,"Total":39.75}]', 
 'PENDING', 'Customer checking with mechanic'),

('PEND-20251025-003', 3, 'Mike Manager', 'Ana Garcia', '2025-10-25', '10:00:00', 245.00, 
 '[{"Product":"Premium Motor Oil","Qty":5,"Price":45.00,"Total":225.00},{"Product":"Fuel Additive","Qty":1,"Price":20.00,"Total":20.00}]', 
 'PENDING', 'Corporate account - awaiting approval'),

('PEND-20251025-004', 1, 'John Admin', 'Roberto Lopez', '2025-10-25', '10:45:00', 156.25, 
 '[{"Product":"Transmission Fluid","Qty":3,"Price":25.00,"Total":75.00},{"Product":"Coolant","Qty":2,"Price":30.00,"Total":60.00},{"Product":"Power Steering Fluid","Qty":1,"Price":21.25,"Total":21.25}]', 
 'PENDING', 'Customer comparing prices'),

('PEND-20251025-005', 2, 'Jane Employee', 'Sofia Martinez', '2025-10-25', '11:30:00', 78.50, 
 '[{"Product":"Engine Cleaner","Qty":1,"Price":45.00,"Total":45.00},{"Product":"Tire Shine","Qty":1,"Price":33.50,"Total":33.50}]', 
 'PENDING', 'New customer - first time purchase'),

('PEND-20251025-006', 3, 'Mike Manager', 'Jose Hernandez', '2025-10-25', '12:15:00', 320.00, 
 '[{"Product":"Battery","Qty":1,"Price":280.00,"Total":280.00},{"Product":"Battery Terminal Cleaner","Qty":1,"Price":40.00,"Total":40.00}]', 
 'PENDING', 'VIP customer - special pricing applied'),

('PEND-20251025-007', 1, 'John Admin', 'Carmen Flores', '2025-10-25', '13:00:00', 95.00, 
 '[{"Product":"Windshield Washer Fluid","Qty":2,"Price":15.00,"Total":30.00},{"Product":"Antifreeze","Qty":2,"Price":32.50,"Total":65.00}]', 
 'PENDING', 'Customer went to get cash'),

('PEND-20251025-008', 2, 'Jane Employee', 'Miguel Torres', '2025-10-25', '13:45:00', 180.75, 
 '[{"Product":"Brake Pads","Qty":1,"Price":120.00,"Total":120.00},{"Product":"Brake Rotor","Qty":1,"Price":60.75,"Total":60.75}]', 
 'PENDING', 'Customer checking vehicle compatibility'),

('PEND-20251025-009', 3, 'Mike Manager', 'Isabel Cruz', '2025-10-25', '14:30:00', 67.25, 
 '[{"Product":"Air Freshener","Qty":3,"Price":8.50,"Total":25.50},{"Product":"Dashboard Cleaner","Qty":1,"Price":41.75,"Total":41.75}]', 
 'PENDING', 'Customer requesting additional items'),

('PEND-20251025-010', 1, 'John Admin', 'Fernando Ramos', '2025-10-25', '15:15:00', 210.50, 
 '[{"Product":"Timing Belt","Qty":1,"Price":150.00,"Total":150.00},{"Product":"Water Pump","Qty":1,"Price":60.50,"Total":60.50}]', 
 'PENDING', 'Customer consulting with mechanic'),

-- Transactions 11-20: Bulk orders and corporate clients
('PEND-20251025-011', 2, 'Jane Employee', 'ABC Transport Corp', '2025-10-25', '16:00:00', 450.00, 
 '[{"Product":"Motor Oil 15W-40","Qty":10,"Price":45.00,"Total":450.00}]', 
 'PENDING', 'Corporate account - bulk order'),

('PEND-20251025-012', 3, 'Mike Manager', 'Pedro Silva', '2025-10-25', '16:45:00', 135.75, 
 '[{"Product":"Fuel Filter","Qty":2,"Price":25.00,"Total":50.00},{"Product":"Air Filter","Qty":3,"Price":28.58,"Total":85.75}]', 
 'PENDING', 'Customer checking inventory'),

('PEND-20251025-013', 1, 'John Admin', 'Rosa Mendez', '2025-10-25', '17:30:00', 89.00, 
 '[{"Product":"Transmission Filter","Qty":1,"Price":35.00,"Total":35.00},{"Product":"Gear Oil","Qty":2,"Price":27.00,"Total":54.00}]', 
 'PENDING', 'Customer went to ATM'),

('PEND-20251025-014', 2, 'Jane Employee', 'Luis Vargas', '2025-10-25', '18:15:00', 275.25, 
 '[{"Product":"Clutch Kit","Qty":1,"Price":220.00,"Total":220.00},{"Product":"Clutch Fluid","Qty":1,"Price":55.25,"Total":55.25}]', 
 'PENDING', 'Customer checking vehicle model'),

('PEND-20251025-015', 3, 'Mike Manager', 'Elena Ruiz', '2025-10-25', '19:00:00', 145.50, 
 '[{"Product":"Power Steering Pump","Qty":1,"Price":125.00,"Total":125.00},{"Product":"Power Steering Hose","Qty":1,"Price":20.50,"Total":20.50}]', 
 'PENDING', 'Customer consulting technician'),

('PEND-20251025-016', 1, 'John Admin', 'Diego Morales', '2025-10-25', '19:45:00', 98.75, 
 '[{"Product":"Radiator Cap","Qty":1,"Price":15.00,"Total":15.00},{"Product":"Thermostat","Qty":1,"Price":25.00,"Total":25.00},{"Product":"Coolant Hose","Qty":2,"Price":29.38,"Total":58.75}]', 
 'PENDING', 'Customer checking part numbers'),

('PEND-20251025-017', 2, 'Jane Employee', 'Patricia Herrera', '2025-10-25', '20:30:00', 165.00, 
 '[{"Product":"Alternator","Qty":1,"Price":140.00,"Total":140.00},{"Product":"Alternator Belt","Qty":1,"Price":25.00,"Total":25.00}]', 
 'PENDING', 'Customer verifying compatibility'),

('PEND-20251025-018', 3, 'Mike Manager', 'Ricardo Jimenez', '2025-10-25', '21:15:00', 78.50, 
 '[{"Product":"Starter Motor","Qty":1,"Price":65.00,"Total":65.00},{"Product":"Starter Solenoid","Qty":1,"Price":13.50,"Total":13.50}]', 
 'PENDING', 'Customer checking warranty'),

('PEND-20251025-019', 1, 'John Admin', 'Monica Castillo', '2025-10-25', '22:00:00', 112.25, 
 '[{"Product":"Ignition Coil","Qty":2,"Price":35.00,"Total":70.00},{"Product":"Spark Plug Wires","Qty":1,"Price":42.25,"Total":42.25}]', 
 'PENDING', 'Customer went to get cash'),

('PEND-20251025-020', 2, 'Jane Employee', 'Antonio Rojas', '2025-10-25', '22:45:00', 195.75, 
 '[{"Product":"Fuel Pump","Qty":1,"Price":150.00,"Total":150.00},{"Product":"Fuel Line","Qty":1,"Price":45.75,"Total":45.75}]', 
 'PENDING', 'Customer checking installation'),

-- Transactions 21-30: Mixed scenarios and special cases
('PEND-20251025-021', 3, 'Mike Manager', 'Walk-in Customer', '2025-10-25', '23:30:00', 45.50, 
 '[{"Product":"Windshield Wiper Blades","Qty":2,"Price":12.50,"Total":25.00},{"Product":"Headlight Bulbs","Qty":2,"Price":10.25,"Total":20.50}]', 
 'PENDING', 'Customer comparing with other stores'),

('PEND-20251025-022', 1, 'John Admin', 'Gabriela Pena', '2025-10-26', '08:00:00', 89.25, 
 '[{"Product":"Cabin Air Filter","Qty":1,"Price":35.00,"Total":35.00},{"Product":"Engine Air Filter","Qty":1,"Price":54.25,"Total":54.25}]', 
 'PENDING', 'Customer checking vehicle manual'),

('PEND-20251025-023', 2, 'Jane Employee', 'Hector Mendoza', '2025-10-26', '08:45:00', 156.00, 
 '[{"Product":"Brake Caliper","Qty":1,"Price":120.00,"Total":120.00},{"Product":"Brake Line","Qty":1,"Price":36.00,"Total":36.00}]', 
 'PENDING', 'Customer verifying part fitment'),

('PEND-20251025-024', 3, 'Mike Manager', 'Valeria Ortega', '2025-10-26', '09:30:00', 78.75, 
 '[{"Product":"Shock Absorber","Qty":1,"Price":65.00,"Total":65.00},{"Product":"Strut Mount","Qty":1,"Price":13.75,"Total":13.75}]', 
 'PENDING', 'Customer checking suspension'),

('PEND-20251025-025', 1, 'John Admin', 'Oscar Delgado', '2025-10-26', '10:15:00', 234.50, 
 '[{"Product":"CV Joint","Qty":2,"Price":85.00,"Total":170.00},{"Product":"CV Boot","Qty":2,"Price":32.25,"Total":64.50}]', 
 'PENDING', 'Customer checking axle'),

('PEND-20251025-026', 2, 'Jane Employee', 'Natalia Vega', '2025-10-26', '11:00:00', 67.25, 
 '[{"Product":"Wheel Bearing","Qty":1,"Price":45.00,"Total":45.00},{"Product":"Hub Assembly","Qty":1,"Price":22.25,"Total":22.25}]', 
 'PENDING', 'Customer went to ATM'),

('PEND-20251025-027', 3, 'Mike Manager', 'Sebastian Aguilar', '2025-10-26', '11:45:00', 145.75, 
 '[{"Product":"Tie Rod End","Qty":2,"Price":35.00,"Total":70.00},{"Product":"Ball Joint","Qty":2,"Price":37.88,"Total":75.75}]', 
 'PENDING', 'Customer checking alignment'),

('PEND-20251025-028', 1, 'John Admin', 'Camila Sandoval', '2025-10-26', '12:30:00', 98.50, 
 '[{"Product":"Control Arm","Qty":1,"Price":75.00,"Total":75.00},{"Product":"Control Arm Bushing","Qty":1,"Price":23.50,"Total":23.50}]', 
 'PENDING', 'Customer verifying suspension'),

('PEND-20251025-029', 2, 'Jane Employee', 'Andres Guerrero', '2025-10-26', '13:15:00', 178.25, 
 '[{"Product":"Sway Bar Link","Qty":2,"Price":25.00,"Total":50.00},{"Product":"Sway Bar Bushing","Qty":2,"Price":64.13,"Total":128.25}]', 
 'PENDING', 'Customer checking handling'),

('PEND-20251025-030', 3, 'Mike Manager', 'Lucia Navarro', '2025-10-26', '14:00:00', 89.75, 
 '[{"Product":"Engine Mount","Qty":1,"Price":65.00,"Total":65.00},{"Product":"Transmission Mount","Qty":1,"Price":24.75,"Total":24.75}]', 
 'PENDING', 'Customer checking vibration'),

-- Transactions 31-40: High-value transactions and special orders
('PEND-20251025-031', 1, 'John Admin', 'Fleet Management Inc', '2025-10-26', '14:45:00', 850.00, 
 '[{"Product":"Motor Oil 10W-30","Qty":20,"Price":42.50,"Total":850.00}]', 
 'PENDING', 'Fleet account - bulk order'),

('PEND-20251025-032', 2, 'Jane Employee', 'Roberto Silva', '2025-10-26', '15:30:00', 125.25, 
 '[{"Product":"Turbocharger","Qty":1,"Price":95.00,"Total":95.00},{"Product":"Turbo Gasket","Qty":1,"Price":30.25,"Total":30.25}]', 
 'PENDING', 'Customer checking turbo'),

('PEND-20251025-033', 3, 'Mike Manager', 'Elena Rodriguez', '2025-10-26', '16:15:00', 67.50, 
 '[{"Product":"EGR Valve","Qty":1,"Price":45.00,"Total":45.00},{"Product":"EGR Gasket","Qty":1,"Price":22.50,"Total":22.50}]', 
 'PENDING', 'Customer checking emissions'),

('PEND-20251025-034', 1, 'John Admin', 'Carlos Mendez', '2025-10-26', '17:00:00', 156.75, 
 '[{"Product":"Catalytic Converter","Qty":1,"Price":120.00,"Total":120.00},{"Product":"O2 Sensor","Qty":1,"Price":36.75,"Total":36.75}]', 
 'PENDING', 'Customer checking emissions'),

('PEND-20251025-035', 2, 'Jane Employee', 'Ana Herrera', '2025-10-26', '17:45:00', 89.25, 
 '[{"Product":"PCV Valve","Qty":1,"Price":25.00,"Total":25.00},{"Product":"PCV Hose","Qty":1,"Price":64.25,"Total":64.25}]', 
 'PENDING', 'Customer checking engine'),

('PEND-20251025-036', 3, 'Mike Manager', 'Miguel Torres', '2025-10-26', '18:30:00', 234.50, 
 '[{"Product":"Intake Manifold","Qty":1,"Price":180.00,"Total":180.00},{"Product":"Intake Gasket","Qty":1,"Price":54.50,"Total":54.50}]', 
 'PENDING', 'Customer checking intake'),

('PEND-20251025-037', 1, 'John Admin', 'Sofia Cruz', '2025-10-26', '19:15:00', 78.75, 
 '[{"Product":"Exhaust Manifold","Qty":1,"Price":65.00,"Total":65.00},{"Product":"Exhaust Gasket","Qty":1,"Price":13.75,"Total":13.75}]', 
 'PENDING', 'Customer checking exhaust'),

('PEND-20251025-038', 2, 'Jane Employee', 'Jose Martinez', '2025-10-26', '20:00:00', 145.25, 
 '[{"Product":"Camshaft","Qty":1,"Price":120.00,"Total":120.00},{"Product":"Camshaft Seal","Qty":1,"Price":25.25,"Total":25.25}]', 
 'PENDING', 'Customer checking timing'),

('PEND-20251025-039', 3, 'Mike Manager', 'Carmen Flores', '2025-10-26', '20:45:00', 98.50, 
 '[{"Product":"Crankshaft Seal","Qty":1,"Price":35.00,"Total":35.00},{"Product":"Rear Main Seal","Qty":1,"Price":63.50,"Total":63.50}]', 
 'PENDING', 'Customer checking seals'),

('PEND-20251025-040', 1, 'John Admin', 'Fernando Ramos', '2025-10-26', '21:30:00', 167.75, 
 '[{"Product":"Timing Chain","Qty":1,"Price":125.00,"Total":125.00},{"Product":"Timing Tensioner","Qty":1,"Price":42.75,"Total":42.75}]', 
 'PENDING', 'Customer checking timing'),

-- Transactions 41-50: Final batch with various scenarios
('PEND-20251025-041', 2, 'Jane Employee', 'Isabel Cruz', '2025-10-26', '22:15:00', 56.25, 
 '[{"Product":"Valve Cover Gasket","Qty":1,"Price":35.00,"Total":35.00},{"Product":"Valve Cover Bolts","Qty":1,"Price":21.25,"Total":21.25}]', 
 'PENDING', 'Customer checking valve'),

('PEND-20251025-042', 3, 'Mike Manager', 'Pedro Silva', '2025-10-26', '23:00:00', 189.50, 
 '[{"Product":"Head Gasket","Qty":1,"Price":150.00,"Total":150.00},{"Product":"Head Bolts","Qty":1,"Price":39.50,"Total":39.50}]', 
 'PENDING', 'Customer checking engine'),

('PEND-20251025-043', 1, 'John Admin', 'Rosa Mendez', '2025-10-27', '08:30:00', 78.25, 
 '[{"Product":"Oil Pan Gasket","Qty":1,"Price":45.00,"Total":45.00},{"Product":"Oil Pan","Qty":1,"Price":33.25,"Total":33.25}]', 
 'PENDING', 'Customer checking oil'),

('PEND-20251025-044', 2, 'Jane Employee', 'Luis Vargas', '2025-10-27', '09:15:00', 134.75, 
 '[{"Product":"Water Pump Gasket","Qty":1,"Price":25.00,"Total":25.00},{"Product":"Water Pump","Qty":1,"Price":109.75,"Total":109.75}]', 
 'PENDING', 'Customer checking cooling'),

('PEND-20251025-045', 3, 'Mike Manager', 'Elena Ruiz', '2025-10-27', '10:00:00', 67.50, 
 '[{"Product":"Thermostat Housing","Qty":1,"Price":35.00,"Total":35.00},{"Product":"Thermostat","Qty":1,"Price":32.50,"Total":32.50}]', 
 'PENDING', 'Customer checking thermostat'),

('PEND-20251025-046', 1, 'John Admin', 'Diego Morales', '2025-10-27', '10:45:00', 156.25, 
 '[{"Product":"Radiator","Qty":1,"Price":120.00,"Total":120.00},{"Product":"Radiator Cap","Qty":1,"Price":15.00,"Total":15.00},{"Product":"Radiator Hose","Qty":1,"Price":21.25,"Total":21.25}]', 
 'PENDING', 'Customer checking cooling'),

('PEND-20251025-047', 2, 'Jane Employee', 'Patricia Herrera', '2025-10-27', '11:30:00', 89.75, 
 '[{"Product":"Fan Clutch","Qty":1,"Price":65.00,"Total":65.00},{"Product":"Fan Blade","Qty":1,"Price":24.75,"Total":24.75}]', 
 'PENDING', 'Customer checking fan'),

('PEND-20251025-048', 3, 'Mike Manager', 'Ricardo Jimenez', '2025-10-27', '12:15:00', 112.50, 
 '[{"Product":"AC Compressor","Qty":1,"Price":95.00,"Total":95.00},{"Product":"AC Belt","Qty":1,"Price":17.50,"Total":17.50}]', 
 'PENDING', 'Customer checking AC'),

('PEND-20251025-049', 1, 'John Admin', 'Monica Castillo', '2025-10-27', '13:00:00', 145.25, 
 '[{"Product":"AC Condenser","Qty":1,"Price":120.00,"Total":120.00},{"Product":"AC Filter","Qty":1,"Price":25.25,"Total":25.25}]', 
 'PENDING', 'Customer checking AC'),

('PEND-20251025-050', 2, 'Jane Employee', 'Antonio Rojas', '2025-10-27', '13:45:00', 98.75, 
 '[{"Product":"AC Evaporator","Qty":1,"Price":75.00,"Total":75.00},{"Product":"AC Refrigerant","Qty":1,"Price":23.75,"Total":23.75}]', 
 'PENDING', 'Customer checking AC system')

GO

-- Display summary of inserted transactions
SELECT 
    COUNT(*) AS TotalPendingTransactions,
    SUM(TotalAmount) AS TotalPendingAmount,
    MIN(TransactionDate) AS EarliestTransaction,
    MAX(TransactionDate) AS LatestTransaction,
    COUNT(DISTINCT EmployeeName) AS UniqueEmployees,
    COUNT(DISTINCT CustomerName) AS UniqueCustomers
FROM [dbo].[PendingTransactions]
WHERE Status = 'PENDING'

GO

-- Display transactions by employee
SELECT 
    EmployeeName,
    COUNT(*) AS TransactionCount,
    SUM(TotalAmount) AS TotalAmount,
    AVG(TotalAmount) AS AverageAmount
FROM [dbo].[PendingTransactions]
WHERE Status = 'PENDING'
GROUP BY EmployeeName
ORDER BY TransactionCount DESC

GO

-- Display transactions by date
SELECT 
    TransactionDate,
    COUNT(*) AS TransactionCount,
    SUM(TotalAmount) AS TotalAmount
FROM [dbo].[PendingTransactions]
WHERE Status = 'PENDING'
GROUP BY TransactionDate
ORDER BY TransactionDate

GO

PRINT 'Successfully inserted 50 pending transactions!'
PRINT 'Summary:'
PRINT '- Total Pending Transactions: 50'
PRINT '- Various transaction amounts from ₱45.50 to ₱850.00'
PRINT '- Multiple employees: John Admin, Jane Employee, Mike Manager'
PRINT '- Diverse customer types: Regular customers, Corporate clients, Fleet accounts'
PRINT '- Realistic scenarios: ATM visits, price comparisons, mechanic consultations'
PRINT '- Date range: October 25-27, 2025'
PRINT ''
PRINT 'Use sp_GetPendingTransactions to retrieve all pending transactions'
PRINT 'Use sp_CompletePendingTransaction to mark transactions as completed'
PRINT 'Use sp_CancelPendingTransaction to cancel pending transactions'
