namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //В C# термин "generic" относится к типу, который параметризуется одним или несколькими другими типами.
            //Это позволяет создавать гибкий и повторно используемый код, который может работать с различными типами
            //данных без необходимости переписывать его для каждого конкретного случая.

            /*     Использование обобщений дает следующие преимущества:

             -упрощение программного кода.Использование обобщений позволяет реализовывать алгоритм для любого типа элементов.
              Не нужно создавать похожие варианты алгоритма для различных типов(int, float, string и т.д.);
             -обеспечение типовой безопасности.В обобщенных элементах(классах, методах, коллекциях и т.п.) помещаются только объекты определенного типа,
             указываемого при их объявлении;
             - в обобщениях исключена необходимость явного приведения типа при преобразовании объекта или иного типа обрабатываемых данных;
             - повышение производительности. При использовании обобщений структурные типы передаются по значению.
            При этом не выполняется упаковка(boxing) и распаковка(unboxing), которые замедляют выполнение программы.
            */

            /*
              Как языковое средство, обобщения могут быть применены к:
              классам;
              структурам;
              интерфейсам;
              методам;
              делегатам.                       
             */


            //Для создания обобщенного типа в C# используется синтаксис (<>) после имени типа   

            //class имя_класса <T>
            //{
            //...
            //}

            // Общая форма объявления обобщенного класса для нескольких типов:


            //class ClassName<T1, T2, ..., TN>
            //        {
            //            // Реализация методов и полей класса,
            //            // которые работают с обобщенными типами T1, T2, ..., TN
            //            // ...
            //        }

            //GenericClass<int> intGeneric = new GenericClass<int>(42);
            //var intValue = intGeneric.GetValue();
            //intGeneric.GenericField = 124;
            //intGeneric.GenericField = 124;
            //Console.WriteLine(intValue);

            //GenericClass<double> doubleGeneric = new GenericClass<double>(12.2);
            //var doubleValue = doubleGeneric.GetValue();
            //doubleGeneric.GenericField = 12.2;
            //doubleGeneric.GenericField = 1.2;
            //Console.WriteLine(doubleValue);

            //GenericClass<string> stringGeneric = new GenericClass<string>("Hello Guys");
            //var stringValue = stringGeneric.GetValue();
            //Console.WriteLine(stringValue);


            //GenericClass<string> stringGeneric = new GenericClass<string>("Hello, world!");
            //string stringValue = stringGeneric.GetValue();

            ////Обобщенные типы также могут использоваться с интерфейсами и методами. 

            //GenericClass obj = new GenericClass();
            //obj.PrintValue(123);


            //var artem = new Person<int>(546, "Artem");
            //Person<int>.code = 1234;

            //var max = new Person<string>("test", "Maxim");
            //Person<string>.code = "meta";


            //Console.WriteLine(Person<int>.code);       // 1234
            //Console.WriteLine(Person<string>.code);   // meta

            //Обобщенные методы

            void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }

            string s1 = "hello";
            string s2 = "bye";

            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1={s1}    s2={s2}");

            int i1 = 2;
            int i2 = 400;
            Swap<int>(ref i1, ref i2);
            Console.WriteLine($"i1={i1} i2={i2}");

            //decimal i1 = 2;
            //decimal i2 = 400;
            //Swap<decimal>(ref i1, ref i2);
            //Console.WriteLine($"i1={i1} i2={i2}");

            //object i1 = 12;
            //object i2 = "Hello guys";
            //Swap<object>(ref i1, ref i2);
            //Console.WriteLine($"i1={i1} i2={i2}");


            //Задание значений по умолчанию для переменных обобщенного типа. Ключевое слово default
            // Поскольку, при объявлении обобщенного класса, параметр типа заранее неизвестен, то невозможно определить значение по умолчанию
            // для переменных обобщенного типа. В этом случае применяется ключевое слово default(T).
            // После использования default значению ссылочного типа присваивается null, а структурного 0.

            //var example = new MyGenericClass<string,int>();
            //Console.WriteLine(example.a);
            //Console.WriteLine(example.b);

            //Создать класс ClsCalc, public static Equal (value1 , value2 ) {
            //....
            //}

            //where
            // класс  прокидиывать в качестве T только Enum , метод который выведет значения енама.
            // класс прокидывать в качестве Т только struct , метод который выведет прокинутое значение



        }
    }
}