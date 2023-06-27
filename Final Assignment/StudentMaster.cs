using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Assignment
{
    [Table("StudentMaster", Schema = "Admin")]
    class StudentMaster
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        [Index]
        public int RegistrationNumber { get; set; }

        public int StandardRefId { get; set; }
        public Standard Standard { get; set; }


    }
    public class Standard
    {

        public int StandardId { get; set; }
        public string StandardName { get; set; }
         [ForeignKey("Standard")]
        public ICollection<Student> Students { get; set; }
    }
}
