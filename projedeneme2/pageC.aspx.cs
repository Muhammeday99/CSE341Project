using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2
{
    public partial class pageC : System.Web.UI.Page
    {

        public SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void buttonClick(object sender, EventArgs e)
        {
            con.Open();

            string newName = TextBoxXX.Text;
            string newPassword = TextBox2.Text;

            string c = "insert into Users(Username,Password,Status) values (@Username,@Password,@Status)";
            SqlCommand addCommand = new SqlCommand(c, con);

            addCommand.Parameters.AddWithValue("@Username", newName);
            addCommand.Parameters.AddWithValue("@Password", newPassword);
            addCommand.Parameters.AddWithValue("@Status", true);

            addCommand.ExecuteNonQuery();

            con.Close();

        }
    }
}