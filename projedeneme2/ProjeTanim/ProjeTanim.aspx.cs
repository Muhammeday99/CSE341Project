using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.ProjeTanim
{
    public partial class ProjeTanim : projedeneme2.Homepage.Homepage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Yeni_Proje_Ekle_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ProjeTanim/YeniProjeEkle.aspx");
        }
    }
}