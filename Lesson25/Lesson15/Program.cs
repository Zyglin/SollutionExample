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
            builder.Services.AddControllersWithViews(); // добавляем поддержку контроллеров и представлений

            string connection = builder.Configuration.GetConnectionString("DefaultConnection"); // получаем connectionString

            // добавляем контекст ApplicationContext в качестве сервиса в приложение
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            //Этот метод в качестве параметра принимает делегат, который настраивает подключение.
            //В частности, с помощью вызова options.UseSqlServer()
            //настраивается подключение к серверу MS SQL Server

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