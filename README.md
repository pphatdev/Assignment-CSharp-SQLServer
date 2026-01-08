# POS System - C# Windows Forms Application

A modern Point of Sale (POS) system built with C# Windows Forms and SQL Server, featuring a clean UI with custom components and comprehensive user management.

## ✨ Pupose
This project is developed as part of the curriculum for CUS - Year III Assignment under the guidance of Lecturer T.NAN Sokchea. It aims to demonstrate proficiency in C# Windows Forms development, SQL Server integration, and UI/UX design principles.

## 📋 Prerequisites

Before running this project, ensure you have the following installed:

- **Visual Studio 2022** (or later)
  - Workload: .NET desktop development
- **.NET 8.0 SDK** or later
- **SQL Server** (2019 or later)
  - SQL Server Express is sufficient
- **SQL Server Management Studio (SSMS)** (recommended for database management)

## 🗄️ Database Setup

### 1. Create Database

Open SQL Server Management Studio and execute the following SQL commands:

```sql
-- Create database
CREATE DATABASE POSSystemDB;
GO

USE POSSystemDB;
GO

-- Create Users table
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(256) NOT NULL,
    Email NVARCHAR(100),
    FullName NVARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);
GO

-- Insert sample admin user (password: admin123)
-- Note: Password is hashed using SHA256
INSERT INTO Users (Username, Password, Email, FullName)
VALUES ('admin', 
        '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9',
        'admin@possystem.com',
        'Administrator');
GO
```

### 2. Configure Connection String

1. Open the project in Visual Studio
2. Locate the connection string in [DatabaseConnection.cs](DB/DatabaseConnection.cs)
3. Update the connection string to match your SQL Server configuration:

```csharp
private static string connectionString = 
    "Server=YOUR_SERVER_NAME;Database=POSSystemDB;Integrated Security=true;TrustServerCertificate=true;";
```

Replace `YOUR_SERVER_NAME` with:
- `localhost` or `(localdb)\MSSQLLocalDB` for local SQL Server
- Your server instance name (e.g., `.\SQLEXPRESS` for SQL Server Express)

## 🚀 Running the Project

### Method 1: Using Visual Studio

1. **Open the Solution**
   - Double-click `AssignmentCSharpAndSqlServer.sln` or open it from Visual Studio

2. **Restore NuGet Packages**
   - Visual Studio will automatically restore packages on first build
   - Or manually: Right-click solution → Restore NuGet Packages

3. **Build the Solution**
   - Press `Ctrl + Shift + B` or
   - Go to Build → Build Solution

4. **Run the Application**
   - Press `F5` (Debug mode) or `Ctrl + F5` (Release mode)
   - Or click the Start button in Visual Studio

### Method 2: Using Command Line

```bash
# Clone the repository
git clone https://github.com/pphatdev/Assignment-CSharp-SQLServer.git

# Navigate to project directory
cd "Assignment-CSharp-SQLServer"

# Restore packages
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

### Method 3: Using MSBuild Task

If you have the build task configured in VS Code:

1. Press `Ctrl + Shift + P`
2. Type "Tasks: Run Task"
3. Select "build"


## ✨ Features

### Authentication
- ✅ Secure login with SHA256 password hashing
- ✅ User registration
- ✅ Form validation
- ✅ Error handling and user feedback
- ✅ Press Enter to login

### Dashboard
- ✅ Modern, responsive sidebar navigation
- ✅ Collapsible sidebar (80px collapsed / 333px expanded)
- ✅ Custom window controls (minimize, maximize, close)
- ✅ Dynamic page title updates
- ✅ User profile display in header

### Navigation Menu
- Cashier
- Inventory
- Customers
- Transactions
- Reports
- Settings

### Custom Components
- **RoundedButton** - Buttons with customizable border radius
- **RoundedTextBox** - Text inputs with rounded borders and focus effects
- **RoundedPictureBox** - Circular avatar images
- **MenuItem** - Custom menu items with hover effects

## 📁 Project Structure

```
AssignmentCSharpAndSqlServer/
├── Assets/
│   └── Icons/
│       └── menus/          # Menu icons (SVG format)
├── DB/
│   └── DatabaseConnection.cs   # Database connection handler
├── Properties/
│   └── Resources.resx          # Application resources
├── Views/
│   ├── Auths/
│   │   ├── Login.cs            # Login form
│   │   └── Register.cs         # Registration form
│   ├── Components/
│   │   ├── Button.cs
│   │   ├── RoundedButton.cs
│   │   ├── TextBox.cs
│   │   ├── RoundedTextBox.cs
│   │   ├── RoundedPictureBox.cs
│   │   └── MenuItem.cs
│   ├── Layouts/
│   │   ├── Sidebar.cs          # Sidebar navigation
│   │   └── Header.cs           # Header component
│   └── Main.cs                 # Main dashboard form
├── Program.cs                  # Application entry point
└── README.md                   # This file
```


## 👨‍🏫 Lecturer

-   **NAN Sokchea** CUS - Year III Assignment


## 👨‍💻 Assignment Team

- [LEAT Sophat](https://pphat.top)

