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
    public partial class RadioButtonsDemo : Form
    {
        public RadioButtonsDemo()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.ToString() != "")
            {
                if (maleRadioButton.Checked)
                {
                    displayLabel.Text = "Name is " + nameTextBox.Text.ToString() + " and gender is " + maleRadioButton.Text.ToString() + ".";
                }
                else if (femaleRadioButton.Checked)
                {
                    displayLabel.Text = "Name is " + nameTextBox.Text.ToString() + " and gender is " + femaleRadioButton.Text.ToString() + ".";
                }
                else
                {
                    MessageBox.Show("Please select your gender!");
                }
            }
            else
                MessageBox.Show("Please enter your name!");
        }
    }
}
