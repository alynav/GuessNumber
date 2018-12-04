using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 100;
            int x = new Random().Next(a, b);
            //Console.WriteLine(x); 

            do
            {
                Console.WriteLine("Introduceti un numar intre {0} si {1}", a, b);
                string str = Console.ReadLine();
                int nr = int.Parse(str);
                //daca nr > 
                //daca nr <
                //daca nr =
                if (nr < x)
                {
                    Console.WriteLine("ati introdus un numar mai mic");
                }
                else if (nr > x)
                {
                    Console.WriteLine("ati introdus un numar mai mare");
                }
                else
                {
                    Console.WriteLine("ati ghicit numarul");
                    break;
                }
            } while (true);
        }
    }
}
