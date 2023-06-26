using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using static Final_Assignment.Students;

namespace Final_Assignment
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base(mySchoolDb)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
    public class SchoolDBInitializer :  CreateDatabaseIfNotExists<SchoolDbContext>
{
    protected override void Seed(SchoolDbContext context)
    {
        base.Seed(context);
    }
}
}
