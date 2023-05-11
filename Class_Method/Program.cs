using System;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
             void MathOp(int dividend)
            {
                Console.WriteLine("Please enter any number: ");
                int div = Convert.ToInt32(Console.ReadLine());                                      
                int quotient = div / 2;
                Console.WriteLine("Your number divided by two is " + quotient);
            }

        }
    }
}
