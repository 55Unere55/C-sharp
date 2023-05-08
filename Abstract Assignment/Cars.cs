using System;

namespace Abstract_Assignment 
{
    public class Car : Vehicles
    {
    public int Id { get; set; }
    public override void SayVehicle()
    {
            Console.WriteLine("Vehicle: " + make + " " + model);
    }
    }
}

