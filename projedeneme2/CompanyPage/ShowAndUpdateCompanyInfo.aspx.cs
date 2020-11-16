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



namespace projedeneme2.CompanyPage
{
    public partial class ShowAndUpdateCompanyInfo : System.Web.UI.Page
    {
        SqlConnection con = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                start();
            }
        }
        protected void start()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from CompanyInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete FROM CompanyInfo where Name='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            start();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            start();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            long number = Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textName = (TextBox)row.Cells[0].Controls[0];
            TextBox textURL = (TextBox)row.Cells[1].Controls[0];
            TextBox textPhonecode = (TextBox)row.Cells[2].Controls[0];
            TextBox textPhoneNumber = (TextBox)row.Cells[3].Controls[0];
            TextBox textIBAN = (TextBox)row.Cells[4].Controls[0];
            TextBox textCompanyDescr = (TextBox)row.Cells[5].Controls[0];
            TextBox textTaxadmin = (TextBox)row.Cells[6].Controls[0];
            TextBox textTaxNumber = (TextBox)row.Cells[7].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");  
            //TextBox textc = (TextBox)row.FindControl("txtc");  
            GridView1.EditIndex = -1;
            con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
            SqlCommand cmd = new SqlCommand("update CompanyInfo set Name='" + textName.Text + "',SiteURL='" + textURL.Text + "',PhoneContryCode='" + textPhonecode.Text + "',PhoneNumber='" + textPhoneNumber.Text + "',IBAN='" + textIBAN + "',Company_Description='" + textCompanyDescr + "',Tax_Admin='" + textTaxadmin + "',Tax_number='" + textTaxNumber + "'where PhoneNumber='" + number + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            start();
            //GridView1.DataBind();  



        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            start();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            start();
        }
    }
}
