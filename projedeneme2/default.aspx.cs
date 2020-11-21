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

                SqlCommand check = new SqlCommand("SELECT * FROM Users WHERE UserEmail=@UserEmail AND Password=@Password", con);

                check.Parameters.AddWithValue("@UserEmail", userEmail);
                check.Parameters.AddWithValue("@Password", userPassword);
                SqlDataReader sqlRead = check.ExecuteReader();

                if (sqlRead.Read())
                    Response.Redirect("Homepage/Homepage.aspx");
                else
                    statusLabel.Text = "Email yada şifre hatalı!";

                sqlRead.Close();
            }
            else
                statusLabel.Text = "Lütfen Email ve şifreyi giriniz!";
            
            con.Close();
            con.Dispose();
        }
    }
}