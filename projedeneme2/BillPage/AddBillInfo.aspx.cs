using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.BillPage
{
    public partial class AddBillInfo : System.Web.UI.Page
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand check = new SqlCommand("SELECT [entityCode] FROM [dbo].[Entity_Card]");
            check.CommandType = System.Data.CommandType.Text;
            check.Connection = con;

            string temp = "";
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                temp = reader["entityCode"].ToString();
            }

            entity.Text = temp;
        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
            con.Open();

            string BillNo = BillNoBox.Text;
            
            string BillDate = DateTime.Now.ToString(BillDateBox.Text);
            //string entityCode = entityCodeBox.Text;
            string BillDescription = BillDescriptionBox.Text;
            string PaymentDate = DateTime.Now.ToString(PaymentDateBox.Text);
            string KDV = Convert.ToString(KDVBox.Text);
            string Amount = Convert.ToString(AmountBox.Text) ;
            string EntityCode = string.Empty;
           
           


            String q = "INSERT INTO dbo.Bill_info (BillNo, BillDate,BillDescription,PaymentDate,KDV,Amount) VALUES (@BillNo, @BillDate, @BillDescription, @PaymentDate, @KDV, @Amount)";

            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@BillNo", BillNo);
            cmnd.Parameters.AddWithValue("@BillDate", BillDate);
            //cmnd.Parameters.AddWithValue("@entityCode", entityCode);
            cmnd.Parameters.AddWithValue("@BillDescription", BillDescription);
            cmnd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            cmnd.Parameters.AddWithValue("@KDV", KDV);
            cmnd.Parameters.AddWithValue("@Amount", Amount);

            cmnd.ExecuteNonQuery();
           
        }
    }
}