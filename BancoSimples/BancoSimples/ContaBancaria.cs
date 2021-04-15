using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BancoSimples
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }



        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta , nome)
        {

            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}
