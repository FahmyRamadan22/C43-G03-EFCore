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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);

            builder.Property(D => D.Id)
                   .UseIdentityColumn(100, 1);

            builder.Property(D => D.Name)
                   .HasColumnType("varchar(50)");

            builder.Property(D => D.HiringDate)
                   .HasDefaultValueSql("getdate()");

            builder.HasMany(D => D.Students)
                   .WithOne(S => S.Department)
                   .HasForeignKey(S => S.DepartmentId);

        }
    }
}
