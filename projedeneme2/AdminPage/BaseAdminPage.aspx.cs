using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//In this section, the admin provides access to users' information.
namespace projedeneme2.AdminPage
{
    /**
     Base admin page class, admins will manage their stuff from
    there. 

    It will be 2 buttons here to manage.Each explained seperately.
     */
    public partial class BaseAdminPage : System.Web.UI.Page
    {
        //Connection to db
        protected SqlConnection conn = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if ((string)Session["NAME"] == null) EmailLabel.Text = "unnamed";
                else EmailLabel.Text = (string)Session["NAME"];
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error happened while fething name from session.");
            }
        }

        /**This function loads a new page that lists all users on our database.*/
        protected void listUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage/ShowAccountList.aspx");
        }

        /**This button loads a new page to add a new user on our database.*/
        protected void newUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage/AddAccount.aspx");
        }
    }
}