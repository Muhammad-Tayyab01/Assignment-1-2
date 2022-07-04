using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int z=1;
            Console.WriteLine("Enter Table No");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Table Length");
            int y = Convert.ToInt32(Console.ReadLine());
            while (z<=y)
            {
                Console.WriteLine(x +"*"+ z + "=" + x * z);
                z++;
            }

             

            }


        }
    }
