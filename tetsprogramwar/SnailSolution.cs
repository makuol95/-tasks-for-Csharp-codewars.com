using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetsprogramwar
{
    class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            if(array.Length==0||array.Any(r=>r.Length==0))
            {
               return new int [0];
                
            }
            
            int[] resuktarray = new int[array.Length * array.Length];
            int a = 0, b = 1, j = 0,i=0 ;
            int flag = 0;
            int c = (array.Length / 2);
            for(int k=0; k<resuktarray.Length&&c>a;k++)
            {
                switch(flag)
                {
                    case 0:
                        {
                            
                            if (a<=j&&j< array.Length-a-b)
                            {
                                resuktarray[k] = array[i][j];
                                j++;
                            }
                            else
                            {
                                k--;
                                flag = 1;
                            }    
                            break;
                        }
                    case 1:
                        {
                            if (i >=a  && i < array.Length - a -b)
                            {
                                resuktarray[k] = array[i][j];
                                i++;
                            }
                            else
                            {
                                k--;
                                flag = 2;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (a+b <= j && j < array.Length - a )
                            {
                                resuktarray[k] = array[i][j];
                                j--;
                            }
                            else
                            {
                                k--;
                                flag = 3;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (i >= a+b && i < array.Length - a )
                            {
                                resuktarray[k] = array[i][j];
                                i--;
                            }
                            else
                            {
                                k--;
                                flag = 0;
                                a++;
                                j = a;
                                i = a;                                
                            }
                            break;
                        }
                }               
            }
            if (array.Length % 2!=0)
                resuktarray[resuktarray.Length-1] = array[c][c];
            return resuktarray;
        }
    }
}
