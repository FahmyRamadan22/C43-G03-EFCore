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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Id);

            builder.Property(I => I.Id)
                   .UseIdentityColumn(202500, 1);

            builder.Property(I => I.Name)
                   .HasColumnType("varchar(50)");

            builder.Property(I => I.Salary)
                   .HasColumnType("decimal(18,2)");
            
            builder.Property(I => I.Bonus)
                   .HasColumnType("decimal(18,2)");
            
            builder.Property(I => I.HourRate)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(I => I.ManagedDepartment)
                   .WithOne(D => D.Manager)
                   .HasForeignKey<Department>(D => D.ManagerId);

            builder.HasOne(I => I.WorkingDepartment)
                   .WithMany(D => D.Instructors)
                   .HasForeignKey(I => I.WorkingDepartmentId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(I => I.InstructorCourses)
                   .WithOne(IC => IC.Instructor)
                   .HasForeignKey(IC => IC.InstructorId);

        }
    }
}
