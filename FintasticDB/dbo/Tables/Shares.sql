CREATE TABLE [dbo].[Shares]
(
	[ShareID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Active] BIT NOT NULL DEFAULT 1, 
    [Symbol] VARCHAR(15) NULL, 
    [Company] VARCHAR(50) NULL
)
