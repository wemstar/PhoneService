CREATE TABLE [dbo].[Client]
(
	[Client_ID] INT NOT NULL PRIMARY KEY, 
    [Client_Name] NCHAR(20) NOT NULL, 
    [Client_Surname] NCHAR(20) NOT NULL, 
    [Client_Telephone] NCHAR(15) NOT NULL, 
    [Client_Adress] TEXT NOT NULL
)
