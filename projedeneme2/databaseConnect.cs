using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace projedeneme2
{
    public class databaseConnect
    {

        /**DATABASE SERVER CONNECTOR FUNCTION
         
         It is in the namespace so we can use in all classes using that namespace.*/
        static public SqlConnection connectToSQL(){
            return new SqlConnection(@"Server=tcp:5m-macro.database.windows.net,1433;Initial Catalog=Project_Tracking_System;Persist Security Info=False;User ID=fivemmacro;Password=5MMacro2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}