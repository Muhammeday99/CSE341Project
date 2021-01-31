using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.ProjeTanim
{
    public partial class ProjeTanim : projedeneme2.Homepage.Homepage
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected static List<string> entityCodes = new List<string>();
        protected static List<string> currencyCodes = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            entityCodes.Clear();
            currencyCodes.Clear();
            Take_Entity_Card_Info();
            Take_Exchange_Rate_Info();
        }
        protected void Yeni_Proje_Ekle_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ProjeTanim/YeniProjeEkle.aspx");
        }
        protected void Take_Entity_Card_Info()
        {
            con.Open();
            
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = "";
            sql = "Select entityCode,entityName from Entity_Card";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //Take entityCode info from database
                output = output + dataReader.GetValue(0);
                //Add entityCode to inputs list
                //Take entityName info from database
                output = output + " " + dataReader.GetValue(1);
                //Add entityName to inputs list
                entityCodes.Add(output);
                output = "";
            }
            con.Close();
        }
        protected void Take_Exchange_Rate_Info()
        {
            con.Open();
            
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = "";
            sql = "Select CurrencyCode,CurrencyExchangeRate from ExchangeRate";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //Take CurrencyCode info from database
                output = output + dataReader.GetValue(0);
                //Add CurrencyCode to inputs list
                //Take CurrencyExchangeRate info from database
                output = output + " " + dataReader.GetValue(1);
                //Add CurrencyExchangeRate to inputs list
                currencyCodes.Add(output);
                output = "";
            }
            con.Close();
        }

        [WebMethod]
        public static string getProjectsInfo()
        {
            JsonConverter converter = new JsonConverter();
            return converter.TableToJSON("ProjectDefinition");
        }

        [WebMethod]
        public static string getEntityInfo()
        {
            JsonConverter converter = new JsonConverter();
            string info = converter.strlistToJSON(entityCodes);
            return info;
        }



    }
}