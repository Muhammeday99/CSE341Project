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
            //CurrencyCode.Text;
            string n_CurrencyCode = "USD";

            //Figuring out how to read date..
            double n_CurrencyExchangeRate = Convert.ToDouble(CurrencyExchangeDate.Value);

            string q = "INSERT INTO dbo.Currency (CurrencyCode, CurrencyExchangeRate) VALUES (@CurrencyCode, CurrencyExchangeRate)";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@CurrencyCode",n_CurrencyCode);
            cmd.Parameters.AddWithValue("@CurrencyExchangeRate", n_CurrencyExchangeRate);

            con.Close();
        }
    }
}