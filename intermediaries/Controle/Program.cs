using System;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com o nome do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o preço do produto: ");
            Console.Write("Preço: R$ ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade no Estoque: ");
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto} ");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine($"\nDados Atualizados: {produto}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos: ");
            int rem = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(rem);
            Console.WriteLine($"\nDados Atualizados: {produto}");
        }
    }
}
