using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.MasrafTanim
{
    public partial class MasrafTanimWebForm : Homepage.Homepage
    {
        protected SqlConnection con = databaseConnect.connectToSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNewExpense_Click(object sender, EventArgs e)
        {
            con.Open();
           
            List<string> inputs = new List<string>();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = "";
            int flag = 0;

            sql = "Select ExpenseCode,ExpenseName,ExpenseDate,ExpenseAmount from Expense_Info";
            command = new SqlCommand(sql, con);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0);
                inputs.Add(output);
                output = "";
            }
            con.Close();
            con.Open();
            try
            {   
                string expenseCode = ExpenseCode.Text;
                //Check unique or not
                for (int i = 0; i < inputs.Count; i++)
                {
                    if (expenseCode == inputs[i])
                    {
                        flag = 1;
                        errorLabel.Text = "Adding operation failed!";
                        break;
                    }
                }
                if(flag != 1)
                {
                    string expenseName = ExpenseName.Text;
                    string expenseDate = DateTime.Now.ToString(ExpenseDate.Text);
                    double expenseAmount = Convert.ToDouble(ExpenseAmount.Text);

                    String q = "INSERT INTO dbo.Expense_Info (ExpenseCode,ExpenseName,ExpenseDate, ExpenseAmount) VALUES (@ExpenseCode, @ExpenseName, @ExpenseDate, @ExpenseAmount)";
                    SqlCommand cmnd = new SqlCommand(q, con);

                    cmnd.Parameters.AddWithValue("@ExpenseCode", expenseCode);
                    cmnd.Parameters.AddWithValue("@ExpenseName", expenseName);
                    cmnd.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                    cmnd.Parameters.AddWithValue("@ExpenseAmount", expenseAmount);

                    cmnd.ExecuteNonQuery();
                    errorLabel.Text = "Added successfully..";
                }   
                con.Close();
            }
            catch(Exception exp)
            {

            }

            
        }

        [WebMethod]
        public static string getExpenses()
        {
            JsonConverter converter = new JsonConverter();

            return converter.TableToJSON("Expense_Info");
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