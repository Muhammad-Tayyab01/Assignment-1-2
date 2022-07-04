using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array of 10 numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[10];
            // loop to take input in array A
            Console.WriteLine("Enter any " + number + " numbers to insert in the array ");
            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            temp = array[0];
            array[0] = array[number - 1];
            array[number - 1] = temp;
            Console.WriteLine("Array after swapping");
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
        }
    }
}
