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



ALTER TABLE prendas
ADD CONSTRAINT UQ_codigo_prenda UNIQUE (codigo_prenda);




SELECT * FROM prendas WHERE codigo_prenda IS NULL;




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


USE FINAL;
GO

CREATE TYPE DETALLE_VENTA AS TABLE (
    id_prenda INT,
    cantidad INT,
    precio_unitario DECIMAL(10,2)
);



use FINAL
go

CREATE PROCEDURE sp_RegistrarVentaCompleta
    @fecha DATETIME,
    @id_cliente INT,
    @id_forma_pago INT,
    @detalle DETALLE_VENTA READONLY 
AS
BEGIN
    DECLARE @id_venta INT
    DECLARE @total DECIMAL(10, 2)

    -- Calcular total
    SELECT @total = SUM(cantidad * precio_unitario) FROM @detalle

    -- Insertar cabecera
    INSERT INTO ventas (fecha, total, id_cliente, id_forma_pago)
    VALUES (@fecha, @total, @id_cliente, @id_forma_pago)

    SET @id_venta = SCOPE_IDENTITY()

    -- Insertar detalle y actualizar stock
   INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
SELECT @id_venta, id_prenda, cantidad, precio_unitario FROM @detalle;


    UPDATE p
    SET p.stock = p.stock - d.cantidad
    FROM prendas p
    INNER JOIN @detalle d ON p.id_prenda = d.id_prenda
END

use FINAL
go

CREATE PROCEDURE sp_EliminarVenta
@id INT
AS
BEGIN
    DELETE FROM ventas WHERE id_venta = @id
END


use FINAL
GO
CREATE OR ALTER PROCEDURE sp_EliminarVenta
    @id_venta INT
AS
BEGIN
    
    UPDATE p
    SET p.stock = p.stock + dv.cantidad
    FROM prendas p
    INNER JOIN detalleventa dv ON p.id_prenda = dv.id_prenda
    WHERE dv.id_venta = @id_venta;

    DELETE FROM detalleventa WHERE id_venta = @id_venta;

    DELETE FROM ventas WHERE id_venta = @id_venta;
END;


CREATE PROCEDURE sp_ModificarVentaCabecera
    @id_venta INT,
    @id_cliente INT,
    @id_forma_pago INT
AS
BEGIN
    UPDATE ventas
    SET id_cliente = @id_cliente,
        id_forma_pago = @id_forma_pago
    WHERE id_venta = @id_venta;
END;


USE FINAL
GO

CREATE PROCEDURE sp_ReporteListaPrecios
AS
BEGIN
    SELECT 
        p.descripcion AS Prenda,
        m.nombre_marca AS Marca,
        p.precio AS Precio,
        p.stock AS Stock
    FROM prendas p
    INNER JOIN marcas m ON p.id_marca = m.id_marca
    ORDER BY m.nombre_marca, p.descripcion;
END;



select * from ventas


use FINAL
go
DROP PROCEDURE sp_ReporteVentasPorFechaFormaPago




use FINAL
go

select * from prendas

CREATE PROCEDURE sp_ReporteVentasPorFecha
    @FechaDesde DATE,
    @FechaHasta DATE
AS
BEGIN
    SELECT 
        c.nombre + ' ' + c.apellido AS Cliente,
        v.fecha AS FechaVenta,
        fp.descripcion AS FormaPago,
        p.descripcion AS Prenda,
        dv.cantidad,
        dv.precio_unitari,
        (dv.cantidad * dv.precio_unitari) AS TotalPorPrenda,
        v.total AS TotalVenta
    FROM ventas v
    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
    INNER JOIN formaspago fp ON v.id_forma_pago = fp.id_forma_pago
    INNER JOIN detalleventa dv ON v.id_venta = dv.id_venta
    INNER JOIN prendas p ON dv.id_prenda = p.id_prenda
    WHERE v.fecha BETWEEN @FechaDesde AND @FechaHasta
    ORDER BY v.fecha, c.apellido, c.nombre
END



use FINAL
go

CREATE PROCEDURE sp_ReporteVentasPorPrendaYRango
    @codigo_prenda NVARCHAR(50),
    @fecha_desde DATE,
    @fecha_hasta DATE
AS
BEGIN
    SELECT 
        v.id_venta,
        v.fecha,
        c.nombre + ' ' + c.apellido AS cliente,
        f.descripcion AS forma_pago,
        p.descripcion AS prenda,
        dv.cantidad,
        dv.precio_unitari,
        (dv.cantidad * dv.precio_unitari) AS subtotal
    FROM ventas v
    INNER JOIN detalleventa dv ON v.id_venta = dv.id_venta
    INNER JOIN prendas p ON dv.id_prenda = p.id_prenda
    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
    INNER JOIN formaspago f ON v.id_forma_pago = f.id_forma_pago
    WHERE p.codigo_prenda = @codigo_prenda
      AND v.fecha BETWEEN @fecha_desde AND @fecha_hasta
END





USE FINAL
GO

ALTER PROCEDURE SP_MostrarVentasPorCliente
    @idCliente INT
AS
BEGIN
    SELECT
        V.id_venta AS ID_Venta,             
        V.fecha AS FechaVenta,           
        C.nombre AS NombreCliente,         
        C.apellido AS ApellidoCliente,    
        FP.descripcion AS FormaPago,        
        DV.cantidad AS Cantidad,
        P.descripcion AS Prenda,
        DV.precio_unitari AS PrecioUnitario, 
        (DV.cantidad * DV.precio_unitari) AS SubtotalPrenda
    FROM
        ventas AS V
    INNER JOIN
        clientes AS C ON V.id_cliente = C.id_cliente
    INNER JOIN
        formaspago AS FP ON V.id_forma_pago = FP.id_forma_pago
    INNER JOIN
        detalleventa AS DV ON V.id_venta = DV.id_venta
    INNER JOIN
        prendas AS P ON DV.id_prenda = P.id_prenda
    WHERE
        V.id_cliente = @idCliente;
END;
GO


use FINAL
go
ALTER PROCEDURE sp_RegistrarVentaCompleta
    @fecha DATETIME,
    @id_cliente INT,
    @id_forma_pago INT,
    @detalle DETALLE_VENTA READONLY 
AS
BEGIN
    DECLARE @id_venta INT
    DECLARE @total DECIMAL(18, 2)

    -- Validar stock disponible
    IF EXISTS (
        SELECT 1
        FROM @detalle d
        INNER JOIN prendas p ON d.id_prenda = p.id_prenda
        WHERE d.cantidad > p.stock
    )
    BEGIN
        RAISERROR('No hay suficiente stock para uno o más productos.', 16, 1)
        RETURN
    END

    -- Calcular total
    SELECT @total = SUM(cantidad * precio_unitario) FROM @detalle

    -- Insertar cabecera
    INSERT INTO ventas (fecha, total, id_cliente, id_forma_pago)
    VALUES (@fecha, @total, @id_cliente, @id_forma_pago)

    SET @id_venta = SCOPE_IDENTITY()

    -- Insertar detalle
    INSERT INTO detalleventa (id_venta, id_prenda, cantidad, precio_unitari)
    SELECT @id_venta, id_prenda, cantidad, precio_unitario FROM @detalle;

    -- Descontar stock
    UPDATE p
    SET p.stock = p.stock - d.cantidad
    FROM prendas p
    INNER JOIN @detalle d ON p.id_prenda = d.id_prenda
END
