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
    public partial class MyBrowser : Form
    {
        public MyBrowser()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (addressTB.Text != "")
            {
                Uri uri = new Uri("https://" + addressTB.Text);
                myWebBrowser.Url = uri;
                addressTB.Text = "https://" + addressTB.Text;
            }
            else
                MessageBox.Show("Please enter any web address!");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            myWebBrowser.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            myWebBrowser.GoForward();
        }

        private void homePageLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myWebBrowser.GoHome();
        }
    }
}
