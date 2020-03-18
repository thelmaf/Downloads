using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager9012402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "Personal contact selected";
            if (radioButton2.Checked)
                label1.Text = "Business contact selected";
        }

      
    }
}
