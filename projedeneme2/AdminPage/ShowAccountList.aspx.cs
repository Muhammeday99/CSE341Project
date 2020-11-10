using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace projedeneme2.AdminPage
{
    public partial class ShowAccountList : System.Web.UI.Page
    {
        SqlConnection con = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            //Nerden çekilecek belli olmadığı için PageBValues(Benim denemek için oluşturduğum) database den çekiyor gözüküyor.Değişecek...
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PageBValues", con);
            //Front end kısmında oluşan grid view den alıp tablo şeklinde listeliyor
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