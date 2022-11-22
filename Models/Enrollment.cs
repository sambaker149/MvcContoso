namespace MvcContoso.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int ModuleID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        // Navigation Properties
        public Module Module { get; set; }
        public Student Student { get; set; }
    }
}