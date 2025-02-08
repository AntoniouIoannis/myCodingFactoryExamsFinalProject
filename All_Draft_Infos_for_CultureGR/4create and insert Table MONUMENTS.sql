
CREATE TABLE [dbo].[MONUMENTS](
	[mon_id] [int] NOT NULL,
	[mon_name] [nvarchar](50) NULL,
	[mon_location] [text] NULL,
	/*[period_id] [int] NOT NULL,
	[exhibit_id] [int] NOT NULL*/
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*ALTER TABLE [dbo].[MONUMENTS]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_EXHIBITS] FOREIGN KEY([exhibit_id])
REFERENCES [dbo].[EXHIBITS] ([exh_id])
GO

ALTER TABLE [dbo].[MONUMENTS] CHECK CONSTRAINT [FK_Table_1_EXHIBITS]
GO */

drop table MONUMENTS
go

INSERT INTO DBO.MONUMENTS(mon_id, mon_name, mon_location)
VALUES
	(1,	'���� �����',	'�������'),
	(2,	'����� ��������',	'�������'),
	(3,	'����� �������� ��������',	'��������'),
	(4,	'����� ��������',	'�������'),
	(5,	'����� ������� ������',	'�����'),
	(6,	'����� ��������',	'�������� ����������'),
	(7,	'�������� ������� �������',	'�������'),
	(8,	'�������� ������',	'�����'),
	(9,	'�������� �������',	'������'),
	(10,	'����������� ����� �����',	'�����'),
	(11,	'�������� ��� ����� �����������'	,'�����'),
	(12,	'������� ��� ������'	,	'������'),
	(13,	'���������� ���������� ��������',	'�����������'),
	(14,	'�������� ������'	, '������'),
	(15,	'�������� �����',	'�������'),
	(16,	'�������� �������',	'����� ������� ���������'),
	(17,	'�������� ������',	'������� ���������'),
	(18,	'�������� �����������',	'����������'),
	(19,	'�������� ������',	'�����'),
	(20,	'�������� �������',	'�������'),
	(21,	'���������� �������',	'����������');
	
GO


