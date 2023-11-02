using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForkWithStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCheckSymbosl_CheckedChanged(object sender, EventArgs e)
        {
            ProccForm();
        }       

        private void rbCompText_CheckedChanged(object sender, EventArgs e)
        {
            ProccForm();
        }

        private void ProccForm()
        {
            if (rbCompText.Checked)
            { 
                textBox2.Enabled = true;
                lbLanguage.Enabled = false;
                cBLanguage.Enabled = false;
            }
            else
            {
                textBox2.Enabled = false;
                lbLanguage.Enabled = true;
                cBLanguage.Enabled = true;
            }
        }

        private void btProcess_Click(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                textBox1.AppendText($"{(char)i}={i},\n");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
