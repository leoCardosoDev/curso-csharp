using System;

namespace DesafioEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre acom as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triagulo Y: ");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double pX = (xA + xB + xC) / 2.0;
            double pY = (yA + yB + yC) / 2.0;

            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            if (areaX > areaY) {
                Console.WriteLine($"Área X é maior que área Y {areaX:F4}");
            } else {
                Console.WriteLine($"Área Y é maior que área X {areaY:F4}");
            }

        }
    }
}
