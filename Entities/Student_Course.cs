﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Student_Course
    {
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int Grade { get; set; }
    }
}
