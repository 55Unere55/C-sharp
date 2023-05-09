using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //shows current Date and Time
            Console.WriteLine("The current Time is: " + DateTime.Now);
            //Ask user for number
            Console.WriteLine("\nEnter any Number to see whicht time will be by then: ");
            float answer = float.Parse(Console.ReadLine());
            //shows time AFTER user input
            Console.WriteLine("{0} + { 1} hour(s) = { 2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
        }
    }
}
