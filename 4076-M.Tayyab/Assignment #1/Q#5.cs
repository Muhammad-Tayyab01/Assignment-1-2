using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("a is largest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is largest");
            }
            else
            {
                Console.WriteLine("c is largest");
            }
        }
    }
}
