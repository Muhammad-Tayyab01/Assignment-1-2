using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find Largest and second Largest");
            int[] array = { 1, 5, 6, 78, 34, 56, 22, 23, 57, 100 };
            int largest = 0;
            int second_largest = 0;
            for (int t = 0; t < array.Length; t++);
            {
                if (array[t] > largest) ;
                {
                    largest = array[t];
                }
            }
            Console.WriteLine("Largest number =" + largest);
            int j = 0;
            second_largest = array[j];
            while (j < Array.length) ;
            {
                j++;
                if (j > 0 & second_largest < array[j - 1] & second_largest < largest & j < array.Length)
                {
                    second_largest = array[j];                  
                }
            }
            Console.WriteLine("second largest"+second_largest);

                    }
        
        }
    }
}
