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
    public partial class Comments : Form
    {
        User user;
        int pid;
        public Comments(User user, int pid)
        {
            InitializeComponent();
            this.user = user;
            this.pid = pid;
            dataGridView1.DataSource = user.getComments(pid).Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Date";
            dataGridView1.Columns[2].HeaderText = "Comment";
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                    mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                    mySqlDataAdapter.Update(changes);
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
