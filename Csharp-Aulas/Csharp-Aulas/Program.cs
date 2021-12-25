using System;
using System.Collections.Generic;

namespace Csharp_Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Triângulo
            //Triangulo x, y;

            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do Triângulo X:");
            //x.A = double.Parse(Console.ReadLine());
            //x.B = double.Parse(Console.ReadLine());
            //x.C = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com as medidas do Triângulo Y:");
            //y.A = double.Parse(Console.ReadLine());
            //y.B = double.Parse(Console.ReadLine());
            //y.C = double.Parse(Console.ReadLine());

            //double areaX = x.Area();
            //double areaY = y.Area();

            //Console.WriteLine("Área de X: " + areaX.ToString("F2"));
            //Console.WriteLine("Área de Y: " + areaY.ToString("F2"));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Área de X é maior!");
            //}
            //else
            //{
            //    Console.WriteLine("Área de Y é maior!");
            //}
            #endregion
            #region Exemplo Produto
            //Console.WriteLine("Entre com os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto tv = new Produto(nome, preco, quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + tv);
            //Console.WriteLine();

            //Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
            //tv.AdicionarProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + tv);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            //tv.RemoverProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + tv);
            #endregion
            #region Seção 05
            //Produto p = new Produto("TV", 900, 10);

            //p.Nome = "T";

            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Preco);
            //Console.ReadLine();
            #endregion

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
        }
    }
}
