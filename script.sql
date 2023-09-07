USE [master]
GO
/****** Object:  Database [login]    Script Date: 7/09/2023 18:32:53 ******/
CREATE DATABASE [login]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'login', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\login.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'login_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\login_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [login] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [login].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [login] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [login] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [login] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [login] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [login] SET ARITHABORT OFF 
GO
ALTER DATABASE [login] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [login] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [login] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [login] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [login] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [login] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [login] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [login] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [login] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [login] SET  DISABLE_BROKER 
GO
ALTER DATABASE [login] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [login] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [login] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [login] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [login] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [login] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [login] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [login] SET RECOVERY FULL 
GO
ALTER DATABASE [login] SET  MULTI_USER 
GO
ALTER DATABASE [login] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [login] SET DB_CHAINING OFF 
GO
ALTER DATABASE [login] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [login] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [login] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [login] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'login', N'ON'
GO
ALTER DATABASE [login] SET QUERY_STORE = ON
GO
ALTER DATABASE [login] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [login]
GO
/****** Object:  Table [dbo].[inicio_sesion]    Script Date: 7/09/2023 18:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inicio_sesion](
	[pass_log] [int] NULL,
	[user_log] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[inicio_sesion] ([pass_log], [user_log]) VALUES (1010, N'juan')
GO
USE [master]
GO
ALTER DATABASE [login] SET  READ_WRITE 
GO
