
CREATE TABLE Customer_Table (
	CustomerID INT PRIMARY KEY,
	FirstName CHAR(255),
	LastName CHAR(255),
	Email CHAR(255),
	Phone CHAR(15),
	Address VARCHAR(MAX),
	City CHAR(100),
	State CHAR(100),
	Country CHAR(100),
	PostalCode CHAR(20),
	DateJoined DATETIME,
	IsActive BIT,
	LastLogin DATETIME
);

CREATE TABLE Products_Table(
    ProductID INT PRIMARY KEY,
    ProductName CHAR(255),
    CategoryID INT,
    Price FLOAT,
    StockQty INT,
    Description VARCHAR(MAX),
	IsActive BIT
);

CREATE TABLE Categories_Table(
    CategoryID INT PRIMARY KEY,
    CategoryName CHAR(255),
    Description VARCHAR(MAX)
);

CREATE TABLE Orders_Table(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATETIME,
    TotalAmount FLOAT,
    Status CHAR(50),
    PaymentStatus CHAR(50),
    ShippingAddress VARCHAR(MAX),
    ShippingMethod CHAR(100)
);

CREATE TABLE OrderItems_Table(
    OrderItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice FLOAT
);

CREATE TABLE Payments_Table(
    PaymentID INT PRIMARY KEY,
    OrderID INT,
    PaymentDate DATETIME,
    Amount FLOAT,
    PaymentMethod CHAR(50),
    PaymentStatus CHAR(50)
);

CREATE TABLE Shipping_Table(
    ShippingID INT PRIMARY KEY,
    OrderID INT,
    ShippingDate DATETIME,
    Carrier CHAR(100),
    TrackingNumber CHAR(100),
    TrackingStatus CHAR(50)
)

CREATE TABLE Inventory_Table(
    InventoryID INT PRIMARY KEY,
    ProductID INT,
    QuantityAdded INT,
    QuantitySold INT,
    Date DATETIME
);

CREATE TABLE ProductReview_Table(
    ReviewID INT PRIMARY KEY,
    CustomerID INT,
    ProductID INT,
    Rating INT,
    ReviewText VARCHAR(MAX),
    ReviewDate DATETIME
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    FullName NVARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
