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
            //Opens the sql database, and list of inputs.
            con.Open();
            List<string> inputs = new List<string>();

            //Fatura Numarası
            string invoiceNumber = InvoiceNumber.Text;
            inputs.Add(invoiceNumber);

            //Fatura Tarihi
            string invoiceDate = DateTime.Now.ToString(InvoiceDate.Text);

            //Cari Kodu
            string entitycode = entityCode.Text;
            inputs.Add(entitycode);

            //Açıklama
            string invoiceDescription = InvoiceDescription.Text;
            inputs.Add(invoiceDescription);

            //Vade Tarihi
            string paymentDate = DateTime.Now.ToString(PaymentDate.Text);
            inputs.Add(paymentDate);

            //Döviz Kodu
            string currencycode = "NON";
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

            /*
            string amount = Convert.ToString(Amount.Text);
            inputs.Add(amount);

            string kdvPercentage = Convert.ToString(KDVamount.Text);
            inputs.Add(kdvPercentage);
            */

            


            

            //Error label BULAMADIM, KALSIN SIMDILIK BURDA SONRA AYARLARIZ.
            if (!stringController.listStringController(inputs)){
                //error case, display on label.
            }else{

                
            }

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