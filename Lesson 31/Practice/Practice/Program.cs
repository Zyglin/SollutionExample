using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            //Часто выполяются операции, которые могут занять продолжительное время:
            //чтение-запись файлов, обращение к базе данных и т.д.
            //Такие операции могут серьезно нагрузить приложение.
            //Продолжительные операции могут блокировать интерфейс пользователя и негативно 
            //повлиять на желание пользователя работать с программой.
            //В синхронном приложении при выполнении продолжительных операций в основном потоке  он блокируется на n-ое время выполнения операции.
            //И чтобы продолжительные операции не блокировали общую работу приложения, используется асинхронность.
            //Асинхронность позволяет вынести отдельные задачи из основного потока в специальные 
            //асинхронные методы и более экономно использовать ресурсы

            //Ключевыми для работы с асинхронными вызовами являются два оператора:
            //async и await, цель которых - упростить написание асинхронного кода. Они используются вместе для создания асинхронного метода.

            //Асинхронный метод обладает следующими признаками:

            //В заголовке метода используется модификатор async

            //Метод содержит одно или несколько выражений await

            //В качестве возвращаемого типа используется один из следующих:

            //void

            //Task

            //Task<T>

            //ValueTask<T>

            //Асинхронный метод, как и обычный, может использовать любое количество параметров 
            //или не использовать их вообще.

            //не может определять параметры с модификаторами out, ref и in.

            // Нарисовать на примере разницу между ассинхронными и синхронными операциями.

            //При использовании ключевого слова void асинхронный метод ничего не возвращает:

            //async void ShowMessageAsync(string message)
            //{
            //    await Task.Delay(1000);  
            //    Console.WriteLine(message);
            //}


            //Возвращение объекта типа Task

            //Для ожидания завершения асинхронной задачи можно применить оператор await. Причем его необязательно использовать непосредственно при вызове задачи.
            //Его можно применить лишь там, где нам нужно гарантировано получить результат задачи или удостовериться, что задача завершена.

            //async Task ShowMessageSecondAsync()
            //{
            //    await Task.Delay(1000);
            //}

            //async Task<int> ShowMessageSecondAsync()
            //{
            //    await Task.Delay(1000);
            //    return 12;
            //}

            async Task ShowMessageSecondAsync(string message)
            {
                await Task.Delay(1000);
                Console.WriteLine(message);

            }

            // await ShowMessageSecondAsync("Hello all");

            //Метод может возвращать некоторое значение. Тогда возвращаемое значение оборачивается в объект Task, а возвращаемым типом является Task<T>

            //int resultFirst = await SumAsync(5);
            //int resultSecond = await SumAsync(6);
            //Console.WriteLine(resultFirst);
            //Console.WriteLine(resultSecond);

            //int SumAsyn(int a)
            //{
            //    await Task.Delay(1000);
            //    return a + a;
            //}


            //Task.Run: Создает и запускает асинхронную задачу на пуле потоков.

            //Task.Run(() =>
            //{
            //    // Код задачи
            //});

            //void Operation()
            //{
            //    Console.WriteLine("Operation ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine("Begin");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("End");
            //}

            //Task task = new Task(Operation);

            //task.Start();

            //Task.Delay: Создает задачу, которая ожидает указанное время до завершения.

            /* await Task.Delay(2000);*/ // Ожидание 2 секунды

            //Thread.Sleep(1000);

            //Task.WhenAll: Создает задачу, которая ожидает завершения всех указанных задач.

            //var tasks = new List<Task>();
            //            tasks.Add(Task.Delay(2000));
            //            tasks.Add(Task.Delay(3000));
            //            tasks.Add(Task.Delay(4000));

            //            await Task.WhenAll(tasks); // Ожидание завершения всех задач



            //Task.WhenAny: Создает задачу, которая ожидает завершения любой из указанных задач.

            //var tasks = new List<Task>();
            //            tasks.Add(Task.Delay(2000));
            //            tasks.Add(Task.Delay(3000));
            //            tasks.Add(Task.Delay(4000));

            //            var completedTask = await Task.WhenAny(tasks); // Ожидание завершения любой задачи

            //// Обработка завершившейся задачи
            //if (completedTask == tasks[0])
            //{
            //    // Задача 1 завершена
            //}
            //else if (completedTask == tasks[1])
            //{
            //    // Задача 2 завершена
            //}
            //// и т.д.

            //   Task.FromResult: Создает задачу, которая завершается с указанным результатом.

            //int result = 42;
            //Task<int> task = Task.FromResult(result);

            //Task.ContinueWith: Добавляет продолжение к задаче, которое будет выполнено после ее завершения.

            //Task<int> task1 = Task.Run(() => 42);
            //Task<string> task2 = task1.ContinueWith(t => $"Результат: {t.Result}");

            //string result = await task2;


            // Task.Wait: Ожидает завершения задачи синхронно(блокирует текущий поток до завершения).

            //var task = Task.Delay(2000);
            //task.Wait(); // Ожидание завершения задачи


            //Task.WaitAll: Ожидает завершения всех указанных задач синхронно.


            //var tasks = new Task[3];
            //tasks[0] = Task.Delay(2000);
            //tasks[1] = Task.Delay(3000);
            //tasks[2] = Task.Delay(4000);

            //Task.WaitAll(tasks); // Ожидание завершения всех задач


            // Task.WaitAny: Ожидает завершения любой из указанных задач синхронно.

            //var tasks = new Task[3];
            //tasks[0] = Task.Delay(4000);
            //tasks[1] = Task.Delay(3000);
            //tasks[2] = Task.Delay(2000);

            //int completedTaskIndex = Task.WaitAny(tasks);

            //string l = "cd"; 


            // конкретный пример разницы между ассинхронностью и синхронностью 

            Console.WriteLine("Начало выполнения асинхронной операции.");
            Task<int>[] tasks = new Task<int>[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = DelayedOperation(i + 1);
            }

            // Ожидаем завершения всех задач
            int[] results = await Task.WhenAll(tasks);

            Console.WriteLine("Результаты асинхронных операций:");
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Асинхронная операция завершена.");
            // TAP (Task Assync Pattern)
        }

        static async Task<int> DelayedOperation(int id)
        {
            Random random = new Random();
            int delay = random.Next(1000, 5000); // Генерируем случайную задержку от 1 до 5 секунд
            await Task.Delay(delay);

            Console.WriteLine("Операция с ID {0} завершена.", id);

            return id;
        }

    }
}