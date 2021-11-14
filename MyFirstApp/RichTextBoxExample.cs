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
    public partial class RichTextBoxExample : Form
    {
        public RichTextBoxExample()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {            
            if(textRichTextBox.Text != "")
            {
                if (filenameTextBox.Text != "")
                {
                    string filename = filenameTextBox.Text.ToString();
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + filename;
                    if(File.Exists(path))
                    {
                        DialogResult dr = MessageBox.Show("File already exists. Do you want to append the text on the same file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            File.AppendAllText(path, textRichTextBox.Text);
                            MessageBox.Show("Text appended to the existing file!");
                        }
                        else
                        {
                            MessageBox.Show("Please enter any other filename!");
                        }
                    }
                    else
                    {
                        File.WriteAllText(path, textRichTextBox.Text);
                        MessageBox.Show("File saved successfully!");
                    }
                }
                else
                    MessageBox.Show("Please enter any filename!");
            }
            else
            {
                MessageBox.Show("Please enter something!");
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if(filenameTextBox.Text != "")
            {
                string filename = filenameTextBox.Text.ToString();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + filename;
                if (File.Exists(path))
                {
                    FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
                    byte[] data = new byte[100];
                    fs.Read(data, 0, Convert.ToInt32(fs.Length));
                    foreach(byte item in data)
                    {
                        textRichTextBox.AppendText(Convert.ToChar(item).ToString());
                    }
                }
                else
                    MessageBox.Show("File doesn't exist!");
            }
            else
                MessageBox.Show("Please enter any filename!");
        }
    }
}
