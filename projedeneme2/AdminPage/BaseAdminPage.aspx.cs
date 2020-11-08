using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.AdminPage
{

    protected SqlConnection conn = databaseConnect.connectToSQL();

    /**
     Base admin page class, admins will manage their stuff from
    there. 

    It will be 2 buttons here to manage.Each explained seperately.
     */
    public partial class BaseAdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /**This function loads a new page that lists all users on our database.*/
        protected void listUserButton_Click(object sender, EventArgs e)
        {
            
        }

        /**This button loads a new page to add a new user on our database.*/
        protected void newUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}