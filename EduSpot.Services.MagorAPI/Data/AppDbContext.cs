using EduSpot.Services.MagorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EduSpot.Services.MagorAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Major> Majors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Major>().HasData( new Major
            {
                MajorId = 1,
                Name = "Name",
                ArbicName = "Name",
                Description = "Description",
                CountHours = 1,
                ShortCut ="dsdssd"
            });
        }
    }
}
