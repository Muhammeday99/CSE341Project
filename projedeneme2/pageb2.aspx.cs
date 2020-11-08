using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace projedeneme2
{
    public partial class pageb2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-4MS0SVU;Initial Catalog=PROJECT_TRACKING_SYSTEM;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PageBValues", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            pageb.DataSource = dtbl;
            pageb.DataBind();
        }

        protected void lnkSelect_Click(object sender, EventArgs e)
        {
          //  int id = Convert.ToInt32((sender as LinkButton).CommandArgument);

        }
    }
}