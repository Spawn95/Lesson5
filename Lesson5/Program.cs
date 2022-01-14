using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор данных для сохранения их файл");
            string userData = Console.ReadLine();
            Console.WriteLine("Введите название файла");
            string filename = Console.ReadLine();
            string filename_txt = filename + ".txt";
            File.WriteAllText(filename_txt, userData);
        }
    }
}
