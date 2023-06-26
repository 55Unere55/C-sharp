using System;
using System.Collections.Generic;
using System.Text;
using static Final_Assignment.Students;

namespace Final_Assignment
{
  
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}

