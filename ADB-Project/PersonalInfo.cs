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
                int Id;
                bool ok = int.TryParse(txtbxID.Text, out Id);
                if (ok)
                {
                    DataSet ds = user.GetInfo(Id);
                    KeyValuePair<DataSet, MySqlDataAdapter> ret;
                    if (ds != null && ds.Tables[0].Rows.Count != 0)
                    {
                        txtbxName.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtbxAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                        txtbxAge.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtbxMstatus.Text = ds.Tables[0].Rows[0][5].ToString();
                        comboBox1.Text = ds.Tables[0].Rows[0][4].ToString();
                        ret = user.GetHistoryOfPast(Id); 
                        if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
                        {
                            dgvPastHistory.AutoGenerateColumns = true;
                            dgvPastHistory.DataSource = ret.Key.Tables[0];
                            dgvPastHistory.Columns[0].Visible = false;
                            dgvPastHistory.Columns[3].Visible = false;
                            dgvPastHistory.Columns[1].HeaderText = "Date";
                            dgvPastHistory.Columns[2].HeaderText = "Past History";
                        }
                        ret = user.GetComplain(Id);
                        if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
                        {
                            dgvComplaint.AutoGenerateColumns = true;
                            dgvComplaint.DataSource = ret.Key.Tables[0];
                            dgvComplaint.Columns[0].Visible = false;
                            dgvComplaint.Columns[3].Visible = false;
                            dgvComplaint.Columns[1].HeaderText = "Date";
                            dgvComplaint.Columns[2].HeaderText = "Complain";
                        }

                        ret = user.GetMedicalHistory(Id);
                        if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
                        {
                            dgvMedHistory.AutoGenerateColumns = true;
                            dgvMedHistory.DataSource = ret.Key.Tables[0];
                            dgvMedHistory.Columns[0].Visible = false;
                            dgvMedHistory.Columns[3].Visible = false;
                            dgvMedHistory.Columns[1].HeaderText = "Date";
                            dgvMedHistory.Columns[2].HeaderText = "Medical History";
                        }

                        ret = user.GetFamilyHistory(Id);
                        if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
                        {
                            dgvFamHistory.AutoGenerateColumns = true;
                            dgvFamHistory.DataSource = ret.Key.Tables[0];
                            dgvFamHistory.Columns[0].Visible = false;
                            dgvFamHistory.Columns[3].Visible = false;
                            dgvFamHistory.Columns[1].HeaderText = "Date";
                            dgvFamHistory.Columns[2].HeaderText = "Family History";
                        }
                        ret = user.GetPresentHistory(Id);
                        if (ret.Key != null && ret.Key.Tables[0].Rows.Count != 0)
                        {
                            dgvPresentHistory.AutoGenerateColumns = true;
                            dgvPresentHistory.DataSource = ret.Key.Tables[0];
                            dgvPresentHistory.Columns[0].Visible = false;
                            dgvPresentHistory.Columns[3].Visible = false;
                            dgvPresentHistory.Columns[1].HeaderText = "Date";
                            dgvPresentHistory.Columns[2].HeaderText = "Present Illness";
                        }
                    }
                    else
                        ResetData();
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
            txtbxID.Text = "";
            txtbxMstatus.Clear();
            txtbxName.Clear();
            txtbxAddress.Clear();
            txtbxAge.Clear();
            comboBox1.Text = "";
            dgvComplaint.DataSource = null;
            dgvFamHistory.DataSource = null;
            dgvMedHistory.DataSource = null;
            dgvPastHistory.DataSource = null;
            dgvPresentHistory.DataSource = null;
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

        private void combtn_Click(object sender, EventArgs e)
        {
            if (txtbxID.Text != "")
            {
                Comments cm = new Comments(user, int.Parse(txtbxID.Text));
                this.Hide();
                cm.Show();
            }
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            int id;
            bool ok;
            ok = Int32.TryParse(txtbxID.Text, out id);
            if (ok)
            {
                this.Hide();
                Examination exam = new Examination(this.user, id);
                exam.Show();
            }
        }

        private void labbtn_Click(object sender, EventArgs e)
        {
            int id;
            bool ok;
            ok = Int32.TryParse(txtbxID.Text, out id);
            if (ok)
            {
                this.Hide();
                Laboratory temp = new Laboratory(this.user, id);
                temp.Show();
            }
        }

        private void Imagbtn_Click(object sender, EventArgs e)
        {
            int id;
            bool ok;
            ok = Int32.TryParse(txtbxID.Text, out id);
            if (ok)
            {
                this.Hide();
                Laboratory temp = new Laboratory(this.user, id);
                temp.Show();
            }
        }

        private void tempbtn_Click(object sender, EventArgs e)
        {
            int id;
            bool ok;
            ok = Int32.TryParse(txtbxID.Text, out id);
            if (ok)
            {
                this.Hide();
                Temprature temp = new Temprature(this.user, id);
                temp.Show();
            }
        }

        private void fluidbtn_Click(object sender, EventArgs e)
        {
            int id;
            bool ok;
            ok = Int32.TryParse(txtbxID.Text, out id);
            if (ok)
            {
                this.Hide();
                Fluid temp = new Fluid(this.user, id);
                temp.Show();
            }
        }

    }
}
