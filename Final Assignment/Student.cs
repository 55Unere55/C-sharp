using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Assignment
{
    class Student
    {
        [Column(Order = 0)]
        public int StudentID { get; set; }

        [Column ("Name", Order = 1)]
        [Required]
        [ConcurrencyCheck]
        public string StudentName { get; set; }
        public virtual StudentAddress Address { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [Column ("DoB", Order = 5)]
        public DateTime? DateOfBirth { get; set; }
        [Column(Order = 3)]
        public byte[] Photo { get; set; }
        [Column(Order = 2)]
        public decimal Height { get; set; }
        [Column(Order = 4)]
        public float Weight { get; set; }
            public virtual Grade Grade { get; set; }
    }
    [Key]
    [Column(Order = 1)]
    public int StudentKey { get; set; }
    [Key]
    [Column(Order = 2)]
    public int AdmissionNum { get; set; }

    public string StudentName { get; set; }

private int _age = 0;

public int StudentId { get; set; }
public string StudentName { get; set; }
public string City { get { return StudentName; } }
public int Age { set { _age = value; } }

    public class StudentAddress
    {
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}





