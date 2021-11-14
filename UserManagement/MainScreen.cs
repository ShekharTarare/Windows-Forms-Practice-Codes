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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void viewUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RetrieveData retUser = new RetrieveData();
            retUser.Show();
        }

        private void viewAllUsersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllUsers viewAllUsers = new ViewAllUsers();
            viewAllUsers.Show();
        }
    }
}
