using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetsprogramwar
{
    class Kata
    {
        public static string High(string s)
        {
            string result = null;
            int max = 0;
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                int prom_rez = 0;
                foreach (char a in words[i])
                {
                    prom_rez += a - 96;
                }
                if (max < prom_rez)
                {
                    result = words[i];
                    max = prom_rez;
                }
            }
            return result;
        }

        public static int[] SortArray(int[] array)
        {
            var chetnieWithNull = new string[array.Length];
            var neChetnie = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    chetnieWithNull[i] = array[i].ToString();
                }
                else
                {
                    neChetnie.Add(array[i]);
                }
            }

            neChetnie.Sort();

            var sortedArr = new int[chetnieWithNull.Length];

            for (var i = 0; i < chetnieWithNull.Length; i++)
            {
                if (chetnieWithNull[i] == null)
                {
                    sortedArr[i] = neChetnie.First();
                    neChetnie.Remove(neChetnie.First());
                }
                else
                {
                    sortedArr[i] = Int32.Parse(chetnieWithNull[i]);
                }
            }

            return sortedArr;
        }

        public static bool IsValidWalk(string[] walk)
        {
            var (x, y) = (0, 0);
            for (var i = 0; i < walk.Length; i++)
            {
                switch (walk[i])
                {
                    case "n":
                        x++;
                        break;
                    case "s":
                        x--;
                        break;
                    case "w":
                        y++;
                        break;
                    case "e":
                        y--;
                        break;

                }
            }

            if ((x, y) == (0, 0) && walk.Length == 10) return true;

            return false;
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            string namber = "(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            return namber;
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> spisok = new List<string>();
            string Open = "Open";
            string Senior = "Senior";
            foreach (int[] arrin in data)
            {
                string klient = (arrin[0] >= 55 && arrin[1] > 7) ? (Senior) : (Open);
                spisok.Add(klient);
            }
            return spisok;
        }

        public static int DuplicateCount(string str)
        {
            string workstr = str.ToLower();
            string musor = "";
            int i = 0;
            foreach (char ach in workstr)
            {
                bool kveleu = musor.Contains(ach);
                if (!kveleu)
                {
                    musor += ach;
                }
                int res = workstr.Count(x => x == ach);
                if (res > 1 && !kveleu)
                    i++;
            }

            return i;
        }

        public static int SquareDigits(int n)
        {
            int a = 0;
            int i = 0;
            while (n != 0)
            {

                int b = n % 10;
                if (b > 3)
                {
                    a = a + b * b * (int)Math.Pow(10, i++);
                }
                else
                    a = a + b * b * (int)Math.Pow(10, i);
                n /= 10;
                i++;
            }

            return a;
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int size_array = a.Length;
            int[] array = new int[size_array];
            int i = 0;
            if (b.Length == 0)
            {
                return a;
            }
            foreach (var item in a)
            {
                bool differend = false;
                foreach (var sarch_item in b)
                {
                    if (item == sarch_item)
                    {
                        differend = true;
                        size_array--;
                        break;
                    }
                }
                if (!differend)
                {
                    array[i] = item;
                    i++;
                }
            }
            int[] copy_array = new int[size_array];
            for (int j = 0; j < size_array; j++)
            {
                copy_array[j] = array[j];
            }

            return copy_array;
        }

        public static string GetMiddle(string s)
        {
            string st;
            if (s.Length % 2 == 0)
            {
                st = s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            }
            else
            {
                st = s[s.Length / 2].ToString();
            }
            return st;
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {

            int[] n = numbers;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = n.Length - 1; j > i; j--)
                {
                    if (n[j] <= n[i])
                    {
                        int b = n[i];
                        n[i] = n[j];
                        n[j] = b;
                    }
                }
            }
            return n[0] + n[1];
        }

        public static double Square(double a)
        {
            return a * a;
        }
    }
}
