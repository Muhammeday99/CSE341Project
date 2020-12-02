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
            string n_bankAccount = entityBankAccount.Text;
            string n_relatedPerson = entityRelatedDescription.Text;
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
            cmnd.Parameters.AddWithValue("@bankAccount", n_bankAccount);
            cmnd.Parameters.AddWithValue("@relatedPerson", n_relatedPerson);
            cmnd.Parameters.AddWithValue("@Pr_description", n_Pr_description);
            cmnd.Parameters.AddWithValue("@paymentTerm", n_paymentTerm);

            cmnd.ExecuteNonQuery();
        }
        
        
        /*
         protected void Homepage_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void User_Profile_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Login_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Register_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Proje_Tanim_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Cari_Kart_click(object sender, EventArgs e)
         {
             Response.Redirect("../CariKart/CariKart.aspx");
         }
         protected void Doviz_Kur_Tanim_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Masraf_Tanimi_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Fatura_Giris_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Proje_Odeme_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Fatura_Odeme_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Masraf_Odeme_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Cek_Giris_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Kasa_Giris_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Tedarikci_Borc_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Müsteri_Alacak_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Bakiye_Durumu_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Kod_Degistir_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Urun_Ara_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }
         protected void Hata_Tespit_click(object sender, EventArgs e)
         {
             Response.Redirect("../Homepage/Homepage.aspx");
         }*/
    }
}