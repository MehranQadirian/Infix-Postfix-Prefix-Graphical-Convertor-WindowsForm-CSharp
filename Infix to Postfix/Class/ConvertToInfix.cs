using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_to_Postfix.Class
{
    public class ConvertToInfix
    {
        private string _result;
        private string []_intermediary;
        private int _type,_interIndex;
        public ConvertToInfix(string txt , int type)
        {
            _result = "";
            _intermediary = new string[txt.Length];
            _type = type;
            _interIndex = 0;
            _ConvertToInfix(txt);
        }
        public string ReturnResult()
        {
            return _result;
        }
        private void _ConvertToInfix(string text)
        {
            //Postfix
            if(_type == 2)
            {
                foreach (var t in text)
                {
                    if (char.IsDigit(t) || char.IsLetter(t))
                    {
                        _intermediary[_interIndex++] = Convert.ToString(t);
                    }
                    else
                    {
                        _result = $"{_intermediary[_interIndex - 2]}{t}{_intermediary[_interIndex - 1]}";
                        _intermediary[--_interIndex] = null;
                        _intermediary[--_interIndex] = null;
                        _intermediary[_interIndex++] = _result;
                    }
                }
            }
            //Prefix
            if(_type == 3)
            {
                for (int i = text.Length-1; i >= 0; i--)
                {
                    if (char.IsDigit(text[i]) || char.IsLetter(text[i]))
                    {
                        _intermediary[_interIndex] = Convert.ToString(text[i]);
                        _interIndex++;
                    }
                    else
                    {
                        _result = $"{_intermediary[_interIndex - 1]}{text[i]}{_intermediary[_interIndex - 2]}";
                        _intermediary[_interIndex - 1] = null;
                        _intermediary[_interIndex] = null;
                        _interIndex = _interIndex - 2;
                        _intermediary[_interIndex] = _result;
                        _interIndex++;
                    }
                }
            }
        }
    }
}
