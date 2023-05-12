using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Methods1
{
    class Method1
    {

        
            void MathOps(int prct)
            {
                Console.WriteLine("Please enter any number: ");
                int pro = Convert.ToInt32(Console.ReadLine());
                int pro2 = 2;
                int product = pro * pro2;
                Console.WriteLine("Your number multiplied by two is " + product);
                Console.ReadLine();
            }

        }
    }


