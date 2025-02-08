USE [CultureGR]
GO
/****** Object:  Table [dbo].[ARCHAEOLOGICAL_POINTS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARCHAEOLOGICAL_POINTS](
	[arc_id] [int] NOT NULL,
	[arc_name] [nvarchar](50) NULL,
	[arc_location] [nvarchar](50) NULL,
	[archaeological_exh_id] [int] NOT NULL,
	[archaeological_per_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CALENDAR]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDAR](
	[cal_id] [int] NULL,
	[cmonth] [date] NULL,
	[cyear] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIESMUSEUMS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIESMUSEUMS](
	[cat_id] [int] NOT NULL,
	[cat_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_CATEGORIESMUSEUMS] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXHIBITS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXHIBITS](
	[exh_id] [int] NOT NULL,
	[name_collection] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EXHIBITS] PRIMARY KEY CLUSTERED 
(
	[exh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAINTENANCE_EXHIBITS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAINTENANCE_EXHIBITS](
	[mnt_id] [int] NOT NULL,
	[mnt_desc] [nvarchar](50) NULL,
	[maintenance_exh_id] [int] NOT NULL,
	[maintenance_name_collection] [nvarchar](50) NULL,
	[museum_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONUMENTS]    Script Date: 9/1/2025 23:50:07 ******/
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
/****** Object:  Table [dbo].[MUSEUMS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUSEUMS](
	[mus_id] [int] NOT NULL,
	[mus_name] [nvarchar](50) NULL,
	[mus_desc] [text] NULL,
	[mus_address] [text] NULL,
	[mus_coordinations] [text] NULL,
	[mus_phone] [nchar](10) NULL,
	[period_id] [int] NOT NULL,
	[period_name] [nvarchar](50) NULL,
	[time] [sql_variant] NULL,
	[categoty_id] [int] NOT NULL,
	[category_name] [nvarchar](50) NULL,
	[exhibit_id] [int] NOT NULL,
	[exhibit_name_collection] [nvarchar](50) NULL,
 CONSTRAINT [PK_MUSEUMS] PRIMARY KEY CLUSTERED 
(
	[mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESTORES_EXHIBITIS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESTORES_EXHIBITIS](
	[res_id] [int] NOT NULL,
	[res_name] [text] NULL,
	[restore_exh_id] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIME_PERIODS]    Script Date: 9/1/2025 23:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIME_PERIODS](
	[p_id] [int] NOT NULL,
	[per_name] [ntext] NULL,
	[per_time_start] [ntext] NULL,
	[per_time_end] [ntext] NULL,
 CONSTRAINT [PK_TIME_PERIODS] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ARCHAEOLOGICAL_POINTS]  WITH CHECK ADD  CONSTRAINT [FK_ARCHAEOLOGICAL_POINTS_EXHIBITS] FOREIGN KEY([archaeological_exh_id])
REFERENCES [dbo].[EXHIBITS] ([exh_id])
GO
ALTER TABLE [dbo].[ARCHAEOLOGICAL_POINTS] CHECK CONSTRAINT [FK_ARCHAEOLOGICAL_POINTS_EXHIBITS]
GO
ALTER TABLE [dbo].[ARCHAEOLOGICAL_POINTS]  WITH CHECK ADD  CONSTRAINT [FK_ARCHAEOLOGICAL_POINTS_TIME_PERIODS] FOREIGN KEY([archaeological_per_id])
REFERENCES [dbo].[TIME_PERIODS] ([p_id])
GO
ALTER TABLE [dbo].[ARCHAEOLOGICAL_POINTS] CHECK CONSTRAINT [FK_ARCHAEOLOGICAL_POINTS_TIME_PERIODS]
GO
ALTER TABLE [dbo].[MAINTENANCE_EXHIBITS]  WITH CHECK ADD  CONSTRAINT [FK_MAINTENANCE_EXHIBITS_EXHIBITS] FOREIGN KEY([maintenance_exh_id])
REFERENCES [dbo].[EXHIBITS] ([exh_id])
GO
ALTER TABLE [dbo].[MAINTENANCE_EXHIBITS] CHECK CONSTRAINT [FK_MAINTENANCE_EXHIBITS_EXHIBITS]
GO
ALTER TABLE [dbo].[MAINTENANCE_EXHIBITS]  WITH CHECK ADD  CONSTRAINT [FK_MAINTENANCE_EXHIBITS_MUSEUMS] FOREIGN KEY([museum_id])
REFERENCES [dbo].[MUSEUMS] ([mus_id])
GO
ALTER TABLE [dbo].[MAINTENANCE_EXHIBITS] CHECK CONSTRAINT [FK_MAINTENANCE_EXHIBITS_MUSEUMS]
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
ALTER TABLE [dbo].[RESTORES_EXHIBITIS]  WITH CHECK ADD  CONSTRAINT [FK_RESTORES_EXHIBITIS_EXHIBITS] FOREIGN KEY([restore_exh_id])
REFERENCES [dbo].[EXHIBITS] ([exh_id])
GO
ALTER TABLE [dbo].[RESTORES_EXHIBITIS] CHECK CONSTRAINT [FK_RESTORES_EXHIBITIS_EXHIBITS]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table CATEGORIESMUSEUMS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_CATEGORIESMUSEUMS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table EXHIBITS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_EXHIBITS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'foreign key which feeded from the table  TIME_PERIOD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MUSEUMS', @level2type=N'CONSTRAINT',@level2name=N'FK_MUSEUMS_TIME_PERIODS'
GO
