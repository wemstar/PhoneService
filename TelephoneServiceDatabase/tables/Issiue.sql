CREATE TABLE [dbo].[Issiue]
(
	[Issiue_ID] INT NOT NULL PRIMARY KEY, 
    [Issiue_Client_ID] INT NOT NULL, 
    [Issiue_Phone_ID] INT NOT NULL, 
    [Status] NCHAR(10) NOT NULL, 
    [Priority] INT NOT NULL, 
    CONSTRAINT [FK_Issiue_Client] FOREIGN KEY ([Issiue_Client_ID]) REFERENCES [dbo].[Client]([Client_ID]), 
    CONSTRAINT [FK_Issiue_Phone] FOREIGN KEY ([Issiue_Phone_ID]) REFERENCES [dbo].[Phone]([Phone_ID]), 
    CONSTRAINT [CK_Issiue_Status] CHECK ([Status] in ('Open','Resolved','Closed','Destroyed'))
)
