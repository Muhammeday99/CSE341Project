using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace projedeneme2
{
     
    public partial class pageA : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-LG9NTD0;Initial Catalog=PROJECT_TRACKING_SYSTEM;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string vad = TextBox1.Text;
            string vsoyad = TextBox2.Text;

            SqlCommand CMD = new SqlCommand("insert into Users(Username,Password,Status) Values(@Username,@Password,@Status)",connect);
            CMD.Parameters.AddWithValue("@Username", vad);
            CMD.Parameters.AddWithValue("@Password", vsoyad);
            CMD.Parameters.AddWithValue("@Status", CheckBox1.Checked);
            
            CMD.ExecuteNonQuery();
            connect.Close();
           
        }
    }
}