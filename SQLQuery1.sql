select * from Categories; 
INSERT INTO Categories (Name) VALUES 
('Electronics'),
('Clothing'),
('Books'),
('Furniture');
select * from Products;
INSERT INTO Products (Name, Price, CategoryId) VALUES 
('Laptop', 1000.00, 1),  -- Electronics
('Smartphone', 700.00, 1),  
('T-Shirt', 20.00, 2),    -- Clothing
('Novel', 15.00, 3),      -- Books
('Sofa', 500.00, 4);
