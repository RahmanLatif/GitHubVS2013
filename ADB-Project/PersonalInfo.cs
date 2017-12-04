using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Project
{
    public partial class PersonalInfo : Form
    {
        User user;
        public PersonalInfo(User user)
        {
            InitializeComponent();
            this.user = user;
            if (user.UserType == "Xray technician")
            {
                this.exambtn.Enabled = false;
                this.fluidbtn.Enabled = false;
                this.combtn.Enabled = false;
                this.Imagbtn.Enabled = true;
                this.tempbtn.Enabled = false;
                this.labbtn.Enabled = false;
                this.addbtn.Enabled = false;
            }
            else if (user.UserType == "Analysis technician")
            {
                this.exambtn.Enabled = false;
                this.fluidbtn.Enabled = true;
                this.combtn.Enabled = false;
                this.Imagbtn.Enabled = false;
                this.tempbtn.Enabled = false;
                this.labbtn.Enabled = true;
                this.addbtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtbxID.Text);
                DataSet ds = user.GetInfo(Id);
                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    txtbxName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtbxAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtbxAge.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtbxMstatus.Text = ds.Tables[0].Rows[0][5].ToString();
                    comboBox1.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                    ResetData();
            }
            catch (Exception ex)
            {
                ResetData();
            }
            
        }
        public void ResetData()
        {
            txtbxMstatus.Clear();
            txtbxName.Clear();
            txtbxAddress.Clear();
            txtbxAge.Clear();
            comboBox1.Text = "";
            dgvComplaint.Rows.Clear();
            dgvFamHistory.Rows.Clear();
            dgvMedHistory.Rows.Clear();
            dgvPastHistory.Rows.Clear();
            dgvPresentHistory.Rows.Clear();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addnew ad = new Addnew(user);
            ad.Show();
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            ResetData();
        }

    }
}
