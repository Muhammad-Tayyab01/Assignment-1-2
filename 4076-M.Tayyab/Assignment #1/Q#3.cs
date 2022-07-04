using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            int sum = X + Y;
            Console.WriteLine("sum=" + sum);
        }
    }
}

        