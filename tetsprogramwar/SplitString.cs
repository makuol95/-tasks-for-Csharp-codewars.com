using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetsprogramwar
{
    class SplitString
    {
        public static string[] Solution(string str)
        {
            int strlength = str.Length;
            str += strlength % 2 == 0 ? ("") : ("_");
            strlength = str.Length / 2;
            string[] strarrey = new string[strlength];
            for (int i = 0; i < strlength; i++)
            {
                strarrey[i] = str[i * 2].ToString() + str[i * 2 + 1].ToString();
            }
            return strarrey;
        }
    }
}
