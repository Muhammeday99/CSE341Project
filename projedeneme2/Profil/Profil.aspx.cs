using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.Profil
{
    public partial class Profil : projedeneme2.Homepage.Homepage
    {
        protected SqlConnection conn = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listUserButton_Click(object sender, EventArgs e)
        {
            //Bu şimdilik eski sayfaya gidiyor, sonra yeni yere gidecek..
            Response.Redirect("../Kullanicilar/KullaniciListesi.aspx");
        }
        protected void newUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Kullanicilar/YeniKullanici.aspx");
        }
        
    }
}