USE [CultureGR]
GO

/****** Object:  Table [dbo].[ARCHAEOLOGICAL_POINTS]    Script Date: 11/1/2025 02:25:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ARCHAEOLOGICAL_POINTS](
	[arc_id] [int] IDENTITY(1,1) NOT NULL,
	[arc_name] [nvarchar](50) NULL,
	[arc_location] [nvarchar](50) NULL,
	[archaeological_exh_id] [int] NOT NULL,
	[archaeological_per_id] [int] NOT NULL
) ON [PRIMARY]
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


insert into ARCHAEOLOGICAL_POINTS(arc_id, arc_name)
values
	(1, 'Ακρόπολη Αθηνών'),
	(2, 'Το χρηστήριον των Δελφών'),
	(3, 'Μονεμβασία'),
	(4, 'κάστρο της Κω'),
	(5, 'Δελφοί'),
	(6, 'Κνωσός'), 
	(7, 'Δωδώνη'),
	(8, 'Μυκήνες'),
	(9, 'Επίδαυρος'),
	(10, 'Σαντορίνη'),
	(11, 'Δίον'),
	(12, 'Ωδείο');
	go