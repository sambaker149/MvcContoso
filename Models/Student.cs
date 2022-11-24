using System;
using System.Collections.Generic;

namespace MvcContoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string LastName { get; set; } = String.Empty;

        public string FirstMidName { get; set; } = String.Empty;

        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}