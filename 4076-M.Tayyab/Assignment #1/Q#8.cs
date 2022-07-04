
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static bool isPrime(int x)
        {
            bool v = false;
            int y = x;
            while (y != 2)
            {
                y--;
                if (x % y == 0)
                {
                    v = true;
                }

            }
            return v;
        }
        static void Main(string[] args)
        {
            if (isPrime(56))
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
