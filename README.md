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
