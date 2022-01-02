//using System;
//using Csharp_Aulas.Entities.Seção_10___Herança_e__polimorfismo;
//using System.IO;

//namespace Csharp_Aulas
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string sourcePath = @"C:\Z_MyTestes\Texto_1.txt";
//            string sourceTarget = @"C:\Z_MyTestes\Texto_2.txt";

//            try
//            {
//                string[] lines = File.ReadAllLines(sourcePath); // lê todas as linhas do arquivo e salva no vetor

//                using (StreamWriter sw = File.AppendText(sourceTarget))
//                {
//                    foreach (var line in lines)
//                    {
//                        sw.WriteLine(line.ToUpper());
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error");
//                Console.WriteLine(e.Message);
//            }

//        }
//    }
//}
