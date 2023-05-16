using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Methods1
{
    class Method1
    {


        public void MathOps(int prct)
        {

            int pro2 = 2;
            int product = prct * pro2;
            Console.WriteLine("Your number multiplied by two is " + product);
            Console.ReadLine();
        }
        public void MathOps(decimal prct2)
        {

            Console.WriteLine("Please enter a decimal number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your number divided by two is " + num2);

        }
        public void MathOps(string prct3)
        {
            Console.WriteLine("Please enter any number like this: twentyone ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int difference = num3 - 5;
            Console.WriteLine("Your number taken away 5 is: " + difference);


        }
    }
};

   

       
    


