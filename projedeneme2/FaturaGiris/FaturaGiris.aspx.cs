using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.FaturaGiris
{
    public partial class FaturaGirisWebForm : projedeneme2.Homepage.Homepage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Yeni_Fatura_Ekle_click(object sender, EventArgs e)
        {
            Response.Redirect("/FaturaGiris/YeniFaturaEkle.aspx");
        }

        [WebMethod]

        public static string getInvoices()
        {
            JsonConverter converter = new JsonConverter();
            return converter.TableToJSON("Invoice_info");
        }
    }
}