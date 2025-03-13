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
        static void Main(string[] args)
        {
            Solution s=new Solution();
            if (args.Length > 0)
            {
                string filePath = args[0];

                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Отримано файл: {filePath}");
                    string content = File.ReadAllText(filePath);
                    string[] parts = content.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 3 && parts.All(p => int.TryParse(p, out _)))
                    {
                        Console.WriteLine("Файл містить рівно три числа.");
                        int[] numbers = parts.Select(int.Parse).ToArray();
                        Console.WriteLine($" {numbers[0]}X^2, +({numbers[1]})*X+,( {numbers[2]})=0");
                    }
                    else
                    {
                        Console.WriteLine("File had wrong stuf.");
                    }
                }
            }
            else
            {
                while (s.do_stuff_normal())
                {
                    Console.WriteLine("Бажаєте продовжити?");
                    Console.WriteLine("1 - так");
                    Console.WriteLine("2 - ні");
                    string str = Console.ReadLine();
                    if (str == "2")
                    {
                        break;
                    }
                }
            }
        }
        

        
    }
}
