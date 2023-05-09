using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //mainMethod(), create 10 Employees, 2 Employes name joe
            List<Employee> campus = new List<Employee>()
            {
                 new Employee() {Id = 1, firstName = "Joe", lastName = "Shaman"},
                 new Employee() {Id = 2, firstName = "Joe", lastName = "Kinning" },
                 new Employee() {Id = 3, firstName = "Mary", lastName = "Finnar" },
                 new Employee() {Id = 4, firstName = "Kevin", lastName = "Grimm" },
                 new Employee() {Id = 5, firstName = "Jimmy", lastName = "White" },
                 new Employee() {Id = 6, firstName = "Hamish", lastName = "Donoughon" },
                 new Employee() {Id = 7, firstName = "Hubert", lastName = "McDonald" },
                 new Employee() {Id = 8, firstName = "Harold", lastName = "Lambiardi" },
                 new Employee() {Id = 9, firstName = "George", lastName = "Oldinth" },
                 new Employee() {Id = 10, firstName = "Merida", lastName = "Dunbrough" }
            };         
            //foreach loop new list for all Employees named joe
            List<Employee> Joes = new List<Employee>();
            foreach(Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //same again but with lambda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //with lambda create a list of all employees from 5+
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
