using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class InstructorCourseConfigurations : IEntityTypeConfiguration<InstructorCourse>
    {
        public void Configure(EntityTypeBuilder<InstructorCourse> builder)
        {
            builder.HasKey(IC => new { IC.InstructorId, IC.CourseId });
        }
    }
}
