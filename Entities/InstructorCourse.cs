using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class InstructorCourse
    {
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int Evaluate { get; set; }
    }
}
