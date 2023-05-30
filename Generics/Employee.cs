using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>: IQuittable
    {
        bool isWorking { get; set; }

        // define a variable of type T 
        public T data;

        // define a constructor of Employee class 
        public Employee(T data) 
        {
            this.data = data;
            Console.WriteLine("Passed on: " + this.data);
        }

        
       public void Quit(Employee<string> employee)
        {
            if(!isworking == false)
            {
                IQuit.Employee<string>.Remove(employee);
                return;
            }
        }

    }
}

        