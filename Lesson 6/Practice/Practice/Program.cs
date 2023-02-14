using Lesson6;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] source = { 5, 4, 7, 2, 9, 7, 10 };
            //int numberReadLine = Convert.ToInt32(Console.ReadLine());
            //int futureArrayLength = 0;

            //foreach (int item in source)
            //{
            //    if (item != numberReadLine)
            //    {
            //        futureArrayLength++;
            //    }
            //}

            //int[] resultArray = new int[futureArrayLength];

            //int iterationForAppend = 0;

            //for (int i = 0; i < source.Length; i++)
            //{
            //    if (source[i] != numberReadLine && iterationForAppend != resultArray.Length)
            //    {
            //        resultArray[iterationForAppend] = source[i];
            //        iterationForAppend++;
            //    }
            //}

            //Console.WriteLine();

            //string stringTaskThree = "abccc,bhc3ndf,aaaab,erty,err54rr,k555";
            //string[] wordsArray = stringTaskThree.Split(',');
            //string resultWord = wordsArray[0];


            //for (int i = 1; i < wordsArray.Length; i++)
            //{
            //    //Distinct-Возвращает различающиеся элементы последовательности.
            //    Console.WriteLine(wordsArray[i].Distinct().Count());
            //    Console.WriteLine(resultWord.Distinct().Count());
            //    Console.WriteLine("----------------------------");

            //    if (wordsArray[i].Distinct().Count() < resultWord.Distinct().Count()) resultWord = wordsArray[i];
            //}


            //Console.WriteLine(resultWord);

            //static void Swap(ref int e1, ref int e2)
            //{
            //    var temp = e1;
            //    e1 = e2;
            //    e2 = temp;
            //}

            ////сортировка пузырьком
            //static int[] BubbleSort(int[] array)
            //{
            //    var len = array.Length;
            //    for (var i = 1; i < len; i++)
            //    {
            //        Console.WriteLine($"----------------------------------------------------------------");
            //        for (var j = 0; j < len - i; j++)
            //        {
            //            Console.WriteLine($"Сравниваем {array[j]} > {array[j + 1]}");
            //            if (array[j] > array[j + 1])
            //            {
            //                Console.WriteLine($"Так как {array[j]} > {array[j + 1]} свапаем эти значения");
            //                Swap(ref array[j], ref array[j + 1]);
            //            }
            //        }
            //    }

            //    return array;
            //}

            //5 4 7 8 9 5 1 2
            //4 5 7 8 9 5 1 2
            //4 5 7 8 5 9 1 2
            //4 5 7 8 5 1 2 9
            //4 5 7 5 8 1 2 9
            //4 5 7 5 1 2 8 9
            //4 5 5 1 2 7 8 9


            //Console.WriteLine("Сортировка пузырьком");
            //Console.Write("Введите элементы массива: ");
            //var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            //var array = new int[parts.Length];
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(parts[i]);
            //}

            //Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));

            //Console.ReadLine();


            //!!!private: закрытый или приватный компонент класса или структуры.Приватный компонент доступен только в рамках своего класса или структуры.

            //private protected: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.

            //file: добавлен в версии C# 11 и применяется к типам, например, классам и структурам. Класс или структура с такми модификатором доступны только из текущего файла кода.

            //!!!protected: такой компонент класса доступен из любого места в своем классе или в производных классах.При этом производные классы могут располагаться в других сборках.

            //!!!internal: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.

            //protected internal: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.

            //!!!public: публичный, общедоступный компонент класса или структуры.Такой компонент доступен из любого места в коде, а также из других программ и сборок.



            //Car audi = new Car("Audi",2022,4,"Yuri");
            //Car bmv = new Car("Bmv",2028,7,"Leon");

            //audi.ShowStats();
            //bmv.ShowStats();


            // имяКласса имяОбъекта =  new имяКласса()
            Car obj = new Car();



            /*
             Константы должны быть определены во время компиляции, а поля для чтения могут быть определены во время выполнения программы.

             Соответственно значение константы можно установить только при ее определении.

             Поле для чтения можно инициализировать либо при его определении, либо в конструкторе класса.

             Константы не могут использовать модификатор static, так как уже неявно являются статическими.Поля для чтения могут быть как статическими, так и не статическими.
            */



            //[модификаторы] тип_возвращаемого_значения название_метода([параметры])
            //{
            //    // тело метода
            //}

            //void 



            //Параметры позволяют передать в метод некоторые входные данные. Параметры определяются через заятую в скобках после названия метода в виде:
            //тип_параметра1 параметр1, тип_параметра2 параметр2, ...)
            //{
            //  // действия метода
            //}




            //Метод может возвращать значение, какой-либо результат.В примере выше были определены два метода, которые имели тип void.Методы с таким типом не возвращают никакого значения.Они просто выполняют некоторые действия.
            //Но методы также могут возвращать некоторое значение.Для этого применяется оператор return, после которого идет возвращаемое значение:
            //return возвращаемое значение;



            /*Кроме примитивных типов данных в языке программирования C# есть такой тип как enum или перечисление. Перечисления представляют набор логически связанных констант.
            Объявление перечисления происходит с помощью оператора enum:


               enum название_перечисления
                {
                 // значения перечисления
                    значение1,
                    значение2,
                    .......
                    значениеN
                 }
            */



            /*Типы значений:

            Целочисленные типы(byte, sbyte, short, ushort, int, uint, long, ulong)

            Типы с плавающей запятой(float, double)

            Тип decimal

            Тип bool

            Тип char

            Перечисления enum

            Структуры (struct)

            Ссылочные типы:

            Тип object

            Тип string

            Классы(class)

            Интерфейсы(interface)

            Делегаты(delegate)
            */

        }
    }
}