//using System;
//using System.IO;
//using System.Collections.Generic;

//namespace Csharp_Aulas
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\Z_MyTestes";

//            try
//            {
//                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FOLDERS");
//                foreach (string s in folders)
//                {
//                    Console.WriteLine(s);
//                }
//                Console.WriteLine();

//                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FILES");
//                foreach (string f in files)
//                {
//                    Console.WriteLine(f);
//                }

//                Directory.CreateDirectory(path + "\\new folder");
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error");
//                Console.WriteLine(e.Message);
//            }

//        }
//    }
//}
