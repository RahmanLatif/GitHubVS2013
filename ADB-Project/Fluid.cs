using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ADB_Project
{
    public partial class Fluid : Form
    {
        KeyValuePair<DataSet, MySqlDataAdapter> ret;
        public Fluid(User user, int pid)
        {
            InitializeComponent();
            ret = user.GetFluid(pid);
            if (ret.Key!= null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvfluid.AutoGenerateColumns = true;
                dgvfluid.DataSource = ret.Key.Tables[0];
            }
        }
    }
}
