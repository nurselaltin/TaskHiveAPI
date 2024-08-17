using Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"D:\connectionstring.json";
            SettingFile connect = JsonConvert.DeserializeObject<SettingFile>(File.ReadAllText(connectionString));

            optionsBuilder.UseSqlServer(connect.DBConString);
        }
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
    public class SettingFile
    {
        public string DBConString { get; set; }
    }
}
