using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.MasrafTanim
{
    public partial class MasrafTanımı : System.Web.UI.Page
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNewExpense_Click(object sender, EventArgs e)
        {
            con.Open();
            string expenseCode = ExpenseCode.Text;
            string expenseName = ExpenseName.Text;
            string expenseDate = DateTime.Now.ToString(ExpenseDate.Text);

            String q = "INSERT INTO dbo.Expense_Info (ExpenseCode,ExpenseName,ExpenseDate) VALUES (@ExpenseCode, @ExpenseName, @ExpenseDate)";
            SqlCommand cmnd = new SqlCommand(q, con);

            cmnd.Parameters.AddWithValue("@ExpenseCode", expenseCode);
            cmnd.Parameters.AddWithValue("@expenseName", expenseName);
            cmnd.Parameters.AddWithValue("@expenseDate", expenseDate);
            //ADD EXPENSE AMOUNT LAZIM. ONU UNUTMUŞUM. DATABASE'E DE EKLENMESİ LAZIM.

            cmnd.ExecuteNonQuery();

            con.Close();
        }

        protected void DeleteExpense_Click(object sender, EventArgs e)
        {
            /*Expense Code girerek silme işlemi yapıyor, şimdilik burda kalsın
           SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Expense_Info] WHERE [ExpenseCode] ='" + ExpenseCode.Text + "'", con);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();*/
        }
    }
}