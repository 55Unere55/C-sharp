using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Methods3
{
    public class Math3
    {
        static void MathOp(int addision)

        {
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number in if you want: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + (num2) + 9;
            Console.WriteLine("your number(s) + 9 is: " + total);
            Console.ReadLine();
        }
    }
}
    }
}
