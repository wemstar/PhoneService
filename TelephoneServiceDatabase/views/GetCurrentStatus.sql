CREATE VIEW [dbo].[GetCurrentStatus]
	AS SELECT * FROM [dbo].[Issiue_History] history join [dbo].[Issiue] issiue on history.History_Issiue_ID=issiue.Issiue_ID;
