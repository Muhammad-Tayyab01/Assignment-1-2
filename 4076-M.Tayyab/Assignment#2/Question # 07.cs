using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VOWELS IN A STRING");
            string test = "TaYYAb";
            int output = vowelcount(test);
            Console.WriteLine("nO. OF VOWELS IN STRING=" + output);
        }
        //fUNCTION FOR CHECKING VOWELS 
        static int vowelcount(string test)
        {
            int count = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == 'a' || test[i] == 'i' || test[i] == 'e' || test[i] == 'o' || test[i] == 'u' || test[i] == 'A' || test[i] == 'E' || test[i] == 'I' || test[i] == 'O' || test[i] == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
