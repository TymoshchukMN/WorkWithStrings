using WorkWithStrings.Enums;
using System;
using System.Windows.Forms;

namespace WorkWithStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void BtProcess_Click(object sender, EventArgs e)
        {
            const string ExistSympols = "В тексте есть символы другой раскладки";
            const string NotExistSympols = "В тексте НЕТ символов другой раскладки";

            textBoxResult.Text = string.Empty;
           
            MainLang lang = (MainLang)Enum.Parse(typeof(MainLang),
                cBLanguage.Text.ToString());

            BL.ProccesSymbols(
                textBoxSource.Text,
                lang,
                ref textBoxResult,
                out bool isExistExternalSymbol);

            if (isExistExternalSymbol)
            {
                tbMessage.Text = ExistSympols;
            }
            else
            {
                tbMessage.Text = NotExistSympols;
            }
        }
    }
}
