
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
	(1,	'Αγία Σοφία',	'Μυστράς'),
	(2,	'’γιοι Θεόδωροι',	'Μυστράς'),
	(3,	'’γιος Γεώργιος Μήθυμνας',	'Κίσσαμος'),
	(4,	'’γιος Νικόλαος',	'Μυστράς'),
	(5,	'Αγορά αρχαίας Ήλιδας',	'Ήλιδα'),
	(6,	'Αγορά Κασσώπης',	'Καμαρίνα Θεσπρωτίας'),
	(7,	'Αγροτική Τράπεζα Αστακού',	'Αστακός'),
	(8,	'Ακαδημία Αθηνών',	'Αθήνα'),
	(9,	'Ακρόπολη Δωδώνης',	'Δωδώνη'),
	(10,	'Αμαράντειος Σχολή Ρόδου',	'Ρόδος'),
	(11,	'Ανάγλυφο του Μίθρα Ταυροκτόνου'	,'Ξάνθη'),
	(12,	'Ανάθημα του Δαόχου'	,	'Δελφοί'),
	(13,	'Ανακτορικό συγκρότημα Γαλέριου',	'Θεσσαλονίκη'),
	(14,	'Ανάκτορο Κνωσού'	, 'Κνωσός'),
	(15,	'Ανάκτορο Αιγών',	'Βεργίνα'),
	(16,	'Ανάκτορο Αρχανών',	'Επάνω Αρχάνες Ηρακλείου'),
	(17,	'Ανάκτορο Γαλατά',	'Γαλατάς Ηρακλείου'),
	(18,	'Ανάκτορο Δημητριάδος',	'Δημητριάδα'),
	(19,	'Ανάκτορο Μαλίων',	'Μάλια'),
	(20,	'Ανάκτορο Φαιστού',	'Φαιστός'),
	(21,	'Ανδριάντας Λεωνίδα',	'Θερμοπύλες');
	
GO


