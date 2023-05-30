using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Welcome to the Fun Counting Room.");
            Console.WriteLine("Please enter 3 numbers :");
            int num2 = Convert.ToInt32(Console.ReadLine());     
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            Meth myobject = new Meth();                       
            myobject.AddTwoNumbers(num2); 
     
            Meth myobject1 = new Meth();
            myobject1.MultiplyTwoNumbers(num4);
           
            Meth myObject2 = new Meth();
            myObject2.SubstractTwoNumbers(num6);
           
    }
    }
}
