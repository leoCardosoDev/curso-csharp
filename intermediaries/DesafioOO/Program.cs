using System;

namespace DesafioOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoa1.name = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {pessoa1.name}");
            pessoa1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.name = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {pessoa2.name}");
            pessoa2.age = int.Parse(Console.ReadLine());

            string moreOld = (pessoa1.age > pessoa2.age) ? pessoa1.name : pessoa2.name;
            Console.WriteLine($"Pessoa mais velha: {moreOld}");
        }
    }
}
