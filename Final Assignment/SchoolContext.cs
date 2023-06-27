using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using static Final_Assignment.Student;

namespace Final_Assignment
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base("SchoolDB")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Student>()
                        .HasRequired(s => s.Address)
                        .WithRequiredPrincipal(ad => ad.Student);

            //Set StudentName as concurrency column
            modelBuilder.Entity<Student>()
                    .Property(p => p.StudentName)
                    .IsConcurrencyToken();

            //Set StudentName column size to 50
            modelBuilder.Entity<Student>()
                    .Property(p => p.StudentName)
                    .HasMaxLength(50);

            //Set StudentName column size to 50 and change datatype to nchar 
            //IsFixedLength() change datatype from nvarchar to nchar
            modelBuilder.Entity<Student>()
                    .Property(p => p.StudentName)
                    .HasMaxLength(50).IsFixedLength();

            //Set size decimal(2,2)
            modelBuilder.Entity<Student>()
                .Property(p => p.Height)
                .HasPrecision(2, 2);

            //Configure Null Column
            modelBuilder.Entity<Student>()
                    .Property(p => p.Heigth)
                    .IsOptional();

            //Configure NotNull Column
            modelBuilder.Entity<Student>()
                .Property(p => p.Weight)
                .IsRequired();

            //Configure primary key
            modelBuilder.Entity<Student>().HasKey<int>(s => s.StudentKey);
            modelBuilder.Entity<Standard>().HasKey<int>(s => s.StandardKey);
            modelBuilder.Entity<Student>().Map(delegate (EntityMappingConfiguration<Student> studentConfig)
            {
                studentConfig.Properties(p => new { p.StudentId, p.StudentName });
                studentConfig.ToTable("StudentInfo");
            });

            Action<EntityMappingConfiguration<Student>> studentMapping = m =>
            {
                m.Properties(p => new { p.StudentId, p.Height, p.Weight, p.Photo, p.DateOfBirth });
                m.ToTable("StudentInfoDetail");
            };

            modelBuilder.Entity<Student>().Map(studentMapping);
            modelBuilder.Entity<Standard>().ToTable("StandardInfo");
        }
    }
}
    


