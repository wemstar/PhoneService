CREATE TABLE [dbo].[Phone_Model]
(
	[Model_ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Model_Parts] XML NULL, 
    [Name] NCHAR(30) NOT NULL, 
    [Producer] NCHAR(20) NOT NULL
)
