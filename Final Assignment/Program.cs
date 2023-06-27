using System;
using static Final_Assignment.Student;

namespace Final_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
            };
            ctx.Students.Add(std);
            ctx.SaveChanges();

            std.StudentName = "Steve";
            context.SaveChanges();
        }

            Console.WriteLine("Student saved succesfully!");
            }
             using (var context = new SchoolContext())
{
    // you must provide the unique CourseId value
    var maths = new Course() { CourseId = 1, CourseName = "Maths" };
    context.Courses.Add(maths);

    // you must provide the unique CourseId value
    var eng = new Course() { CourseId = 2, CourseName = "English" };
    context.Courses.Add(eng);

    // the following will throw an exception as CourseId has duplicate value
    //var sci = new Course(){ CourseId=2,  CourseName="sci"};

    context.SaveChanges();
}
            }
        }
    }

    




    
