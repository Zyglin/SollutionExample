using Lesson6;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Передача параметров по значению

            //При передаче аргументов  по значению параметр метода получает не саму переменную, а ее копию и  работает с этой копией независимо.

            //int num = 12;

            //void PlusOne(int example)
            //{
            //    example = example + 485;
            //    Console.WriteLine($"Число в методе: {example}");
            //}

            //Console.WriteLine($"Число до метода: {num}");
            //PlusOne(num);
            //Console.WriteLine($"Число после метода: {num}");


            //Console.WriteLine("------------------------------------------------------------------");

            ////Передача параметров по ссылке

            ////При передаче значений параметрам по ссылке метод получает адрес переменной в памяти. И, таким образом,
            ////если в методе изменяется значение параметра, передаваемого по ссылке, то также изменяется и значение переменной, которая передается на его место.

            //int secondNum = 12;

            //void PlusOneRef(ref int example)
            //{
            //    example = example + 485;
            //    Console.WriteLine($"Число в методе: {example}");
            //}

            //Console.WriteLine($"Число до метода: {secondNum}");
            //PlusOneRef(ref secondNum);
            //Console.WriteLine($"Число после метода: {secondNum}");



            //Console.WriteLine("------------------------------------------------------------------");
            ////Выше я юзал в качестве примера входные параметры.Но параметры могут быть также выходными. Чтобы сделать параметр выходным, перед ним ставится модификатор out:

            ////В примере ниже результат возвращается не через оператор return, а через выходной параметр result.


            //int number;

            //void Sum(int first, int second, out int resultSum)
            //{
            //    resultSum = first + second;
            //}

            //int SumSecond(int first, int second)
            //{
            //    int result = first + second;
            //    return result;
            //}


            //Sum(110, 125, out number);

            //Console.WriteLine(number);
            //Console.WriteLine();
            //Как ис ref ключевое слово out используется как при определении метода, так и при его вызове.


            //Car car = new Car();
            //car.Age = 2020;
            //Console.WriteLine(car.Age);
            //car.CircleCount = 5;
            //Console.WriteLine(car.CircleCount);
            //Car car = new Car("Toyota", 2005);
            //car.Age = 20;
            //car.Brand = "Honda";
            //Console.WriteLine(car.Age);
            //Console.WriteLine(car.Brand);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine(car.Age);
            //Console.WriteLine(car.Brand);

            //int number = 180; 
            //Car car = new Car();
            //car.Drive();
            //car.Drive(120);
            //car.Drive(140,"Artem");
            //car.Drive("Artem",160);
            //car.Drive(ref number);

            Circle circle = new Circle(18, "Круг");

            //Console.WriteLine(circle.R);
            //Console.WriteLine(circle.Pi);
            //Console.WriteLine(circle.Type);
            //Console.WriteLine(circle.Color);
            //Console.WriteLine(circle.Name);
            circle.ShowSquare();


            Triangle triangle = new Triangle(12, 6, "Треугольник");

            triangle.ShowSquare();
            //Console.WriteLine(triangle.Side);
            //Console.WriteLine(triangle.Name);
            //Console.WriteLine(triangle.Height);
            //Console.WriteLine(triangle.Type);
            //Console.WriteLine(triangle.Color);
            //circle.ShowSquare();

            //Triangle triangle  = new Triangle(7,8,"Треугольник");

            //triangle.ShowSquare();

            //Circle circle = new Circle(12, "Круг");

            //circle.ShowSquare();



            //Инкапсуляция (Сокрытие) - 1 принцип
            //Полиморфизм (Пеопределение / Overriding) - 2 принцип
            //Наследование (Наследник : базовый) - 3 принцип
            //Абстракция - 4 принцип ?;


            //class Phone string Type = "мобильный" virtual ShowName() , class Nokia, class Motorola , Name  и  override ShowName()



        }
    }
}