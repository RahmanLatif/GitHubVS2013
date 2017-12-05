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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnSbmtLogin_Click(object sender, EventArgs e)
        {
            int idx = cmboUserType.SelectedIndex;
            this.Hide();
            User user = new User(txtbxUsernameLogin.Text, txtbxPassLogin.Text, cmboUserType.Text);
            this.Hide();
            if (user.Login())
            {
                PersonalInfo perinfo = new PersonalInfo(user);
                perinfo.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
                Application.Restart();
            }

        }

        private void btnRstLogin_Click(object sender, EventArgs e)
        {
            txtbxUsernameLogin.Clear();
            txtbxPassLogin.Clear();
            cmboUserType.SelectedIndex = -1;
        }

    }
}
