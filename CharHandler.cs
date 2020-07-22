using System;
using System.Collections.Generic;
using System.Text;

namespace MsgCountPlusNET
{
    class ArrayHandler
    {

    }
    class CharHandler
    {
        public string remFirstChar(string s)
        {
            char[] array = s.ToCharArray();
            string output = "";
            for (int i = 1; i < array.Length; i++)
            {
                output = output + array[i].ToString();
            }
            return output;
        }
        public string remLastChar(string s)
        {
            char[] array = s.ToCharArray();
            string output = "";
            for (int i = 0; i < array.Length - 1; i++)
            {
                output = output + array[i].ToString();
            }
            return output;
        }
        public string remFirstLast(string s)
        {
            return remLastChar(remFirstChar(s));
        }
        public string remAllChar(string s, char c)
        {
            char[] array = s.ToCharArray();
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != c)
                {
                    output = output + array[i].ToString();
                }
            }
            return output;
        }
    }
}
