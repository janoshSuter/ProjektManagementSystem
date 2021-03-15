USE [master]
GO

/****** Object:  Database [ProjektManagementSystemDB]    Script Date: 15.03.2021 16:16:40 ******/
CREATE DATABASE [ProjektManagementSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjektManagementSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjektManagementSystemDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjektManagementSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjektManagementSystemDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjektManagementSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET  MULTI_USER 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ProjektManagementSystemDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ProjektManagementSystemDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ProjektManagementSystemDB] SET  READ_WRITE 
GO

