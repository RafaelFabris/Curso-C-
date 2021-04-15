using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double calculo = a * c / 2;
            Console.WriteLine("TRIANGULO: " + calculo.ToString("F3", CultureInfo.InvariantCulture));
            calculo = c * c * 3.14159;
            Console.WriteLine("CIRCULO: " + calculo.ToString("F3", CultureInfo.InvariantCulture));
            calculo = c * (a + b) / 2;
            Console.WriteLine("TRAPEZIO: " + calculo.ToString("F3", CultureInfo.InvariantCulture));
            calculo = b * b;
            Console.WriteLine("QUADRADO: " + calculo.ToString("F3", CultureInfo.InvariantCulture));
            calculo = a * b;
            Console.WriteLine("RETANGULO: " + calculo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
