using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } //DbSet ������������ ����� ��������� ��������, ������� �������������� � ������������ �������� � ���� ������. 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //� ������������ � ������� ������ Database.EnsureCreated() �� ����������� ������� ����� ����������� ���� ������ (���� ��� �����������).
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //������������� ��������� ������������ ������
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "Yuri", LastName = "Mikhnovetc", Age = 29, Address = "Skripnikova 44" },
                    new User { Id = 2, Name = "Artem", LastName = "Zyglin", Age = 30, Address = "Lobanka 45" },
                    new User { Id = 3, Name = "Leon", LastName = "Grishenko", Age = 31, Address = "Suharevo 65" }
            );
        }
    }
}
