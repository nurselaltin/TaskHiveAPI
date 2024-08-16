using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Assigment> Tasks { get; set; }
        public DbSet<Reminder> Reminder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assigment>()
                .HasMany(v => v.Reminders)
                .WithOne(v => v.Assigment)
                .HasForeignKey(v => v.Id);
        }
    }
}
