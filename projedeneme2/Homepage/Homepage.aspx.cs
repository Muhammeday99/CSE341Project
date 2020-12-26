using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.Homepage
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public static string ID = " ";
        public static string NAME = " ";
        public static string ProfilePicture = " ";
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Session["ID"].ToString();
            NAME = Session["NAME"].ToString();
            ProfilePicture = Session["ProfilePicture"].ToString();
        }
        protected void Homepage_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void User_Profile_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Login_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Register_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Proje_Tanim_click(object sender, EventArgs e)
        {
            Response.Redirect("../ProjeTanim/ProjeTanim.aspx");
        }
        protected void Cari_Kart_click(object sender, EventArgs e)
        {
            Response.Redirect("../CariKart/CariKart.aspx");
        }
        protected void Doviz_Kur_Tanim_click(object sender, EventArgs e)
        {
            Response.Redirect("../DovizKurTanim/DovizKurTanim.aspx");
        }
        protected void Masraf_Tanimi_click(object sender, EventArgs e)
        {
            Response.Redirect("../MasrafTanim/MasrafTanim.aspx");
        }
        protected void Fatura_Giris_click(object sender, EventArgs e)
        {
            Response.Redirect("../FaturaGiris/FaturaGiris.aspx");
        }
        protected void Proje_Odeme_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Fatura_Odeme_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Masraf_Odeme_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Cek_Giris_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Kasa_Giris_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Tedarikci_Borc_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Müsteri_Alacak_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Bakiye_Durumu_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Kod_Degistir_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Urun_Ara_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }
        protected void Hata_Tespit_click(object sender, EventArgs e)
        {
            Response.Redirect("../Homepage/Homepage.aspx");
        }

        [WebMethod]
        public static string[] getUserInfo()
        {

            string[] info = { NAME, ProfilePicture };

            return info;
        }

        [WebMethod]
        public static string getCompanyInfo()
        {

            JsonConverter convert = new JsonConverter();

            return convert.getRowInfo("CompanyInfo", "ID", "1");
        }

        [WebMethod]
        public static string getProjectsInfo()
        {

            JsonConverter convert = new JsonConverter();

            return convert.TableToJSON("ProjectDefinition");
        }
    }
}