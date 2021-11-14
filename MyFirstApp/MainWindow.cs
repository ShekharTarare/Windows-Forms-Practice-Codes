using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (numTxt1.Text == null || numTxt1.Text == "")
            {
                num1ErrorLab.Text = "Please enter any number!";
            }
            else
                num1ErrorLab.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            int flag = 0;
            if (numTxt1.Text == null || numTxt1.Text == "")
            {
                num1ErrorLab.Text = "Please enter any number!";
                flag++;
            }
            else if(!regex.Match(numTxt1.Text).Success)
            {
                num1ErrorLab.Text = "Please enter only number!";
                flag++;
            }
            else
                num1ErrorLab.Text = "";

            if (numTxt2.Text == null || numTxt2.Text == "")
            {
                num2ErrorLab.Text = "Please enter any number!";
                flag++;
            }
            else if(!regex.Match(numTxt2.Text).Success)
            {
                num2ErrorLab.Text = "Please enter only number!";
                flag++;
            }
            else
                num2ErrorLab.Text = "";

            if (flag == 0)
            {
                int num1 = int.Parse(numTxt1.Text);
                int num2 = int.Parse(numTxt2.Text);
                int add = num1 + num2;
                outputLab.Text = add.ToString();
            }
        }

        private void numTxt2_TextChanged(object sender, EventArgs e)
        {
            if (numTxt2.Text == null || numTxt2.Text == "")
            {
                num2ErrorLab.Text = "Please enter any number!";
            }
            else
                num2ErrorLab.Text = "";
        }
    }
}
