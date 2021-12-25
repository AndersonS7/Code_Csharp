using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seções anteriores
            #region Exercicio 01 Cap. Introdução a POO
            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}
            #endregion
            #region Exercicio 02 Cap. Introdução a POO
            //Pessoa2 p1 = new Pessoa2();
            //Pessoa2 p2 = new Pessoa2();

            //Console.WriteLine("Dados do primeiro funcionário: ");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //p1.Salario = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Dados do segundo funcionário: ");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //p2.Salario = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //double media = (p1.Salario + p2.Salario) / 2;

            //Console.Write("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            // Seção 05 Construtores, This, Sobrecarga, Encapsulamento
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito:");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque:");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
