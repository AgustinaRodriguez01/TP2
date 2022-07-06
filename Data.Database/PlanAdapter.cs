using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PlanAdapter: Adapter
    {
        public void GetDescripciones(ComboBox cb)
        {
            cb.Items.Clear();
            this.OpenConnection();
            SqlCommand cmdPlan = new SqlCommand("select * from planes", sqlConn);
            SqlDataReader drPlan = cmdPlan.ExecuteReader();
            while (drPlan.Read())
            {
                cb.Items.Add(drPlan["desc_plan"].ToString());
            }
            this.CloseConnection();
            cb.Items.Insert(0, "Elija uno...");
            cb.SelectedIndex = 0;
        }
    }
}
