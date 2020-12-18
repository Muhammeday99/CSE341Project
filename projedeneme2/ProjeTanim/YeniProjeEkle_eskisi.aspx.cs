using projedeneme2.InputControllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projedeneme2.ProjeTanim
{
    public partial class YeniProjeEkle_eskisi: System.Web.UI.Page
    {

        protected SqlConnection con = databaseConnect.connectToSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            List<string> inputs = new List<string>();

            string n_projectCode = projectCode.Text;
            inputs.Add(n_projectCode);

            string n_projectName = projectName.Text;
            inputs.Add(n_projectName);

            string n_clientCode = clientCode.Text;
            inputs.Add(n_clientCode);

            string n_orderCode = orderCode.Text;
            inputs.Add(n_orderCode);

            string n_billCode = billCode.Text;
            inputs.Add(n_billCode);

            string n_startDate = startDate.Text;
            inputs.Add(n_startDate);

            string n_finishDate = finishDate.Text;
            string n_exchangeCode = exchangeCode.Text;

            long n_feeBox = -1;
            if (!Int64.TryParse(feeBox.Text, out n_feeBox)) return;

            long n_KDVBox = -1;
            if (!Int64.TryParse(KDVbox.Text, out n_KDVBox)) return;

            string n_authorizedBox = authorizedBox.Text;
            inputs.Add(n_authorizedBox);

            bool n_activeProject = activeProject.Checked;

            if (!stringController.listStringController(inputs))
            {

            }
            else
            {


            }

            con.Close();
        }

        protected void activeProject_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}