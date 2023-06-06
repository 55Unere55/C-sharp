using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assignment
{
    class Course
    {
        public class Courses
        {
            public void Course()
            {
                this.Students = new HashSet<Student>();
            }

            public int CourseId { get; set; }
            public string CourseName { get; set; }

           
        }
    }
}
