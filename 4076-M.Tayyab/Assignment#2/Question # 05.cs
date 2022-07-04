using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the Repeated elements in given array");
            int[] array = { 1, 1, 2, 2, 3, 3, 6, 6, 8, 9, 9, 67, 67 };
            int value = 0;
            for (int t = 0; t < array.Length; t++)
            {
                value = array[t];
                for (int v = t + 1; v < array.Length; v++)
                {
                    if (value == array[v])
                    {
                        Console.WriteLine("Element: " + value + " Repeated at index " + v);
                    }
                }
            }
        }
    }
}
