using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace projedeneme2.DovizKurTanim
{
    public partial class WebForm1 : projedeneme2.Homepage.WebForm1
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            JsonConverter convert = new JsonConverter();
            DataTable table = convert.ToJson("Currency");
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str, "ExchangeList.json");
        }

        protected void AddNewCurrency_Click(object sender, EventArgs e)
        {
            con.Open();
          
            //We have 3 inputs: CODE, DATE, RATE.

            //Currently this label is not readable.
            
            string n_CurrencyCode = Request.Form["CurrencyCode"];

            //date of the currency
            string n_CurrencyDate = CurrencyExchangeDate.Text;

            double n_CurrencyExchangeRate = double.Parse(CurrencyExchangeRate.Text, System.Globalization.CultureInfo.InvariantCulture);
            if (n_CurrencyExchangeRate < 0)
            {
                //error label
            }
            else
            {
                string q = "INSERT INTO dbo.Currency (CurrencyCode,CurrencyExchangeDate,CurrencyExchangeRate) VALUES (@CurrencyCode,@CurrencyExchangeDate,@CurrencyExchangeRate)";
                SqlCommand cmd = new SqlCommand(q, con);

                cmd.Parameters.AddWithValue("@CurrencyCode", n_CurrencyCode);
                cmd.Parameters.AddWithValue("@CurrencyExchangeDate", n_CurrencyDate);
                cmd.Parameters.AddWithValue("@CurrencyExchangeRate", n_CurrencyExchangeRate);

                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}