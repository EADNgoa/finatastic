CREATE TABLE [dbo].[FDs]
(
	[FDID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FDNo] VARCHAR(50) NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    [FDName] VARCHAR(50) NOT NULL, 
    [BuyDate] DATE NULL, 
    [Interest] DECIMAL(5, 2) NOT NULL, 
    [Amount] DECIMAL(10, 2) NOT NULL, 
    [Maturity] DATE NOT NULL, 
    [Comment] VARCHAR(150) NULL
)
