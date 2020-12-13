using projedeneme2.InputControllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.YeniFaturaEkle
{
    
    public partial class YeniFaturaEkleWebForm : projedeneme2.FaturaGiris.FaturaGirisWebForm
    {

        protected SqlConnection con = databaseConnect.connectToSQL();


        //SQLCommand – The 'SQLCommand' is a class defined within C#. 
        //This class is used to perform operations of reading and writing into the database.
        //Hence, the first step is to make sure that we create a variable type of this class. 
        //This variable will then be used in subsequent steps of reading data from our database.   
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

 
        protected void AddNewInvoice_Click(object sender, EventArgs e)
        {
            con.Open();
            List<string> inputs = new List<string>();

            string invoiceNumber = InvoiceNumber.Text;
            inputs.Add(invoiceNumber);

            string invoiceDate = DateTime.Now.ToString(InvoiceDate.Text);
            inputs.Add(invoiceDate);

            string entitycode = entityCode.Text;
            inputs.Add(entitycode);

            string invoiceDescription = InvoiceDescription.Text;
            inputs.Add(invoiceDescription);

            string paymentDate = DateTime.Now.ToString(PaymentDate.Text);
            inputs.Add(paymentDate);
            string currencycode = string.Empty;
            if(Request.Form["CurrencyCode"] == "TRY")
            {
                currencycode = "TRY";
                inputs.Add(currencycode);
            }
            else if(Request.Form["CurrencyCode"] == "USD")
            {
                currencycode = "USD";
                inputs.Add(currencycode);
            }
            else if(Request.Form["CurrencyCode"] == "EUR")
            {
                currencycode = "EUR";
                inputs.Add(currencycode);
            }
         
            string amount = Convert.ToString(Amount.Text);
            inputs.Add(amount);

            string kdvPercentage = Convert.ToString(KDVpercentage.Text);
            inputs.Add(kdvPercentage);

            //Error label BULAMADIM, KALSIN SIMDILIK BURDA SONRA AYARLARIZ.
          /*  if (!stringController.listStringController(inputs))
            {
                //error case, display on label.
                errorsLabel.Text = "Error, some inputs lenght are less than 2 characters.";
            }else{}*/

            String q = "INSERT INTO dbo.Invoice_info (InvoiceNumber, InvoiceDate,entityCode,InvoiceDescription,PaymentDate,CurrencyCode,Amount,KDVpercentage) VALUES (@InvoiceNumber, @InvoiceDate, @entityCode,@InvoiceDescription, @PaymentDate,@CurrencyCode, @Amount, @KDVpercentage)";

            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
            cmnd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
            cmnd.Parameters.AddWithValue("@entityCode", entitycode);
            cmnd.Parameters.AddWithValue("@InvoiceDescription", invoiceDescription);
            cmnd.Parameters.AddWithValue("@PaymentDate", paymentDate);
            cmnd.Parameters.AddWithValue("@CurrencyCode", currencycode);
            cmnd.Parameters.AddWithValue("@Amount", amount);
            cmnd.Parameters.AddWithValue("@KDVpercentage", kdvPercentage);
            
            cmnd.ExecuteNonQuery();

            con.Close();

        }

        //TOTAL AMOUNT TEXTBOX OLARAK GOZUKUYOR, DEGISMESI LAZIM, LABEL OLARAK DEGISTIRILMELI
        //DEGISINCE KULLANACAGIZ BUNU O YUZDEN BURDA KALSIN.Silmeyin !!!
        /*
        protected void totalAmountCalculator(object sender, EventArgs e)
        {
            
            string KDV = Convert.ToString(KDVBox.Text);
            string Amount = Convert.ToString(AmountBox.Text);

            Double Kdvv;

            if (KDV.Length == 0) Kdvv = 0;
            else Kdvv = Convert.ToDouble(KDVBox.Text);

            Double AAmount;

            if (Amount.Length == 0) AAmount = 0;
            else AAmount = Convert.ToDouble(AmountBox.Text);

            TotalAmount.Text = Convert.ToString(((Kdvv * AAmount) / 100) + AAmount);
            TotalamountTitle.Text = "Total Amount:";
            
        }
        */
    }
}