using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(char.GetNumericValue('8')); // 8
            //Console.WriteLine(char.GetNumericValue('d')); // -1
            //Console.WriteLine(char.GetNumericValue('\t')); // -1

            //https://learn.microsoft.com/ru-ru/dotnet/api/system.globalization.unicodecategory?view=net-7.0
            //Console.WriteLine(char.GetUnicodeCategory('a'));
            //Console.WriteLine(char.GetUnicodeCategory('2'));
            //Console.WriteLine(char.GetUnicodeCategory(','));

            //Console.WriteLine(char.IsDigit('8'));
            //Console.WriteLine(char.IsDigit('s'));

            //Console.WriteLine(char.IsLetter('d'));
            //Console.WriteLine(char.IsLetter('0'));

            //Console.WriteLine(char.IsLetterOrDigit('8'));
            //Console.WriteLine(char.IsLetterOrDigit('a'));
            //Console.WriteLine(char.IsLetterOrDigit('-'));

            //Console.WriteLine(char.IsLower('A'));
            //Console.WriteLine(char.IsLower('c'));

            //Console.WriteLine(char.IsUpper('A'));
            //Console.WriteLine(char.IsUpper('c'));

            //Console.WriteLine(char.IsNumber('-'));
            //Console.WriteLine(char.IsNumber('a'));
            //Console.WriteLine(char.IsNumber('0'));

            //Console.WriteLine(char.IsPunctuation('-'));
            //Console.WriteLine(char.IsPunctuation('.'));
            //Console.WriteLine(char.IsPunctuation(','));
            //Console.WriteLine(char.IsPunctuation(':'));
            //Console.WriteLine(char.IsPunctuation('0'));
            //Console.WriteLine(char.IsPunctuation('`'));

            //Console.WriteLine(char.IsWhiteSpace(' '));
            //Console.WriteLine(char.IsWhiteSpace('a'));
            //Console.WriteLine(char.IsWhiteSpace('\t'));
            //Console.WriteLine(char.IsWhiteSpace('\n'));

            //Console.WriteLine(char.Parse("h"));
            //Console.WriteLine(char.Parse("8"));
            //var charVariable = char.Parse("h");

            //Console.WriteLine(char.ToLower('A'));
            //Console.WriteLine(char.ToLower('2'));

            //Console.WriteLine(char.ToUpper('v'));
            //Console.WriteLine(char.ToUpper('1'));



            //В языке C# определен класс char[], и его можно использовать для представления строк постоянной
            //длины.

            //char[] letters = { 'A', 'B', 'C' };
            //int number = 12;
            //string alphabet = new string(letters);
            //Console.WriteLine(alphabet); // ABC
            //Console.WriteLine(alphabet.GetType());
            //Console.WriteLine(number.GetType());


            //Строки 
            // В языке C# строковые значения представляет тип string, а вся функциональность работы с данным
            //типом сосредоточена в классе System.String.Максимальный размер объекта String может
            //составлять в памяти 2 ГБ, или около 1 миллиарда символов.

            //string s1 = "hello";
            //string s2 = null;
            //int? a = null;

            //Применяя индексатор, мы можем обратиться к строке как к массиву символов и получить по индексу
            //любой из ее символов:
            //string s1 = "helloasdjaskdjlasdjlasjdlsa";
            //char ch1 = s1[2];
            //Console.WriteLine(ch1);
            //Console.WriteLine(s1.Length);
            //? :
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    Console.Write(s1[i] != 'a' && s1[i] != 'k' && s1[i] != 'd' ? s1[i].ToString() : "");
            //}


            //Задача 

            //Форматирование строк
            //string name = "Artem";
            //string age = "120";

            //Console.WriteLine("Имя: {0} Возраст: {1}", name, age);

            //// <=>

            //string output = string.Format("Имя: {0} Возраст: {1}", name, age);
            //Console.WriteLine(output);

            //В методе Format могут использоваться различные спецификаторы и описатели, которые позволяют
            //настроить вывод данных:

            // Форматирование целых чисел
            //Для форматирования целочисленных значение применяется описатель "d":
            //d-указывает минимальное количество цифр
            //int number = 234;
            ////string result = string.Format("{0:d}", number);
            ////Console.WriteLine(result); // 23
            //string result2 = string.Format("{0:d6}", number);
            //Console.WriteLine(result2); // 0023


            // Форматирование дробных чисел
            //Для форматирования дробны чисел используется описатель F, число после которого указывает,
            //сколько знаков будет использоваться после разделителя между целой и дробной частью.Если
            //исходное число - целое, то к нему добавляются разделитель и нули.
            //f-указывает количество десятичных разрядов после запятой
            //int number = 23;
            //string result = string.Format("{0:f}", number);
            //Console.WriteLine(result); // 23,00
            //double number2 = 45.08;
            //string result2 = string.Format("{0:f4}", number2);
            //Console.WriteLine(result2); // 45,0800
            //double number3 = 25;
            //string result3 = string.Format("{0:f2}", number3);
            //Console.WriteLine(result3); // 25,1


            //Формат процентов
            //Описатель "P" задает отображение процентов.Используемый с ним числовой спецификатор
            //указывает, сколько знаков будет после запятой:
            //decimal number = 0.15345m;
            //Console.WriteLine("{0:P4}", number);// 15.3%


            //Настраиваемые форматы
            //Используя знак #, можно настроить формат вывода. Например, нам надо вывести некоторое число в
            //формате телефона +х(ххх)ххх - хх - хх:
            //long number = 19876543210;
            //string result = string.Format("{0:+# (###)  ###-##-##}", number);
            //Console.WriteLine(result); // +1 (987) 654-32-10

            //string  multiText = ; 


            //Начиная с версии языка C# 6.0 была добавлена такая функциональность, как интерполяция строк.
            //string name = "Artem2131231232";
            //string age = "110";
            //Console.WriteLine($"Имя: {name} Возраст: {age}");

            //(Конкатенация)!!!!!! строк или объединение может производиться как с помощью операции +, так и с
            //помощью метода Concat:
            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = s1 + " " + s2; // результат: строка "hello world"\
            //string s4 = string.Concat(s3, "!!!");
            // результат: строка "hello world!!!"

            //Console.WriteLine(s4);


            //Для объединения строк также может использоваться метод Join:
            //string s5 = "apple";
            //string s6 = "day";
            //string s7 = "keeps";
            //string s8 = "doctor";
            //string s9 = "away";
            //string[] values = new string[] { s5, s6, s7, s8, s9 };


            //string symbolBetweenWords = "@@@@@";


            //string s10 = string.Join(symbolBetweenWords, values);
            //Console.WriteLine(s10);


            //string stringMulti = @"fasfasfasfasfdasdasflaskf;laskf
            //asfalskfa;skf;akfakf;aksfaksf
            //asdakslkkas;fka;fk;askfaksf
            //afkaslkf;askf;aks;fkasfasfk";

            //string a = "helsdasdasdasdasdlo";

            //Console.WriteLine(stringMulti);

            //Так же для сравнения строк применяется статический метод Compare:
            //string s1 = "world";
            //string s2 = "world";

            //int result = string.Compare(s2, s1);
            //if (result < 0)
            //{
            //    Console.WriteLine("Строка s1 перед строкой s2");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Строка s1 стоит после строки s2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки s1 и s2 идентичны");
            //}

            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = "world";
            //var result = s1.Equals(s2);
            //var resultTwo = s2.Equals(s3);
            //Console.WriteLine(result);
            //Console.WriteLine(resultTwo); !!!!!!!!!!!!
            //if(s1.Equals(s2))
            //{

            //}

            //string s1 = "hello world";
            ////char ch = 'o';
            ////int indexOfChar = s1.IndexOf(ch); // равно 4
            ////Console.WriteLine(indexOfChar);


            //string subString = "wor";
            //int indexOfSubstring = s1.IndexOf(subString); // равно 6
            //Console.WriteLine(indexOfSubstring);


            // StartsWith и EndsWith
            //string path = @"D:\SomeDir";
            //string[] files = Directory.GetFiles(path);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].EndsWith(".txt"))
            //    {
            //        File.Delete(files[i]);
            //    }
            //}


            //string text = "   hello world   ";
            //text = text.Trim(); // результат "hello world"
            //char[] chars = new char[] { 'd', 'h' };
            //text = text.Trim(chars); // результат "ello worl"
            //Console.WriteLine(text);

            //string text = "Хороший день";
            //// обрезаем начиная с третьего символа
            //text = text.Substring(2);
            //// результат "роший день"
            //Console.WriteLine(text);
            //// обрезаем сначала до последних двух символов
            //text = text.Substring(0, text.Length - 2);
            //// результат "роший де"
            //Console.WriteLine(text);


            //StringBuilder sb = new StringBuilder("Привет мир");

            //sb.Append("!");
            //sb.Insert(7, "компьютерный ");
            //// заменяем слово
            //sb.Replace("мир", "world");
            ////// удаляем 13 символов, начиная с 7-го
            //sb.Remove(7, 13);
            //// получаем строку из объекта StringBuilder
            //var s = sb.ToString();

            //Console.WriteLine(s);

            // StringBuilder vs String

            //Microsoft рекомендует использовать класс string в следующих случаях:
            //При небольшом количестве операций и изменений над строками
            //При выполнении фиксированного количества операций объединения. В этом случае
            //компилятор может объединить все операции объединения в одну
            //Когда надо выполнять масштабные операции поиска при построении строки, например
            //IndexOf или StartsWith. Класс StringBuilder не имеет подобных методов.



            //Класс StringBuilder рекомендуется использовать в следующих случаях:
            //При неизвестном количестве операций и изменений над строками во время выполнения
            //программы
            //Когда предполагается, что приложению придется сделать множество подобных операций



            // Рассмотрим вкратце некоторые элементы синтаксиса регулярных выражений:

            // ^: соответствие должно начинаться в начале строки(например, выражение @"^пр\w*" соответствует слову "привет" в строке "привет мир")

            //$: конец строки(например, выражение @"\w*ир$" соответствует слову "мир" в строке "привет мир", так как часть "ир" находится в самом конце)

            //.: знак точки определяет любой одиночный символ(например, выражение "м.р" соответствует слову "мир" или "мор")

            //*: предыдущий символ повторяется 0 и более раз

            //+: предыдущий символ повторяется 1 и более раз

            //?: предыдущий символ повторяется 0 или 1 раз

            //\s: соответствует любому пробельному символу

            //\S: соответствует любому символу, не являющемуся пробелом

            //\w: соответствует любому алфавитно - цифровому символу

            //\W: соответствует любому не алфавитно-цифровому символу

            //\d: соответствует любой десятичной цифре

            //\D: соответствует любому символу, не являющемуся десятичной цифрой


            //string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            //Regex regex = new Regex(@"туп(\w*)");
            //MatchCollection matches = regex.Matches(s);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //        Console.WriteLine(match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Совпадений не найдено");
            //}


            //string phoneNumberFirst = "456-435-2318";
            //string phoneNumberSecond = "26-35-2318";
            //Regex regex = new Regex(@"[a-zA-Z]");
            //MatchCollection matches = regex.Matches(phoneNumberSecond);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //        Console.WriteLine(match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Совпадений не найдено");
            //}


        }
    }
}