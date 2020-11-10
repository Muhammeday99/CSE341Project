using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2
{
    public partial class Default : System.Web.UI.Page
    {
        //This should be there so we dont need to initialize again and again.
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-LG9NTD0;Initial Catalog=PROJECT_TRACKING_SYSTEM;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            con.Open();
       
            string userName = txtAd.Text;
            string userPassword = txtSifre.Text;

            SqlCommand sorgula = new SqlCommand("SELECT * FROM Users WHERE Username=@Username AND Password=@Password", con);

            sorgula.Parameters.AddWithValue("@Username", userName);
            sorgula.Parameters.AddWithValue("@Password", userPassword);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read())
            {
                //  Session["Kullanici"] = oku["KullaniciAdi"].ToString();
                //  Response.Redirect("Default.aspx");
                lblDurum.Text = "Kullanıcı adı ya da password!!";
            }
            else
                lblDurum.Text = "Kullanıcı adı yada şifre hatalı!";
            oku.Close();
            con.Close();
            con.Dispose();
        }
    }
}