using System;

namespace DesafioConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double despositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, despositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine("Saldo atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para sacar: ");
            double saque = double.Parse(Console.ReadLine());

            conta.Saque(saque);
            Console.WriteLine(conta);
        }
    }
}
