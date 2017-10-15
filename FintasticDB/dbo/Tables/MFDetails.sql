CREATE TABLE [dbo].[MFDetails]
(
	[MFDetailID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MFID] INT NOT NULL, 
    [TDate] DATE NOT NULL, 
    [SourceBankID] INT NULL, 
    [SourceMFID] INT NULL, 
    [BuyAmountRs] DECIMAL(10, 2) NULL, 
    [SellAmountRs] DECIMAL(10, 2) NULL, 
    [Comment] VARCHAR(150) NULL, 
    CONSTRAINT [FK_MFDetails_ToMFs] FOREIGN KEY (MFID) REFERENCES [MFs]([MFID]), 
	CONSTRAINT [FK_MFDetailsSourc_ToMFs] FOREIGN KEY (SourceMFID) REFERENCES [MFs]([MFID]), 
    CONSTRAINT [FK_MFDetails_ToBanks] FOREIGN KEY ([SourceBankID]) REFERENCES [Banks]([BankID])
)
