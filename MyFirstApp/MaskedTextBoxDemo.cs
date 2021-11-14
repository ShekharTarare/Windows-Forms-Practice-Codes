using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class MaskedTextBoxDemo : Form
    {
        public MaskedTextBoxDemo()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneMTB.Text.ToString());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void MaskedTextBoxDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
