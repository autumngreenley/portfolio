-- Users table
CREATE TABLE [dbo].[Users]
(
	[ID]		INT IDENTITY (1,1)	NOT NULL,
	[FirstName]	NVARCHAR(64)		NOT NULL,
	[LastName]	NVARCHAR(128)		NOT NULL,
	[DOB]		DateTime			NOT NULL,
	CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO [dbo].[Users] (FirstName, LastName, DOB) VALUES
	('Jim','Johnson','2000-08-22 00:00:00'),
	('Sue','Suzanne','2005-11-12 00:00:00'),
	('Mira','Kuzak','1997-03-02 00:00:00')
GO