﻿using System;
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

            string customerCode = CustomerCode.Text;
            inputs.Add(customerCode);

            string orderCode = OrderCode.Text;
            inputs.Add(orderCode);

            string argeInvoiceNumber = Convert.ToString(ArgeInvoiceNumber.Text);
            inputs.Add(argeInvoiceNumber);
            //Currency id sonradan halledicem!!(FK Sıkıntısı var!)
       /*     string currencyid = string.Empty;
            if (Request.Form["CurrencyId"] == "TRY")
            {
                currencyid = "TRY";
                inputs.Add(currencyid);
            }
            else if (Request.Form["CurrencyId"] == "USD")
            {
                currencyid = "USD";
                inputs.Add(currencyid);
            }
            else if (Request.Form["CurrencyId"] == "EUR")
            {
                currencyid = "EUR";
                inputs.Add(currencyid);
            }*/

            string amount = Convert.ToString(Amount.Text);
            inputs.Add(amount);

            string kdvPercentage = Convert.ToString(KDVpercentage.Text);
            inputs.Add(kdvPercentage);

            string worksmanshipPrice = Convert.ToString(WorkmanshipPricePercentage.Text);
            inputs.Add(worksmanshipPrice);

            string relatedPerson = RelatedPerson.Text;
            inputs.Add(relatedPerson);

            string projectDescription = Pr_description.Text;
            inputs.Add(projectDescription);

            string projectManager = ProjectManager.Text;
            inputs.Add(projectManager);

            String q = "INSERT INTO dbo.ProjectDefinition (ProjectCode, ProjectName,StartingDate,EndingDate,CustomerCode,OrderCode,ArgeInvoiceNumber,Amount,KDVpercentage,WorkmanshipPricePercentage,RelatedPerson,Pr_description,ProjectManager) VALUES (@ProjectCode, @ProjectName, @StartingDate,@EndingDate, @CustomerCode,@OrderCode, @ArgeInvoiceNumber, @Amount, @KDVpercentage, @WorkmanshipPricePercentage, @RelatedPerson, @Pr_description, @ProjectManager)";

            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@ProjectCode", projectCode);
            cmnd.Parameters.AddWithValue("@ProjectName", projectName);
            cmnd.Parameters.AddWithValue("@StartingDate", startingDate);
            cmnd.Parameters.AddWithValue("@EndingDate", endingDate);
            cmnd.Parameters.AddWithValue("@CustomerCode", customerCode);
            cmnd.Parameters.AddWithValue("@OrderCode", orderCode);
            cmnd.Parameters.AddWithValue("@ArgeInvoiceNumber", argeInvoiceNumber);
         //   cmnd.Parameters.AddWithValue("@CurrencyId", currencyid);
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