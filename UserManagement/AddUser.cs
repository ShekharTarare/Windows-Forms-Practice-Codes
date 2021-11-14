using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void ResetControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && ageTextBox.Text != "" && phoneTextBox.Text != "" &&
                (maleRadioButton.Checked == true || femaleRadioButton.Checked == true) &&
                (statusComboBox.SelectedIndex != -1))
            {
                Database_code db = new Database_code();
                Int16 gender = maleRadioButton.Checked ? Convert.ToInt16(1) : Convert.ToInt16(0);
                Int16 status = statusComboBox.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                db.AddUser(nameTextBox.Text, phoneTextBox.Text, Convert.ToInt16(ageTextBox.Text), gender, status);
            }
            else
                MessageBox.Show("Please enter data in all fields!");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetControls(panel2);
        }
    }
}
