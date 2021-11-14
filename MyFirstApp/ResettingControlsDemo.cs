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
    public partial class ResettingControlsDemo : Form
    {
        public ResettingControlsDemo()
        {
            InitializeComponent();
        }

        private void ResetControls(Panel panel)
        {
            foreach(Control control in panel.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
                if(control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                if(control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                if(control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetControls(panel1);
        }
    }
}
