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
    public partial class Laboratory : Form
    {
        KeyValuePair<DataSet, MySqlDataAdapter> ret;
        public Laboratory(User user, int pid)
        {
            InitializeComponent();
            ret = user.GetCoagulationProfile(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvprofile.AutoGenerateColumns = true;
                dgvprofile.DataSource = ret.Key.Tables[0];
            }
            ret = user.GetCompleteBloodPicture(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvblood.AutoGenerateColumns = true;
                dgvblood.DataSource = ret.Key.Tables[0];
            }
            ret = user.GetElectrolyTeskIdneyfun(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvfunctions.AutoGenerateColumns = true;
                dgvfunctions.DataSource = ret.Key.Tables[0];
            }
            ret = user.GetLiverFun(pid);
            if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
            {
                dgvliver.AutoGenerateColumns = true;
                dgvliver.DataSource = ret.Key.Tables[0];
            }
        }
    }
}
