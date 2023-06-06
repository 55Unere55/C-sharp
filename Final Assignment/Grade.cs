using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assignment
{
    class Grades
    {
        public Grade Grade { get; set; }
    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

    }
}

