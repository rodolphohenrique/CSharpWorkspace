CREATE TABLE [dbo].[Table]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Client] BIT NULL, 
    [Last_Call] DATETIME NULL 
)


