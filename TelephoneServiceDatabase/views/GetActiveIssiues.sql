CREATE VIEW [dbo].[GetActiveIssiues]
	AS SELECT * FROM [dbo].[Issiue] issiue where not exists (select * from [dbo].[Issiue_History] history where history.History_Issiue_ID=issiue.Issiue_ID and history.History_To_Status='Closed')
