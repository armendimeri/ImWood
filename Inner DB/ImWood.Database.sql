USE [master]
GO
/****** Object:  Database [ImWood]    Script Date: 7/13/2020 3:59:16 PM ******/
CREATE DATABASE [ImWood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ImWood', FILENAME = N'D:\DATA\ImWood.mdf' , SIZE = 15360KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ImWood_log', FILENAME = N'D:\DATA\ImWood_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ImWood] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ImWood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ImWood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ImWood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ImWood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ImWood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ImWood] SET ARITHABORT OFF 
GO
ALTER DATABASE [ImWood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ImWood] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ImWood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ImWood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ImWood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ImWood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ImWood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ImWood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ImWood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ImWood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ImWood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ImWood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ImWood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ImWood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ImWood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ImWood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ImWood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ImWood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ImWood] SET RECOVERY FULL 
GO
ALTER DATABASE [ImWood] SET  MULTI_USER 
GO
ALTER DATABASE [ImWood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ImWood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ImWood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ImWood] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ImWood] SET  READ_WRITE 
GO
