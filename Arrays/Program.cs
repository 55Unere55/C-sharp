using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[] array1 = new int[] { 1, 3, 5, 7, 9, };
            Console.WriteLine("Please give a number in: ");

            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value at the index you entered is: " + array1[index]);
            }



            catch
            {
                Console.WriteLine("You entered a wrong number, Please enter a number between 0 and 4.");

            }

                    string[] stringArray = new string[6];
                    string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                    Console.WriteLine("Please enter a number: ");
                    try
                    {
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The value at the index you entered is: " + weekDays[index1]);
                    }

                    catch
                    {
                        Console.WriteLine("You entered a wrong number, Please enter a number between 0 and 5.");
                      
                    }


                    }
                }
            }
    

