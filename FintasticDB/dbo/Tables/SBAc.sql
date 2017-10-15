CREATE TABLE [dbo].[SBAc]
(
	[SBAcID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[BankID] INT NULL, 
    [TDate] DATE NULL, 
    [AmtIn] DECIMAL(10, 2) NULL, 
    [AmtOut] DECIMAL(10, 2) NULL, 
    [Comment] VARCHAR(150) NULL, 
    [CatID] INT NULL, 
    [MFID] INT NULL, 
    [ShareID] INT NULL, 
    [FDID] INT NULL
)
