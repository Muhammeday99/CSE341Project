﻿using System;
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
           
            bool isLoggedIn = false;
            string userEmail = string.Empty;
            string userPassword = string.Empty;
                  
            userEmail = InputEmail.Text;
            userPassword = InputPassword.Text;
            isLoggedIn = IsValidLogin(userEmail, userPassword);
            if (isLoggedIn)
            {
                Session.Add("email", userEmail);
                Boolean checkUserType = checkUser(userEmail,userPassword);

                if (checkUserType)
                {
                    Response.Redirect("AdminPage/BaseAdminPage.aspx");
                }
                else
                {
                    Response.Redirect("Homepage/Homepage.aspx");
                }
            }
            else
            {
                statusLabel.Text = "Email yada şifre hatalı!";
            }
        }
        //Checks if you are logged in, email and password are correct
        private bool IsValidLogin(string userEmail, string userPassword)
        {
  
            SqlCommand check = new SqlCommand("SELECT * FROM Users WHERE UserEmail=@userEmail AND Password=@userPassword", con);
            check.Parameters.AddWithValue("@userEmail", userEmail);
            check.Parameters.AddWithValue("@userPassword", userPassword);
            //Opens the database.
            con.Open();
            SqlDataReader sqlRead = check.ExecuteReader();

            if (sqlRead.Read())
            {
                con.Close();
                sqlRead.Close();
                return true;
            }
          
            con.Close();
            sqlRead.Close();
            return false;
           
        }
        //Checking whether the logged in person is an admin or a user
        protected Boolean checkUser(string userEmail,string userPassword)
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