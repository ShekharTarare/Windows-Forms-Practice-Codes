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
    public partial class RetrieveData : Form
    {
        public RetrieveData()
        {
            InitializeComponent();
        }

        private void fetchBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                Database_code db = new Database_code();
                string[] userData = db.GetUserById(Convert.ToInt32(idTextBox.Text));
                nameTextBox.Text = userData[0];
                phoneTextBox.Text = userData[1];
                ageTextBox.Text = userData[2];

                if (userData[3] == "Male")
                    maleRadioButton.Checked = true;
                else if (userData[3] == "Female")
                    femaleRadioButton.Checked = true;

                if (userData[4] == "Active")
                    statusComboBox.SelectedItem = "Active";
                else if (userData[4] == "Inactive")
                    statusComboBox.SelectedItem = "Inactive";
            }
            else
                MessageBox.Show("Please enter id first");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void RetrieveData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && nameTextBox.Text != "" && ageTextBox.Text != "" && phoneTextBox.Text != "" &&
                (maleRadioButton.Checked == true || femaleRadioButton.Checked == true) && statusComboBox.SelectedIndex != -1)
            {
                    Database_code db = new Database_code();
                    Int16 gender = maleRadioButton.Checked ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    Int16 status = statusComboBox.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    db.UpdateUser(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, phoneTextBox.Text, Convert.ToInt16(ageTextBox.Text), gender, status);
            }
            else
                MessageBox.Show("Please enter data in all fields!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to delete the data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Database_code db = new Database_code();
                    db.DeleteUser(Convert.ToInt32(idTextBox.Text));
                }
            }
            else
                MessageBox.Show("Please enter id first!");
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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetControls(panel2);
        }
    }
}
