using System;
using System.Collections.Generic;
using Generics2.Services;
using Generics2.Entities;
using System.Globalization;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i< n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1] , CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.WriteLine();
            Console.Write("Max: ");
            Console.WriteLine(max);
        }
    }
}
