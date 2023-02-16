namespace Lesson6
{
    public class Car
    {
        //private string brand;
        //private int age = 0;
        //private int circleCount = 0;
        //private string driver;

        //свойства
        //[модификатор доступа] тип имя {
        //get { ....... }
        //set { ....... }
        //}
        //public int Age
        //{
        //    get { return age; }

        //    set
        //    {
        //        if (value < 1970 || value > 2023)
        //            Console.WriteLine("Год выпуска машины может быть в диапазоне  1970 до 2023");
        //        else
        //            age = value;
        //    }
        //}

        //public int CircleCount
        //{
        //    get { return circleCount; }

        //    set
        //    {
        //        if (value < 4 && value > 6)
        //            Console.WriteLine("Колёс может быть не меньше 4 и не больше 6");
        //        else
        //            circleCount = value;
        //    }
        //}


        //--------------------------------------------------------
        //автосвойства

        //[модификатор доступа] тип имя { get; set; }
        //public string Brand { get; set; }
        //public int Age { get; set; }

        //public Car(string brand, int age)
        //{
        //    Brand = brand;
        //    Age = age;
        //}

        //public void ShowStats()
        //{
        //    Console.WriteLine($"Название машины {brand}, год выпуска {age}. У нашей машины {circleCount} колеса");
        //    Console.WriteLine($"Имя водителя {driver}");
        //}

        //Иногда возникает необходимость создать один и тот же метод, но с разным набором параметров.Это называется перегрузкой методов.
        //Сигнатура метода складывается из следующего:
        //*Имя метода
        //*Количество параметров
        //*Типы параметров
        //*Порядок параметров
        //*Модификаторы параметров
        //Перегрузка метода это когда методы имеют разную сигнатуру, в которой совпадает только название метода.
        public void Drive()
        {
            Console.WriteLine("Машина поехала");
        }

        public void Drive(int speed)
        {
            Console.WriteLine($"Машина поехала со скоростью {speed}");
        }

        public void Drive(int speed, string driverName)
        {
            Console.WriteLine($"Машина поехала со скоростью {speed}. За рулём сидит {driverName}");
        }

        public void Drive(string driverName, int speed)
        {
            Console.WriteLine($"Машина поехала со скоростью {speed}. За рулём сидит {driverName}");
        }

        public void Drive(ref int speed)
        {
            speed = speed + 485;
            Console.WriteLine($"Скорость водителя {speed}");
        }

        //Drive()
        //Drive(int)
        //Drive(int,string)
        //Drive(string,int)
        //Drive(ref int);

        //Задание напишите метод,который будет выводить число, складывать два числа, умножать 2 числа.
        //Используя перегрузку.
        //Т.е нейминг у метода должен быть одинаковый.





        // Принципы ООП. И их примеры.

        //sealed запрет наследования


    }


    //Определив конструктор, мы можем вызвать его для создания объекта Person:
    //Person tom = new Person();  // Создание объекта Person


    //class Person
    //{
    //    public string Name { get; set; }
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}
    //class Employee : Person
    //{
    //   public string Company { get; set; }
    //public Employee(string name, string company)
    //    : base(name)
    //{
    //    Company = company;
    //}
    //public override void Print()
    //{
    //    Console.WriteLine($"{Name} работает в {Company}");
    //}
    //}
}
