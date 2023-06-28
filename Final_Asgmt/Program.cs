using System;

namespace Final_Asgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine(stud.StudentName + " was added to the database.");
        }
    }
}
