using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class PictureBoxDemo : Form
    {
        public PictureBoxDemo()
        {
            InitializeComponent();
        }

        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            if (filenameTextBox.Text != "")
            {
                string destinationFilePath = @"C:\\Users\Shekhar\source\repos\MyFirstApp\MyFirstApp\Images\Output.jpg";
                File.Copy(filenameTextBox.Text, destinationFilePath);
                MessageBox.Show("Image saved successfully!");
            }
            else
                MessageBox.Show("Please select any file before saving!");
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                filenameTextBox.Text = openFileDialog1.FileName;
                Image image = new Bitmap(filenameTextBox.Text);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;               
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void PictureBoxDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
