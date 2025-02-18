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
                .HasForeignKey(e => e.UserID);
            
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.CourseID);

            modelBuilder.Entity<Lesson>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Lessons)
                .HasForeignKey(e => e.CourseID);
            // base.OnModelCreating(modelBuilder);
        }
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<User>().HasData(
    //         new User { UserID = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" },
    //         new User { UserID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com" }
    //     );

    //     modelBuilder.Entity<Course>().HasData(
    //         new Course { CourseID = 1, Title = "React for Beginners", Description = "Learn React from scratch!" }
    //     );

    //     modelBuilder.Entity<Lesson>().HasData(
    //         new Lesson { LessonID = 1, Title = "Introduction to React", CourseID = 1 },
    //         new Lesson { LessonID = 2, Title = "React Components", CourseID = 1 }
    //     );
    // }

    }
}