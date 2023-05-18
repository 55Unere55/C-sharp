using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>
    {

        // define a variable of type T 
        public T data;

        // define a constructor of Employee class 
        public Employee(T data)
        {
            this.data = data;
            Console.WriteLine("Passed on: " + this.data);
        }
    }
}

        