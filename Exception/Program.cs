using System;
using System.Collections.Generic;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 14, 3, 23, 12, 44, 99, 74, 88, 37, 110 };
            bool numValid = false;
            while(!numValid)
                {
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above List by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter an other number then 0: ");
                    }
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please enter a number: ");
                }
            }
            Console.WriteLine("The program has exited the catch block. ");
        }
    }
}
