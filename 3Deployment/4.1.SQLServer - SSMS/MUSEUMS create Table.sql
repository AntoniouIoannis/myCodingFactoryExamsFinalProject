USE [CultureGR]
GO

/****** Object:  Table [dbo].[MUSEUMS]    Script Date: 19/1/2025 10:16:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MUSEUMS](
	[mus_id] [int] IDENTITY(1,1) NOT NULL,
	[mus_name] [nvarchar](150) NULL,
	[mus_desc] [text] NULL,
	[mus_address] [text] NULL,
	[mus_phone] [nchar](60) NULL,
	[period_id] [int] NOT NULL,
	[period_name] [nvarchar](50) NULL,
	[categoty_id] [int] NOT NULL,
	[category_name] [nvarchar](50) NULL,
	[exhibit_id] [int] NOT NULL,
	[exhibit_name_collection] [nvarchar](50) NULL,
	[mus_avg_rate] [tinyint] NULL,
	[mus_open] [nvarchar](150) NULL,
	[mus_coordinate] [geography] NULL,
 CONSTRAINT [PK_MUSEUMS] PRIMARY KEY CLUSTERED 
(
	[mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[MUSEUMS]  WITH CHECK ADD  CONSTRAINT [FK_MUSEUMS_CATEGORIESMUSEUMS] FOREIGN KEY([categoty_id])
REFERENCES [dbo].[CATEGORIESMUSEUMS] ([cat_id])
GO

ALTER TABLE [dbo].[MUSEUMS] CHECK CONSTRAINT [FK_MUSEUMS_CATEGORIESMUSEUMS]
GO

ALTER TABLE [dbo].[MUSEUMS]  WITH CHECK ADD  CONSTRAINT [FK_MUSEUMS_EXHIBITS] FOREIGN KEY([exhibit_id])
REFERENCES [dbo].[EXHIBITS] ([exh_id])
GO

ALTER TABLE [dbo].[MUSEUMS] CHECK CONSTRAINT [FK_MUSEUMS_EXHIBITS]
GO

ALTER TABLE [dbo].[MUSEUMS]  WITH CHECK ADD  CONSTRAINT [FK_MUSEUMS_TIME_PERIODS] FOREIGN KEY([period_id])
REFERENCES [dbo].[TIME_PERIODS] ([p_id])
GO

ALTER TABLE [dbo].[MUSEUMS] CHECK CONSTRAINT [FK_MUSEUMS_TIME_PERIODS]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table CATEGORIESMUSEUMS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_CATEGORIESMUSEUMS'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table EXHIBITS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_EXHIBITS'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table  TIME_PERIOD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_TIME_PERIODS'
GO


