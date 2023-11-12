USE [ITTicketing]
GO
/****** Object:  Table [dbo].[tblIncidentTicket]    Script Date: 12/11/2023 4:39:17 PM ******/
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
