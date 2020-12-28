using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.YeniProjeEkle
{
    public partial class YeniProjeEkle : projedeneme2.ProjeTanim.ProjeTanim
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNewProject_Click(object sender, EventArgs e)
        {
            con.Open();
            List<string> inputs = new List<string>();

            string projectCode = ProjectCode.Text;
            inputs.Add(projectCode);

            string projectName = ProjectName.Text;
            inputs.Add(projectName);

            string startingDate = DateTime.Now.ToString(StartingDate.Text);
            inputs.Add(startingDate);

            string endingDate = DateTime.Now.ToString(EndingDate.Text);
            inputs.Add(endingDate);

            string entityCode = EntityCode.Text;
            inputs.Add(entityCode);

            string orderCode = OrderCode.Text;
            inputs.Add(orderCode);

            int argeInvoiceNumber = Convert.ToInt32(ArgeInvoiceNumber.Text);
           
            // inputs.Add(argeInvoiceNumber);
            
            // string currencyid = string.Empty;
            int currency = -1;
            if (Request.Form["CurrencyCode"] == "TRY")
            {
                currency = 1;
            //    currencyid = Convert.ToString(currency);
            //    inputs.Add(currencyid);
            }
            else if (Request.Form["CurrencyCode"] == "USD")
            {
                currency = 2;
            //    currencyid = Convert.ToString(currency);
            //     inputs.Add(currencyid);
            }
            else if (Request.Form["CurrencyCode"] == "EUR")
            {
                currency = 3;
            //    currencyid = Convert.ToString(currency);
            //    inputs.Add(currencyid);
            }
            
            double amount = Convert.ToDouble(Amount.Text);
           // inputs.Add(amount);

            double kdvPercentage = Convert.ToDouble(KDVpercentage.Text);
           // inputs.Add(kdvPercentage);

            double worksmanshipPrice = Convert.ToDouble(WorkmanshipPricePercentage.Text);
           // inputs.Add(worksmanshipPrice);

            string relatedPerson = RelatedPerson.Text;
            inputs.Add(relatedPerson);

            string projectDescription = Pr_description.Text;
            inputs.Add(projectDescription);

            string projectManager = ProjectManager.Text;
            inputs.Add(projectManager);

            String q = "INSERT INTO dbo.ProjectDefinition (ProjectCode, ProjectName,StartingDate,EndingDate,EntityId,OrderCode,ArgeInvoiceNumber,ExchangeRateId,Amount,KDVpercentage,WorkmanshipPricePercentage,RelatedPerson,Pr_description,ProjectManager) VALUES (@ProjectCode, @ProjectName, @StartingDate,@EndingDate, @EntityCode,@OrderCode, @ArgeInvoiceNumber, @CurrencyId, @Amount, @KDVpercentage, @WorkmanshipPricePercentage, @RelatedPerson, @Pr_description, @ProjectManager)";

            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@ProjectCode", projectCode);
            cmnd.Parameters.AddWithValue("@ProjectName", projectName);
            cmnd.Parameters.AddWithValue("@StartingDate", startingDate);
            cmnd.Parameters.AddWithValue("@EndingDate", endingDate);
            cmnd.Parameters.AddWithValue("@EntityCode", entityCode);
            cmnd.Parameters.AddWithValue("@OrderCode", orderCode);
            cmnd.Parameters.AddWithValue("@ArgeInvoiceNumber", argeInvoiceNumber);
            cmnd.Parameters.AddWithValue("@CurrencyId", currency);
            cmnd.Parameters.AddWithValue("@Amount", amount);
            cmnd.Parameters.AddWithValue("@KDVpercentage", kdvPercentage);
            cmnd.Parameters.AddWithValue("@WorkmanshipPricePercentage", worksmanshipPrice);
            cmnd.Parameters.AddWithValue("@RelatedPerson", relatedPerson);
            cmnd.Parameters.AddWithValue("@Pr_description", projectDescription);
            cmnd.Parameters.AddWithValue("@ProjectManager", projectManager);

            cmnd.ExecuteNonQuery();

            con.Close();
        }
    }
}