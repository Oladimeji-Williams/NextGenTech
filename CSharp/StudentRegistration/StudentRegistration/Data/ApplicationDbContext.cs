using StudentRegistration.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace StudentRegistration.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {

        }
        public DbSet<Student> Students {get; set;}
        public override int SaveChanges()
        {
            UpdateTimeStamps();
            return base.SaveChanges();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default){
            UpdateTimeStamps();
            return await base.SaveChangesAsync(cancellationToken);
        }
        public void UpdateTimeStamps(){
            var entries = ChangeTracker.Entries<Student>();
            foreach (var entry in entries){
                if(entry.State == EntityState.Added){
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    entry.Entity.ModifiedAt = DateTime.UtcNow;
                } else if(entry.State == EntityState.Modified){
                    entry.Entity.ModifiedAt = DateTime.UtcNow;
                }
            }
        }
    }
}