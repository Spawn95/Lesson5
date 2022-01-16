using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255, для записи в бинарный файл.");                 
            string userNumbers = Console.ReadLine();          
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("UserNumbers.bin", FileMode.OpenOrCreate), userNumbers); 
        }
    }
}
