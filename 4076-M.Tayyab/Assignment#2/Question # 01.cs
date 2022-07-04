using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Define Length: ");
            int length = int.Parse(Console.ReadLine());
            List<int> tempList=new List<int>();
            int sum=0;
            float avg = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter Element Number " + (i + 1)+ ": ");
                int a = int.Parse(Console.ReadLine());
                tempList.Add(a);
            }
            int[] array=new int[length];
            array = tempList.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum is : " + sum);
            avg = (float)sum/ array.Length;
            Console.WriteLine("Avg is : " + avg);

        }
    }
}
