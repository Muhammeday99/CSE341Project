using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.Profil
{
    public partial class Profil : projedeneme2.Homepage.Homepage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../YeniKullanici/YeniKullanici.aspx");
        }
        protected void newUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../YeniKullanici/YeniKullanici.aspx");
        }
        
    }
}