using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа дописывает текущее время в файл «startup.txt».");                 
            string programName = "startup.txt";
            string userTime = Convert.ToString(DateTime.Now);
            File.WriteAllText(programName, userTime);
        }
    }
}
