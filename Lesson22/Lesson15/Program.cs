using Lesson15.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // ��������� ��������� ������������ � �������������

            string connection = builder.Configuration.GetConnectionString("DefaultConnection"); // �������� connectionString

            // ��������� �������� ApplicationContext � �������� ������� � ����������
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            //���� ����� � �������� ��������� ��������� �������, ������� ����������� �����������.
            //� ���������, � ������� ������ options.UseSqlServer()
            //������������� ����������� � ������� MS SQL Server

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
         
            app.Run();
        }

    }
}