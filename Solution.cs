using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_lab1
{
    internal class Solution
    {
        public bool do_stuff_normal()
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

            solve(a, b, c);
            return true;
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
