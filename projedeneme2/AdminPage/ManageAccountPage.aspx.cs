using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.AdminPage
{
    public partial class ManageAccountPage : System.Web.UI.Page
    {

        protected SqlConnection conn = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void applyChanges_Click(object sender, EventArgs e)
        {
            //Henüz database bağlı değil.
            // "label" database e göre değişecek.

           // nameLabel.Text = "username from database."

            string changedName = NewnameText.Text;
            string changedPassword = NewpassText.Text;

            if(changedName.Length<=1 || changedPassword.Length <= 1){
                errorLabel.Text= "You cannot set this username or password less than 2 characters.";
            }

           


        }
    }
}