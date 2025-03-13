using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_lab1
{
    internal class Program
    {
        void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string filePath = args[0];

                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Отримано файл: {filePath}");
                    // Додаткові дії з файлом, наприклад, зчитування вмісту
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine("Вміст файлу:");
                    Console.WriteLine(content);
                }

                while (do_stuff()) {
            }

        }

        private bool do_stuff()
        {

            return true;
        }
    }
}
