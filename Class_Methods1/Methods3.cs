using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Methods1
{
    class Methods3
    {
        public void MathOps(string prct3)
        {
            Console.WriteLine("Please enter any number like this: twentyone ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int difference = num3 - 5;
            Console.WriteLine("Your number taken away 5 is: " + difference);


        }
    }
};
