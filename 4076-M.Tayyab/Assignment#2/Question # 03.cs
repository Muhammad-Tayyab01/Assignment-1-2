using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program deletes the prime numbers in a given array");
            int[] array = { 7,9,11,14,17,23,37,27,47 };
            int numtoremove = 0;
            for (int t = 0; t < array.Length; t++)
            {

                if (CheckPrime(array[t]))
                {
                    numtoremove++;
                }
                else
                {
                    continue;
                }
            }

            //Console.WriteLine(numtoremove);
            int index = 0;

            int[] output_array = new int[array.Length - numtoremove];

            for(int j = 0; j < array.Length; j++)
            {
                if(CheckPrime(array[j]))
                {
                    continue;
                }
                else
                {
                    output_array[index] = array[j];
                    index++;
                }
            }

            foreach(int num in output_array)
            {
                Console.WriteLine(num);
            }
        }

        static bool CheckPrime(int num)
        {
            int a = num - 1;
            int i = 0;
            while (a > 1)
            {
                if (num % a == 0)
                {
                    i++;
                }
                a--;
            }
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
