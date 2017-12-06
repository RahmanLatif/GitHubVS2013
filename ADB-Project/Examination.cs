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
    }
}
