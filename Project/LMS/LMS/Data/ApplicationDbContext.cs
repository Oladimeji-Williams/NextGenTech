using Microsoft.EntityFrameworkCore;
using LMS.Models.Entities;

namespace LMS.Data{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {

        }
        public DbSet<User> Users {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<Lesson> Lessons {get; set;}
        public DbSet<Enrollment> Enrollments {get; set;}
        public DbSet<Progress> Progresses {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.User)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Lesson>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Lessons)
                .HasForeignKey(e => e.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Progress>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);  // Prevents cascading delete

            modelBuilder.Entity<Progress>()
                .HasOne(p => p.Course)
                .WithMany()
                .HasForeignKey(p => p.CourseID)
                .OnDelete(DeleteBehavior.Restrict);  // Prevents cascading delete

            modelBuilder.Entity<Progress>()
                .HasOne(p => p.Lesson)
                .WithMany()
                .HasForeignKey(p => p.LessonID)
                .OnDelete(DeleteBehavior.Cascade); // Allow only one cascade delete
        }
    }
}