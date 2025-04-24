using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public virtual Topic Topic { get; set; }
        public int TopicId { get; set; }
        public virtual ICollection<Student_Course> StudentCourses { get; set; } = new HashSet<Student_Course>();
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();

    }
}
