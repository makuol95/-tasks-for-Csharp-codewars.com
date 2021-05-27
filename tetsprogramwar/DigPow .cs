using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetsprogramwar
{
    class DigPow
    {
        public static long digPow(int n, int p)
        {
            long summ = 0;
            int i = 0;
            int a = n;
            while (a > 0)
            {
                i++;
                a /= 10;
            }
            i--;
            a = n;
            while (n > 0)
            {
                int element = n / (int)Math.Pow(10, i);
                summ = summ + (int)Math.Pow(element, p);
                p++;
                n = n % (int)Math.Pow(10, i);
                i--;
            }
            if (summ % a == 0)
                return summ / a;
            else
                return -1;
        }
    }
}
