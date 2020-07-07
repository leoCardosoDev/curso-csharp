using System;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto {produto}");

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionadas ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

        }
    }
}
