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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void comboBoxBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ComboBoxDemo comboBoxDemo = new ComboBoxDemo();
            comboBoxDemo.MdiParent = Home.ActiveForm;
            comboBoxDemo.WindowState = FormWindowState.Maximized;
            comboBoxDemo.Show();
        }

        private void checkBoxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBoxDemo checkBoxDemo = new CheckBoxDemo();
            checkBoxDemo.Show();
        }

        private void maskedTextBoxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaskedTextBoxDemo maskedTextBoxDemo = new MaskedTextBoxDemo();
            maskedTextBoxDemo.Show();
        }

        private void pictureBoxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PictureBoxDemo pictureBoxDemo = new PictureBoxDemo();
            pictureBoxDemo.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }
    }
}
