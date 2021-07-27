using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("How Many values?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First "+ printService.First());

            PrintService<string> printService2 = new PrintService<string>();

            Console.WriteLine("How Many values?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService2.AddValue(x);
            }

            printService2.Print();
            Console.WriteLine("First " + printService2.First());
        }
    }
}
