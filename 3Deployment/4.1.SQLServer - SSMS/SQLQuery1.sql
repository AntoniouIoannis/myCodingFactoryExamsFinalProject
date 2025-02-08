USE [CultureGR]
GO

drop table EXHIBITS

/****** Object:  Table [dbo].[MUSEUMS]    Script Date: 23/1/2025 01:01:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
********************************************
CREATE TABLE [dbo].[MUSEUMS](
	[mus_id] [int] NOT NULL,
	[mus_name] [nvarchar](150) NULL,
	[mus_desc] [text] NULL,
	[mus_address] [text] NULL,
	[mus_phone] [nchar](60) NULL,
	[mus_open] [nvarchar](150) NULL,
	[category_id] [int] NOT NULL,
	[coll_id] [int] NOT NULL,
	[mus_avg_rate] [tinyint] NULL,
	[mus_coordinate] [geography] NULL,
 CONSTRAINT [PK_MUSEUMS] PRIMARY KEY CLUSTERED 
(
	[mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
*****************************************
ALTER TABLE [dbo].[MUSEUMS]  WITH CHECK ADD  CONSTRAINT [FK_MUSEUMS_CATEGORIESMUSEUMS] FOREIGN KEY([category_id])
REFERENCES [dbo].[CATEGORIESMUSEUMS] ([cat_id])
GO

ALTER TABLE [dbo].[MUSEUMS] CHECK CONSTRAINT [FK_MUSEUMS_CATEGORIESMUSEUMS]
GO

ALTER TABLE [dbo].[MUSEUMS]  WITH CHECK ADD  CONSTRAINT [FK_MUSEUMS_COLLECTIONS] FOREIGN KEY([coll_id])
REFERENCES [dbo].[COLLECTIONS] ([coll_id])

GO

ALTER TABLE [dbo].[MUSEUMS] CHECK CONSTRAINT [FK_MUSEUMS_EXHIBITS]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table CATEGORIESMUSEUMS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_CATEGORIESMUSEUMS'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table EXHIBITS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_EXHIBITS'
GO

*****************************************
CREATE TABLE [dbo].[MUSEUMS_COLLECTIONS] (
    [mus_id] INT NOT NULL,
    [coll_id] INT NOT NULL,
    CONSTRAINT [PK_MUSEUMS_COLLECTIONS] PRIMARY KEY (mus_id, coll_id),
    CONSTRAINT [FK_MUSEUMS_COLLECTIONS_MUSEUMS] FOREIGN KEY (mus_id) REFERENCES [dbo].[MUSEUMS](mus_id),
    CONSTRAINT [FK_MUSEUMS_COLLECTIONS_COLLECTIONS] FOREIGN KEY (coll_id) REFERENCES [dbo].[COLLECTIONS](coll_id)
);
GO

**********************************************
CREATE TABLE [dbo].[COLLECTIONS](
	[exh_id] [int] NOT NULL,
	[name_collection] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_COLLECTIONS] PRIMARY KEY CLUSTERED 
(
	[exh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

***********************************
CREATE TABLE [dbo].[COLLECTIONS_TIME_PERIODS] (
    [coll_id] INT NOT NULL,
    [p_id] INT NOT NULL,
    CONSTRAINT [PK_COLLECTIONS_TIME_PERIODS] PRIMARY KEY (coll_id, p_id),
    CONSTRAINT [FK_COLLECTIONS_TIME_PERIODS_COLLECTIONS] FOREIGN KEY (coll_id) REFERENCES [dbo].[COLLECTIONS](coll_id),
    CONSTRAINT [FK_COLLECTIONS_TIME_PERIODS_TIME_PERIODS] FOREIGN KEY (p_id) REFERENCES [dbo].[TIME_PERIODS](p_id)
);
GO

*******************************************





















