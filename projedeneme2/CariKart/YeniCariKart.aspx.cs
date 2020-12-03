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

            string n_entityKind = entityKind.Text;
            string n_entityType = entityType.Text;
            string n_entityName = entityName.Text;
            string n_entityCode = entityCode.Text;
            string n_entityAddress = entityAddress.Text;
            string n_entityEmail = entityEmail.Text;
            string n_phoneCountry;
            string n_phoneNumber = entityPhoneNumber.Text;
            string n_entityFaxNumber = entityFaxNumber.Text;
            string n_taxNumber;
            string n_bankAccountNumber = entityBankAccountNumber.Text;
            string n_relatedPerson = entityRelatedPerson.Text;
            string n_Pr_description = entityDescription.Text;
            string n_paymentTerm = entityPaymentTerm.Text;

            String q = "INSER INTO dbo.Entity_Card (entityKind,entityType,entityName,entityCode,entityAddress,entityEmail,phoneNumber,entityFaxNumber,bankAccount,relatedPerson,Pr_description,paymentTerm) VALUES (@entityKind,@entityType,@entityName,@entityCode,@entityAddress,@entityEmail,@phoneNumber,@entityFaxNumber,@bankAccount,@relatedPerson,@Pr_description,@paymentTerm)";
            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@entityKind",n_entityKind);
            cmnd.Parameters.AddWithValue("@entityType", n_entityType);
            cmnd.Parameters.AddWithValue("@entityName", n_entityName);
            cmnd.Parameters.AddWithValue("@entityCode", n_entityCode);
            cmnd.Parameters.AddWithValue("@entityAddress", n_entityAddress);
            cmnd.Parameters.AddWithValue("@entityEmail", n_entityEmail);
            cmnd.Parameters.AddWithValue("@phoneNumber", n_phoneNumber);
            cmnd.Parameters.AddWithValue("@entityFaxNumber", n_entityFaxNumber);
            cmnd.Parameters.AddWithValue("@bankAccountNumber", n_bankAccountNumber);
            cmnd.Parameters.AddWithValue("@relatedPerson", n_relatedPerson);
            cmnd.Parameters.AddWithValue("@Pr_description", n_Pr_description);
            cmnd.Parameters.AddWithValue("@paymentTerm", n_paymentTerm);

            cmnd.ExecuteNonQuery();
        }
    }
}