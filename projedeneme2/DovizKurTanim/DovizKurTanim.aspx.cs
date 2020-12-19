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
            List<string> inputs = new List<string>();

            //We have 3 inputs: CODE, DATE, RATE.

            //Currently this label is not readable.

            double n_CurrencyExchangeRate = double.Parse(CurrencyExchangeRate.Text, System.Globalization.CultureInfo.InvariantCulture);
            string n_CurrencyCode = " ";

            if (Request.Form["CurrencyCode"] == "TRY")
            {
                n_CurrencyCode = "TRY";
                n_CurrencyExchangeRate = double.Parse(TRY.Value, System.Globalization.CultureInfo.InvariantCulture);
                inputs.Add(n_CurrencyCode);
            }
            else if (Request.Form["CurrencyCode"] == "USD")
            {
                n_CurrencyCode = "USD";
                n_CurrencyExchangeRate = 1;
                inputs.Add(n_CurrencyCode);
            }
            else if (Request.Form["CurrencyCode"] == "EUR")
            {
                n_CurrencyCode = "EUR";
                n_CurrencyExchangeRate = double.Parse(EUR.Value, System.Globalization.CultureInfo.InvariantCulture);
                inputs.Add(n_CurrencyCode);
            }

            //date of the currency
            string n_CurrencyDate = CurrencyExchangeDate.Text;

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

        protected void CurrencyExchangeRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}