using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to our Company, please specify how many Kilogram you need today: ");
                decimal num = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your Amount today is: " + num + " Kg ");
            Console.ReadLine();

        }
    }
}
