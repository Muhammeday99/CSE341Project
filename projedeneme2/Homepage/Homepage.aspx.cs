using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.Homepage
{
	
	public partial class Homepage : System.Web.UI.Page
	{
		protected static SqlConnection con = databaseConnect.connectToSQL();
		public static string ID = " ";
		public static string NAME = " ";
		public static string ProfilePicture = " ";
		protected void Page_Load(object sender, EventArgs e)
		{
			con.Close();
			con.Open();
			try
			{
				ID = Session["ID"].ToString();
				NAME = Session["NAME"].ToString();
				ProfilePicture = Session["ProfilePicture"].ToString();
			}catch(System.NullReferenceException exc)
			{
				ID = "noID";
				NAME = "noname";
				ProfilePicture = " ";
			}
		}

		protected void Homepage_click(object sender, EventArgs e)
		{
			Response.Redirect("../Homepage/Homepage.aspx");
		}
		protected void User_Profile_click(object sender, EventArgs e)
		{
			Response.Redirect("../Profil/Profil.aspx");
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
			SqlCommand cmd = new SqlCommand("select UserName,UserSurname,UserEmail,ProfilePicture,Status from Users where UserID = @ID;", con);
			cmd.Parameters.AddWithValue("@ID", Int32.Parse(ID));
			SqlDataReader dataReader = cmd.ExecuteReader();
			string[] info = new string[5];
			while (dataReader.Read())
			{
				for (int i = 0; i < info.Length; i++)
				{
					info[i] = dataReader.GetValue(i).ToString();
				}
			}
			dataReader.Close();
			return info;
		}

		[WebMethod]
		public static string getCompanyInfo()
		{

			JsonConverter convert = new JsonConverter();

			return convert.getRowInfo("CompanyInfo", "ID", "1");
		}

		[WebMethod]

		public static int[] getCountInfo()
        {
			int[] info = new int[4];
			string[] tables = { "Entity_Card", "Invoice_Info", "ProjectDefinition", "Users" };


			for (int i = 0; i < 4; ++i) {

				SqlCommand cmd = new SqlCommand("Select Count(*) from " + tables[i], con);
				SqlDataReader dataReader = cmd.ExecuteReader();
				if (dataReader.Read())
				{
					info[i] = dataReader.GetInt32(0);
				}
				dataReader.Close();
			}
			return info;
		}

		[WebMethod]

		public static float[] getTotalAmounts() {
			float[] total = new float[3];
			string[] tables = { "Invoice_Info", "ProjectDefinition", "Expense_Info" };
			SqlCommand cmd;
			SqlDataReader dataReader;

			for (int i = 0; i < 2; ++i)
			{

				cmd = new SqlCommand("Select Sum(Amount + Amount*KDVpercentage*0.01) from " + tables[i], con);
				dataReader = cmd.ExecuteReader();
				if (dataReader.Read())
				{
					string t = dataReader.GetValue(0).ToString();
					total[i] = float.Parse(t);
				}
				dataReader.Close();
			}

			cmd = new SqlCommand("Select Sum(ExpenseAmount) from " + tables[2], con);
			dataReader = cmd.ExecuteReader();
			if (dataReader.Read())
			{
				string t = dataReader.GetValue(0).ToString();
				total[2] = float.Parse(t);
			}
			dataReader.Close();
			return total;
		}

		[WebMethod]

		public static List<string> getProjectNames() {
			List<string> names = new List<string>();

			SqlCommand cmd = new SqlCommand("Select ProjectName from ProjectDefinition", con);
			SqlDataReader dataReader = cmd.ExecuteReader();
			
            while (dataReader.Read())
            {
				names.Add(dataReader.GetString(0));
            }
			dataReader.Close();
			return names;
		}
	}
}