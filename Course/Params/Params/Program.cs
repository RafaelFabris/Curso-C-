using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.TriplexX(a , out triple);
            Console.WriteLine(triple);

            /*int a = 10;
            Calculator.TripleX(ref a);
            Console.WriteLine(a);*/


            //int result = Calculator.Sum(10, 20, 30, 40);

            //Console.WriteLine(result);
        }
    }
}
