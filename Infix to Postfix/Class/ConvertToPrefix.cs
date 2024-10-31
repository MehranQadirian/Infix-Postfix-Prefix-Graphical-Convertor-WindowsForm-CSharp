using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_to_Postfix.Class
{
    class ConvertToPrefix
    {
        private string Result, Elemental;
        private string[] Intermediary;
        private int Type, InterIndex;
        public ConvertToPrefix(string txt , int type)
        {
            Result = ""; Elemental = "";
            Intermediary = new string[txt.Length];
            Type = type;
            InterIndex = 0;
            _ConvertToPrefix(txt);
        }

        private void _ConvertToPrefix(string text)
        {
            //Infix
            if (Type == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != '(' || text[i] != ')')
                    {
                        if (char.IsDigit(text[i]) || char.IsLetter(text[i]))
                        {
                            Intermediary[InterIndex++] = Convert.ToString(text[i]);
                        }
                        else if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
                        {
                            Elemental += Convert.ToString(text[i]);
                        }
                    }
                }
                for (int i = Elemental.Length - 1; i >= 0; i--)
                    Result += Elemental[i];
                for (int i = 0; i < Intermediary.Length; i++)
                    Result += Intermediary[i];
            }
        }
        public string ReturnResult()
        {
            return Result;
        }
    }
}
