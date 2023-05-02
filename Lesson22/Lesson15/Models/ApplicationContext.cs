using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var google = new Manufacture { Id = 1, Members = 3000, Name = "Google" };
            var apple = new Manufacture { Id = 2, Members = 3000, Name = "Apple" };
            var microsoft = new Manufacture { Id = 3, Members = 3000, Name = "Microsoft" };

            modelBuilder.Entity<Manufacture>().HasData(
                apple,
                google,
                microsoft
                );
        }
    }
}
