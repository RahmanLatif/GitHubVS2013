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
            ret = user.GetImageStudies(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                chestxrays.Text = ret.Key.Tables[0].Rows[0][1].ToString();
                abdominal.Text = ret.Key.Tables[0].Rows[0][2].ToString();
                msct.Text = ret.Key.Tables[0].Rows[0][3].ToString();
                other.Text = ret.Key.Tables[0].Rows[0][4].ToString();
            }
        }
    }
}
