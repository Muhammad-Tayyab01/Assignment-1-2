using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the number you want to check");
            int find = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int check = 0;
            while (counter < a.Length)
            {
                if (find == a[counter])
                {
                    Console.WriteLine("Element Found");
                    check++;
                }
                counter++;
            }

            if (check == 0)
            {
                Console.WriteLine("Element Not Found");
            }

        }
    }
}
