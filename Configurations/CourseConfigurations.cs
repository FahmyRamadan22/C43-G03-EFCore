using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(C => C.Topic)
                   .WithMany(T => T.Courses)
                   .HasForeignKey(C => C.TopicId);

            builder.HasMany(C => C.StudentCourses)
                   .WithOne(SC => SC.Course)
                   .HasForeignKey(SC => SC.CourseId);

            builder.HasMany(C => C.InstructorCourses)
                   .WithOne(IC => IC.Course)
                   .HasForeignKey(IC => IC.CourseId);
        }
    }
}
