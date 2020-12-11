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
            return new SqlConnection(@"Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BF24_fivemmacro1;User Id=DB_A6BF24_fivemmacro1_admin;Password=5MMacro2020");

        }
    }
}