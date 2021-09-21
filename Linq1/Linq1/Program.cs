using System;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the querry expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10 );

            // Executet the querry
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
