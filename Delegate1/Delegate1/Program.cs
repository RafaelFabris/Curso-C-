using System;
using Delegate1.Services;

namespace Delegate1
{
    delegate double BynaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);

            Console.WriteLine(result);
        }
    }
}
