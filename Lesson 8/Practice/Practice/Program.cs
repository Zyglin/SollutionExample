using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Patient patient = new Patient(1);
            //patient.SelectDoctor();

            //Абстрактный класс похож на обычный класс. Он также может иметь переменные, методы, конструкторы, свойства.
            //Единственное, что при определении абстрактных классов используется ключевое слово abstract.
            //Абстрактные классы используются в качестве обобщенных концепций, на основе которых можно создавать более конкретные производные классы.
            //Производный класс обязан переопределить и реализовать все абстрактные методы и свойства, которые имеются в базовом абстрактном классе. 
            //Абстрактными могут быть:
            // - Методы
            // - Свойства
            // - Индексаторы
            // - События

            //Doctor doctor = new Doctor();
            //doctor.Eat();

            //Engineer engineer = new Engineer();
            //engineer.Eat();

            //Builder builder = new Builder();
            //builder.Eat();

            //можно так задать значения свойств
            //var rectangleExample = new Rectangle();
            //rectangleExample.Width = 10;
            //rectangleExample.Height = 10;

            //var rectangle = new Rectangle { Width = 90, Height = 70 };
            //var circle = new Circle { Radius = 100 };
            //PrintShape(rectangle);
            //PrintShape(circle);

            //void PrintShape(Shape shape)
            //{
            //    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}  Area: {shape.GetArea()}");
            //    //var genericType = (Rectangle)shape;
            //    //Console.WriteLine(genericType.Height);
            //    //Console.WriteLine(genericType.Width);
            //    //genericType.GetArea();
            //}



            // Задача реализовать абстрактный класс  Transport.
            // У него должен быть абстрактный метод Move и Stop, абстрактное свойство Speed.
            // Создать так же производные классы Car Plane Train  от Transport




            //Для определения интерфейса используется ключевое слово interface.
            //Названия интерфейсов принято писать с заглавной буквы I, например, IEnumerable.

            //В интерфейсы могут определять следующие сущности:
            //Методы
            //Свойства
            //Индексаторы
            //События
            //Статические поля и константы

            //если методы и свойства интерфейса не имеют модификаторов доступа, по умолчанию доступ public,
            //так как цель интерфейса - определение функционала для реализации его классом.

            // В конечном счете интерфейс предназначен для реализации в классах и структурах

            // Показать пример интерфейса IPersonService
            // Показать пример множественного наследования
            /*
             class myClass: Interface1, Interface2, Interface3, ...
                {
     
                }
             */
            // Добавить интерфейс для реализации методов Чтения и Записи



            //Вывод
            //Interface в C# обладает такими особенностями:
            //не содержит поля;
            //не использует конструкторы;
            //в нем не осуществляется перегрузка операторов;
            //методы по умолчанию имеют статус public;
            //нет реализации элементов интерфейса;
            //нет возможности создать экземпляра интерфейса.
            //Интерфейс может быть реализован в любом количестве классов, а в одном классе может быть реализовано любое количество интерфейсов.



            //Кроме обычных полей, методов, свойств классы могут иметь статические поля, методы, свойства.
            //Статические поля, методы, свойства относятся ко всему классу для обращения к подобным членам необязательно создавать экземпляр класса.
            //Статические классы объявляются с модификатором static и могут содержать только статические поля, свойства и методы.
            //Например, определим класс, который выполняет ряд арифметических операций по типу класса Math

            //Console.WriteLine(Operations.FeigenBaumNumber);
            //Console.WriteLine(Operations.Pi);
            //Operations.Pi = 4.52;
            //Console.WriteLine(Operations.Pi);
            //Operations.Pi = 3.14;
            //Console.WriteLine(Operations.Pi);
            //Console.WriteLine(Operations.Sum(12, 15));
            //Console.WriteLine(Operations.Subtraction(19, 15));
            //Console.WriteLine(Operations.Multiply(12, 15));
            //Console.WriteLine(Operations.Abs(-19));
            //Console.WriteLine(Operations.Pow(4,4));


            //Задача реализовать класс Operations и добавить туда стастические методы Pow, Abs.
            //Вызвать их чтобы работали.



            //Наряду с классами структуры представляют еще один способ создания собственных типов данных.
            //Более того многие примитивные типы, например, int, являются структурами.
            //Для определения структуры применяется ключевое слово struct

            //struct имя_структуры
            //{
            //   .....
            //}

            //Структра схожа с классом, она так же может иметь в себе перечень неких данных и даже методов.
            //Структуры — это типы значений; классы являются ссылочными типами.
            //Переменная типа структуры содержит данные структуры, а не ссылку на данные в качестве типа класса.
            //Структуры сохраняются в стек; классы в кучу
            //Cтруктура не поддерживает наследование
            //В структуре обязательно должны все поля и свойства быть проинициализированы
            //Где использовать структуры C#?
            // Используйте struct всякий раз, когда вы хотите просто хранить данные.
            // Как правило, структуры подходят для программирования игр.Однако легче передать объект класса, чем структуру.
            // Поэтому не используйте структуру при передаче данных по сети или другим классам.

            //PersonStruct evgeniy  = new PersonStruct("Evgeniy", 123);
            //PersonStruct max = evgeniy with { name = "Max" };

            //Console.WriteLine(evgeniy.name);
            //Console.WriteLine(evgeniy.age);

            //Console.WriteLine(max.name);
            //Console.WriteLine(max.age);
            //max.Print();


            // Задача давайте создадим инвентарь по умолчанию который будет у игрока в начале игры. struct Equipment. поля Sword, Shield, Armor




            //Типы значений:

            //Целочисленные типы(byte, sbyte, short, ushort, int, uint, long, ulong)

            //Типы с плавающей запятой(float, double)

            //Тип decimal

            //Тип bool

            //Тип char

            //Перечисления enum

            //Структуры (struct)

            //Ссылочные типы:

            //Тип object

            //Тип string

            //Классы(class)

            //Интерфейсы(interface)

            //Делегаты(delegate)



            // Кроме примитивных типов данных в C# есть такой тип как enum или перечисление.
            // Перечисления представляют набор логически связанных констант.

            //enum название_перечисления
            //{
            //  значение1,
            //  значение2,
            //  .......
            //}

            //Console.WriteLine(DayTimeExamle.Morning);
            Console.WriteLine((int)DocumentElementType.Table);

            //var now = DayTime.Night;

            //switch (now)
            //{
            //    case DayTime.Morning:
            //        Console.WriteLine(DayTime.Morning);
            //        break;
            //    case DayTime.Afternoon:
            //        Console.WriteLine(DayTime.Afternoon);
            //        break;
            //    case DayTime.Evening:
            //        Console.WriteLine(DayTime.Evening);
            //        break;
            //    case DayTime.Night:
            //        Console.WriteLine(DayTime.Night);
            //        break;
            //}

            // Создайте enum 
        }
    }
}