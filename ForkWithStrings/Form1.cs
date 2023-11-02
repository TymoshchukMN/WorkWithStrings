using ForkWithStrings.Enums;
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

        private void RbCheckSymbosl_CheckedChanged(object sender, EventArgs e)
        {
            ProccForm();
        }       

        private void RbCompText_CheckedChanged(object sender, EventArgs e)
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

        private void BtProcess_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            if (rbCheckSymbosl.Checked)
            {
                MainLang lang = (MainLang)Enum.Parse(typeof(MainLang),
                    cBLanguage.Text.ToString());
                BL.ProccesSymbols(textBoxSource.Text, lang, ref textBoxResult);
            }
        }
    }
}
