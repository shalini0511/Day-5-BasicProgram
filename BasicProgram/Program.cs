﻿using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables
            int a, b, c;
            Console.WriteLine("largest among three numbers:");
            //reading inputs
            Console.WriteLine("Enter value for a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToInt32(Console.ReadLine());
            //finding largest among three numbers
            if((a>b)&&(a>c))
            {
                Console.WriteLine("{0} is largest value", a);
            }
            else if((b>a)&&(b>c))
            {
                Console.WriteLine("{0} is largest value", b);
            }
            else
            {
                Console.WriteLine("{0} is largest value", c);

            }
            Console.ReadLine();
        }




          



        
    }
}
