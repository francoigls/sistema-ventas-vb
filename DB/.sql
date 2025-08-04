create database FINAL
use FINAL
go

CREATE TABLE usuarios(
id_usuario int primary key IDENTITY(1,1),
nombre_usuario nvarchar(50) unique,
psw nvarchar(100)
)

CREATE TABLE clientes(
id_cliente int primary key IDENTITY(1,1),
nombre nvarchar(100),
apellido nvarchar(100),
dni nvarchar(20) unique,
direccion nvarchar(200),
telefono nvarchar(20)
)

CREATE TABLE  marcas(
id_marca int primary key IDENTITY(1,1),
nombre_marca nvarchar(100)
)

CREATE TABLE prendas(
id_prenda int primary key identity(1,1),
descripcion nvarchar(100),
precio decimal(10,2),
stock int,
id_marca int,
FOREIGN KEY (id_marca) REFERENCES marcas(id_marca)
)

CREATE TABLE formaspago(
id_forma_pago int primary key identity(1,1),
descripcion nvarchar(100)
)

CREATE TABLE ventas(
id_venta int primary key identity(1,1),
fecha datetime,
total decimal(10,2),
id_cliente int,
id_forma_pago int,
FOREIGN KEY(id_cliente) references clientes(id_cliente),
FOREIGN KEY(id_forma_pago) references formaspago(id_forma_pago)
)


CREATE TABLE detalleventa(
id_detalle int primary key identity(1,1),
id_venta int,
id_prenda int,
cantidad int,
precio_unitari decimal(10,2),
FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
FOREIGN KEY (id_prenda) REFERENCES prendas(id_prenda),
)

use FINAL
GO

INSERT INTO ventas (fecha, total, id_cliente, id_forma_pago)
VALUES 
('2025-07-20', 15000.00, 1, 2), 
('2025-07-21', 23500.00, 2, 1),
('2025-07-22', 18500.00, 3, 3);


use FINAL
GO


INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
VALUES 
(1, 1, 2, 5000.00),
(1, 2, 1, 5000.00);


INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
VALUES 
(2, 2, 2, 5500.00),
(2, 3, 1, 6500.00);


INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
VALUES 
(3, 1, 1, 5000.00),
(3, 3, 2, 6750.00);

select * from detalleventa