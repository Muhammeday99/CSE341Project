using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace projedeneme2.CariKart
{
    public class EntityJsonConverter
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected SqlDataAdapter Dadapt;
        protected DataTable table = new DataTable();
        protected DataRow Drow;
        public DataTable ToJson()
        {
            Dadapt = new SqlDataAdapter("select * from Entity_Card", con);
            
            Dadapt.Fill(table);
            return table;
        }

        public string DataTableToJSON(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public void WriteToJsonFile(string JSONString)
        {
            
            string userfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string p1 = HttpContext.Current.Server.MapPath(".") + "\\";
            System.IO.File.WriteAllText(Path.Combine(p1, "EntityCards.json"), JSONString);
        }
    }
}