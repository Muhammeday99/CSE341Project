using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.ProjeTanim
{
    public partial class ProjeTanim : projedeneme2.Homepage.Homepage
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected List<String> inputs = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
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
            List<string> inputs = new List<string>();
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
                inputs.Add(output);
                //Take entityName info from database
                output = output + dataReader.GetValue(1);
                //Add entityName to inputs list
                inputs.Add(output);
                output = "";
            }
            con.Close();
        }
        protected void Take_Exchange_Rate_Info()
        {
            con.Open();
            List<string> inputs = new List<string>();
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
                inputs.Add(output);
                //Take CurrencyExchangeRate info from database
                output = output + dataReader.GetValue(1);
                //Add CurrencyExchangeRate to inputs list
                inputs.Add(output);
                output = "";
            }
            con.Close();
        }
    }
}