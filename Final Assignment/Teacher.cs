using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assignment
{
    class Teachers
    {
    }
        public class Teacher
        {
            public int Id { get; set; }
            public string TeacherName { get; set; }
            public TeachingMode ModeOfTeaching { get; set; }
        }

        public enum TeachingMode
        {
            Online,
            ClassRoom,
            LiveOnline
        }
    }
}

