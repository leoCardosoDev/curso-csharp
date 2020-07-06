using System;

namespace Desafio2OO
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaSalario funcionario1, funcionario2;
            funcionario1 = new MediaSalario();
            funcionario2 = new MediaSalario();

            Console.WriteLine("Digite no nome do Primeiro Funcionário: ");
            funcionario1.name = Console.ReadLine();
            Console.WriteLine($"Digite o salário do {funcionario1.name}");
            funcionario1.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            funcionario2.name = Console.ReadLine();
            Console.WriteLine($"Digite o salário de {funcionario2.name}");
            funcionario2.salary = double.Parse(Console.ReadLine());

            double salaryMedia = (funcionario1.salary + funcionario2.salary) / 2;

            Console.WriteLine($"A mádia de salário da empresa é de: {salaryMedia:F2}");
        }
    }
}
