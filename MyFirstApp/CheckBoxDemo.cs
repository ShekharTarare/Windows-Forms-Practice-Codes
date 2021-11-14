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
    public partial class CheckBoxDemo : Form
    {
        public CheckBoxDemo()
        {
            InitializeComponent();
        }
        double sum = 0;

        private void calculateCharges(CheckBox checkBox, double amount, Label label, ListBox listBox)
        {
            if(checkBox.Checked)
            {
                sum = sum + amount;
                listBox.Items.Add(checkBox.Text);
                label.Text = sum.ToString();
            }
            else
            {
                sum = sum - amount;
                listBox.Items.Remove(checkBox.Text);
                label.Text = sum.ToString();
            }
        }

        private void internetCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateCharges(internetCB, 500, totalChargesLab, chargesLB);
        }

        private void swimmingCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateCharges(swimmingCB, 450, totalChargesLab, chargesLB);
        }

        private void lunchCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateCharges(lunchCB, 200, totalChargesLab, chargesLB);
        }

        private void geyserCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateCharges(geyserCB, 200, totalChargesLab, chargesLB);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void CheckBoxDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
