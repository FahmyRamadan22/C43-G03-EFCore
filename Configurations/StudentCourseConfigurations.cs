using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations
{
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.HasKey(SC => new { SC.CourseId, SC.StudentId });
        }
    }
}
