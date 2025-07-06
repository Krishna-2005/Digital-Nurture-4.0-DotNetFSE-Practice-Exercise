CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price)
VALUES 
(1, 'Laptop', 'Electronics', 80000),
(2, 'Smartphone', 'Electronics', 60000),
(3, 'TV', 'Electronics', 60000),
(4, 'Tablet', 'Electronics', 30000),
(5, 'Washing Machine', 'Appliances', 25000),
(6, 'Refrigerator', 'Appliances', 35000),
(7, 'Microwave', 'Appliances', 15000),
(8, 'Vacuum Cleaner', 'Appliances', 25000),
(9, 'Jeans', 'Clothing', 2000),
(10, 'Shirt', 'Clothing', 1500);
(11, 'Jacket', 'Clothing', 4000),
(12, 'Shoes', 'Clothing', 4000);

SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
FROM Products;

SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
FROM Products;

WITH RankedProducts AS (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE RowNum <= 3;