using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа записала текущее время в файл проекта «startup.txt».");                 
            string programName = "startup.txt";
            string userTime = Convert.ToString(DateTime.Now);
            File.WriteAllText(programName, userTime);
        }
    }
}
