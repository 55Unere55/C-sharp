﻿using System;

namespace Exception_handling
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("How old are you ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime newDate = myDate.AddYears(-age);
            int newYear = newDate.Year;
            Console.WriteLine(newYear);

            if (age == 0)
            {
                try
                {
                    Console.WriteLine("Please enter a number not NULL !");
                    Console.ReadLine();
                    return;
                }
                
                catch
                {
                    Console.WriteLine("Something went wrong, please try again to enter your Age: ");
                    return;
                }
                
                
            }
        }
    }
}


        
    

