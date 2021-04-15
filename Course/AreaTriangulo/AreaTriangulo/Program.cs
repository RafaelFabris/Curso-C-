using System;
using System.Globalization;
namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

            //double p = (x.A + x.B + x.C) / 2.0;
            //areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            //double xA, xB, xC, yA, yB, yC;
            //Console.WriteLine("Entre com as medidas do triangulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triangulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area X:" + areaX.ToString("F4" ,  CultureInfo.InvariantCulture));
            Console.WriteLine("Area Y:" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX >  areaY)
            {
               Console.WriteLine("Maior Area Triangulo X");
            }
            else
                Console.WriteLine("Maior area Triangulo Y");
        }
    }
}
