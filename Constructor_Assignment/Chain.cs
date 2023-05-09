using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Assignment
{
    public class Chain
    {

        public Chain(float num1) : this(num1, "Mary-Ann")
        {
            Console.WriteLine(num1 + " and your Name is: " + Name);
        }
        public Chain(string name1) : this(42, name1)
        { 
        Console.WriteLine(name1 + "you favourite number is: " + Num);
        }
        public Chain(float num, string name)
        { 
            Name = name;
            Num = num;
        }
        string Name { get; set; }
        float Num { get; set; }
}
}