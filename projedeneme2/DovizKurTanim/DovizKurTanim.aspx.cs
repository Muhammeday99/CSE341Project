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
    public partial class DovizKurTanim : projedeneme2.Homepage.Homepage
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            convertToJson();
        }

        protected void AddNewCurrency_Click(object sender, EventArgs e)
        {
            con.Open();
            List<string> inputs = new List<string>();

            //We have 3 inputs: CODE, DATE, RATE.

            //Currently this label is not readable.

            double n_CurrencyExchangeRate = 0;
            int n_CurrencyCode = -1;

            if (Request.Form["CurrencyCode"] == "TRY")
            {
                n_CurrencyCode = 1;
                
                n_CurrencyExchangeRate = 1.0;
                CurrencyExchangeRate.Text = TRY.Value + " ₺";
            }
            else if (Request.Form["CurrencyCode"] == "USD")
            {
                n_CurrencyCode = 2;
                System.Diagnostics.Debug.WriteLine(USD.Value);
                n_CurrencyExchangeRate = double.Parse(USD.Value);
                CurrencyExchangeRate.Text = 1 + " $";

            }
            else if (Request.Form["CurrencyCode"] == "EUR")
            {
                n_CurrencyCode = 3;
                System.Diagnostics.Debug.WriteLine(EUR.Value);
                n_CurrencyExchangeRate = double.Parse(EUR.Value);
                CurrencyExchangeRate.Text = 1 + " €";
            }
            
            //date of the currency
            string n_CurrencyDate = CurrencyExchangeDate.Text;

            if (n_CurrencyExchangeRate < 0)
            {
                //error label
                errorLabel.Text = "Adding operation failed!";

            }
            else
            {
                try
                {
                    string q = "INSERT INTO dbo.ExchangeRate (CurrencyCode,CurrencyExchangeDate,CurrencyExchangeRate) VALUES (@CurrencyCode,@CurrencyExchangeDate,@CurrencyExchangeRate)";
                    SqlCommand cmd = new SqlCommand(q, con);

                    cmd.Parameters.AddWithValue("@CurrencyCode", n_CurrencyCode);
                    cmd.Parameters.AddWithValue("@CurrencyExchangeDate", n_CurrencyDate);
                    cmd.Parameters.AddWithValue("@CurrencyExchangeRate", n_CurrencyExchangeRate);

                    cmd.ExecuteNonQuery();
                    errorLabel.Text = "Added successfully..";
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                }
            }

            con.Close();
            convertToJson();
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        private void convertToJson()
        {
            JsonConverter convert = new JsonConverter();
            DataTable table = convert.ToJson("ExchangeRate");
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str, "ExchangeList.json");
        }
        protected void CurrencyExchangeRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}