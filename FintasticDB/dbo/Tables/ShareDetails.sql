CREATE TABLE [dbo].[ShareDetails]
(
	[ShareDetailID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShareID] INT NOT NULL, 
    [TDate] DATE NOT NULL, 
    [BuyAmountRs] DECIMAL(10, 2) NULL, 
    [SellAmountRs] DECIMAL(10, 2) NULL, 
    [Units] INT NULL, 
    [Comment] VARCHAR(150) NULL, 
    CONSTRAINT [FK_ShareDetails_ToShares] FOREIGN KEY (ShareID) REFERENCES [Shares]([ShareID])
)
