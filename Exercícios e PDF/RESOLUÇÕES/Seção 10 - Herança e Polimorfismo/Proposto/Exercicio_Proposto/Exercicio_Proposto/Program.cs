using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Proposto.Entities;

namespace Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listProduct.Add(new ImportedProduct(name, price, customFee));

                }
                else if (resp == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listProduct.Add(new Product(name, price));

                }
                else if (resp == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    listProduct.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.WriteLine("ERRO! opção invalida");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:---------------------------------------------------------");
            foreach (Product product in listProduct)
            {
                Console.Write(product.PriceTag());
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
