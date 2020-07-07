﻿using System;

namespace TrianguloMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Area de x = {areaX:F4}");
            Console.WriteLine($"Area de y = {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("Area X é maior");
            } else {
                Console.WriteLine("Area Y é maior");
            }
        }
    }
}
