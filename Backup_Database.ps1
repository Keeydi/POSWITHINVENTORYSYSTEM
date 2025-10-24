# =============================================
# PowerShell Database Backup Script for POS System
# Database: MYDB
# Server: DESKTOP-GB785JE\SQLEXPRESS01
# =============================================

# Set variables
$ServerName = "DESKTOP-GB785JE\SQLEXPRESS01"
$DatabaseName = "MYDB"
$BackupPath = "C:\Backup"
$Timestamp = Get-Date -Format "yyyyMMdd_HHmmss"

# Create backup directory if it doesn't exist
if (!(Test-Path $BackupPath)) {
    New-Item -ItemType Directory -Path $BackupPath -Force
    Write-Host "Created backup directory: $BackupPath" -ForegroundColor Green
}

# SQL Server connection string
$ConnectionString = "Server=$ServerName;Database=$DatabaseName;Integrated Security=True;"

try {
    # Load SQL Server module
    Import-Module SqlServer -ErrorAction SilentlyContinue
    
    # Create SQL Server connection
    $Connection = New-Object System.Data.SqlClient.SqlConnection($ConnectionString)
    $Connection.Open()
    
    Write-Host "Connected to SQL Server successfully!" -ForegroundColor Green
    
    # Execute full database backup
    $BackupFileName = "$BackupPath\MYDB_Full_Backup_$Timestamp.bak"
    $BackupQuery = @"
BACKUP DATABASE [$DatabaseName] 
TO DISK = '$BackupFileName'
WITH 
    FORMAT,
    INIT,
    NAME = 'MYDB Full Database Backup',
    SKIP,
    NOREWIND,
    NOUNLOAD,
    STATS = 10;
"@
    
    Write-Host "Starting full database backup..." -ForegroundColor Yellow
    $Command = New-Object System.Data.SqlClient.SqlCommand($BackupQuery, $Connection)
    $Command.ExecuteNonQuery()
    
    Write-Host "Full database backup completed successfully!" -ForegroundColor Green
    Write-Host "Backup file: $BackupFileName" -ForegroundColor Cyan
    
    # Get table information
    Write-Host "`nGetting table information..." -ForegroundColor Yellow
    $TableQuery = @"
SELECT 
    TABLE_NAME,
    (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES t2 WHERE t2.TABLE_NAME = t.TABLE_NAME) as TableCount
FROM INFORMATION_SCHEMA.TABLES t
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
"@
    
    $TableCommand = New-Object System.Data.SqlClient.SqlCommand($TableQuery, $Connection)
    $TableReader = $TableCommand.ExecuteReader()
    
    Write-Host "`nTables in database:" -ForegroundColor Cyan
    while ($TableReader.Read()) {
        $TableName = $TableReader["TABLE_NAME"]
        Write-Host "- $TableName" -ForegroundColor White
    }
    $TableReader.Close()
    
    # Export table data to CSV (optional)
    Write-Host "`nWould you like to export table data to CSV files? (Y/N)" -ForegroundColor Yellow
    $ExportChoice = Read-Host
    
    if ($ExportChoice -eq "Y" -or $ExportChoice -eq "y") {
        $Tables = @("Users", "Employees", "Products", "Categories", "Inventory", "Transactions", "Transaction_Items", "Stock_In", "Defects", "Pending_Transactions", "User_Logs")
        
        foreach ($Table in $Tables) {
            try {
                $ExportQuery = "SELECT * FROM [$DatabaseName].[dbo].[$Table]"
                $ExportCommand = New-Object System.Data.SqlClient.SqlCommand($ExportQuery, $Connection)
                $Adapter = New-Object System.Data.SqlClient.SqlDataAdapter($ExportCommand)
                $DataSet = New-Object System.Data.DataSet
                $Adapter.Fill($DataSet)
                
                $CsvPath = "$BackupPath\${Table}_$Timestamp.csv"
                $DataSet.Tables[0] | Export-Csv -Path $CsvPath -NoTypeInformation
                Write-Host "Exported $Table to: $CsvPath" -ForegroundColor Green
            }
            catch {
                Write-Host "Could not export $Table : $($_.Exception.Message)" -ForegroundColor Red
            }
        }
    }
    
} catch {
    Write-Host "Error: $($_.Exception.Message)" -ForegroundColor Red
} finally {
    if ($Connection.State -eq "Open") {
        $Connection.Close()
        Write-Host "`nDatabase connection closed." -ForegroundColor Yellow
    }
}

Write-Host "`nBackup process completed!" -ForegroundColor Green
Write-Host "Backup location: $BackupPath" -ForegroundColor Cyan
Write-Host "Press any key to exit..." -ForegroundColor Yellow
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
