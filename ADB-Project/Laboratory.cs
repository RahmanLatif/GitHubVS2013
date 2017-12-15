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
        User user;
        int pid;
        MySqlCommandBuilder mscb;
        KeyValuePair<DataSet, MySqlDataAdapter> ret1;
        KeyValuePair<DataSet, MySqlDataAdapter> ret2;
        KeyValuePair<DataSet, MySqlDataAdapter> ret3;
        KeyValuePair<DataSet, MySqlDataAdapter> ret4;
        public Laboratory(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
            ret1 = user.GetCoagulationProfile(pid);
            if (ret1.Key != null && ret1.Key.Tables[0].Rows.Count != 0)
            {
                dgvprofile.AutoGenerateColumns = true;
                dgvprofile.DataSource = ret1.Key.Tables[0];
                dgvprofile.Columns[0].Visible = false;
                dgvprofile.Columns[6].Visible = false;
            }
            ret2 = user.GetCompleteBloodPicture(pid);
            if (ret2.Key != null && ret2.Key.Tables[0].Rows.Count != 0)
            {
                dgvblood.AutoGenerateColumns = true;
                dgvblood.DataSource = ret2.Key.Tables[0];
                dgvblood.Columns[0].Visible = false;
                dgvblood.Columns[11].Visible = false;
            }
            ret3 = user.GetElectrolyTeskIdneyfun(pid);
            if (ret3.Key != null && ret3.Key.Tables[0].Rows.Count != 0)
            {
                dgvfunctions.AutoGenerateColumns = true;
                dgvfunctions.DataSource = ret3.Key.Tables[0];
                dgvfunctions.Columns[0].Visible = false;
                dgvfunctions.Columns[8].Visible = false;
            }
            ret4 = user.GetLiverFun(pid);
            if (ret4.Key != null && ret4.Key.Tables[0].Rows.Count != 0)
            {
                dgvliver.AutoGenerateColumns = true;
                dgvliver.DataSource = ret4.Key.Tables[0];
                dgvliver.Columns[0].Visible = false;
                dgvliver.Columns[9].Visible = false;
            }
        }

        private void btnSbmtLogin_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ret1.Key.Tables[0].Rows)
            {
                dr.SetField(0, "" + pid + "");
            }
            foreach (DataRow dr in ret2.Key.Tables[0].Rows)
            {
                dr.SetField(0, "" + pid + "");
            }
            foreach (DataRow dr in ret3.Key.Tables[0].Rows)
            {
                dr.SetField(0, "" + pid + "");
            }
            foreach (DataRow dr in ret4.Key.Tables[0].Rows)
            {
                dr.SetField(0, "" + pid + "");
            }
            try
            {
                mscb = new MySqlCommandBuilder(ret1.Value);
                ret1.Value.Update(ret1.Key);
                mscb = new MySqlCommandBuilder(ret2.Value);
                ret2.Value.Update(ret2.Key);
                mscb = new MySqlCommandBuilder(ret3.Value);
                ret3.Value.Update(ret3.Key);
                mscb = new MySqlCommandBuilder(ret4.Value);
                ret4.Value.Update(ret4.Key);
                MessageBox.Show("Updating done");
                PersonalInfo pi = new PersonalInfo(user);
                this.Hide();
                pi.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enter Correct Information !!");
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Blood Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Clinical System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvblood);
        }

        private void printbtn2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Coagulation Profile Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Clinical System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvprofile);
        }
        private void printbtn3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Electrolutes and Kidney Functions Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Clinical System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvprofile);
        }

        private void printbtn4_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liver Function Test Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Clinical System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvfunctions);
        }
    }
}
