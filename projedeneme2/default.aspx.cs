using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2
{

    /**OUR MAIN WEB FORM. 
    This web form makes the log-in with primary error handles. 
    
    ---Enter email
    ---Enter password
    ---ENTER
     */
    public partial class Default : System.Web.UI.Page
    {
        //This should be there so we dont need to initialize again and again.
        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //Opens the database.
            con.Open();

            string userEmail = InputEmail.Text;
            string userPassword = InputPassword.Text;

            //IF because user can enter nothing to textboxes.
            if(!(userEmail.Length < 1 || userPassword.Length < 1)){

                SqlCommand sorgula = new SqlCommand("SELECT * FROM Users WHERE UserEmail=@UserEmail AND Password=@Password", con);

                sorgula.Parameters.AddWithValue("@UserEmail", userEmail);
                sorgula.Parameters.AddWithValue("@Password", userPassword);
                SqlDataReader oku = sorgula.ExecuteReader();
                if (oku.Read())
                {
                    //  Session["Kullanici"] = oku["KullaniciAdi"].ToString();
                    //  Response.Redirect("Default.aspx");

                    string v = oku[0].ToString(); //Id
                    string v2 = oku[1].ToString(); //Email

                    lblDurum.Text = v2;
                }
                else
                    lblDurum.Text = "Email yada şifre hatalı!";

                oku.Close();
            }
            else{
                lblDurum.Text = "Lütfen Email ve şifreyi giriniz!";
            }

            con.Close();
            con.Dispose();
        }
    }
}