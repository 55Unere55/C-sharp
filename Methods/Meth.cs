using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
   public class Meth
    {
        public int AddTwoNumbers()
        {
            Console.WriteLine("Please enter your first Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 34;
            int total = num1 + num2;
            return num1 + num2;
        }
        public int MultiplyTwoNumbers()
        {
            Console.WriteLine("Please enter a second Number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num3 = 13;
            int product = num3 * num4;
            return num3 * num4;

        }
        public int SubstractTwoNumbers()
        {
            Console.WriteLine("Please give one last Number in: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num5 = 50;
            int difference = num5 - num6;
            return num5 - num6;

        }
    }
}
