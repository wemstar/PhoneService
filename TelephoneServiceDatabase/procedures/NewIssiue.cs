using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void NewIssiue (int clientID,int phoneID,int prority,string comment="")
    {
        string commandIssiue = "Insert into [dbo].[Issiue] ([Issiue_Client_ID],[Issiue_Phone_ID],[Priority])VALUES (@clientID,@phoneID,@prority);SELECT SCOPE_IDENTITY();";
        string commandIssiueHistory = "Insert into [dbo].[Issiue_History] ([History_Issiue_ID],[History_From_Status],[History_To_Status],[History_Date],[History_Comment])"
        +"VALUES (@issiueID,@fromStatus,@toStatus,@date,@comment);";
        using (SqlConnection cn = new SqlConnection("context connection=true"))
        {
            cn.Open();
            Decimal issiueId;
            using (SqlCommand cm = new SqlCommand(commandIssiue, cn))
            {
                cm.Parameters.AddWithValue("@clientID", clientID);
                cm.Parameters.AddWithValue("@phoneID", phoneID);
                cm.Parameters.AddWithValue("@prority", prority);
                issiueId = (Decimal)cm.ExecuteScalar();
            }
            using (SqlCommand cm = new SqlCommand(commandIssiueHistory, cn))
            {
                cm.Parameters.AddWithValue("@issiueID", issiueId);
                cm.Parameters.AddWithValue("@fromStatus", null);
                cm.Parameters.AddWithValue("@toStatus", "OPEN");
                cm.Parameters.AddWithValue("@date", DateTime.Now);
                cm.Parameters.AddWithValue("@comment", comment);
                cm.ExecuteNonQuery();
            }
        }           
    }
}
