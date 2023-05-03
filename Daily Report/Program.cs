using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tech Academy");
            Console.WriteLine("Student-Daily Report");
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Which Course are you  on?");
            string course = Console.ReadLine();
            Console.WriteLine("Which Module?");
            string module = Console.ReadLine();
            Console.WriteLine("Need help with something? Type \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Do you have positive Thoughts to share?");
            string positiveThoughts = Console.ReadLine();
            Console.WriteLine("Do you have any Feedback for us? Please be exact.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Hours studied today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your time. An Instructor will be in touch eith you shortly. Have a nice day.");
            Console.ReadLine();


        }
    }
}
