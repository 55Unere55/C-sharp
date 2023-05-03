using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer Yes/No");
            string userAnswer = Console.ReadLine();
            bool dui = userAnswer == "Yes";
            Console.WriteLine("How many speeding Tickets do you have?");
            int userTickets = Convert.ToInt32(Console.ReadLine());

            bool userValid = (userAge > 15) && (!dui) && (userTickets < 3);
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(userValid);
            Console.Read();
        }
    }
}
