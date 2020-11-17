using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            string uEmail = emailBox.Text;
            string uPassword = passwordBox.Text;
            Boolean isAdmin = adminOrNot.Checked;

            if (!uEmail.Contains('@'){
                errorLabel.Text = "Your email should contain @, and password needs to be longer than 1 character.";
            }
            else{

                SqlDataAdapter adapter = new SqlDataAdapter();
                //SqlCommand command = new SqlCommand("Insert INTO Users ()")
               




            }
        }
    }
}