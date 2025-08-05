Sistema de Gestión de Ventas para Tienda de Ropa
Este proyecto es un sistema de gestión de ventas desarrollado en Visual Basic .NET, orientado a tiendas de ropa. Permite administrar el inventario de prendas, gestionar clientes, registrar ventas con sus detalles y generar reportes.

Funcionalidades principales a travez de procedimientos almacenados
ABM de Prendas, Marcas, Clientes, y Formas de Pago.

Registro de Ventas con cabecera y detalle.

Validación de stock disponible antes de confirmar una venta.

Aumentos masivos de precios por marca.


Reportes:

Lista de precios actualizada.

Ventas por fecha y forma de pago.

Ventas de una prenda en un rango de fechas.

Ventas realizadas a un cliente específico.

Interfaz intuitiva hecha con formularios de Windows Forms.

Tecnologías utilizadas
Lenguaje: Visual Basic .NET

Base de datos: SQL Server

Reportes: ReportViewer con informes RDLC

Control de versiones: Git + GitHub

Instalación
Clonar el repositorio:

bash
Copiar
Editar
git clone https://github.com/francoigls/sistema-ventas-vb.git
Abrir el proyecto en Visual Studio 2022.

Restaurar paquetes NuGet (por los reportes RDLC y dependencias).

Configurar la cadena de conexión de la base de datos en el módulo conexion.vb según tu entorno SQL Server.

Crear la base de datos con los scripts incluidos en la carpeta /sql.

Ejecutar la aplicación.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Sales Management System for Clothing Store
This project is a sales management system developed in Visual Basic .NET, designed for clothing stores. It allows you to manage the inventory of garments, handle clients, register sales with their details, and generate reports.

Main Features
CRUD operations for Garments, Brands, Clients, and Payment Methods.

Sales registration with header and detail lines.

Stock availability validation before confirming a sale.

Mass price increases by brand.

Reports:

Updated price list.

Sales by date and payment method.

Sales of a specific garment within a date range.

Sales made to a specific client.

Intuitive interface built with Windows Forms.

Technologies Used
Language: Visual Basic .NET

Database: SQL Server

Reports: ReportViewer with RDLC reports

Version control: Git + GitHub

Installation
Clone the repository:

bash
Copiar
Editar
git clone https://github.com/francoigls/sistema-ventas-vb.git
Open the project in Visual Studio 2022.

Restore NuGet packages (required for RDLC reports and dependencies).

Configure the database connection string in the conexion.vb module according to your SQL Server environment.

Create the database using the scripts included in the /sql folder.

Run the application.


