namespace Lesson15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // ��������� ��������� ������������ � �������������

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // ������������� ������������� ��������� � �������������
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //����� app.MapControllerRoute ��������� ���� ������� � ������ default � �������� "{controller=Home}/{action=Index}/{id?}".
            //������ ������ ������������� �������������� ��������� ������ �������: controller / action / id.�� ���� � ������ ���� �������� �����������,
            //����� �������� ��������, � ����� ����� ���� �������������� �������� id.
            //���������� ������� ������� ����� ��������� ������ ���� localhost:xxxx / Home / Index � ������������ � ��� ���������.
            //����� ���������� ����������� �� ��� - ��������, ��� ���� � �������� ������ ������� �����_����� / ���_����������� / ��������_�����������.
            //���, �� ������� �����_����� / Home / Index ������� ������������� �� ��������� ������� ����� Index ����������� HomeController ��� ��������� ��������� �������

            app.Run();
        }

        //Dependencies: ��� ����������� � ������ ������ � ����������

        //wwwroot: ���� ���� ������������ ��� �������� ����������� ������ - �����������, �������� javascript, ������ css � �.�., ������� ������������ �����������.

        //Controllers: ����� ��� �������� ������������, ������������ �����������.�� ��������� ����� ��� ���� ���� ���������� - Homecontroller

        //Models: ������� ��� �������� �������.�� ��������� ����� ��������� ������ ErrorviewModel

        //Views: ������� ��� �������� �������������. ����� ����� �� ��������� ����������� ��� ������ - �������������

        //appsettings.json: ������ ������������ ����������

        //Program.cs: ����, ������� ���������� ������� ����� � ���������� ASP.NET Core
    }
}