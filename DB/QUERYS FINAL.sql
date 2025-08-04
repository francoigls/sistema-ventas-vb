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




USE FINAL
GO

CREATE PROCEDURE sp_InsertarCliente
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @dni NVARCHAR(20),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(20)
AS
BEGIN
    INSERT INTO clientes (nombre, apellido, dni, direccion, telefono)
    VALUES (@nombre, @apellido, @dni, @direccion, @telefono)
END
GO


CREATE PROCEDURE sp_ActualizarCliente
    @id INT,
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @dni NVARCHAR(20),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(20)
AS
BEGIN
    UPDATE clientes
    SET nombre = @nombre,
        apellido = @apellido,
        dni = @dni,
        direccion = @direccion,
        telefono = @telefono
    WHERE id_cliente = @id
END
GO


CREATE PROCEDURE sp_EliminarCliente
    @id INT
AS
BEGIN
    DELETE FROM clientes WHERE id_cliente = @id
END
GO


-- PRENDAS



CREATE PROCEDURE sp_InsertarPrenda
    @descripcion NVARCHAR(100),
    @precio DECIMAL(10,2),
    @stock INT,
    @id_marca INT
AS
BEGIN
    INSERT INTO prendas (descripcion, precio, stock, id_marca)
    VALUES (@descripcion, @precio, @stock, @id_marca)
END
GO


CREATE PROCEDURE sp_ActualizarPrenda
    @id INT,
    @descripcion NVARCHAR(100),
    @precio DECIMAL(10,2),
    @stock INT,
    @id_marca INT
AS
BEGIN
    UPDATE prendas
    SET descripcion = @descripcion,
        precio = @precio,
        stock = @stock,
        id_marca = @id_marca
    WHERE id_prenda = @id
END
GO


CREATE PROCEDURE sp_EliminarPrenda
    @id INT
AS
BEGIN
    DELETE FROM prendas WHERE id_prenda = @id
END
GO


-- FORMAS DE PAGO



CREATE PROCEDURE sp_InsertarFormaPago
    @descripcion NVARCHAR(100)
AS
BEGIN
    INSERT INTO formaspago (descripcion) VALUES (@descripcion)
END
GO


CREATE PROCEDURE sp_ActualizarFormaPago
    @id INT,
    @descripcion NVARCHAR(100)
AS
BEGIN
    UPDATE formaspago SET descripcion = @descripcion WHERE id_forma_pago = @id
END
GO


CREATE PROCEDURE sp_EliminarFormaPago
    @id INT
AS
BEGIN
    DELETE FROM formaspago WHERE id_forma_pago = @id
END
GO


-- MARCAS

CREATE PROCEDURE sp_InsertarMarca
    @nombre NVARCHAR(100)
AS
BEGIN
    INSERT INTO marcas (nombre_marca) VALUES (@nombre)
END
GO


CREATE PROCEDURE sp_ActualizarMarca
    @id INT,
    @nombre NVARCHAR(100)
AS
BEGIN
    UPDATE marcas SET nombre_marca = @nombre WHERE id_marca = @id
END
GO

CREATE PROCEDURE sp_EliminarMarca
    @id INT
AS
BEGIN
    DELETE FROM marcas WHERE id_marca = @id
END
GO



-- STAGE 2
USE FINAL
GO
CREATE PROCEDURE sp_CargarVenta
    @fecha DATETIME,
    @total DECIMAL(10,2),
    @id_cliente INT,
    @id_forma_pago INT
AS
BEGIN
    INSERT INTO ventas (fecha, total, id_cliente, id_forma_pago)
    VALUES (@fecha, @total, @id_cliente, @id_forma_pago)
END


CREATE PROCEDURE sp_VerDetalleVenta
    @id_venta INT
AS
BEGIN
    SELECT 
        p.descripcion AS Prenda,
        dv.cantidad,
        dv.precio_unitari,
        (dv.cantidad * dv.precio_unitari) AS Subtotal
    FROM detalleventa dv
    INNER JOIN prendas p ON dv.id_prenda = p.id_prenda
    WHERE dv.id_venta = @id_venta
END
GO


CREATE PROCEDURE sp_AumentarPreciosPorMarca
    @id_marca INT,
    @porcentaje DECIMAL(5,2)
AS
BEGIN
    UPDATE prendas
    SET precio = precio + (precio * @porcentaje / 100.0)
    WHERE id_marca = @id_marca
END


CREATE PROCEDURE sp_ListaPrecios
AS
BEGIN
    SELECT descripcion, precio FROM prendas
END



CREATE PROCEDURE sp_ListarVentasConDatos
AS
BEGIN
    SELECT
        v.id_venta,
        v.fecha,
        v.total,
        c.nombre + ' ' + c.apellido AS cliente,
        fp.descripcion AS forma_pago
    FROM ventas v
    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
    INNER JOIN formaspago fp ON v.id_forma_pago = fp.id_forma_pago
END

use FINAL 
go
CREATE PROCEDURE sp_InsertarDetalleVenta
    @id_venta INT,
    @id_prenda INT,
    @cantidad INT,
    @precio_unitario DECIMAL(10,2)
AS
BEGIN
   
    INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
    VALUES (@id_venta, @id_prenda, @cantidad, @precio_unitario)

    
    UPDATE prendas
    SET stock = stock - @cantidad
    WHERE id_prenda = @id_prenda
END
GO









USE FINAL 
GO
SELECT * FROM prendas

SELECT * FROM ventas
SELECT * FROM detalleventa


USE FINAL
GO

insert into usuarios (nombre_usuario, psw) values 
('admin', '123'),
('franco','123'),
('mauri','izo')


select * from usuarios



USE FINAL
GO
DROP PROCEDURE sp_InsertarDetalleVenta;
GO

USE FINAL;
UPDATE prendas
SET stock = 100 -- Pon una cantidad grande, o la cantidad que necesites + un extra.
WHERE id_prenda = 6; -- Reemplaza con el ID de la prenda

select * from ventas