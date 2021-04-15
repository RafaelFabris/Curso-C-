using System;
using System.Globalization;
namespace Mercadinho
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV" , 900, 10);

            p.setNome("T");
            Console.WriteLine(p.getNome());

            

            //Console.WriteLine("Entre os dados do produto");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque:");
            //int quant = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quant);

            //Console.WriteLine();
            //Console.WriteLine("Dados do Produto: " + p);

            //Console.WriteLine();
            //Console.Write("Numero de Produtos adicionados no estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite numero de produtos a ser removidos do estoque: " );
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
