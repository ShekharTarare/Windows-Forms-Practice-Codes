using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class ViewAllUsers : Form
    {
        public ViewAllUsers()
        {
            InitializeComponent();
        }

        private void ViewAllUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ViewAllUsers_Load(object sender, EventArgs e)
        {
            Database_code database_Code = new Database_code();
            database_Code.GetAllUsers(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //to resolve the error when clicking on headers 
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; //got the clicked row's data
                MessageBox.Show("The person name in this row is " + row.Cells["Name"].Value.ToString());

                if(e.ColumnIndex == 2)
                {
                    MessageBox.Show(row.Cells["Gender"].Value.ToString());
                }

                nameTextBox.Text = row.Cells["Name"].Value.ToString();
            }
        }
    }
}
