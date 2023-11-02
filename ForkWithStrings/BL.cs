///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 02/11/2023
// Last Modified On :
// Description: Additional logic and methods
// Project: ForkWithStrings
///////////////////////////////////////

using ForkWithStrings.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForkWithStrings
{
    internal class BL
    {
        public static void ProccesSymbols(
            string str,
            MainLang lang,
            ref RichTextBox textBox)
        {
           Color defColor = Color.Black;
           switch (lang)
           {
                case MainLang.EN:

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (char.IsLetter(str[i]))
                        {
                            if (CheckEN(str[i].ToString()))
                            {
                                AppendText(ref textBox, str[i].ToString(), defColor);   
                            }
                            else
                            {
                                AppendText(ref textBox, str[i].ToString(), Color.Red);
                            }
                        }
                        else
                        {
                            AppendText(ref textBox, str[i].ToString(), defColor);
                        }
                    }

                    break;
                case MainLang.RU:
                    break;
                case MainLang.UA:
                    break;
           }
        }

        private static void AppendText(
            ref RichTextBox box,
            string text,
            Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    

        private static bool CheckEN(string s)
            {
                return Enum.IsDefined(typeof(Latin), s);
            }
        }
}
