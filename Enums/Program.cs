using System;

namespace Enums
{
    class Program
    {
    public enum MonthsOfTheYear
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    static void Main(string[] args);
    {

            bool isValid = false;
            while(!isValid)
            {
                try
                {
                    Console.WriteLine("Enter the current Month of the Year");
                    string monthInput = Console.ReadLine();
                    MonthsOfTheYear month = (MonthsOfTheYear)Enum.Parse(typeof(MonthsOfTheYear), monthInput);
                    Console.WriteLine("Have a nice " + month);
                    Console.ReadLine();
                    isValid = true;
                }
                catch (ArgumentException execute) 
               {
                
                Console.WriteLine("Please enter an actual Month of the Year");
            }  
         }
      }
   }
 }


