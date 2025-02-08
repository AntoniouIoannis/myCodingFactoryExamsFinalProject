USE [CultureGR]
GO
/****** Object:  Table [dbo].[WriterCategory]    Script Date: 21/1/2025 00:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WriterCategory](
	[UserID] [int] NOT NULL,
	[cat_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WriterCategory]  WITH CHECK ADD FOREIGN KEY([cat_id])
REFERENCES [dbo].[CATEGORIESMUSEUMS] ([cat_id])
GO
ALTER TABLE [dbo].[WriterCategory]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
