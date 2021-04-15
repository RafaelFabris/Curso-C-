using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Calculator
    {

        public static void TriplexX(int origin , out int result)
        {
            result = origin * 3;

        }
        /*public static void TripleX(ref int x)
        {
            x = x * 3;

        }*/


        /*public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        */
    }
}
