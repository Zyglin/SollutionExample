namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Привет");
            //Console.WriteLine("Добро пожаловать в C#");
            //--------------------------------------------


            //string name = Console.ReadLine(); // вводим имя
            //Console.WriteLine($"Привет {name}"); // выводим имя на консоль

            //--------------------------------------------
            /*
                Пример 
                многострочного
                комментария
             */
            //--------------------------------------------
            //int main = 10;
            //int Main = 12;
            //int MAIN = 13;
            //Console.WriteLine(main);
            //Console.WriteLine(Main);
            //Console.WriteLine(MAIN);
            //--------------------------------------------

            //string name = "Artem";
            //int number = 15;
            //bool flag = false;

            //--------------------------------------------

            //Console.WriteLine(true);
            //Console.WriteLine(false);

            //--------------------------------------------
            //○ целые числа в десятичной форме
            //Console.WriteLine(-11);
            //Console.WriteLine(5);
            //Console.WriteLine(505);
            //https://calculatori.ru/perevod-chisel.html
            //○ числа в двоичной форме
            //Console.WriteLine(0b11); // 3
            //Console.WriteLine(0b1011); // 11
            //Console.WriteLine(0b100001); // 33

            // ○ числа в шестнадцатеричной форме
            //Console.WriteLine(0x0A); // 10
            //Console.WriteLine(0xFF); // 255
            //Console.WriteLine(0xA1); // 161
            // ○ вещественные числа с фиксированной запятой
            //Console.WriteLine(3.14);
            //Console.WriteLine(100.001);
            //Console.WriteLine(-0.38);
            //○ обычные символы
            //Console.WriteLine('d');
            //Console.WriteLine('A');
            //Console.WriteLine('T');
            //○ управляющие последовательности
            //‘/ n' - перевод строки
            //‘/ t' - табуляция
            //‘/ ' - обратный слеш
            //  Строковые литералы
            //Console.WriteLine("hello");
            //Console.WriteLine("Компания \"Рога и копыта\"");
            //Console.WriteLine("Привет \nмир");
            //Console.WriteLine("Привет \tмир");
            //--------------------------------------------
            //// типы данных
            //bool flag = false;
            //bool secondFlag = true;
            ////байты
            //byte bt = 0;
            //byte bt2 = 25;
            //sbyte sbt = -128;
            //sbyte sbt2 = 12;
            //// целочисленные
            //short sh = -32768;
            //short sh2 = 32767;
            //ushort ush = 0;
            //ushort ush2 = 65535;
            //int i = -2147483648;
            //int i2 = 2147483647;
            //uint ui = 0;
            //uint ui2 = 4294967295;
            //long l = -9223372036;
            //long l2 = 922337203685477580;
            //ulong ul = 0;
            //ulong ul2 = 18446744073709551615;
            ////вещественные
            //float f = 12.3f;
            //double d = 124.412;
            //decimal dc = 1005.8M;
            //char ch = 'a';
            //string s = null;
            //s = "hello";
            //object o = 1;
            //object o2 = "2asdasd";
            //object o3 = 'l';
            //object o4 = 12.4;
            //--------------------------------------------
            // null предствляет ссылку которая не указывает ни на какой объект
            // работает онли с ссылочными типами
            //s = null;
            //o = null;
            //--------------------------------------------
            //неявная типизация
            //var hello = "Hellо to World";
            //var c = 20;
            //var j = 'g';
            //--------------------------------------------
            //Преобразование значений ввода
            //Console.Write("Введите возраст: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите рост: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите размер зарплаты: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());
            //--------------------------------------------
            //Арифметические операции
            //Приоритет операций от наивысшего к низшему
            //1.Инкремент, декремент
            //2.Умножение, деление, получение остатка
            //3.Сложение, вычитание
            //4.Операции присвоения имеют самый низкий приоритет.
            //Все арифметические операторы(кроме префиксного инкремента и
            //декремента) являются левоассоциативными!
            //int x = 1;
            //Console.WriteLine(++x);
            //Console.WriteLine(x);
            //Console.WriteLine("--------------------------------------------");
            //int g = 1;
            //Console.WriteLine(g++);
            //Console.WriteLine(g);
            //int x = 1;
            //Console.WriteLine(--x);
            //Console.WriteLine(x);
            //Console.WriteLine("--------------------------------------------");
            //int g = 1;
            //Console.WriteLine(g--);
            //Console.WriteLine(g);
            //int x = 7 * 12;
            //int u = 20 / 10;
            //int proc = 12 % 5;
            //Console.WriteLine(x);
            //Console.WriteLine(u);
            //Console.WriteLine(proc);
            //int plus = 7 + 12;
            //int minus = 15 - 12;
            //Console.WriteLine(minus);
            //Console.WriteLine(plus);
            //double d = 0;
            //int x = 10 / (5 * 2);
            //Console.WriteLine(x);
            //--------------------------------------------
            //int number = 23;
            //int a, b, c;
            //a = b = c = 34;
            //--------------------------------------------
            //Операции присваивания
            //int x = 12;
            //// x = x+3
            //x += 3;

            //int g = 12;
            //// g = g-3
            //g -= 3;

            //int v = 12;
            //// v = v+3
            //v *= 3;

            //int o = 12;
            //// v = v/3
            //o /= 3;
            //Console.WriteLine(x);
            //Console.WriteLine(g);
            //Console.WriteLine(v);
            //Console.WriteLine(o);
            //Преобразование базовых типов
            //byte a = 4;
            //int b = a + 70; // 74
            //Console.WriteLine(b);
            //int b = 30;
            //Console.WriteLine(b);
            //byte a = 4;
            //byte b = (byte)(a + 70);
            //Потеря данных и ключевое слово checked
            //int a = 33;
            //int b = 600;
            //byte c = (byte)(a + b);
            //Console.WriteLine(c);

            //try
            //{
            //    int a = 33;
            //    int b = 600;
            //    byte c = checked((byte)(a + b));
            //    Console.WriteLine(c);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Упаковка и распаковка
            //int i = 123;
            //object o = i;

            //o = 123;
            //i = (int)o;

            //Console.WriteLine(o);
            //Console.WriteLine(i);
            //--------------------------------------------

            //условные конструкции
            //int num1 = 7;
            //int num2 = 5;

            //if (num1 > num2)
            //{
            //    Console.WriteLine($"Число {num1} больше {num2} числа");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {num1} меньше числа {num2}");
            //}

            //--------------------------------------------


            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2 || num2 > 5 || num1 > 7)
            //{
            //    Console.WriteLine($"Число {num1} больше числа {num2}");
            //}


            //--------------------------------------------


            //int num1 = 8;
            //int num2 = 6;
            //Console.WriteLine(num1 > num2);
            //Console.WriteLine(num1 >= num2);
            //Console.WriteLine(num1 < num2);
            //Console.WriteLine(num1 <= num2);
            //Console.WriteLine(num1 > num2 && num1 == 8); // true true  result: true
            //Console.WriteLine(num1 > num2 && num1 == 8 && num2 == 6); //  true  true true  result: true
            //Console.WriteLine(num1 > num2 && num1 == 8 && num2 != 6); // true true false  result: false
            //Console.WriteLine(num1 < num2 || num1 == 8); // false || true  result :true 
            //Console.WriteLine(num1 < num2 || num1 != 8); // false || false  result :false 
            //Console.WriteLine(num1 != num2);

            //--------------------------------------------

            //int num1 = 8;
            //int num2 = 6;

            //if (num1 > num2 && !(num1 == 8)) // true false  result :false
            //{
            //    Console.WriteLine($"Число {num1} больше числа {num2}");
            //}
            //else
            //{
            //    Console.WriteLine("else");
            //}

            //--------------------------------------------

            //int x = 3;
            //int y = 2;

            //int z = x < y ? (x + y) : (x - y); 

            //if (x < y)
            //{
            //    Console.WriteLine(x + y);
            //}
            //else
            //{
            //    Console.WriteLine(x - y);
            //}

            //Console.WriteLine(z);   

            //switch case конструкция


            //string name = "Artem";

            //switch (name)
            //{
            //    case "Yuri":
            //        Console.WriteLine("Ваше имя - Yuri");
            //        break;
            //    case "Artem":
            //        Console.WriteLine("Ваше имя - Artem");
            //        break;
            //    case "Evgeniy":
            //        Console.WriteLine("Ваше имя - Evgeniy");
            //        break;
            //    default:
            //        Console.WriteLine("Неизвестное имя");
            //        break;
            //}


            //--------------------------------------------

            //int number = 4;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        goto case 5;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    case 5:
            //        Console.WriteLine("5");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}

            //int number = 3;
            //switch (number)
            //{
            //    case 1:
            //    case 3:
            //        Console.WriteLine(" 1 или 3");
            //        break;
            //    case 5:
            //        Console.WriteLine("5");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}

        }
    }
}