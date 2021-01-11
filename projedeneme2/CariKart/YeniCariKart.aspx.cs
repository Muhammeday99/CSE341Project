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
    public partial class YeniCariKart : projedeneme2.CariKart.CariKart
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void AddEntityCard_click(object sender, EventArgs e){
            con.Open();
            List<string> inputs =new  List<string>();

            //ENTITYKIND
            bool n_entityKind;
            if (Request.Form["entityKind"] == "Firma") n_entityKind = true;
            else if (Request.Form["entityKind"] == "Şahıs") n_entityKind = false;
            else n_entityKind = true;

            bool n_entityType;
            if (Request.Form["entityType"] == "Müşteri") n_entityType = true;
            else if (Request.Form["entityType"] == "Tedarikçi") n_entityType = false;
            else n_entityType = true;
            
            //name of the entity.
            string n_entityName = entityName.Text;
            inputs.Add(n_entityName);

            //code of the entity, as string
            string n_entityCode = entityCode.Text;
            inputs.Add(n_entityCode);

            //adress of the entity, as string
            string n_entityAddress = entityAddress.Text;
            inputs.Add(n_entityAddress);

            //email adress of the entity, as string
            string n_entityEmail = entityEmail.Text;
            inputs.Add(n_entityEmail);

            //phone number of the entity, as integer
            long n_phoneNumber = -1;
            if (!Int64.TryParse(entityPhoneNumber.Text, out n_phoneNumber)) return;

            //fax number of the entity, as integer
            long n_entityFaxNumber = -1;
            if (!Int64.TryParse(entityFaxNumber.Text, out n_entityFaxNumber)) return;

            long n_taxOffice = -1;
            if (!Int64.TryParse(taxOffice.Text, out n_taxOffice)) return;

            //tax number of the entity, as integer.
            long n_taxNumber = -1;
            if (!Int64.TryParse(taxNumber.Text, out n_taxNumber)) return;

            //bank account number of the entity, as integer.
            long n_bankAccountNumber = -1;
            if (!Int64.TryParse(bankAccountNumber.Text,out n_bankAccountNumber)) return;     

            //related person of the entity, as string
            string n_relatedPerson = relatedPerson.Text;
            inputs.Add(n_relatedPerson);

            //pr description of the entity, as string
            string n_Pr_description = Pr_description.Text;
            inputs.Add(n_Pr_description);

            //payment term of the entity, as integer.
            long n_paymentTerm = -1;
            if (!Int64.TryParse(paymentTerm.Text, out n_paymentTerm)) return;    

            if (!stringController.listStringController(inputs))
            {
                //error label triggers
                errorLabel.Text = "Adding operation failed!";
            }
            else
            {
                try
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
                    errorLabel.Text = "Added successfully..";
                }
                catch (Exception exc)
                {

                }
            }

            con.Close();
        }
    }
}