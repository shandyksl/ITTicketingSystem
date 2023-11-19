USE [ITTicketing]
GO
/****** Object:  Table [dbo].[tblEnhancementTicket]    Script Date: 20/11/2023 12:51:41 AM ******/
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
/****** Object:  Table [dbo].[tblIncidentTicket]    Script Date: 20/11/2023 12:51:41 AM ******/
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
/****** Object:  Table [dbo].[tblLocation]    Script Date: 20/11/2023 12:51:41 AM ******/
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
/****** Object:  Table [dbo].[tblShift]    Script Date: 20/11/2023 12:51:41 AM ******/
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
/****** Object:  Table [dbo].[tblUser]    Script Date: 20/11/2023 12:51:41 AM ******/
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
