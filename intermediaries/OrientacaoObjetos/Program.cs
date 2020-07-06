using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            double p;
            double areax;
            double areay;

            Console.WriteLine("Digitos 3 valores da area X: ");
            x.LadoA = double.Parse(Console.ReadLine());
            x.LadoB = double.Parse(Console.ReadLine());
            x.LadoC = double.Parse(Console.ReadLine());
            p = (x.LadoA + x.LadoB + x.LadoC) / 2;
            areax = Math.Sqrt(p * (p - x.LadoA) * (p - x.LadoB) * (p - x.LadoC));

            Console.WriteLine("Digite os 3 valores da area Y: ");
            y.LadoA = double.Parse(Console.ReadLine());
            y.LadoB = double.Parse(Console.ReadLine());
            y.LadoC = double.Parse(Console.ReadLine());
            p = (y.LadoA + y.LadoB + y.LadoC) / 2;
            areay = Math.Sqrt(p * (p - y.LadoA) * (p - y.LadoB) * (p - y.LadoC));

            Console.WriteLine($"A area x: {areax:F4}");
            Console.WriteLine($"A area y: {areay:F4}");

            if (areax > areay)
            {
                Console.WriteLine($"A área x é maior que a area y");
            }
            else {
                Console.WriteLine($"A área x é maior que a area x");
            }

        }
    }
}
