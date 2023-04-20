using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } //DbSet представляет собой коллекцию объектов, которая сопоставляется с определенной таблицей в базе данных. 
        public DbSet<Manufacture> Manufactures { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            //В конструкторе с помощью вызова Database.EnsureCreated()
            //по определению моделей будет создаваться база данных (если она отсутствует).
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //настраивается начальная конфигурация модели
        {
            var google = new Manufacture { Id = 1, Members = 3000, Name = "Google" };
            var apple = new Manufacture { Id = 2, Members = 3000, Name = "Apple" };
            var microsoft = new Manufacture { Id = 3, Members = 3000, Name = "Microsoft" };

            modelBuilder.Entity<Manufacture>().HasData(
                apple,
                google,
                microsoft
                );
            //modelBuilder.Entity<User>().HasData(
            //         new User { Id = 1, Name = "Yuri", LastName = "Mikhnovetc", Age = 29, Address = "Skripnikova 44", Manufacture = google },
            //         new User { Id = 2, Name = "Artem", LastName = "Zyglin", Age = 30, Address = "Lobanka 45", Manufacture = apple },
            //         new User { Id = 3, Name = "Leon", LastName = "Grishenko", Age = 31, Address = "Suharevo 65", Manufacture = microsoft }
            // );
        }
    }
}
