CREATE TABLE [dbo].[Phone]
(
	[Phone_ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Phone_Model_ID] INT NOT NULL, 
    [Color] TEXT NOT NULL, 
    [State] INT NOT NULL, 
    CONSTRAINT [FK_Phone_PhoneModel] FOREIGN KEY ([Phone_Model_ID]) REFERENCES [dbo].[Phone_Model]([Model_ID])
)
