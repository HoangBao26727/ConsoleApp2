﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào a: ");
            float a = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a phải khác 0");
            }
            else
            {
                Console.WriteLine("Nhập vào b: ");
                float b = float.Parse(Console.ReadLine());

                float x = -b / a;
                Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
            }
            Console.ReadKey();
        }
    }
}
