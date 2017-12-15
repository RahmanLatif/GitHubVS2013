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
        User user;
        int pid;
        MySqlCommandBuilder mscb;
        KeyValuePair<DataSet, MySqlDataAdapter> ret;
        public Fluid(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
            ret = user.GetFluid(pid);
            if (ret.Key!= null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvfluid.AutoGenerateColumns = true;
                dgvfluid.DataSource = ret.Key.Tables[0];
                dgvfluid.Columns[0].Visible = false;
                dgvfluid.Columns[4].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ret.Key.Tables[0].Rows)
            {
                dr.SetField(0, "" + pid + "");
            }
            try
            {
                mscb = new MySqlCommandBuilder(ret.Value);
                ret.Value.Update(ret.Key);
                MessageBox.Show("Updating done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalInfo pi = new PersonalInfo(user);
            this.Hide();
            pi.Show();
        }
    }
}
