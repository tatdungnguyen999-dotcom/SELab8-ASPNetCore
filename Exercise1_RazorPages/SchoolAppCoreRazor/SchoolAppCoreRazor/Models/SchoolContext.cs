
using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreRazor.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(
            DbContextOptions<SchoolContext> options
        ) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .Property(d => d.Budget)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Grade)
                .HasPrecision(5, 2);
        }
    }
}
