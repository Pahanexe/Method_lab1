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
                s.do_stuff_file(args[0]);
                string filePath = args[0];

                
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
