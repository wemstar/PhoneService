CREATE TABLE [dbo].[Issiue_History]
(
	[History_ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [History_Issiue_ID] INT NOT NULL, 

    [History_From_Status] NCHAR(10) NULL, 
    [History_To_Status] NCHAR(10) NOT NULL, 
    [History_Date] DATETIME NOT NULL, 
    [History_Comment] TEXT NOT NULL, 
    CONSTRAINT [FK_Issiue_History_Issiue] FOREIGN KEY ([History_Issiue_ID]) REFERENCES [dbo].[Issiue]([Issiue_ID]),
	CONSTRAINT [CK_Issiue_ToStatus] CHECK ([History_To_Status] in ('Open','Resolved','Closed','Destroyed')),
	CONSTRAINT [CK_Issiue_FromStatus] CHECK ([History_From_Status] in ('Open','Resolved','Closed','Destroyed',NULL))
)
