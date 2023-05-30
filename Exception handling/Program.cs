using System;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("How old are you ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime newDate = myDate.AddYears(-age);
            int newYear = newDate.Year;
            Console.WriteLine(newYear);
        }

        }
    }

