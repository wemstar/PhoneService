using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void UpdateIssiue (int issiueId,string status,string comment)
    {
        string commandIssiueHistory = "Insert into [dbo].[Issiue_History] ([History_Issiue_ID],[History_From_Status],[History_To_Status],[History_Date],[History_Comment])"
        + "VALUES (@issiueID,@fromStatus,@toStatus,@date,@comment);";
        string commandIssiuHistoryPrevious = "Select TOP 1 [History_To_Status] from [dbo].[Issiue_History] where [History_Issiue_ID] = @issiueID order by [History_Date] DESC ";
        using (SqlConnection cn = new SqlConnection("context connection=true"))
        {
            cn.Open();
            string previousStatus;
            using (SqlCommand cm = new SqlCommand(commandIssiuHistoryPrevious, cn))
            {
                cm.Parameters.AddWithValue("@issiueID", issiueId);
                previousStatus = (string)cm.ExecuteScalar();
            }
            using (SqlCommand cm = new SqlCommand(commandIssiueHistory, cn))
            {
                cm.Parameters.AddWithValue("@issiueID", issiueId);
                cm.Parameters.AddWithValue("@fromStatus", previousStatus);
                cm.Parameters.AddWithValue("@toStatus", status);
                cm.Parameters.AddWithValue("@date", DateTime.Now);
                cm.Parameters.AddWithValue("@comment", comment);
                cm.ExecuteNonQuery();
            }
        }
        
    }
}
