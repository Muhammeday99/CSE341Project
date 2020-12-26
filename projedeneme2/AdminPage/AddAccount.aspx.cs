using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using projedeneme2.InputControllers;


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
        
        protected void saveButtonClick(object sender, EventArgs e)
        {
            con.Open();

            string folderPath = Server.MapPath("../ProfilePictures/");
            Console.WriteLine(folderPath);
            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            try
            {
                if (photoUpload.PostedFile != null)
                {
                    //Save the File to the Directory (Folder).
                    string imgFile = Path.GetFileName(photoUpload.PostedFile.FileName); ;
                    System.Diagnostics.Debug.WriteLine(imgFile);
                    System.Diagnostics.Debug.WriteLine(folderPath);
                    photoUpload.SaveAs(folderPath + imgFile);
                    //Display the Picture in Image control.
                    Image1.ImageUrl = "/../ProfilePictures/" + imgFile;
                    System.Diagnostics.Debug.WriteLine(Image1.ImageUrl);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Hello");
                }
            }catch(Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(folderPath);
            }

            List<string> inputs = new List<string>();
            
            //mail input
            string uEmail = emailBox.Text;
            inputs.Add(uEmail);

            //password input
            string uPassword = passwordBox.Text;
            inputs.Add(uPassword);

            //checks if admin or not.
            Boolean isAdmin = adminOrNot.Checked;

            if (!uEmail.Contains('@') || (!stringController.listStringController(inputs))){
                errorLabel.Text = "Your email should contain @, and password needs to be longer than 1 character.";
            }
            else{
                String q = "INSERT INTO dbo.Users (Password,Status,ProfilePicture,UserEmail) VALUES (@Password, @Status,@ProfilePicture, @UserEmail)";

                SqlCommand cmnd = new SqlCommand(q,con);

                cmnd.Parameters.AddWithValue("@Password", encryption.EnryptString(uPassword));
                cmnd.Parameters.AddWithValue("@Status", isAdmin);
                cmnd.Parameters.AddWithValue("@ProfilePicture", Image1.ImageUrl);
                cmnd.Parameters.AddWithValue("@UserEmail", uEmail);

                cmnd.ExecuteNonQuery();

                //clears inputs.
                clearInputs();
            }

            con.Close();
        }

        //This method clears those inputs.
        private bool clearInputs()
        {
            try
            {
                emailBox.Text = null;
                passwordBox.Text = null;
                adminOrNot.Checked = false;
                photoUpload = null;
            }
            catch(Exception exc)
            {
                Console.WriteLine("Some error happened.");
                return false;
            }
      
            return true;
        }

        protected void passwordtext_Changed(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            int securityLevel = stringController.passwordSecurity(password);

            switch (securityLevel) {
                case 0:
                    passwordLevelLabel.Text = "UYARI: Şifre güvenliği çok düşük. Özel karakterler, büyük ve küçük karakterler kullanabilirsiniz.";
                    break;
                case 1:
                    passwordLevelLabel.Text = "Şifre güvenliği : Düşük.";
                    break;
                case 2:
                    passwordLevelLabel.Text = "Şifre güvenliği : Orta.";
                    break;
                case 3:
                    passwordLevelLabel.Text = "Şifre güvenliği : İyi.";
                    break;
                case 4:
                    passwordLevelLabel.Text = "Şifre güvenliği : Çok iyi.";
                    break;
            }
        }
    }
}