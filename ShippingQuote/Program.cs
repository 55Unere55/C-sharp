using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the Package weight.");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50) {
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
            }
            else {
                Console.WriteLine("Please enter the package width.");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height.");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length.");
                int packLength = Convert.ToInt32(Console.ReadLine());

                if (packWeight + packHeight + packLength > 50) {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else {
                    decimal product = Convert.ToDecimal((packWidth * packHeight * packLength) / 100);
                    Console.WriteLine(("Your estimated total for shipping this package is: " + product + "£"));
                    Console.ReadLine();

                }
            }
        }
    }
}
