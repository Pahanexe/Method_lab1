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
                while (do_stuff())
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
        private bool do_stuff()
        {
            string str;

            Console.WriteLine("Введіть коефіцієнти квадратного рівняння:");

            Console.Write("a = ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out int a))
            {
                Console.WriteLine($"Ви ввели {str}, а треба було число. Спробуємо знов.");
                return true;
            }

            Console.WriteLine("b = ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out int b))
            {
                Console.WriteLine($"Ви ввели {str}, а треба було число. Спробуємо знов.");
                return true;
            }
            Console.Write("c = ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out int c))
            {
                Console.WriteLine($"Ви ввели {str}, а треба було число. Спробуємо знов.");
                return true;
            }

            return true;
        }

        private void solve(int a, int b,int c)
        {
            double d = b * b - 4 * a * c;
            if(d < 0)
            {
                Console.WriteLine("Рівняння не має коренів");
                return;
            }
            if (d == 0)
            {
                double answr = -b / (2 * a);
                Console.WriteLine($"Коренем рівння є {answr}");
            
            }


        }
    }
}
