using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Methods1
{
    class Method2
    {
        static void Main(string[] args)
        {
            void MathOps(decimal dif)
            {
                Console.WriteLine("Please enter any number: ");
                decimal dec = Convert.ToInt32(Console.ReadLine());
                int num = 2;
                decimal difference = dec - num;
                Console.WriteLine("Your number - two is " + difference);
                Console.ReadLine();
            }
        }
    }
}


