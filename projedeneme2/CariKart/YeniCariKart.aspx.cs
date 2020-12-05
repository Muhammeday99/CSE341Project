using projedeneme2.InputControllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace projedeneme2.YeniCariKart
{
    public partial class WebForm1 : projedeneme2.CariKart.WebForm1
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void addEntityCard_click(object sender, EventArgs e){
            con.Open();

            List<string> inputs =new  List<string>();

            string n_entityKind = entityKind.Text;
            inputs.Add(n_entityKind);

            string n_entityType = entityType.Text;
            inputs.Add(n_entityType);

            string n_entityName = entityName.Text;
            inputs.Add(n_entityName);

            string n_entityCode = entityCode.Text;
            inputs.Add(n_entityCode);

            string n_entityAddress = entityAddress.Text;
            inputs.Add(n_entityAddress);

            string n_entityEmail = entityEmail.Text;
            inputs.Add(n_entityEmail);

            //string n_phoneCountry;

            string n_phoneNumber = entityPhoneNumber.Text;
            inputs.Add(n_phoneNumber);

            string n_entityFaxNumber = entityFaxNumber.Text;
            inputs.Add(n_entityFaxNumber);

            string n_taxNumber = entityTaxNumber.Text;
            inputs.Add(n_taxNumber);

            string n_bankAccountNumber = entityBankAccountNumber.Text;
            inputs.Add(n_bankAccountNumber);

            string n_relatedPerson = entityRelatedPerson.Text;
            inputs.Add(n_relatedPerson);

            string n_Pr_description = entityDescription.Text;
            inputs.Add(n_Pr_description);

            string n_paymentTerm = entityPaymentTerm.Text;
            inputs.Add(n_paymentTerm);

            if (!stringController.listStringController(inputs))
            {
                //error label triggers
            }
            else
            {
                String q = "INSERT INTO dbo.Entity_Card (entityKind,entityType,entityName,entityCode,entityAddress,entityEmail,phoneNumber,entityFaxNumber,taxNumber,bankAccountNumber,relatedPerson,Pr_description,paymentTerm) VALUES (@entityKind,@entityType,@entityName,@entityCode,@entityAddress,@entityEmail,@phoneNumber,@entityFaxNumber,@taxNumber,@bankAccountNumber,@relatedPerson,@Pr_description,@paymentTerm)";
                SqlCommand cmnd = new SqlCommand(q, con);

                cmnd.Parameters.AddWithValue("@entityKind", n_entityKind);
                cmnd.Parameters.AddWithValue("@entityType", n_entityType);
                cmnd.Parameters.AddWithValue("@entityName", n_entityName);
                cmnd.Parameters.AddWithValue("@entityCode", n_entityCode);
                cmnd.Parameters.AddWithValue("@entityAddress", n_entityAddress);
                cmnd.Parameters.AddWithValue("@entityEmail", n_entityEmail);
                cmnd.Parameters.AddWithValue("@phoneNumber", n_phoneNumber);
                cmnd.Parameters.AddWithValue("@entityFaxNumber", n_entityFaxNumber);
                cmnd.Parameters.AddWithValue("@taxNumber", n_taxNumber);
                cmnd.Parameters.AddWithValue("@bankAccountNumber", n_bankAccountNumber);
                cmnd.Parameters.AddWithValue("@relatedPerson", n_relatedPerson);
                cmnd.Parameters.AddWithValue("@Pr_description", n_Pr_description);
                cmnd.Parameters.AddWithValue("@paymentTerm", n_paymentTerm);
                
                //Exceptionleri Handle Et ve Cari kart eklendikten sonra Cari kart Syfasina donsun 
                //Exceptionlerden biri Entity Codelar unique olmalari lazim iki ayni kod olamaz exception firlat
                cmnd.ExecuteNonQuery();
                
            }

            con.Close();
        }
    }
}