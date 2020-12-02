using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//In this section, the new user is added. It is determined whether the new user will be in the admin status or not.
//Also, the photo of the new user is added here so that users is gained identity .
namespace projedeneme2.AdminPage
{
    public partial class AddAccount : System.Web.UI.Page
    {

        protected SqlConnection con = databaseConnect.connectToSQL();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //In this section, the information received from the text box is saved in the database.
        protected void saveButtonClick(object sender, EventArgs e)
        {
            con.Open();

            string uEmail = emailBox.Text;
            string uPassword = passwordBox.Text;
            Boolean isAdmin = adminOrNot.Checked;

            if (!uEmail.Contains('@')){
                errorLabel.Text = "Your email should contain @, and password needs to be longer than 1 character.";
            }
            else{

                String q = "INSERT INTO dbo.Users (Password,Status,ProfilePicture,UserEmail) VALUES (@Password, @Status,@ProfilePicture, @UserEmail)";

                SqlCommand cmnd = new SqlCommand(q,con);

                cmnd.Parameters.AddWithValue("@Password", uPassword);
                cmnd.Parameters.AddWithValue("@Status", isAdmin);
                cmnd.Parameters.AddWithValue("@ProfilePicture", "empty");
                cmnd.Parameters.AddWithValue("@UserEmail", uEmail);
             
                cmnd.ExecuteNonQuery();
            }
        }
    }
}