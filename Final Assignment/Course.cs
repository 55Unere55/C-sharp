using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assignment
{
    class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordNum { get; set; }

        modelBuilder.Entity<Course>()
    .Property(p => p.RecordNum)
    .ValueGeneratedOnAdd();

        public string Description { get; set; }

        [ForeignKey("OnlineTeacher")]
        public Teacher OnlineTeacher { get; set; }
        public Teacher ClassRoomTeacher { get; set; }
        
        [ForeignKey("ClassRoomTeacher")]
        public int? ClassRoomTeacherId { get; set; }
        public Teacher ClassRoomTeacher { get; set; }
    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        [InverseProperty("OnlineTeacher")]
        public ICollection<Course> OnlineCourses { get; set; }
        [InverseProperty("ClassRoomTeacher")]
        public ICollection<Course> ClassRoomCourses { get; set; }
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
