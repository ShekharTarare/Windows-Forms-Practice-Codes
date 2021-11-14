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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.MdiParent = this;
            home.WindowState = FormWindowState.Maximized;
            home.Show();
        }
    }
}
