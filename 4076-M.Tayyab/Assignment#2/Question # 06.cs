using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(" Program to calculate no. of Positive and Negative Integers and Average of Arrays");
            Console.Write("Enter the number of elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] user_array = new int[length];
            int positive = 0;
            int negative = 0;
            int sum = 0;
            float average = 0;

            for(int t = 0; t < length; t++)
            {
                Console.Write("Enter Element: ");
                user_array[t] = Convert.ToInt32(Console.ReadLine());
                sum += user_array[t];
            }
            for(int j = 0; j < length; j++)
            {
                if (user_array[j] >= 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            average = (float) sum / length;
            Console.WriteLine("No.of Positive Numbers: " + positive);
            Console.WriteLine("The Number of Negative Numbers: " + negative);
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine("Average= " + average);

        }
    }
}

        