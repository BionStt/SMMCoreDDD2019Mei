# Sumber Mas Enterprise API - Build and Run Script
# PowerShell script untuk build dan menjalankan project

param(
    [switch]$Clean,
    [switch]$Restore,
    [switch]$Build,
    [switch]$Run,
    [switch]$All
)

$ErrorActionPreference = "Stop"
$ProjectPath = "SumberMas2015.Blazor/Server"

Write-Host "🚀 Sumber Mas Enterprise API - Build and Run Script" -ForegroundColor Green
Write-Host "==================================================" -ForegroundColor Green

# Function untuk menampilkan error
function Show-Error {
    param($Message)
    Write-Host "❌ ERROR: $Message" -ForegroundColor Red
    exit 1
}

# Function untuk menampilkan success
function Show-Success {
    param($Message)
    Write-Host "✅ $Message" -ForegroundColor Green
}

# Function untuk menampilkan info
function Show-Info {
    param($Message)
    Write-Host "ℹ️  $Message" -ForegroundColor Cyan
}

# Check if project exists
if (-not (Test-Path $ProjectPath)) {
    Show-Error "Project path not found: $ProjectPath"
}

# Clean project
if ($Clean -or $All) {
    Show-Info "Cleaning project..."
    try {
        dotnet clean $ProjectPath
        Show-Success "Project cleaned successfully"
    }
    catch {
        Show-Error "Failed to clean project: $($_.Exception.Message)"
    }
}

# Restore packages
if ($Restore -or $All) {
    Show-Info "Restoring packages..."
    try {
        dotnet restore $ProjectPath
        Show-Success "Packages restored successfully"
    }
    catch {
        Show-Error "Failed to restore packages: $($_.Exception.Message)"
    }
}

# Build project
if ($Build -or $All) {
    Show-Info "Building project..."
    try {
        dotnet build $ProjectPath --configuration Release --no-restore
        Show-Success "Project built successfully"
    }
    catch {
        Show-Error "Failed to build project: $($_.Exception.Message)"
    }
}

# Run project
if ($Run -or $All) {
    Show-Info "Starting application..."
    Show-Info "API Documentation will be available at: http://localhost:5000/api-docs"
    Show-Info "Health Check will be available at: http://localhost:5000/health"
    Show-Info "Press Ctrl+C to stop the application"
    Write-Host ""
    
    try {
        dotnet run --project $ProjectPath --configuration Release
    }
    catch {
        Show-Error "Failed to run project: $($_.Exception.Message)"
    }
}

# If no parameters provided, show help
if (-not ($Clean -or $Restore -or $Build -or $Run -or $All)) {
    Write-Host "Usage:" -ForegroundColor Yellow
    Write-Host "  .\build-and-run.ps1 -Clean    # Clean project" -ForegroundColor White
    Write-Host "  .\build-and-run.ps1 -Restore  # Restore packages" -ForegroundColor White
    Write-Host "  .\build-and-run.ps1 -Build    # Build project" -ForegroundColor White
    Write-Host "  .\build-and-run.ps1 -Run      # Run project" -ForegroundColor White
    Write-Host "  .\build-and-run.ps1 -All      # Clean, restore, build, and run" -ForegroundColor White
    Write-Host ""
    Write-Host "Examples:" -ForegroundColor Yellow
    Write-Host "  .\build-and-run.ps1 -All      # Full build and run" -ForegroundColor White
    Write-Host "  .\build-and-run.ps1 -Build    # Just build" -ForegroundColor White
}
