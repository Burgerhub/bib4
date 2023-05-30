using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Varian_24
    {
        public static int Task1(int[] x)
        {
            int result = 1;
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (true)
                {
                    result *= i;
                    count++;
                }
            }
            return result;
        }

        public static int [] Task2 (int [] x1)
        {
            int[] result = new int[x1.Length];
            for (int i = 0; i < x1.Length; i++)
            {
               result[i] = 6 * x1[i] - 7;
            }

            return result;
        }

        public static double[] Task3 (double[] x , double []x1)
        {
            double sum = 0;
            double count = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    sum += x[i];
                    count++;
                }
            }
            for (int i = 0; i < x1.Length; i++)
            {
                if (x1[i] < 0)
                {
                    sum += x1[i];
                    count++;
                }
            }
            return sum;
        }
    } 
}
