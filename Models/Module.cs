using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcContoso.Models
{
    public class Module
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleID { get; set; }

        public string Title { get; set; } = String.Empty;

        public int Credits { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}