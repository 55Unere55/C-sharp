using System;

namespace Class_Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            
                Method1 math1 = new Method1();
                {
                    Console.WriteLine("Please enter any number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    math1.MathOps(num1);
                    {                                                
                    Console.WriteLine("Please enter a decimal: ");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());
                    math1.MathOps(decimal num2);
                        {                                                              
                            Console.WriteLine("Please enter a number like this: twentyone ");
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            math1.MathOps(num3);

                        }
                            }
}
                     }
                }
            }

        
    
