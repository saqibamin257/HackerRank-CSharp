using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TextInput
    {
        public string currentValue = "";
        public virtual void Add(char c)
        {
            currentValue += c;
        }
        public string GetValue() 
        {
            return currentValue;
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c) 
        {
            if (Char.IsNumber(c)) 
            {
                currentValue += c;
            }
        }
    }
}
