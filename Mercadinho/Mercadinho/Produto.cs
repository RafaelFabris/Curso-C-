using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Mercadinho
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set;  }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco, int quant) : this(nome, preco)
        {

            Quantidade = quant;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}