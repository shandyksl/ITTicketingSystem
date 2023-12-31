USE [master]
GO
/****** Object:  Database [ITTicketing]    Script Date: 21/11/2023 11:35:01 AM ******/
CREATE DATABASE [ITTicketing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ITTicketing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ITTicketing.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ITTicketing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ITTicketing_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ITTicketing] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ITTicketing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ITTicketing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ITTicketing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ITTicketing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ITTicketing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ITTicketing] SET ARITHABORT OFF 
GO
ALTER DATABASE [ITTicketing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ITTicketing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ITTicketing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ITTicketing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ITTicketing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ITTicketing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ITTicketing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ITTicketing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ITTicketing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ITTicketing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ITTicketing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ITTicketing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ITTicketing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ITTicketing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ITTicketing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ITTicketing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ITTicketing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ITTicketing] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ITTicketing] SET  MULTI_USER 
GO
ALTER DATABASE [ITTicketing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ITTicketing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ITTicketing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ITTicketing] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ITTicketing] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ITTicketing] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ITTicketing] SET QUERY_STORE = ON
GO
ALTER DATABASE [ITTicketing] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ITTicketing]
GO
/****** Object:  Table [dbo].[tblEnhancementTicket]    Script Date: 21/11/2023 11:35:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEnhancementTicket](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[ticketNo] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[objective] [nvarchar](200) NULL,
	[description] [nvarchar](500) NULL,
	[chat] [nvarchar](max) NULL,
	[assignGroup] [nvarchar](50) NULL,
	[createdBy] [nvarchar](50) NULL,
	[updatedBy] [nvarchar](50) NULL,
	[requiredDate] [nvarchar](50) NULL,
	[createdDate] [nvarchar](50) NULL,
	[updatedDate] [nvarchar](50) NULL,
	[developing] [nvarchar](max) NULL,
	[complete] [nvarchar](500) NULL,
	[estimateDate] [nvarchar](50) NULL,
	[completeDate] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIncidentTicket]    Script Date: 21/11/2023 11:35:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIncidentTicket](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[ticketNo] [nvarchar](50) NULL,
	[priority] [nvarchar](10) NULL,
	[title] [nvarchar](200) NULL,
	[status] [nvarchar](50) NULL,
	[description] [nvarchar](500) NULL,
	[type] [nvarchar](50) NULL,
	[location] [nvarchar](50) NULL,
	[assignGroup] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[chat] [nvarchar](max) NULL,
	[solution] [nvarchar](max) NULL,
	[comment] [nvarchar](max) NULL,
	[solvedBy] [nvarchar](50) NULL,
	[closedBy] [nvarchar](50) NULL,
	[createdBy] [nvarchar](50) NULL,
	[updatedBy] [nvarchar](50) NULL,
	[createdDate] [nvarchar](50) NULL,
	[updatedDate] [nvarchar](50) NULL,
	[solveDate] [nvarchar](50) NULL,
	[closeDate] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLocation]    Script Date: 21/11/2023 11:35:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLocation](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[location] [nvarchar](50) NULL,
	[createdDate] [nvarchar](50) NULL,
	[createdBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblShift]    Script Date: 21/11/2023 11:35:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblShift](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[createdDate] [nvarchar](50) NULL,
	[createdBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 21/11/2023 11:35:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[un] [nvarchar](50) NULL,
	[pw] [nvarchar](50) NULL,
	[dept] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[createdDate] [nvarchar](50) NULL,
	[updatedDate] [nvarchar](50) NOT NULL,
	[createdBy] [nvarchar](50) NULL,
	[updatedBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblEnhancementTicket] ON 

INSERT [dbo].[tblEnhancementTicket] ([id], [cc], [ticketNo], [type], [status], [objective], [description], [chat], [assignGroup], [createdBy], [updatedBy], [requiredDate], [createdDate], [updatedDate], [developing], [complete], [estimateDate], [completeDate]) VALUES (6, N'NTMP', N'ENC-20231022-0001', N'Enterprise Resource Planning System', N'NEW', N'erp is broken', N'please help', N'2023-10-22 22:32:24 SHENGLI : please help', N'IT ADMIN', N'SHENGLI', N'SHENGLI', N'2023-10-25 22:32:24', N'2023-10-22 22:32:24', N'2023-10-22 22:32:24', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblEnhancementTicket] ([id], [cc], [ticketNo], [type], [status], [objective], [description], [chat], [assignGroup], [createdBy], [updatedBy], [requiredDate], [createdDate], [updatedDate], [developing], [complete], [estimateDate], [completeDate]) VALUES (7, N'NTMP', N'ENC-20231022-0002', N'Manufacturing Packing System', N'COMPLETED', N'Please help to modify the packing system', N'The packing system need to add one more product code', N'2023-10-22 22:37:51 SHENGLI : please help to add one product code latest by this week wednesday. 
2023-10-22 22:37:51 ADMIN : develop test
2023-10-22 22:37:51 ADMIN : complete test
2023-10-22 22:37:51 SHENGLI : sorry close
2023-10-22 22:37:51 ADMIN : its ok, then i will close the ticket', N'IT ADMIN', N'SHENGLI', N'ADMIN', N'2023-10-26 22:37:51', N'2023-10-22 22:37:51', N'2023-10-28 17:20:24', N'waiting for schedule ', N'waiting for schedule ', N'2023-10-27 22:52:24', N'2023-10-24 23:15:08')
INSERT [dbo].[tblEnhancementTicket] ([id], [cc], [ticketNo], [type], [status], [objective], [description], [chat], [assignGroup], [createdBy], [updatedBy], [requiredDate], [createdDate], [updatedDate], [developing], [complete], [estimateDate], [completeDate]) VALUES (8, N'NTMP', N'ENC-20231025-0003', N'Manufacturing Packing System', N'REJECT', N'Please help to modify the packing system', N'The packing system need to add one more product code', N'2023-10-22 22:37:51 SHENGLI : please help to add one product code latest by this week wednesday. 
2023-10-22 22:37:51 ADMIN : develop test
2023-10-22 22:37:51 ADMIN : complete test
2023-10-22 22:37:51 SHENGLI : why reject, can you let me know ?', N'IT ADMIN', N'SHENGLI', N'SHENGLI', N'2023-10-26 22:37:51', N'2023-10-22 22:37:51', N'2023-10-22 22:37:51', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblEnhancementTicket] OFF
GO
SET IDENTITY_INSERT [dbo].[tblIncidentTicket] ON 

INSERT [dbo].[tblIncidentTicket] ([id], [cc], [ticketNo], [priority], [title], [status], [description], [type], [location], [assignGroup], [shift], [chat], [solution], [comment], [solvedBy], [closedBy], [createdBy], [updatedBy], [createdDate], [updatedDate], [solveDate], [closeDate]) VALUES (4, N'NTMP', N'INC-20231111-0004', N'Medium', N'Setup MES Station (Glob Top)', N'CLOSED', N'Please help to setup MES station (Glob Top)', N'Manufacturing Execution System', N'Plant 1 Production Module 2', N'IT ADMIN', N'Normal', N'2023-11-11 00:33:17 SHENGLI : How long will it take to setup MES station (Glob Top)?
2023-11-11 02:42:26 ADMIN : if there is nothing, i will close this ticket ', N'Done setup ', N'', N'ADMIN', NULL, N'SHENGLI', N'SHENGLI', N'2023-11-11 00:28:02', N'2023-11-15 02:05:55', N'2023-11-15 02:05:55', NULL)
SET IDENTITY_INSERT [dbo].[tblIncidentTicket] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLocation] ON 

INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (10, N'NTMP', N'Plant 1 Production Module 1', N'2023-11-20 00:05:20', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (11, N'NTMP', N'Plant 1 Production Module 2', N'2023-11-20 00:05:26', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (12, N'NTMP', N'Plant 2 Production Module 1', N'2023-11-20 00:05:31', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (13, N'NTMP', N'Plant 2 Production Module 2', N'2023-11-20 00:05:36', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (14, N'NTMP', N'Finish Good Area', N'2023-11-20 00:05:41', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (15, N'NTMP', N'Shipping Office', N'2023-11-20 00:05:46', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (16, N'NTMP', N'Supply Chain And Management Office', N'2023-11-20 00:05:51', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (17, N'NTMP', N'HR Office', N'2023-11-20 00:05:56', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (18, N'NTMP', N'Engineering Office', N'2023-11-20 00:06:01', N'ADMIN')
INSERT [dbo].[tblLocation] ([id], [cc], [location], [createdDate], [createdBy]) VALUES (19, N'NTMP', N'BU Office', N'2023-11-20 00:06:06', N'ADMIN')
SET IDENTITY_INSERT [dbo].[tblLocation] OFF
GO
SET IDENTITY_INSERT [dbo].[tblShift] ON 

INSERT [dbo].[tblShift] ([id], [cc], [shift], [createdDate], [createdBy]) VALUES (2, N'NTMP', N'Standard', N'2023-11-20 00:31:39', N'ADMIN')
INSERT [dbo].[tblShift] ([id], [cc], [shift], [createdDate], [createdBy]) VALUES (3, N'NTMP', N'Morning', N'2023-11-20 00:31:56', N'ADMIN')
INSERT [dbo].[tblShift] ([id], [cc], [shift], [createdDate], [createdBy]) VALUES (4, N'NTMP', N'Night', N'2023-11-20 00:32:04', N'ADMIN')
SET IDENTITY_INSERT [dbo].[tblShift] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON 

INSERT [dbo].[tblUser] ([id], [cc], [un], [pw], [dept], [role], [mobile], [createdDate], [updatedDate], [createdBy], [updatedBy]) VALUES (1, N'NTMP', N'ADMIN', N'123123', N'IT', N'IT ADMIN', N'0124609827', N'Oct  8 2023 12:00AM', N'Oct  8 2023 12:00AM', NULL, NULL)
INSERT [dbo].[tblUser] ([id], [cc], [un], [pw], [dept], [role], [mobile], [createdDate], [updatedDate], [createdBy], [updatedBy]) VALUES (2, N'NTMP', N'SHENGLI', N'456456', N'BU', N'USER', N'0179876543', N'Oct 15 2023 12:00AM', N'Oct 15 2023 12:00AM', NULL, NULL)
INSERT [dbo].[tblUser] ([id], [cc], [un], [pw], [dept], [role], [mobile], [createdDate], [updatedDate], [createdBy], [updatedBy]) VALUES (6, N'NTMP', N'newplayer', N'9789', N'9789', N'IT ADMIN', N'0120931930', N'2023-11-19 22:29:22', N'2023-11-19 22:29:22', N'ADMIN', N'ADMIN')
SET IDENTITY_INSERT [dbo].[tblUser] OFF
GO
USE [master]
GO
ALTER DATABASE [ITTicketing] SET  READ_WRITE 
GO
