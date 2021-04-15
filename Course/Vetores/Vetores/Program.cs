using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] a = new Aluno[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #"+i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quato: ");
                int numero = int.Parse(Console.ReadLine());

                a[numero] = new Aluno(nome, email, numero);
            }

            Console.WriteLine("Quartos Ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(a[i] != null)
                    Console.WriteLine(a[i]);
            }

            /*
            int n = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produto { Name = name, Price = price };
            }
            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                media += p[i].Price;
            }
            media /= n;

            Console.WriteLine("Media dos produtos" + media.ToString("F2" , CultureInfo.InvariantCulture));*/

                /*int n = int.Parse(Console.ReadLine());
                double media = 0.0;
                double[] vet = new double[n];
                for (int i = 0; i < n; i++)
                {
                    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    media += vet[i];
                }
                media /= n;
                Console.WriteLine("Média de altura: "+ media.ToString("F2"), CultureInfo.InvariantCulture);*/




        }
    }
}
