﻿CREATE TABLE [dbo].[Banks]
(
	[BankID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Bank] VARCHAR(50) NOT NULL, 
    [AcNo] VARCHAR(50) NOT NULL, 
    [Comment] VARCHAR(150) NULL
)
