USE [master]
GO

/****** Object:  Table [dbo].[tblFormAuthentication]    Script Date: 10-Sep-18 5:21:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblFormAuthentication](
	[UserID] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](125) NOT NULL,
	[LastName] [nvarchar](100) NULL,
	[EmailID] [nvarchar](125) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO


