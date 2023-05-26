using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fun Counting Room.");

            Meth myobject = new Meth();            
            Console.WriteLine("Please enter your first Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = 34 + num2;
            Console.WriteLine(total);
            Console.ReadLine();

            Meth myobject1 = new Meth();           
        Console.WriteLine("Please enter a second Number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int product = 13 * num4;
            Console.WriteLine(product);
            Console.ReadLine();


            Meth myObject2 = new Meth();           
            Console.WriteLine("Please give one last Number in: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int difference = 50 - num6;
            Console.WriteLine(difference);
            Console.ReadLine();
    }}
}
