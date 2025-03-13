using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_lab1
{
    internal class Solution
    {
        

        public void do_stuff_file(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"Файл {filename} не існує.");
                return;
            }

            Console.WriteLine($"Отримано файл: {filename}");
            string content = File.ReadAllText(filename);
            string[] parts = content.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3 && parts.All(p => int.TryParse(p, out _)))
            {
                int[] numbers = parts.Select(int.Parse).ToArray();
                solve(numbers[0], numbers[1], numbers[2]);
            }
            else
            {
                Console.WriteLine("У файлі не було чисел для квадратного рівняння.");
            }

        }

        private void solve(int a, int b, int c)
        {
            Console.WriteLine($"Рівняння має вигляд {a}X^2+({b})X+({c})=0");
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Рівняння не має коренів");
                return;
            }
            if (d == 0)
            {
                double answr = -b / (2 * a);
                Console.WriteLine($"Коренем рівння є {answr}");
                return;
            }

            double answr1, answr2;
            answr1 = (-b + Math.Sqrt(d)) / (2 * a);
            answr2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine($"Корені рівняння ");
        }
    }

}
