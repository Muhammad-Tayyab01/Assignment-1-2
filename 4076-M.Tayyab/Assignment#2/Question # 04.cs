using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program deletes the duplicate element from array");
            int[] Arr = { 2, 2, 5, 8, 7,5, 9, 3 ,7,8};
            Array.Sort(Arr);
            int duplicate = 0;

            for (int i = 1; i < Arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arr[j] == Arr[i])
                    {
                        duplicate++;
                    }
                }
            }

            int[] unique_array = new int[Arr.Length - duplicate];
            int index = 0;


            for (int i = 0; i < Arr.Length; i++)
            {
                if (i == 0)
                {
                    unique_array[index] = Arr[i];
                    index++;
                }
                else if (i > 0 & Arr[i] == Arr[i - 1])
                {
                    continue;
                }
                else
                {
                    unique_array[index] = Arr[i];
                    index++;
                }

            }

            foreach (int num in unique_array)
            {
                Console.WriteLine(num);
            }

        }
    }
}
