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

        private class subinvoiceContent{

            public int invoiceId; // has to match with invoiceid.

            public bool type;
            public int projectORexpenseId; //has to match too.
            public int stockType;
            public string stockCode;
            public string stockName;
            public int unit;
            public int stockAmount;
            public double amount;
            public double KDV;

            public subinvoiceContent()
            {

            }

            subinvoiceContent(int n_invoiceId, bool n_type, int n_projectORexpenseId, int n_stockType, string n_stockCode,
                string n_stockName, int n_unit,int n_stockAmount, double n_amount, double n_KDV)
            {
                invoiceId = n_invoiceId;
                type = n_type;
                projectORexpenseId = n_projectORexpenseId;
                stockType = n_stockType;
                stockCode = n_stockCode;
                stockName = n_stockName;
                unit = n_unit;
                stockAmount = n_stockAmount;
                amount = n_amount;
                KDV = n_KDV;
            }
        }

        List<subinvoiceContent> subinvoiceList = new List<subinvoiceContent>();
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected double total = 0;

        //SQLCommand – The 'SQLCommand' is a class defined within C#. 
        //This class is used to perform operations of reading and writing into the database.
        //Hence, the first step is to make sure that we create a variable type of this class. 
        //This variable will then be used in subsequent steps of reading data from our database.   
        protected void Page_Load(object sender, EventArgs e)
        {
            InvoiceTotalAmount.Text = "0";
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

            //Vade Tarihi
            string paymentDate = DateTime.Now.ToString(PaymentDate.Text);

            //Cari Kodu
            long entitycode = -1;
            if (!Int64.TryParse(entityCode.Text, out entitycode)) return;

            //Açıklama
            string invoiceDescription = InvoiceDescription.Text;
            inputs.Add(invoiceDescription);

            //Döviz Kodu
            int currencycode = 1;
            if(Request.Form["CurrencyCode"] == "TRY")
            {
                currencycode = 1;
            }
            else if(Request.Form["CurrencyCode"] == "USD")
            {
                currencycode = 2;
            }
            else if(Request.Form["CurrencyCode"] == "EUR")
            {
                currencycode = 3;
            }

            //Error label BULAMADIM, KALSIN SIMDILIK BURDA SONRA AYARLARIZ.
            if (!stringController.listStringController(inputs)){
                //error case, display on label.
            }else{

                String q = "INSERT INTO Invoice_info (InvoiceNumber,InvoiceDate,entityCode,InvoiceDescription,PaymentDate,CurrencyId,Amount) VALUES (@InvoiceNumber,@InvoiceDate,@entityCode,@InvoiceDescription,@PaymentDate,@CurrencyId,@Amount)";
                SqlCommand cmnd = new SqlCommand(q, con);

                string a = " ";

                cmnd.Parameters.AddWithValue("@InvoiceNumber",invoiceNumber);
                cmnd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                cmnd.Parameters.AddWithValue("@entityCode", entitycode);
                cmnd.Parameters.AddWithValue("@InvoiceDescription", invoiceDescription);
                cmnd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmnd.Parameters.AddWithValue("@Amount", double.Parse(Session["Total"].ToString()));
                cmnd.Parameters.AddWithValue("@CurrencyId", currencycode);

                cmnd.ExecuteNonQuery();

                //GETS THE ID FOR SUBINVOICE.
                /*
                q = "SELECT ID FROM Invoice_info WHERE InvoiceNumber=@InvoiceNumber";
                cmnd = new SqlCommand(q, con);
                cmnd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
                SqlDataReader sqlRead = cmnd.ExecuteReader();
                sqlRead.Read();
                int id = sqlRead.GetInt32(0);
                sqlRead.Close();
                */
            }

            con.Close();
        }

        protected void addNewTotal(string newSubTotal)
        {
            double newSub = double.Parse(newSubTotal);

            Session["Total"] = double.Parse(Session["Total"].ToString()) + newSub;
            InvoiceTotalAmount.Text = total.ToString();
        }

        public void addNewSubInvoice(object sender, EventArgs e)
        {
            addNewTotal(TotalAmount.Text);

            con.Open();
            subinvoiceContent newContent = new subinvoiceContent();

            if (Request.Form["Type"] == "Masraf") //boolean 0
            {
                newContent.type = false;
            }
            else if (Request.Form["Type"] == "Proje") //boolean 1
            {
                newContent.type = true;
            }

            Int32.TryParse(ProjectExpenseCode.Text, out newContent.projectORexpenseId);

            if (Request.Form["StockKind"] == "Mekanik") // 0
            {
                newContent.stockType = 0;
            }
            else if (Request.Form["StockKind"] == "Pinomatik") // 1
            {
                newContent.stockType = 1;
            }
            else if (Request.Form["StockKind"] == "Otomasyon") // 2
            {
                newContent.stockType = 2;
            }

            newContent.stockCode = StockCode.Text;

            newContent.stockName = StockName.Text;

            if (Request.Form["Unit"] == "Adet") // 0
            {
                newContent.stockType = 0;
            }
            else if (Request.Form["Unit"] == "Kilogram") // 1
            {
                newContent.stockType = 1;
            }
            else if (Request.Form["Unit"] == "Metre") // 2
            {
                newContent.stockType = 2;
            }

            Int32.TryParse(Count.Text, out newContent.stockAmount);

            newContent.amount = double.Parse(Amount.Text);

            if (Request.Form["KDVpercentage"] == "0") // 0
            {
                newContent.KDV = 0;
            }
            else if (Request.Form["KDVpercentage"] == "1") // 1
            {
                newContent.KDV = 1;
            }
            else if (Request.Form["KDVpercentage"] == "8") // 2
            {
                newContent.KDV = 8;
            }
            else if (Request.Form["KDVpercentage"] == "18") // 2
            {
                newContent.KDV = 18;
            }

            subinvoiceList.Add(newContent);

            try
            {
                String q = "INSERT INTO SubInvoice (InvoiceId,Type,ProjectId,ExpenseId,StockType,StockCode,StockName,Unit,StockAmount,Amount,KDV) VALUES (@InvoiceId,@Type,@ProjectId,@ExpenseId,@StockType,@StockCode,@StockName,@Unit,@StockAmount,@Amount,@KDV)";
                SqlCommand cmnd = new SqlCommand(q, con);

                newContent.invoiceId = 1;

                cmnd.Parameters.AddWithValue("@InvoiceId", newContent.invoiceId);
                cmnd.Parameters.AddWithValue("@Type", newContent.type);
                if (newContent.type)
                {
                    cmnd.Parameters.AddWithValue("@ExpenseId", newContent.projectORexpenseId);
                    cmnd.Parameters.AddWithValue("@ProjectId", 6);
                }
                else
                {
                    cmnd.Parameters.AddWithValue("@ProjectId", newContent.projectORexpenseId);
                    cmnd.Parameters.AddWithValue("@ExpenseId", 6);
                }

                cmnd.Parameters.AddWithValue("@StockType", newContent.stockType);
                cmnd.Parameters.AddWithValue("@StockCode", newContent.stockCode);
                cmnd.Parameters.AddWithValue("@StockName", newContent.stockName);
                cmnd.Parameters.AddWithValue("@Unit", newContent.unit);
                cmnd.Parameters.AddWithValue("@StockAmount", newContent.stockAmount);
                cmnd.Parameters.AddWithValue("@Amount", newContent.amount);
                cmnd.Parameters.AddWithValue("@KDV", newContent.KDV);

                cmnd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                errorLabel.Text = "THERE IS NO SUCH PROJECT !!";
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