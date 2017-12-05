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
    public partial class Temprature : Form
    {
        User user;
        KeyValuePair<DataSet, MySqlDataAdapter> ret;
        int pid;
        public Temprature(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
            ret = user.GetTemprature(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvTemprature.DataSource = ret.Key.Tables[0];
                dgvTemprature.AutoGenerateColumns = true;
            }
        }
    }
}
