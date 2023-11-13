///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 02/11/2023
// Last Modified On :
// Description: Additional logic and methods
// Project: ForkWithStrings
///////////////////////////////////////

using WorkWithStrings.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace WorkWithStrings
{
    internal class BL
    {
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

        private static bool CheckRUUA(string s)
        {
            return Enum.IsDefined(typeof(Cirillic), s);
        }

        private static void ProcessCirillic(
            ref RichTextBox textBox,
            string str,
            Color defColor)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (CheckRUUA(str[i].ToString()))
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
        }

        private static string RemoveUnnecessarySpaces(string s)
        {
            const RegexOptions options = RegexOptions.None;

            var regex = new Regex("[ ]{2,}", options);

            return regex.Replace(s, " ").Trim();
        }

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

                    ProcessCirillic(ref textBox, str, defColor);

                    break;
                case MainLang.UA:

                    ProcessCirillic(ref textBox, str, defColor);

                    break;
            }
        }

        public static void CompareText(
            string strSource,
            string strComparable,
            ref RichTextBox textBox)
        {
            string general = RemoveUnnecessarySpaces(strSource);
            string compare = RemoveUnnecessarySpaces(strComparable);

            Color defColor = Color.Black;

            if (general.Length > compare.Length)
            {
                for (int i = 0; i < compare.Length; i++)
                {
                    if (strSource[i] == compare[i])
                    {
                        AppendText(ref textBox, strSource[i].ToString(), defColor);
                    }
                    else
                    {
                        AppendText(ref textBox, strSource[i].ToString(), Color.Red);
                    }
                }

                int  k = general.Length - (general.Length - compare.Length);

                for (int i = k; i < general.Length; i++)
                {
                    AppendText(ref textBox, strSource[i].ToString(), Color.Red);
                }

            }
            else if(general.Length < compare.Length)
            {
                for (int i = 0; i < general.Length; i++)
                {
                    if (strSource[i] == compare[i])
                    {
                        AppendText(ref textBox, strSource[i].ToString(), defColor);
                    }
                    else
                    {
                        AppendText(ref textBox, strSource[i].ToString(), Color.Red);
                    }
                }

                int k = compare.Length - (compare.Length - general.Length);

                for (int i = k; i < compare.Length; i++)
                {
                    AppendText(ref textBox, compare[i].ToString(), Color.Red);
                }
            }
            else
            {
                for (int i = 0; i < general.Length; i++)
                {
                    if (strSource[i] == compare[i])
                    {
                        AppendText(ref textBox, strSource[i].ToString(), defColor);
                    }
                    else
                    {
                        AppendText(ref textBox, strSource[i].ToString(), Color.Red);
                    }
                }
            }
        }
    }
}
