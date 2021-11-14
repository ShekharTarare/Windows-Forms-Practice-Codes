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
    public partial class MenuExampleDemo : Form
    {
        public MenuExampleDemo()
        {
            InitializeComponent();
        }

        private void page1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxDemo pictureBoxDemo = new PictureBoxDemo();
            pictureBoxDemo.ShowDialog();
            //pictureBoxDemo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxDemo pictureBoxDemo = new PictureBoxDemo();
            pictureBoxDemo.ShowDialog();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hello";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }
        }
    }
}
