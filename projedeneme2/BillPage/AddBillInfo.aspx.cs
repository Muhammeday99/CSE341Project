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


        //SQLCommand – The 'SQLCommand' is a class defined within C#. 
        //This class is used to perform operations of reading and writing into the database.
        //Hence, the first step is to make sure that we create a variable type of this class. 
        //This variable will then be used in subsequent steps of reading data from our database.
        
        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand check = new SqlCommand("SELECT [entityCode] FROM [dbo].[Entity_Card]");
            check.CommandType = System.Data.CommandType.Text;
            check.Connection = con;

            string temp = "";
            SqlDataReader reader = check.ExecuteReader();
            //The DataReader object is used to get all the data specified by the SQL query.
            //We can then read all the table rows one by one using the data reader.
            while (reader.Read())
            {
                temp = reader["entityCode"].ToString();
            }

            entity.Text = temp;

            reader.Close();
        }
        // In this we do get values from BillNo, BillDate,BillDescription,PaymentDate,KDV,Amount Textboxes:
        protected void saveButtonClick(object sender, EventArgs e)
        {
            

            string BillNo = BillNoBox.Text;
            
            string BillDate = DateTime.Now.ToString(BillDateBox.Text);
            //string entityCode = entityCodeBox.Text;
            string BillDescription = BillDescriptionBox.Text;
            string PaymentDate = DateTime.Now.ToString(PaymentDateBox.Text);
            string KDV = Convert.ToString(KDVBox.Text);
            string Amount = Convert.ToString(AmountBox.Text) ;
           
            
            Double Kdvv = Convert.ToDouble(KDVBox.Text);
            Double AAmount = Convert.ToDouble(AmountBox.Text);

            TotalAmount.Text = Convert.ToString(((Kdvv*AAmount)/100)+AAmount);
            TotalamountTitle.Text = "Total Amount:";
            //In this part, the bill information received from the text box is added to the entity card db.
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
            con.Close();
        }
    }
}