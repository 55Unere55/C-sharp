using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
             void MathOp(int dividend)
            {
                Console.WriteLine("Please enter a number: ");
                int MathOp = Convert.ToInt32(Console.ReadLine());
                int quotient = MathOp  / 2;
                Console.WriteLine("Your number divided by two is " + quotient);
            }

        }
    }

}
    