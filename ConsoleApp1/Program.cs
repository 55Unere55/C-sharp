using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleAppAssignment!");

            //this is a do while Loop
            int count = 100;
            do
            {
                Console.WriteLine("Inside the Loop");
                count++; //add one more each time
            }
            while (count < 120); //continue from 100 - 120

            //This is a while Loop
            int counting = 20;
            while (counting < 28) //continue until Loop reaches 28
            {
                Console.WriteLine("Counting Numbers");
                counting++; //add one to counting each time

            }
            Console.ReadLine();


        }
    }
}
