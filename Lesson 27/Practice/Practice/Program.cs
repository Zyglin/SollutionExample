using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //в языке C# есть массивы, которые хранят в себе наборы однотипных объектов.
            //Массив хранит фиксированное количество объектов.Когда мы заранее не знаем,
            //сколько нам потребуется объектов.В этом случае удобнее применять коллекции.
            //Еще один плюс коллекций состоит в том, что некоторые из них реализует стандартные структуры данных,
            //например, стек, очередь, словарь, которые могут пригодиться для решения задач.
            //Большая часть классов коллекций содержится в пространстве имен System.Collections.Generic.

            //Класс List<T> из пространства имен System.Collections.Generic представляет простейший список однотипных объектов

            //var cars = new List<string>() { "Audi","BMW","Honda" }; // var name =  new List<T> () { example(T),exampleOne(T) }

            //Console.WriteLine(cars.Count);

            //cars.Add("Tesla");  

            //cars.Insert(0, "Suzuki");

            //cars.RemoveAt(1); 

            //cars.Remove("Honda");

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //var containsHonda = cars.Contains("Honda");

            //Console.WriteLine(containsHonda);

            //var range = cars.GetRange(1, 2);

            //Console.WriteLine("------------------------------------------------");

            //foreach (var car in range)
            //{
            //    Console.WriteLine(car);
            //}

            //// переворачиваем весь список
            //cars.Reverse();

            //var nums = new List<int>();
            //var rnd =  new Random();

            //for (int i = 0; i < rnd.Next(150); i++)
            //{
            //    nums.Add(rnd.Next(150));
            //}

            //Console.WriteLine(nums.Average());

            //Создайте программу, которая генерирует случайные числа и добавляет их в список.
            //Затем программа должна отобразить среднее значение чисел в списке.

            //Создайте программу, которая запрашивает у пользователя
            //два списка целых чисел и затем сливает их в один список,
            //удаляя все дубликаты. ****** hard level

            //-----------------------------------------------------------


            //Класс LinkedList<T> представляет двухсвязный список,
            //в котором каждый элемент хранит ссылку одновременно на следующий и на предыдущий элемент.

            //var prof = new List<string> { "Programer", "SysAdmin", "Engineer", "Designer" };

            //var employees = new LinkedList<string>(prof);

            //foreach (var empl in employees)
            //{
            //    Console.WriteLine(empl);
            //}

            //Console.WriteLine(employees.Count);
            //Console.WriteLine(employees.First?.Value);    
            //Console.WriteLine(employees.Last?.Value);

            //var currentNode = employees.First;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}

            ////// с конца до начала списка
            //currentNode = employees.Last;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Previous;
            //}

            //var games = new LinkedList<string>();
            //games.AddFirst("Warhammer");
            //games.AddFirst("BattleField");


            //if (games.First != null) games.AddAfter(games.First, "Mikes");

            ////foreach (var game in games) Console.WriteLine(game);



            //games.RemoveFirst();
            //games.RemoveLast();


            //foreach (var game in games) Console.WriteLine(game);


            //Класс Queue<T> представляет обычную очередь, которая работает по алгоритму
            //первый вошел - первый вышел. FIFO


            var names = new Queue<string>();

            /*
             void Clear(): очищает очередь

             bool Contains(T item): возвращает true, если элемент item имеется в очереди

             T Dequeue(): извлекает и возвращает первый элемент очереди

             void Enqueue(T item): добавляет элемент в конец очереди

             T Peek(): просто возвращает первый элемент из начала очереди без его удаления
             */

            //Для перебора  foreach.

            //Для получения количества элементов Count.

            names.Enqueue("Artem");
            names.Enqueue("Oleg");
            names.Enqueue("Daniil");
            names.Enqueue("Slava");

            //var firstName = names.Peek();
            //Console.WriteLine(firstName);

            //var nameOne = names.Dequeue();
            //Console.WriteLine(nameOne);
            //var nameTwo = names.Dequeue();
            //Console.WriteLine(nameTwo);
            //var nameThree = names.Dequeue();
            //Console.WriteLine(nameThree);
            //var nameFour = names.Dequeue();
            //Console.WriteLine(nameFour);

            //Напишите программу, которая принимает очередь строк от пользователя
            //и затем находит самую длинную строку в очереди.

            //Напишите метод который принимает на вход Queue<Car>, внутри метода  реализуйте функционал где в
            // консоль будет выводится поочередно помытая машина, пока в очереди не останется не одной машины.После
            // этого напишите что машин больше не осталось, Все машины помыты!!!!




            //Stack<T> представляет коллекцию, которая использует алгоритм последний вошел - первый вышел. LIFO

            var numbers = new Stack<int>(); // var имя = new Stack<T>(12)

            /*
             Clear: очищает стек

            Contains: проверяет наличие в стеке элемента и возвращает true при его наличии

            Push: добавляет элемент в стек в верхушку стека

            Pop: извлекает и возвращает первый элемент из стека

            Peek: просто возвращает первый элемент из стека без его удаления
             */

            //numbers.Push(12);
            //numbers.Push(14);
            //numbers.Push(18);

            ////// получаем первый элемент стека без его удаления 
            //int headNumber = numbers.Peek();
            //Console.WriteLine(headNumber);

            //int numberOne = numbers.Pop();
            //Console.WriteLine(numberOne);

            //int numberTwo = numbers.Pop();
            //Console.WriteLine(numberTwo);

            //int numberThree = numbers.Pop();
            //Console.WriteLine(numberThree);



            //Еще один распространенный тип коллекции  словари.
            //Словарь хранит объекты, которые представляют пару ключ-значение.
            //Класс словаря Dictionary<K, V> типизируется двумя типами:
            //K представляет тип ключей,
            //V предоставляет тип значений.

            var passports = new Dictionary<string, string>()
            {
                { "MC25218923", "Artem"},
                { "MC28218111", "Egor"},
                { "MC26212923", "Oleg"}
            };

            var users = new Dictionary<int, string>()
            {
                { 1, "Artem"},
                { 2, "Egor"},
                { 3, "Maxim"}
            };


            foreach (var passport in passports)
            {
                Console.WriteLine($"key: {passport.Key}  value: {passport.Value}");
            }

            Console.WriteLine(passports["MC25218923"]); // имяСловаря["MC25218923"]


            users.Add(4, "Mario");

            var userKeyExist = users.ContainsKey(4); //ContainsValue
            Console.WriteLine(userKeyExist);


            users.Remove(2);



            //У вас есть 3 словаря (Китайского, Русского, Английского), у вас есть какой текст на любом из этих трёх языков, фраза вам изначально дана
            //и вы изначально знаете язык на котором эта фраза написана (RU,ENG)

            //В C# интерфейсы IEnumerable, IEnumerator и IQueuerable используются для работы с коллекциями
            //и структурами данных.
            //IEnumerable представляет последовательность элементов и позволяет
            //перебирать элементы коллекции с помощью цикла foreach.
            //Он определяет метод GetEnumerator(), который возвращает объект типа IEnumerator.
            //Этот интерфейс имеет один метод MoveNext(), который переводит курсор на следующий элемент
            //в последовательности, и свойство Current, которое возвращает текущий элемент.
            //IQueuerable представляет очередь элементов и предоставляет методы для работы с очередью.
            //Он определяет метод GetEnumerator(), который возвращает объект типа IEnumerator, и метод Enqueue(),
            //который добавляет элемент в очередь.
            //Каждая коллекция, которая должна быть перебираемой или очередью,
            //должна реализовывать интерфейс IEnumerable, IEnumerator или IQueuerable.
            //Эти интерфейсы обеспечивают стандартный способ работы с коллекциями в C#.


            //ObservableCollection

        }
    }
}