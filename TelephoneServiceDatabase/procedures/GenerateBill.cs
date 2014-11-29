using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Xml;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GenerateBill(int issiueID, out SqlXml result)
    {
        string command = "select * from [dbo].[Issiue] join [dbo].[Client] on Client_ID=Issiue_Client_ID "
                     + "join [dbo].[Phone] on Phone_ID=Issiue_Phone_ID "
                     + "where [dbo].[Issiue].[Issiue_ID] = @issiueID for xml AUTO, ELEMENTS, ROOT('Issiues') ;";

        using (SqlConnection cn = new SqlConnection("context connection=true"))
        {
            cn.Open();

            using (SqlCommand cm = new SqlCommand(command, cn))
            {
                cm.Parameters.AddWithValue("@issiueID", issiueID);
                result =new SqlXml( cm.ExecuteXmlReader());
                
            }
        }

    }
}
