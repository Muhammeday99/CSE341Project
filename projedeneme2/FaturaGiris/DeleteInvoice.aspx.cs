using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Drawing;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


namespace projedeneme2.FaturaGiris
{
    public partial class DeleteInvoice : System.Web.UI.Page
    {
        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        protected void BindGrid()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select InvoiceNumber,InvoiceDate,entityCode,InvoiceDescription,PaymentDate,CurrencyCode,Amount,KDVpercentage from Invoice_info", con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            con.Close();
        }
      
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
        }
        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            con.Open();
            string invoiceNumber = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string sqlStatement = "DELETE FROM Invoice_info WHERE InvoiceNumber=@InvoiceNumber";
            SqlCommand cmd = new SqlCommand(sqlStatement, con);
            cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
        }

    }
}