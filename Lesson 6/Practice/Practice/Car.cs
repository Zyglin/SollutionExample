namespace Lesson6
{
    public class Car
    {
        public string brand;
        public int age;
        public int circleCount;
        public string driver;

        //public const string type = "Car";
        //public readonly string name = "Undefined";

        //public Car(string brandInit, int ageInit, int circleCountInit, string diverInit)
        //{
        //    brand = brandInit;
        //    age = ageInit;
        //    circleCount = circleCountInit;
        //    driver = diverInit;
        //}

        // [модификаторы] имяКласса ( параметры для инициализации) {
        // 
        // какой-то код инициализации   
        // }

        //public int MultiCar(int height, int width)
        //{
        //    ShowResultString();
        //    Console.WriteLine($"ширина {width}, высота{height}");
        //    int result = height * width;
        //    return result;
        //}

        public void ShowStats()
        {
            Console.WriteLine($"Название машины {brand}, год выпуска {age}. У нашей машины {circleCount} колеса");
            Console.WriteLine($"Имя водителя {driver}");
        }


        //public void Drive()
        //{
        //    Console.WriteLine($"Название машины {brand}, год выпуска {age}. У нашей машины {circleCount} колеса");

        //}


        //[модификаторы] тип_возвращаемого_значения название_метода([параметры])
        //{
        //    // тело метода
        //}



        //Поля , методы, свойства, конструктор





        //


    }

    //На уровне кода конструктор представляет метод, который называется по имени класса, который может иметь параметры, но для него не надо определять возвращаемый тип
    //Например, определим в классе Person простейший конструктор:
    //class Person
    //{
    //    public string name;
    //    public int age;
    //    public Person()
    //    {
    //        Console.WriteLine("Создание объекта Person");
    //        name = "Tom";
    //        age = 37;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    //    }
    //}

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
