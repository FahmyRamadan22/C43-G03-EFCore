using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // Entity Framework Core Support 4 ways of mapping
    // 1. By Convension
    // 2. By Data Annotation
    // 3. By Fluent APIs
    // 4. By Configuration Classes

    public class Student
    {
        public int Id { get; set; } // Identity Constraint (1, 1)
        public string FirstName { get; set; } // NVARCHAR(MAX)
        public string LastName { get; set; } // NVARCHAR(MAX)
        public string Address { get; set; } // NVARCHAR(MAX)
        public int Age { get; set; } // int
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
        public virtual ICollection<Student_Course> StudentCourses { get; set; } = new HashSet<Student_Course>();

    }
}
