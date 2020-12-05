using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace projedeneme2.DovizKurTanim
{
    public partial class WebForm1 : projedeneme2.Homepage.WebForm1
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JsonConverter convert = new JsonConverter();
            DataTable table = convert.ToJson("Currency");
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str, "ExchangeList.json");
        }
    }
}