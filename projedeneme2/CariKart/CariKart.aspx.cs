using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using projedeneme2.Homepage;


namespace projedeneme2.CariKart
{
    public partial class WebForm1 : projedeneme2.Homepage.WebForm1
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityJsonConverter convert = new EntityJsonConverter();
            DataTable table = convert.ToJson();
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str);
        }
        protected void Yeni_Cari_Kart_click(object sender, EventArgs e)
        {
            Response.Redirect("/CariKart/YeniCariKart.aspx");
        }

    }
}