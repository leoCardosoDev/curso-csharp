using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string vetor = Console.ReadLine();

            string[] vet = vetor.Split(' ');

            string vetor1 = vet[0];
            string vetor2 = vet[1];
            string vetor3 = vet[2];

            Console.WriteLine($"Você digitou {frase}");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(vetor1);
            Console.WriteLine(vetor2);
            Console.WriteLine(vetor3);

        }
    }
}
