using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Separate Even & ODD NUMBERS");
            // ARRAY WITH BOTH EVEN AND ODD NUMBERS
            int[] test = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] req_array = new int[test.Length];
            int counter = 0;
            for (int t = 0; t < test.Length; t++) 
            {
                if (test[t] % 2 == 0)
                {
                    req_array[counter] = test[t];
                    counter++;
                }
            }

            for (int v = 0; v< test.Length; v++)
            {
                if (test[v] % 2 == 1)
                {
                    req_array[counter] = test[v];
                    counter++;
                }
            }

            foreach(int number in req_array)
            {
                Console.WriteLine(number);
            }
        }
    }
}

       
