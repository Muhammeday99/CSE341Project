﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;
using projedeneme2.InputControllers;

namespace projedeneme2.Kullanicilar
{
    public partial class KullaniciListesi : projedeneme2.Homepage.Homepage
    {
        SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //To restore the page so that data is not lost and overlaid 
            if (!IsPostBack)
            {
                ShowData();
            }
            JsonConverter convert = new JsonConverter();
            DataTable table = convert.ToJson("Users");
            string str = convert.DataTableToJSON(table);
            convert.WriteToJsonFile(str, "Users.json");
        }

        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select UserID,Password,ProfilePicture,UserEmail,Status from Users", con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            con.Close();
        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            //Finding the controls from Gridview for the row which is going to update  
            TextBox password = GridView1.Rows[e.RowIndex].FindControl("passwordTextBox") as TextBox;
            TextBox profilephoto = GridView1.Rows[e.RowIndex].FindControl("ProfileFotoTextBox") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("useremailTextBox") as TextBox;
            //CheckBox Status = GridView1.Rows[e.RowIndex].FindControl("StatusCheckBox") as CheckBox;
            //Check Box not fix
            con.Open();

            SqlCommand cmd = new SqlCommand("Update Users set Password='" + encryption.DecryptString(password.Text) + "',ProfilePicture='" + profilephoto.Text + "',UserEmail='" + email.Text + "'where UserID='" + id + "'", con);
            cmd.ExecuteNonQuery();

            con.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            //Call ShowData method for displaying updated data  
            ShowData();
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            ShowData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}