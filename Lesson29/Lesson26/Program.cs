using Lesson26.DataAccess;
using Lesson26.DataAccess.DbPatterns;
using Lesson26.DataAccess.DbPatterns.Interfaces;
using Lesson26.Services.Interface;
using Lesson26.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lesson26
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            //За управление сервисами в приложении в классе WebApplicationBuilder определено свойство Services, которое представляет объект IServiceCollection - коллекцию сервисов
            //Каждый сервис в коллекции IServiceCollection представляет объект ServiceDescriptor, который несет некоторую информацию. В частности, наиболее важные свойства этого объекта:
            //ServiceType: тип сервиса
            //ImplementationType: тип реализации сервиса
            //Lifetime: жизненный цикл сервиса
            //роме ряда подключаемых по умолчанию сервисов ASP.NET Core имеет еще ряд встроенных сервисов, которые мы можем подключать в приложение при необходимости.
            //Все сервисы и компоненты middleware, которые предоставляются ASP.NET по умолчанию, регистрируются в приложение с помощью методов расширений IServiceCollection,
            //имеющих общую форму Add

            //Фреймворк ASP.NET Core предоставляет ряд встроенных сервисов, которые мы можем использовать. Но также мы можем создавать свои собственные сервисы.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            //Благодаря вызову AddTransient<IUserService, UserService>() система на место объектов интерфейса IUserService будет передавать экземпляры класса UserService.
            //После добавления сервиса его можно получить и использовать в любой части приложения. 
            builder.Services.AddTransient<IUserService, UserService>();

            //В ASP.NET Core мы можем получить добавленные в приложения сервисы различными способами;

            //Через свойство Services объекта WebApplication

            //Через свойство RequestServices контекста запроса HttpContext в компонентах middleware

            //Через конструктор класса

            //Через свойство Services объекта WebApplicationBuilder

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseHttpsRedirection();
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