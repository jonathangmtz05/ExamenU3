CREATE DATABASE Tienda;
go
USE Tienda;
go
CREATE TABLE Producto (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio varchar(100) NOT NULL,
    Stock INT NOT NULL ,
    FechaRegistro DATE
);
go
INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaRegistro)
VALUES 
('Laptop HP 15', 'Laptop de 15 pulgadas con procesador Intel i5', 12000.00, 10, '2024-05-10'),
('Mouse Logitech', 'Mouse inalámbrico ergonómico', 350.50, 50, '2024-05-15'),
('Teclado Mecánico Redragon', 'Teclado RGB con switches rojos', 890.00, 20, '2024-05-12'),
('Monitor Samsung 24"', 'Monitor LED Full HD de 24 pulgadas', 2800.00, 15, '2024-05-18'),
('Memoria USB 64GB', 'Memoria flash USB 3.0', 120.75, 100, '2024-05-14');