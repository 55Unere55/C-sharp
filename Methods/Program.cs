using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fun Counting Room.");
            Console.WriteLine("Please enter numbers for : number2, number4 and number6:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());

            Meth myobject = new Meth();                       
            int total = 34 + num2;
            Console.WriteLine(total);
            Console.ReadLine();

            Meth myobject1 = new Meth();             
            int product = 13 * num4;
            Console.WriteLine(product);
            Console.ReadLine();


            Meth myObject2 = new Meth();
            int difference = 50 - num6;
            Console.WriteLine(difference);
            Console.ReadLine();
    }
    }
}
