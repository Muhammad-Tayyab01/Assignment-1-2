using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM tO REPLACE THE CONTENT OF ARRAY WITH SUM");
            int[] arr = { 1, 11, 21, 31, 41 };
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i];
            } for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
