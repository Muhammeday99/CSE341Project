using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.IO;
using System.Windows;


namespace projedeneme2
{
    public class JsonConverter
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected SqlDataAdapter Dadapt;
        protected DataTable table = new DataTable();
        protected DataRow Drow;
        
        public SqlConnection GetConnection()
        {
            return con;
        }

        public DataTable ToJson(string TableName)
        {
            Dadapt = new SqlDataAdapter("select * from " + TableName, con);
            
            Dadapt.Fill(table);
            return table;
        }

        public string DataTableToJSON(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public void WriteToJsonFile(string JSONString, string FileName)
        {
            string p1 = HttpContext.Current.Server.MapPath(".") + "\\";
            System.IO.File.WriteAllText(Path.Combine(p1, FileName), JSONString);
        }

        
        public string getRowInfo(string tableName,string column,string id)
        {

            /*DataTable temp = c.ToJson(table);
            temp.Rows.Find()*/
            con.Open();
            SqlCommand command = new SqlCommand("select * from " + tableName + " where " + column + "='" + id +"'", con);
            Dadapt = new SqlDataAdapter("select * from " + tableName + " where " + column + "='" + id + "'", con);
            Dadapt.Fill(table);
            
            con.Close();
            
            return JsonConvert.SerializeObject(table);
        }

        public string TableToJSON(string TableName)
        {
            table = ToJson(TableName);
            string str = DataTableToJSON(table);
            return str;
        }

        public string strToJSON(string str)
        {
            return JsonConvert.SerializeObject(str);
        }

        public string strlistToJSON(List<string> str)
        {
            return JsonConvert.SerializeObject(str);
        }

    }
}