USE [master]
GO

/****** Object:  Database [Control de Pedidos Fotocopiadora UTN]    Script Date: 10/6/2020 19:07:50 ******/
CREATE DATABASE [Control de Pedidos Fotocopiadora UTN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Control de Pedidos Fotocopiadora UTN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Control de Pedidos Fotocopiadora UTN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Control de Pedidos Fotocopiadora UTN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Control de Pedidos Fotocopiadora UTN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Control de Pedidos Fotocopiadora UTN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ARITHABORT OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET RECOVERY FULL 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET  MULTI_USER 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Control de Pedidos Fotocopiadora UTN] SET  READ_WRITE 
GO


