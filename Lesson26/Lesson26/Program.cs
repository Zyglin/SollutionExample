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
            //�� ���������� ��������� � ���������� � ������ WebApplicationBuilder ���������� �������� Services, ������� ������������ ������ IServiceCollection - ��������� ��������
            //������ ������ � ��������� IServiceCollection ������������ ������ ServiceDescriptor, ������� ����� ��������� ����������. � ���������, �������� ������ �������� ����� �������:
            //ServiceType: ��� �������
            //ImplementationType: ��� ���������� �������
            //Lifetime: ��������� ���� �������
            //���� ���� ������������ �� ��������� �������� ASP.NET Core ����� ��� ��� ���������� ��������, ������� �� ����� ���������� � ���������� ��� �������������.
            //��� ������� � ���������� middleware, ������� ��������������� ASP.NET �� ���������, �������������� � ���������� � ������� ������� ���������� IServiceCollection,
            //������� ����� ����� Add

            //��������� ASP.NET Core ������������� ��� ���������� ��������, ������� �� ����� ������������. �� ����� �� ����� ��������� ���� ����������� �������.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            //��������� ������ AddTransient<IUserService, UserService>() ������� �� ����� �������� ���������� IUserService ����� ���������� ���������� ������ UserService.
            //����� ���������� ������� ��� ����� �������� � ������������ � ����� ����� ����������. 
            builder.Services.AddTransient<IUserService, UserService>();

            //� ASP.NET Core �� ����� �������� ����������� � ���������� ������� ���������� ���������;

            //����� �������� Services ������� WebApplication

            //����� �������� RequestServices ��������� ������� HttpContext � ����������� middleware

            //����� ����������� ������

            //����� �������� Services ������� WebApplicationBuilder

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