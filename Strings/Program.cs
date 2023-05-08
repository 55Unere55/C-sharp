using System;
using System.Collections.Generic;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 7, 100, 27, 10, 190, 20, 11, 2998, 103, 75000 };
            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above List by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0");
                    }
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + "=" + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            Console.WriteLine("The Program has exited the try/catch block");
        }
    }
}
