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
    public partial class Examination : Form
    {
        User user;
        int pid;
        KeyValuePair<DataSet, MySqlDataAdapter> ret;
        public Examination(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
        }

        private void btnSbmtLogin_Click(object sender, EventArgs e)
        {
            List<string> all = new List<string>();
            all.Add(generallock.Text);
            all.Add(headneck.Text);
            all.Add(chestexamination.Text);
            all.Add(cardiac.Text);
            all.Add(pulse.Text);
            all.Add(bloodpressure.Text);
            all.Add(temprature.Text);
            all.Add(respiratory.Text);
            all.Add(inspection.Text);
            all.Add(superficial.Text);
            all.Add(deepplap.Text);
            all.Add(percussion.Text);
            all.Add(auscultation.Text);
            all.Add(provisionaldiag.Text);
            if (user.newExamination(pid, all))
            {
                MessageBox.Show("Examinantion Added");
                PersonalInfo pi = new PersonalInfo(user);
                this.Hide();
                pi.Show();
            }
            else
                MessageBox.Show("Enter Correct Information !!");
        }
        private void Clear()
        {
            generallock.Clear();
            headneck.Clear();
            chestexamination.Clear();
            cardiac.Clear();
            pulse.Clear();
            bloodpressure.Clear();
            temprature.Clear();
            respiratory.Clear();
            inspection.Clear();
            superficial.Clear();
            deepplap.Clear();
            percussion.Clear();
            auscultation.Clear();
            provisionaldiag.Clear();
        }
        private void btnRstLogin_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
