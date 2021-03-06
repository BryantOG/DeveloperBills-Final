USE [master]
GO
/****** Object:  Database [Facturacion]    Script Date: 25/4/2022 5:59:04 a. m. ******/
CREATE DATABASE [Facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Facturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Facturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Facturacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facturacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Facturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Facturacion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Facturacion] SET QUERY_STORE = OFF
GO
USE [Facturacion]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Cliente]  AS ('C'+right('0000'+CONVERT([varchar],[Id]),(5))),
	[CedulaC] [varchar](13) NULL,
	[NombresC] [varchar](80) NULL,
	[ApellidosC] [varchar](80) NULL,
	[TelefonoC] [varchar](20) NULL,
	[DireccionC] [varchar](100) NULL,
	[CorreoC] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdE] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Empleado]  AS ('E'+right('0000'+CONVERT([varchar],[IdE]),(5))),
	[CedulaE] [varchar](13) NULL,
	[NombresE] [varchar](80) NULL,
	[ApellidosE] [varchar](80) NULL,
	[TelefonoE] [varchar](20) NULL,
	[DepartE] [varchar](100) NULL,
	[CorreoE] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_factura] [int] IDENTITY(1,1) NOT NULL,
	[Numero_de_factura]  AS ('F'+right('0000'+CONVERT([varchar],[ID_factura]),(5))),
	[Codigo_cliente] [varchar](50) NULL,
	[Nombre_cliente] [varchar](60) NULL,
	[Fecha_Factura] [datetime] NULL,
	[Codigo_Producto] [varchar](60) NULL,
	[Nombre_producto] [varchar](70) NULL,
	[Detalle_Producto] [varchar](200) NULL,
	[Precio_producto] [varchar](60) NULL,
	[Cantidad_producto] [varchar](25) NULL,
	[total_producto] [varchar](25) NULL,
	[Codigo_Vendedor] [varchar](80) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[ID_producto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_producto]  AS ('P'+right('0000'+CONVERT([varchar],[ID_producto]),(5))),
	[Nombre_producto] [varchar](60) NULL,
	[Detalles_producto] [varchar](200) NULL,
	[Precio_producto] [int] NULL,
	[cantidad_productor] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DetalleReporte]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DetalleReporte]
@cantClientes int out,
@cantProd int out,
@stock int out,
@totalVent int out
as
	set @cantClientes = (select count(ID) cantClientes from Cliente) 
	set @cantProd = (select count(ID_producto) as cantProd from productos)
	set @stock = (select sum( CAST(cantidad_productor as int)) as stock from productos)
	set @totalVent = (select sum( CAST(total_producto as float) ) as totalVent from Factura)
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarCliente]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscarCliente]
@CedulaC varchar(30)
as 
select * from cliente where CedulaC like @CedulaC  + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarFacClie]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscarFacClie]
@Codigo varchar(30)
as 
select * from Factura where Codigo_Cliente like @Codigo  + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarFacFec]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscarFacFec]
@Fecha varchar(30)
as 
select * from Factura where Fecha_Factura like @Fecha  + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarProductos]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscarProductos]
@CodigoP varchar(30)
as 
select * from productos where Codigo_producto like @CodigoP  + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarClientes]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_cargarClientes]
as
select Codigo_Cliente, NombresC
from Cliente
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarClientes2]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_cargarClientes2]
@IdC int
as
select Id, NombresC
from Cliente
where  Id = @IdC
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarProducto]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_cargarProducto]
as
select Codigo_producto, Nombre_producto
from productos
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Cliente]
@CedulaC varchar(13),
@NombresC varchar(80),
@ApellidosC varchar(80),
@TelefonoC varchar(20),
@DireccionC varchar(100),
@CorreoC varchar(20),
@accionC varchar(10) output
as
if (@accionC ='1')
begin
	insert into Cliente (CedulaC, NombresC, ApellidosC, TelefonoC, DireccionC, CorreoC)
	Values (@CedulaC, @NombresC, @ApellidosC, @TelefonoC , @DireccionC, @CorreoC)
	set @accionC ='Se inserto cliente:' +@NombresC
end
else if @accionC = '2'
begin
	update Cliente set CedulaC= @CedulaC, NombresC = @NombresC, ApellidosC  = @ApellidosC , TelefonoC = @TelefonoC,
						DireccionC= @DireccionC, CorreoC=@CorreoC where CedulaC = @CedulaC
end
else if @accionC ='3'
begin
	delete from Cliente where CedulaC = @CedulaC
	set @accionC ='Se elimino cliente:' +@NombresC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Empleados]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Empleados]
@CedulaE varchar(13),
@NombreE varchar(80),
@ApellidoE varchar(80),
@TelefonoE varchar(20),
@DepartamentoE varchar(100),
@CorreE varchar(20),
@accionE varchar(10) output
as
if (@accionE ='1')
begin
	insert into Empleado (CedulaE, NombresE, ApellidosE, TelefonoE, DepartE, CorreoE)
	Values (@CedulaE, @NombreE, @ApellidoE, @TelefonoE , @DepartamentoE, @CorreE)
	set @accionE ='Se inserto cliente:' +@NombreE
end
else if @accionE = '2'
begin
	update Empleado set CedulaE= @CedulaE, NombresE = @NombreE, ApellidosE  = @ApellidoE , TelefonoE = @TelefonoE,
						DepartE= @DepartamentoE, CorreoE=@CorreE where CedulaE = @CedulaE
end
else if @accionE ='3'
begin
	delete from Empleado where CedulaE = @Cedulae
	set @accionE ='Se elimino cliente:' +@NombreE
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Factura]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Factura]
@Codigo_cliente varchar(50),
@Nombre_cliente varchar(60),
@Fecha_Factura datetime,
@Codigo_Producto varchar(60),
@Nombre_producto varchar(70),
@Detalle_Producto varchar(200),
@Precio_producto varchar(60),
@Cantidad_producto varchar(25),
@total_producto varchar(25),
@Codigo_Vendedor varchar(80),
@accionF varchar(10) output
as
if (@accionF ='1')
begin
	insert into Factura (Codigo_cliente, Nombre_cliente, Fecha_Factura, Codigo_Producto, Nombre_producto, Detalle_Producto, Precio_producto,
	Cantidad_producto, total_producto, Codigo_Vendedor)
	Values (@Codigo_cliente, @Nombre_cliente, @Fecha_Factura , @Codigo_Producto, @Nombre_producto, @Detalle_Producto, @Precio_producto,
	@Cantidad_producto, @total_producto, @Codigo_Vendedor )
	set @accionF ='Se inserto Factura:' + @Nombre_cliente
end
else if @accionF = '2'
begin
	update Factura set Codigo_cliente= @Codigo_cliente, Nombre_cliente = @Nombre_cliente, Fecha_Factura = @Fecha_Factura ,Codigo_Producto = @Codigo_Producto,
	Nombre_producto=@Nombre_producto,  Detalle_Producto =@Detalle_Producto, Precio_producto =@Precio_producto, Cantidad_producto= @Cantidad_producto,
	total_producto =@total_producto, Codigo_Vendedor =@Codigo_Vendedor 
						 where Codigo_cliente = @Codigo_cliente
end
else if @accionF ='3'
begin
	delete from Factura where Codigo_cliente = @Codigo_cliente
	set @accionF ='Se elimino producto:' +@Nombre_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inventario]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_inventario]
@CodigoPr varchar(15),
@cantidad int,
@accionI varchar(10) output  
as 
if (@accionI ='1')
begin
	update productos set cantidad_productor =  cantidad_productor - @cantidad where Codigo_producto = @CodigoPr
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listarCliente]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarCliente]
as
select * 
from Cliente
GO
/****** Object:  StoredProcedure [dbo].[sp_listarEmp]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarEmp]
as
select *
from Empleado
GO
/****** Object:  StoredProcedure [dbo].[sp_listarEmpleado]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarEmpleado]
as
select *
from Empleado
GO
/****** Object:  StoredProcedure [dbo].[sp_listarFactura]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarFactura]
as
select * from Factura
GO
/****** Object:  StoredProcedure [dbo].[sp_listarProducto]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarProducto]
as
select * 
from productos
GO
/****** Object:  StoredProcedure [dbo].[sp_productos]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_productos]
@Codigo_producto varchar(25),
@NombresP varchar(80),
@DetallesP varchar(20),
@PrecioP int,
@CantidadP varchar(20),
@accionP varchar(10) output
as
if (@accionP ='1')
begin
	insert into productos(Nombre_producto, Detalles_producto, Precio_producto, cantidad_productor)
	Values (@NombresP, @DetallesP, @PrecioP , @CantidadP)
	set @accionP ='Se inserto producto:' + @NombresP
end
else if @accionP = '2'
begin
	update productos set Nombre_producto= @NombresP, Detalles_producto = @DetallesP, Precio_producto = @PrecioP , cantidad_productor = @CantidadP
						 where Codigo_producto = @Codigo_producto
end
else if @accionP ='3'
begin
	delete from productos where Codigo_producto = @Codigo_producto
	set @accionP ='Se elimino producto:' +@NombresP
end
GO
/****** Object:  StoredProcedure [dbo].[sp_vendedor]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_vendedor]
as
select Codigo_Empleado
from Empleado
GO
/****** Object:  StoredProcedure [dbo].[TopProducts]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TopProducts]
as
	select top 3 
		Nombre_Producto + ' ' + Detalle_Producto as Producto, 
		SUM(CAST(CANTIDAD_producto AS INT)) as Cantidad 
	from Factura 
	group by Nombre_Producto, Detalle_Producto
	order by Cantidad desc
GO
/****** Object:  StoredProcedure [dbo].[VentProductos]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[VentProductos]
as
	select Nombre_Producto+' '+Detalle_Producto as producto, sum(CAST(Cantidad_producto as int)) as Cantidad
	from Factura
	group by Nombre_Producto, Detalle_Producto


GO
/****** Object:  StoredProcedure [dbo].[VentProductosFecha]    Script Date: 25/4/2022 5:59:04 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VentProductosFecha]
@fechainicial datetime,
@fechafinal datetime
as
	select Nombre_Producto+' '+Detalle_Producto as producto, sum(CAST(Cantidad_producto as int)) as Cantidad
	from Factura where Fecha_Factura >= @fechainicial and Fecha_Factura <= @fechafinal  
	group by Nombre_Producto, Detalle_Producto


GO
USE [master]
GO
ALTER DATABASE [Facturacion] SET  READ_WRITE 
GO
