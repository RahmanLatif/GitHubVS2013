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
            ret = user.GetExamination(this.pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                generallock.Text = ret.Key.Tables[0].Rows[0][1].ToString();
                headneck.Text = ret.Key.Tables[0].Rows[0][6].ToString();
                chestexamination.Text = ret.Key.Tables[0].Rows[0][7].ToString();
                cardiac.Text = ret.Key.Tables[0].Rows[0][8].ToString();
                pulse.Text = ret.Key.Tables[0].Rows[0][2].ToString();
                bloodpressure.Text = ret.Key.Tables[0].Rows[0][3].ToString();
                temprature.Text = ret.Key.Tables[0].Rows[0][4].ToString();
                respiratory.Text = ret.Key.Tables[0].Rows[0][5].ToString();
                inspection.Text = ret.Key.Tables[0].Rows[0][10].ToString();
                superficial.Text = ret.Key.Tables[0].Rows[0][11].ToString();
                deepplap.Text = ret.Key.Tables[0].Rows[0][12].ToString();
                percussion.Text = ret.Key.Tables[0].Rows[0][13].ToString();
                auscultation.Text = ret.Key.Tables[0].Rows[0][14].ToString();
                provisionaldiag.Text = ret.Key.Tables[0].Rows[0][15].ToString();
                examdate.Text = ret.Key.Tables[0].Rows[0][0].ToString();
            }
        }
    }
}
