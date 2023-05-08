using System;

namespace Abstract_Assignment
{
    class Program
    {
        static void Main(string[] args)

        {
            Car Ford = new Car() { make = "Ford", model = "Mondeo" };
            Ford.SayVehicle();
            Console.ReadLine();
        }
    }
}


        