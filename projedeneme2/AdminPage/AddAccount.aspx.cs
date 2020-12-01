using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace projedeneme2.AdminPage
{
    public partial class AddAccount : System.Web.UI.Page
    {

        protected SqlConnection con = databaseConnect.connectToSQL();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
            con.Open();

            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            photoUpload.SaveAs(folderPath + Path.GetFileName(photoUpload.FileName));

            //Display the Picture in Image control.
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(photoUpload.FileName);




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
                cmnd.Parameters.AddWithValue("@ProfilePicture", Image1.ImageUrl);
                cmnd.Parameters.AddWithValue("@UserEmail", uEmail);

                cmnd.ExecuteNonQuery();
            }
        }
    }
}