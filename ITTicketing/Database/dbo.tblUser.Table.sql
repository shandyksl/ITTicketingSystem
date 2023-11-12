USE [ITTicketing]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 12/11/2023 4:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cc] [nvarchar](50) NULL,
	[un] [nvarchar](50) NULL,
	[pw] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
	[createdDate] [datetime] NULL,
	[updatedDate] [datetime] NULL
) ON [PRIMARY]
GO
