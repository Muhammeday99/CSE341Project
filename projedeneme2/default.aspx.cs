using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using projedeneme2.InputControllers;
namespace projedeneme2
{

    /**OUR MAIN WEB FORM. 
    This web form makes the log-in with primary error handles. 
   #deneme
    ---Enter emailASASa
    ---Enter password
    ---ENTERaaAA
     */
    public partial class Default : System.Web.UI.Page
    {
        //This should be there so we dont need to initialize again and again.
        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //The registered user query is made on the login page.
        //If the login is verified, the user logs into the system.
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            
            bool isLoggedIn = false;
            string userEmail = string.Empty;
            string userPassword = string.Empty;
                  
            userEmail = InputEmail.Text;
            userPassword = InputPassword.Text;

            //because admin is not hold cryipted.
            if (userPassword != "admin" && userPassword != "unittest" ) userPassword = encryption.DecryptString(InputPassword.Text);
            Console.WriteLine("{0}", (userPassword));

            //Checks if user is admin or user.
            isLoggedIn = IsValidLogin(userEmail, userPassword);
            if (isLoggedIn)
            {
                Session.Add("email", userEmail);
                Boolean checkUserType = checkUser(userEmail,userPassword);

                if (checkUserType)
                {
                    Session["USER"] = "ADMIN";
                    Response.Redirect("AdminPage/BaseAdminPage.aspx");
                }
                else
                {
                    Session["USER"] = "USER";
                    Response.Redirect("Homepage/Homepage.aspx");
                }
            }
            else
            {
                statusLabel.Text = "Email yada şifre hatalı!";
            }
        }

        //Checks if you are logged in, email and password are correct
        public bool IsValidLogin(string userEmail, string userPassword)
        {
            //Opens the database.
            con.Open();

            //String for checking.
            SqlCommand check = new SqlCommand("SELECT * FROM Users WHERE UserEmail=@userEmail AND Password=@userPassword", con);
            check.Parameters.AddWithValue("@userEmail", userEmail);
            check.Parameters.AddWithValue("@userPassword", userPassword);
            SqlDataReader sqlRead = check.ExecuteReader();

            if (sqlRead.Read())
            {
                //Closes the previus db.
                sqlRead.Close();

                //This is a sql con to fetch id from login.
                string idstring = "SELECT UserID FROM USERS WHERE UserEmail=@userEmail";
                check = new SqlCommand(idstring, con);
                check.Parameters.AddWithValue("@userEmail", userEmail);
                sqlRead = check.ExecuteReader();
                sqlRead.Read();
                Session["ID"] = sqlRead.GetInt32(0);
                sqlRead.Close();

                //This is a sql con to fetch id from login.
                string PPstring = "SELECT ProfilePicture FROM USERS WHERE UserEmail=@userEmail";
                check = new SqlCommand(PPstring, con);
                check.Parameters.AddWithValue("@userEmail", userEmail);
                sqlRead = check.ExecuteReader();
                sqlRead.Read();

                //Assign id and name to session.
                
                Session["NAME"] = userEmail.Substring(0,userEmail.IndexOf('@'));
                Session["ProfilePicture"] = sqlRead.GetString(0);

                con.Close();
                sqlRead.Close();
                return true;
            }
          
            con.Close();
            sqlRead.Close();
            return false;
        }

        //Checking whether the logged in person is an admin or a user
        public Boolean checkUser(string userEmail,string userPassword)
        {
            //Opens the database.
            con.Open();

            string query = "SELECT Status FROM Users WHERE [Status] = 1 and [UserEmail] = @userEmail AND [Password] = @userPassword";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@userEmail", userEmail);
            command.Parameters.AddWithValue("@userPassword", userPassword);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            con.Close();

            return false;
        }
    }
}