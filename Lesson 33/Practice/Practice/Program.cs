using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {

        //Многопоточность.Ключевым понятием при работе с многоопоточностью является поток.
        //Поток предствляет некоторую часть кода программы. При выполнении программы каждому потоку выделяется определенный квант времени.
        //И при помощи многопоточности мы можем выделить в приложении несколько потоков, которые будут выполнять различные задачи одновременно.

        //Поток - это отдельный путь выполнения кода, который может выполняться параллельно с другими потоками.
        //Он используется для выполнения асинхронных операций, таких как чтение/запись файлов, сетевые запросы и т.д.

        //Параллельность(Parallelism) в C# - это способность программы выполнять несколько задач одновременно на нескольких ядрах процессора.
        //Это достигается путем разделения задач на более мелкие части и выполнения их параллельно на разных потоках.
        //В C# для работы потоками используется пространство имен System.Threading.


        //Основной функционал для использования потоков в приложении сосредоточен в  System.Threading. Класс Thread.

        //IsAlive: указывает, работает ли поток в текущий момент

        //IsBackground: указывает, является ли поток фоновым

        //Name: содержит имя потока

        //Priority: хранит приоритет потока - ThreadPriority:
        //Lowest
        //BelowNormal
        //Normal
        //AboveNormal
        //Highest


        //ThreadState возвращает состояние потока -одно из значений перечисления ThreadState:
        //Aborted: поток остановлен(не завершен)
        //AbortRequested: для потока вызван метод Abort, но остановка потока еще не произошла
        //Background: поток выполняется в фоновом режиме
        //Running: поток запущен и работает
        //Stopped: поток завершен
        //StopRequested: поток получил запрос на остановку
        //Unstarted: поток еще не был запущен
        //WaitSleepJoin: поток заблокирован в результате действия метода Sleep или Join

        var currThread = Thread.CurrentThread;
        Console.ReadLine();
        //выведите свойства currThread в консоль 


        //Для создания потока применяется один из конструкторов класса Thread:
        //Не важно какой конструктор будет применяться для создания, нам надо определить выполняемое в потоке действие.

        //public delegate void ThreadStart();  без параметров

        //void Print()
        //{
        //    Console.WriteLine("Поток");
        //};

        //var t1 = new Thread(Print);
        //var t2 = new Thread(new ThreadStart(Print));
        //var t3 = new Thread(() => Console.WriteLine("Поток Поток"));

        //t1.Start();
        //t2.Start();
        //t3.Start();

        //var t4 = new Thread(Show);
        //// запускаем поток myThread
        //t4.Start();

        //// действия, выполняемые в главном потоке
        //for (int i = 0; i < 14; i++)
        //{
        //    Console.WriteLine($"Поток Main: {i}");
        //    Thread.Sleep(300);
        //}

        //// действия, выполняемые во втором потокке
        //void Show()
        //{
        //    for (int i = 0; i < 14; i++)
        //    {
        //        Console.WriteLine($"Дополнительный поток поток: {i}");
        //        Thread.Sleep(400);
        //    }
        //}


        //public delegate void ParameterizedThreadStart(object? obj); параметры  c параметрами


        //var tp1 = new Thread(new ParameterizedThreadStart(Show));

        //tp1.Start("Hello");

        //void Show(object? message) 
        //{
        //    Console.WriteLine(message);
        //}


        //var t1 = new Thread(Mul);
        //t1.Start(122);


        //void Mul(object? obj)
        //{
        //    if (obj is int num)
        //    {
        //        Console.WriteLine(num * num);
        //    }
        //}


        //Создайте класс Car,создайте поток, запустите метод ShowCarDescription в другом потоке.ShowCarDescription выводит информацию о машине.


        //Класс Parallel также является частью TPL и предназначен для упрощения параллельного выполнения кода.
        //Parallel имеет ряд методов, которые позволяют распараллелить задачу.

        Parallel.Invoke
            (
            () => { Console.WriteLine("HelloAll"); },
            () => { Console.WriteLine(8 * 8 * 8); },
            () => { Console.WriteLine(true || false); }
            );

        //for (int i = 0; i < char.MaxValue; i++)
        //{
        //    char character = (char)i;
        //}
        // Запустите  паралельно выполнение следующих задач 1) Метод считает модуль числа, 2) Метод убирает повторяющиеся символы из строки
        // аааббббвввв => абв 
        // 3)метод создаёт словарь  русских символов (ключ : символ, значение : ширина)

        void RussianDictionary(string text)
        {
            var random = new Random();
            var dict = new Dictionary<char, int>();

            foreach (var c in text)
            {
                dict.Add(c, random.Next(1, 20));
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }


        //Метод Parallel.For позволяет выполнять итерации цикла параллельно. 

        //int start = 1;
        //int end = 100;

        //var primes = PrimeNumberFinder.FindPrimesInRange(start, end);

        //foreach (var prime in primes)
        //{
        //    Console.WriteLine(prime);
        //}

        //В этом примере создается класс PrimeNumberFinder, который содержит метод FindPrimesInRange,
        //выполняющий поиск простых чисел в заданном диапазоне.
        //В методе FindPrimesInRange используется ConcurrentBag для хранения найденных простых чисел,
        //чтобы избежать проблем с одновременным доступом к коллекции из нескольких потоков.
        //Затем в методе Main определяются начальное и конечное значения диапазона поиска простых чисел.
        //Затем вызывается метод FindPrimesInRange, который выполняет поиск простых чисел параллельно с использованием Parallel.For.
        //Результаты сохраняются в ConcurrentBag, а затем выводятся на консоль.
        //Этот пример демонстрирует использование параллельных потоков для ускорения выполнения задачи поиска простых чисел в заданном диапазоне.
        //Каждый поток проверяет простоту чисел в своей части диапазона и добавляет найденные простые числа в общую коллекцию ConcurrentBag.
    }
}

