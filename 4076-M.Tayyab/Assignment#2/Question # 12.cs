﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to replace ies with s");
            string str = "Who worries about curries";
            ChangeString(str);
        }
        static void ChangeString(string str)
        {
            char[]temp_string= new char[str.Length];
            for (int i=0;i<str.Length;i++){
                if(str[i]=='i'){
                    if(str[i+1]=='e' && str[i+2]=='s' && i+2<str.Length) 
                    {
                        temp_string[i]='s';
                        i+=2;
                    }


                } 
                else
                {
                    temp_string[i] = str[i];
                }
            }
            foreach (char ch in temp_string)
            {
                Console.Write(ch);
            }
        }

    }
}
