using System;

namespace Final_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

             internal class Programs
        {
            private static void Main(string[] args)
            {
                using (var ctx = new SchoolContext())
                {
                    var student = new Student() { StudentName = "Bill" };

                    ctx.Students.Add(student);
                    ctx.SaveChanges();
                }
                Console.WriteLine("Demo completed.");
                Console.ReadLine();
            }
        }
    }
}
    




    
