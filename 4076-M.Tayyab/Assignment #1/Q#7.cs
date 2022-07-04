using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 15, 20, 25, 30, 35, 40 };
            int i=1;
            while (i <= A.Length)
            {
                Console.WriteLine(A[i]);
                i = i + 2;
            }
        }
    }
}
