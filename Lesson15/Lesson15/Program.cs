namespace Lesson15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // добавл€ем поддержку контроллеров и представлений

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // устанавливаем сопоставление маршрутов с контроллерами
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //ћетод app.MapControllerRoute добавл€ет один маршрут с именем default и шаблоном "{controller=Home}/{action=Index}/{id?}".
            //ƒанный шаблон устанавливает трехсегментную структуру строки запроса: controller / action / id.“о есть в начале идет название контроллера,
            //затем название действи€, и далее может идти необ€зательный параметр id.
            //—обственно поэтому система может соотнести запрос типа localhost:xxxx / Home / Index с контроллером и его действием.
            //„тобы обратитьс€ контроллеру из веб - браузера, нам надо в адресной строке набрать адрес_сайта / »м€_контроллера / ƒействие_контроллера.
            //“ак, по запросу адрес_сайта / Home / Index система маршрутизации по умолчанию вызовет метод Index контроллера HomeController дл€ обработки вход€щего запроса

            app.Run();
        }

        //Dependencies: все добавленные в проект пакеты и библиотеки

        //wwwroot: этот узел предназначен дл€ хранени€ статических файлов - изображений, скриптов javascript, файлов css и т.д., которые используютс€ приложением.

        //Controllers: папка дл€ хранени€ контроллеров, используемых приложением.ѕо умолчанию здесь уже есть один контроллер - Homecontroller

        //Models: каталог дл€ хранени€ моделей.ѕо умолчанию здесь создаетс€ модель ErrorviewModel

        //Views: каталог дл€ хранени€ представлений. «десь также по умолчанию добавл€ютс€ р€д файлов - представлений

        //appsettings.json: хранит конфигурацию приложени€

        //Program.cs: файл, который определ€ет входную точку в приложение ASP.NET Core
    }
}