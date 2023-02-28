using System;
using System.Runtime.ConstrainedExecution;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLR
            //CTS
            //FCL
            //CLS
            //Что такое пространство имен(namespace) и зачем это нужно?
            //Ссылочные и значимые типы
            //Что такое класс?
            //Чем отличается класс от абстрактного класса?
            //Чем отличается абстрактный класс от интерфейса? Для чего нужны интерфейсы и какие задачи они выполняют?
            //В чем разница между обычным классом и статическим?
            //Модификаторы доступа
            //Полиморфизм и остальная магия методов
            //Конструкторы
            //Строки


            //Иногда при выполнении программы возникают ошибки, которые трудно предусмотреть или предвидеть, очень часто бывает такое что это нереально.


            //int num = 522;
            //int result = num / 0;
            //Console.WriteLine($"Результат: {result}");
            //Console.WriteLine("Конец программы");


            /*
             try
            {
                ... код в котором может случиться ошибка
            }
             catch
            {
                ... то что будет происходить если случилась ошибка
            }
             finally
            {
                ... всегда будет выпонена в самом конце
            } 

             */


            //try
            //{
            //    int num = 522;
            //    int result = num / 1;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch
            //{
            //    Console.WriteLine("Возникло исключение!");
            //}
            //finally
            //{
            //    Console.WriteLine("Блок finally всегда выполняется в конце один раз");
            //}
            //Console.WriteLine("Конец программы");



            //try
            //{
            //    int num = 522;
            //    int result = num / 0;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch
            //{
            //    Console.WriteLine("Возникло исключение!");
            //}
            //Console.WriteLine("Конец программы");




            //try
            //{
            //    int num = 522;
            //    int result = num / 0;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //finally
            //{
            //    Console.WriteLine("Блок finally всегда выполняется в конце один раз");
            //}
            //Console.WriteLine("Конец программы");



            //За обработку исключения отвечает блок catch

            //catch
            //{
            //    // выполняемые инструкции
            //}

            //Обрабатывает определённый тип исключения

            //catch (тип_исключения)
            //{
            //    // выполняемые инструкции
            //}

            //try
            //{
            //    int num = 522;
            //    int result = num / 0;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("исключение DivideByZeroException");
            //}


            //возникнут исключения каких - то других типов, отличных от DivideByZeroException то их не обработают


            //var num = new int[10];
            //num[12] = 12;
            //Console.WriteLine($"Результат: {num}");


            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("исключение IndexOutOfRangeException");
            //}

            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("исключение IndexOutOfRangeException");
            //}
            //catch
            //{
            //    Console.WriteLine("исключение");
            //}


            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("исключение IndexOutOfRangeException");
            //}
            //catch
            //{
            //    Console.WriteLine("исключение");
            //}


            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch
            //{
            //    Console.WriteLine("исключение");
            //}
            //catch
            //{
            //    Console.WriteLine("исключение 2");
            //}


            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("исключение IndexOutOfRangeException");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("исключение DivideByZeroException");
            //}


            //try
            //{
            //    var num = new int[10];
            //    num[12] = 12;
            //    Console.WriteLine($"Результат: {num}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"исключение  и текст исключения{ex.Message}");
            //}

            //Фильтры исключений
            //Для их применения после выражения catch идет выражение when

            //int num = 1;

            //try
            //{
            //    int result = 522 / num;
            //    var arr = new int[10];
            //    arr[12] = 12;
            //    Console.WriteLine($"Результат: {arr.Length}");
            //}
            //catch (DivideByZeroException) when (num == 0)
            //{
            //    Console.WriteLine("num не должен быть равен 0");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Базовым для всех типов исключений является тип Exception


            //int num = 0;
            //try
            //{
            //    int result = 522 / num;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"num не должен быть равен {ex.Message}");
            //}


            //У него есть свойства:
            //InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения

            //Message: текст ошибки

            //StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения

            //TargetSite: возвращает метод, в котором и было вызвано исключение

            //try
            //{
            //    int num = 522;
            //    int result = num / 0;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //    Console.WriteLine($"Исключение: {ex.Message}");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //    Console.WriteLine($"Исключение Исключение: {ex.InnerException}");
            //}



            //DivideByZeroException: представляет исключение, которое генерируется при делении на ноль

            //ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений

            //ArgumentException: генерируется, если в метод для параметра передается некорректное значение

            //IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений

            //InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов

            //NullReferenceException: генерируется при попытке обращения к объекту, который равен null(то есть по сути неопределен)


            //Мы можем  генерировать исключения вручную с помощью оператора throw.
            //То есть с помощью этого оператора мы сами можем создать исключение и вызвать его
            //в процессе выполнения.

            //try
            //{
            //    Console.Write("Введите возраст: ");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age > 100 || age < 0)
            //    {
            //        throw new Exception("Не верный возраст");
            //        //throw new Exception("asdsadasdsad")
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Ваш возраст: {age}");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}

            // Задача. Введите пароль в одну переменную  и подтвержение этого пароля во вторую перменную.
            // Если переменные равны то всё хорошо конец программы.
            // Если пароли не равны генерируйте исключение  "Пароли не равны!!!!"
            // Если во время программы произошла ошибка обрабатывайте это исключение  в отдельном блоке catch


            //try
            //{
            //    try
            //    {
            //        Console.Write("Введите возраст: ");
            //        int age = int.Parse(Console.ReadLine());
            //        if (age > 100 || age < 0)
            //        {
            //            throw new Exception("Не верный возраст");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Ваш возраст: {age}");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Ошибка: {e.Message}");
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}

            //исключение будет передано дальше внешнему блоку catch, который получит то же самое исключение и выведет то же самое сообщение на консоль.

            //Мы можем создать свои типы исключений. Базовым классом для всех исключений является класс Exception,
            //соответственно для создания своих типов мы можем унаследовать данный класс.

            try
            {
                var password = new Password { Value = "qwerty", ConfirmPassword = "qwerty" };
                Console.WriteLine("Пароли совпадают всё хорошо");
            }
            catch (PasswordException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


        }
    }
}