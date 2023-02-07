using System.Globalization;
using System.Runtime.CompilerServices;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            camelCase. camelCase должен начинаться со строчной буквы, а первая буква каждого последующего слова должна быть заглавной.
            Все слова при этом пишутся слитно между собой.
            Пример camelCase
             */
            //var camelCaseVar = "Example";
            //int numberOfMembersOfMyTeam = 12;

            //double temp = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(temp);

            //Реализуем оператор goto -топ решение
            //Console.WriteLine("А теперь используем goto:");

            //link1:
            //   Console.Write("lol");
            //   Console.Write("lol2");
            //   goto link1;


            //--------------------------------------------
            /*Циклы являются управляющими конструкциями,
            позволяя в зависимости от определенных условий выполнять некоторое действие множество раз.
            В C# имеются следующие виды циклов:
            -for
            -while
            -do...while\
            -foreach
            */
            //--------------------------------------------
            // * Цикл for
            //for (int b = 0; b < 8; b++)
            //{
            //    Console.WriteLine(b);
            //}

            /*
            Здесь первая часть объявления цикла - int b = 1 - создает и инициализирует переменную b.
            Вторая часть - условие b < 8. То есть пока переменная b меньше 8, будет выполняться цикл.
            И третья часть - шаг итерации(действия) - увеличение переменной b на единицу.
             */

            // Задача
            // вычислить сумму 2+4+8+...+100

            //int sum = 0;

            //for (int i = 0; i <= 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //Если хотите можете ничего не вставлять, тогда получится бесконечный цикл
            //for ( ; ; )
            //{
            //    Console.WriteLine($"Квадрат числа");
            //}
            //--------------------------------------------

            // За каждый месяц банк начисляет к сумме вклада 12% от суммы.
            // Напишите код в котором пользователь вводит сумму вклада и количество месяцев.
            // А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            //Для вычисления суммы с учетом процентов используйте цикл for.
            //Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine())(сумма вклада будет представлять тип decimal).

            //Console.WriteLine("Введите сумму вклада: ");
            //decimal summary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введите срок вклада в месяцах: ");
            //int period = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= period; i++)
            //{
            //    summary += summary * 0.12M;
            //}
            //Console.WriteLine($"После {period} месяцев сумма вклада составит {summary}"); // интерполяция 
            //Console.ReadKey();

            //--------------------------------------------

            // * Цикл do-while 

            //int i = 12;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);


            //таблица умножения числа 7.
            //int i = 1;
            //int n = 7;
            //int result;
            //do
            //{
            //    result = n * i;
            //    Console.WriteLine($"{n} * {i} = {result}");
            //    i++;
            //} while (i <= 100);

            //бесконечный цикл
            //do
            //{
            //    Console.WriteLine("test");
            //} while (true);
            //--------------------------------------------

            // *Цикл while

            //int i = 6;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //бесконечный цикл
            //while (true)
            //{
            //    Console.WriteLine("test");
            //}


            //Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
            //Console.WriteLine("Введите сумму вклада: ");
            //decimal sum = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введите срок вклада в месяцах: ");
            //int period = Convert.ToInt32(Console.ReadLine());
            //int i = period;

            //while (i > 0)
            //{
            //    sum += sum * 0.12M;
            //    i--;
            //}
            //Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            //Console.ReadKey();

            //--------------------------------------------
            //break завершает цикл полностью 
            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //сontinue прерывает одну итерацию (в цикле), если возникает указанное условие,
            //и продолжает следующую итерацию в цикле.
            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //    i++;
            //}


            //--------------------------------------------
            //Массив в C# — это конечное именованное множество переменных одного типа.
            //Массивы позволяют удобно группировать информацию и получать доступ к
            //ней.
            //Массивы могут быть одномерными,многомерными(двумерные, трехмерные, зубчатые).
            //Чтобы создать массив, нужно сначала объявить переменную массива
            //требуемого типа.

            //тип_переменной[] название_массива;

            //string[] stringsArray;

            //Одномерные массивы
            //string[] stringsArraytTwo = new string[4];

            //int[] nums1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            //int[] nums2 = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 , 11 };

            //int[] nums3 = new[] { 1, 22, 3, 5, 6, 7, 8 };

            //int[] nums4 = { 1, 2, 3, 5, 6, 7, 8 };

            //Все перечисленные выше способы будут равноценны.

            //Задание объявите массив double состоящий из 5 элементов

            //Для обращения к элементам массива используются индексы.
            //Индекс представляет номер элемента в массиве, при этом нумерация начинается с нуля,
            //Индекс первого элемента будет равен 0.

            //var n = nums3[0];
            //Console.WriteLine(n);

            //nums4[1] = 48888;


            //double[] nums3 = new[] { 1.1, 2.2, 3.3 };
            //nums3[0] = 1.4;
            //nums3[1] = 1.4;
            //nums3[2] = 1.4;


            //Console.WriteLine(nums2[12]);// Error длина массива меньше


            //Console.WriteLine(nums1.Length);

            //--------------------------------------------
            //int[] numbers = { 1, 2, 3, 4, 5, 8 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //--------------------------------------------

            //string[] substrings = { "hello", "GOODbYE", "Test" };
            int[] nums3 = new[] { 1, 22, 3, 5, 6, 7, 8 };

            Array.Reverse(nums3);

            int i = 0;
            while (i < nums3.Length)
            {
                Console.WriteLine(nums3[i]);
                i++;
            }
            //--------------------------------------------

            //foreach (var item in substrings)
            //{
            //    Console.Write($"{item} ");
            //}

            //Двумерные массивы
            //int[,] nums1;
            //int[,] nums2 = new int[2, 3];
            //int[,] nums3 = new int[2, 4] { { 0, 1, 2, 3 }, { 3, 4, 5, 3 } };
            //int[,] nums4 = new int[,] { { 0, 1, 2 ,0, 1 }, { 3, 4, 5, 0, 1 } }; //array
            //int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            //int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            //--------------------------------------------


            //Console.WriteLine(nums3[1, 2]);  // вернётся 1

            // доступ к третьему элементу второй строки
            //Console.WriteLine(nums3[1, 2]);  // вернётся 5

            // доступ к третьему элементу первой строки
            //Console.WriteLine(nums3[0, 2]);  // вернё


            //--------------------------------------------


            //int[,] numbers = { { 2, 3 }, { 4, 5 } };

            //// старый элемента
            //Console.WriteLine("Old element at index [0, 0] : " + numbers[1, 1]);

            //// присваивание нового значения
            //numbers[1, 1] = 50;

            //// новый элемент
            //Console.WriteLine("New element at index [0, 0] : " + numbers[1, 1]);

            //--------------------------------------------

            //foreach (var i in nums3)
            //{
            //    Console.Write($"{i} ");
            //}
            //--------------------------------------------

            //int[,] myArr = new int[4, 5];

            //Random ran = new Random();

            ////Инициализируем данный массив
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        myArr[i, j] = ran.Next(1, 15);
            //        Console.Write($"{myArr[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            //--------------------------------------------

            ////Трёхмерные массивы
            //int[,,] nums3 = new int[2, 3, 4];

            //int[,,] myArr = new int[6, 6, 6];

            //Random ran = new Random();

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            myArr[i, j, k] = ran.Next(1, 15);
            //            Console.Write($"{myArr[i, j, k]}\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int i in myArr)
            //{
            //    Console.Write($"{i} ");
            //}

            //Зубчатый массив 
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2 };
            //numbers[1] = new int[] { 1, 2, 3 };
            //numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int[] row in numbers)
            //{
            //    foreach (int number in row)
            //    {
            //        Console.Write($"{number} \t");
            //    }
            //    Console.WriteLine();
            //}

            //класс Array https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-7.0

            //виды сортировки массива https://programm.top/c-sharp/algorithm/array-sort

        }
    }
}