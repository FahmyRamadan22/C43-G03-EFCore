using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assignment.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-QK0IFST\\MSSQLSERVERR; Database=ITIDb; Trusted_Connection=true; TrustServerCertificate = True")
                          .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }

    }
}
