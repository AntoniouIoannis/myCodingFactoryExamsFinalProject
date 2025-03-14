USE [CultureGR]
GO
/****** Object:  Table [dbo].[CategotiesTheme]    Script Date: 23/12/2024 20:46:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategotiesTheme](
	[id] [uniqueidentifier] NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
 CONSTRAINT [PK_CategotiesTheme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Points]    Script Date: 23/12/2024 20:46:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Points](
	[id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[city] [nvarchar](100) NULL,
	[Region] [nvarchar](100) NULL,
	[Category] [nvarchar](100) NULL,
	[season] [text] NULL,
	[image] [image] NOT NULL,
 CONSTRAINT [PK_Points] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeasonPeriods]    Script Date: 23/12/2024 20:46:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeasonPeriods](
	[id] [uniqueidentifier] NOT NULL,
	[SeasonPeriod] [text] NULL,
 CONSTRAINT [PK_SeasonPeriods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Points]  WITH CHECK ADD  CONSTRAINT [FK_Points_Category] FOREIGN KEY([id])
REFERENCES [dbo].[Points] ([id])
GO
ALTER TABLE [dbo].[Points] CHECK CONSTRAINT [FK_Points_Category]
GO
