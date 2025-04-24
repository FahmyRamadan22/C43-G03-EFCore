using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(S => S.FirstName)
                  .HasColumnType("varchar(50)");
            
            builder.Property(S => S.LastName)
                  .HasColumnType("varchar(50)");

            builder.HasMany(S => S.StudentCourses)
                   .WithOne(SC => SC.Student)
                   .HasForeignKey(SC => SC.StudentId);


        }
    }
}
