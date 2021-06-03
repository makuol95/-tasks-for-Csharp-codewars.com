using System;
using System.Linq;
using System.Collections.Generic;

namespace tetsprogramwar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new int [0]
                /*new []{1, 2, 3,4,5},
                new []{6,7, 8,9,10},
                new []{11, 12, 13,14,15},                
                new []{16,17, 18,19,20},
                new []{21, 22, 23,24,25}*/
            };
            foreach (int [] a in array)
            {
                foreach (int b in a)
                    Console.Write("{0,4}",b);
                Console.WriteLine();
            }
            var result = SnailSolution.Snail(array);
            foreach(int a in result)
            {
                Console.Write($"{a} ");
            }
            
        }
    }
}
