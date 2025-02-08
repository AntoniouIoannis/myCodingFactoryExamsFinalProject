USE [CultureGR]
GO
/****** Object:  Table [dbo].[MONUMENTS]    Script Date: 11/1/2025 02:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONUMENTS](
	[mon_id] [int] NOT NULL,
	[mon_name] [nvarchar](50) NULL,
	[mon_location] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
