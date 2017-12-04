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
    public partial class Addnew : Form
    {
        User user;
        public Addnew(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnSbmtLogin_Click(object sender, EventArgs e)
        {
            KeyValuePair<bool, string> ret = user.AddUser(txtbxUsernameLogin.Text, txtbxPassLogin.Text, txtbxConfirm.Text, cmboUserType.Text);
            if (ret.Key)
            {
                MessageBox.Show(ret.Value);
                PersonalInfo pi = new PersonalInfo(user);
                this.Hide();
                pi.Show();
            }
            else
            {
                MessageBox.Show(ret.Value);
            }
        }
    }
}
