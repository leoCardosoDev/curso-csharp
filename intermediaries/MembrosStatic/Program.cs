using System;

namespace MembrosStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferencia: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"PI: {Calculadora.Pi:F2}");
        }
    }
}
