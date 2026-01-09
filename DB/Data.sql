-- Insert sample categories
INSERT INTO Categories_Table (CategoryID, CategoryName, Description) VALUES
(1, 'Electronics', 'Electronic devices and gadgets'),
(2, 'Clothing', 'Apparel and fashion items'),
(3, 'Books', 'Books and educational materials'),
(4, 'Home & Garden', 'Home improvement and gardening supplies'),
(5, 'Sports', 'Sports equipment and accessories');

-- Insert sample products
INSERT INTO Products_Table (ProductID, ProductName, CategoryID, Price, StockQty, Description, IsActive) VALUES
(1, 'Laptop Dell XPS 15', 1, 1299.99, 50, 'High-performance laptop with 16GB RAM and 512GB SSD', 1),
(2, 'iPhone 14 Pro', 1, 999.99, 100, 'Latest Apple smartphone with advanced camera system', 1),
(3, 'Samsung 4K TV 55"', 1, 799.99, 30, '55-inch 4K Smart TV with HDR support', 1),
(4, 'Wireless Headphones', 1, 149.99, 200, 'Noise-cancelling Bluetooth headphones', 1),
(5, 'Men Cotton T-Shirt', 2, 19.99, 500, 'Comfortable cotton t-shirt available in multiple colors', 1),
(6, 'Women Denim Jeans', 2, 49.99, 300, 'Classic fit denim jeans', 1),
(7, 'Winter Jacket', 2, 89.99, 150, 'Warm winter jacket with hood', 1),
(8, 'Programming Book: C# Guide', 3, 39.99, 80, 'Comprehensive guide to C# programming', 1),
(9, 'Fiction Novel: Mystery', 3, 14.99, 120, 'Bestselling mystery novel', 1),
(10, 'Coffee Maker', 4, 79.99, 60, 'Automatic coffee maker with timer', 1),
(11, 'Garden Tool Set', 4, 45.99, 75, 'Complete set of essential garden tools', 1),
(12, 'LED Desk Lamp', 4, 29.99, 180, 'Adjustable LED desk lamp with USB charging port', 1),
(13, 'Yoga Mat', 5, 24.99, 250, 'Non-slip yoga mat with carrying strap', 1),
(14, 'Basketball', 5, 34.99, 100, 'Professional-grade basketball', 1),
(15, 'Running Shoes', 5, 89.99, 180, 'Lightweight running shoes with cushioned sole', 1);