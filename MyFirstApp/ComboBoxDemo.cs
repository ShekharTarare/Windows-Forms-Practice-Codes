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
    public partial class ComboBoxDemo : Form
    {
        public ComboBoxDemo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedIndex != -1)
            {
                cityComboBox.Items.Clear();
                if (countryComboBox.SelectedItem.ToString() == "India")
                {
                    if (!cityComboBox.Items.Contains("Pune"))
                        cityComboBox.Items.Add("Pune");
                }
                else if (countryComboBox.SelectedItem.ToString() == "US")
                {
                    if (!cityComboBox.Items.Contains("Alaska"))
                        cityComboBox.Items.Add("Alaska");
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any country!");
            }
            else if(cityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any city!");
            }
            else
            {
                resLab.Text = countryComboBox.SelectedItem.ToString();
            }
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            if(cityComboBox.SelectedIndex != -1)
            {
                if (!citiesListBox.Items.Contains(cityComboBox.SelectedItem.ToString()))
                    citiesListBox.Items.Add(cityComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select any city first!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.MdiParent = MDIForm.ActiveForm;
            home.WindowState = FormWindowState.Maximized;
            home.Show();
        }

        private void ComboBoxDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
