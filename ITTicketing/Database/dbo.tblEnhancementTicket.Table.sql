USE [ITTicketing]
GO
/****** Object:  Table [dbo].[tblEnhancementTicket]    Script Date: 12/11/2023 4:39:17 PM ******/
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
