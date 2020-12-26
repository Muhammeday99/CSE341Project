using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;
//using projedeneme2.Homepage;


namespace projedeneme2.CariKart
{
    public partial class WebForm1 : projedeneme2.Homepage.WebForm1
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Session["ID"].ToString();
            JsonConverter convert = new JsonConverter();
            DataTable table = convert.ToJson("Entity_Card");
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str,"EntityCards.json");
        }
        protected void Yeni_Cari_Kart_click(object sender, EventArgs e)
        {
            Response.Redirect("/CariKart/YeniCariKart.aspx");
        }

        

    }

    

}