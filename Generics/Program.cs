using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // create an instance with data type string 
                Employee<string> EmployeeName = new Employee<string> ( "Kevin Donoghe" );
            
            // create an instance with data type int
            Employee<int> EmployeeId = new Employee<int>(23);
            
        }
    }
    }

