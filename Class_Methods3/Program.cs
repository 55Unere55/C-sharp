using System;

namespace Class_Methods3
{
          class Program
    {
        static void Main(string[] args)
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


    
