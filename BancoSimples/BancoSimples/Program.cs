using System;
using System.Globalization;

namespace BancoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;
            Console.Write("Entre o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicia (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre deposito inial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numeroConta, nome, saldoInicial);

            }
            else
                c = new ContaBancaria(numeroConta, nome);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);

        }
    }
}
