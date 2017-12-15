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
    public partial class Imaging_Studies : Form
    {
        
        int pid;
        User user;
        KeyValuePair<DataSet,MySqlDataAdapter>ret;
        public Imaging_Studies(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
        }

        private void btnSbmtLogin_Click(object sender, EventArgs e)
        {
            List<string> all = new List<string>();
            all.Add(chestxrays.Text);
            all.Add(abdominal.Text);
            all.Add(msct.Text);
            all.Add(other.Text);
            if (user.newImagingStudies(pid, all))
            {
                MessageBox.Show("Imaging Study Added");
                PersonalInfo pi = new PersonalInfo(user);
                this.Hide();
                pi.Show();
            }
            else
                MessageBox.Show("Enter Correct Information !!");
        }
    }
}
