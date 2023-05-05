using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number.");
            int anyNumber1 = Convert.ToInt32(Console.ReadLine());
            int product = anyNumber1 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Enter a new Number");
            int newNumber = Convert.ToInt32(Console.ReadLine()); ;
            int total = newNumber + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            Console.WriteLine("Enter a Decimal Number");
            double number = Convert.ToDouble(Console.ReadLine());
            double number2 = 12.5;
            double quotient = number / number2;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Give me a number between 0 and 150.");
            int smallNumber = Convert.ToInt32(Console.ReadLine());
            bool isBigger = (smallNumber > 50);
            Console.WriteLine(isBigger);
            Console.ReadLine();

            Console.WriteLine("Give me any Number at all.");
            int anyNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = anyNumber % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
