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
    public partial class DateTimePickerDemo : Form
    {
        public DateTimePickerDemo()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            showHereLab.Text = dateTimePicker.Value.ToString();
        }
    }
}
