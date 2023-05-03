using System;

namespace Math_and_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per Week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hours1) * 52;
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per Week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual Salary Person1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual Salaru Person2");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person1 makes more Money than Person2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();



        }
    }
}
