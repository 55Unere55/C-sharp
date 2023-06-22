﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assignment
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
