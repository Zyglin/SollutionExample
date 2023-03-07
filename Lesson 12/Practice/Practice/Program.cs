using System.Security.Principal;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Делегат - это тип, который представляет собой ссылки на методы с определенным списком
            //параметров и возвращаемым типом.

            //При создании экземпляра делегата этот экземпляр можно связать с любым методом с
            //совместимой сигнатурой и возвращаемым типом.

            //Метод можно вызвать(активировать) с помощью экземпляра делегата.

            //Поскольку созданный экземпляр делегата является объектом, его можно передавать как
            //параметр или назначать свойству.

            //Это позволяет методу принимать делегат в качестве параметра и вызывать делегат в
            //дальнейшем.

            //Для объявления делегата используется ключевое слово delegate, после которого идет возвращаемый тип, название и параметры.Например:

            //DelegateExample example;            // 2. Создали переменную делегата
            //example = HelloAll;            // 4. Присваиваем адрес метода переменной делегата
            //example();                 // 5. Вызываем метод через переменную делегата

            //HelloAll();

            //void HelloAll() { Console.WriteLine("Hello Net06"); } //3. Создали метод 
            //-----------------------------------------------------------------

            //DefaultOperation operation;
            //operation = Sum;               // делегат указывает на метод Sum
            //int result = operation(6, 7, 8);   // то же самое что и Sum(6, 7, 8)
            //Console.WriteLine(result);

            //operation = Multiply;           // теперь делегат указывает на метод Multiply
            //result = operation(4, 5, 9);       // то же самое что и Multiply(4, 5, 9)
            //Console.WriteLine(result);


            //int Multiply(int x, int y, int z) => x * y * z;

            //int Sum(int x, int y, int z) => x + y + z;


            //DefaultOperation operationOne = Sum;

            //var operationSecond = new DefaultOperation(Sum); //  оба способа равноценны 

            //Console.WriteLine(operationOne(1, 2, 3));
            //Console.WriteLine(operationSecond(1, 2, 3));


            //Задание создать делегат  DefaultOperation с тремя параметрами и возвращаемым типом int,
            //Присвоить делегату два метода для Вычитания и Деления.


            //Делегат может указывать на множество методов, которые имеют ту же сигнатуру и возвращаемые тип.
            //Все методы в делегате попадают в специальный список invocation list.!!!!!!!
            //При вызове делегата все методы из этого списка последовательно вызываются.
            //Для добавления методов в делегат применяется операция +=.

            //ShowMessage message = HelloProgrammers;
            //message += HelloQa;  // теперь message указывает на два метода

            //void HelloProgrammers() => Console.WriteLine("Hello Programmers");
            //void HelloQa() => Console.WriteLine("Hello Qa");

            //message += HelloQa;

            //message();

            //Задание создайте делегат, прикрутите к нему 3 метода и вызовите.

            //ShowMessage messageOne = HelloProgrammers;
            //ShowMessage messageTwo = HelloQa;
            //ShowMessage showMessagemessageThree = messageOne + messageTwo;

            //void HelloProgrammers() => Console.WriteLine("Hello Programmers");
            //void HelloQa() => Console.WriteLine("Hello Qa");

            //showMessagemessageThree(); // делегаты можно объединять

            ////Обобщённый делегат
            //DefaultOperationGeneric<double, int> squareOperation = SquareNum;
            //var result = squareOperation(5);
            //Console.WriteLine(result);  

            //double SquareNum(int n) => n * n;

            //Задание создать обобщёный делегат,
            //который на вход принимает два инта а на выход отдаёт строку.
            //--------------------------------------------------------------
            //Задание создать обобщёный делегат,
            //который на вход принимает 4 инта( нужно перемножить) а на выход отдаёт decimal.


            //С делегатами тесно связаны анонимные методы. Анонимные методы используются для создания экземпляров делегатов.
            //Определение анонимных методов начинается с ключевого слова delegate,
            //после которого идет в скобках список параметров и тело метода в фигурных скобках.

            //delegate (параметры)
            //{
            //    ....код
            //}

            //Анонимный метод не может существовать сам по себе, он используется для инициализации экземпляра делегата,
            //как в данном случае переменная anonymous представляет анонимный метод.

            //AnonymousDelegate anonymous = delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //};

            //AnonymousDelegateSecond anonymousSecond = delegate
            //{
            //    Console.WriteLine("Hello");
            //};

            //anonymous("Hello Programmers");
            //anonymousSecond();


            //Задание создать аноноимный метод с 2 инт параметрами присвоить этот метод делегату. Внутри
            //Анонимного метода вывести сумму вычитание умножение и деление этих чисел.


            //DefaultOperation operation = delegate (int x, int y, int z)
            //{
            //    return x + y + z;
            //};
            //int result = operation(4, 5, 8);
            //Console.WriteLine(result);


            //Если анонимный метод использует параметры, то они должны соответствовать параметрам делегата.
            //Если для анонимного метода не требуется параметров,
            //то скобки с параметрами опускаются.


            //delegate
            //{
            //    ....код
            //}

            //Задание создайте делегат, прикрутите к нему анонимный метод на вычитание и вызовите.



            //Лямбда-выражения представляют упрощенную запись анонимных методов.
            //(параметрЫ) => выражение
            //С точки зрения типа данных лямбда-выражение представляет делегат


            //AnonymousDelegate anonymous = delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //};

            //AnonymousDelegate anonymous =  (string mes) => Console.WriteLine(mes);
            //anonymous("Hello Programmers");


            //DefaultOperation operation = (int x, int y, int z) => x + y + z;
            //int result = operation(4, 5, 8);
            //Console.WriteLine(result);

            //Задание cоздать лямда выражение которок преобразует строку из прописных букв в заглавные.
            //Присвоить делегату и вызвать.


            ////если мы напишем var  и не прокинем параметры по умолчанию компилятор будет рассматривать как переменную встроенного делегата Action,
            ////который не принимает никаких параметров и ничего не возвращает.

            var helloAllProgrammers = () => Console.WriteLine("Hello All Programmers");
            //var showMessageExample = () => Console.WriteLine("Hello all Guys ");
            //showMessageExample += () => Console.WriteLine("Hello all Delegates"); // добавляем лямбда-выражение
            //showMessageExample += helloAllProgrammers;   // добавляем лямбда-выражение из переменной helloAllProgrammers

            //showMessageExample -= helloAllProgrammers;

            //showMessageExample();

            /////------------------------------
            //var sum = (int g, int f) => g + f;
            //int result = sum(6, 75);
            //Console.WriteLine(result);
            ////Если лямбда-выражение содержит несколько строк кода, тогда нужно использовать оператор return, как в обычных методах
            //var exampleWithReturn = (int g, int f) =>
            //{
            //    if (g > f) return g + g;
            //    else return g - f;
            //};

            //Лямбда-выражение как результат метода
            //DefaultOperation operation = SelectOperation(OperationType.Add);
            //Console.WriteLine(operation(9, 5, 12));

            //operation = SelectOperation(OperationType.Subtract);
            //Console.WriteLine(operation(9, 5, 1));

            //operation = SelectOperation(OperationType.Multiply);
            //Console.WriteLine(operation(9, 5, 3));

            //DefaultOperation SelectOperation(OperationType enumType)
            //{
            //    switch (enumType)
            //    {
            //        case OperationType.Add: return (x, y, z) => x + y + z;
            //        case OperationType.Subtract: return (x, y, z) => x - y - z;
            //        default: return (x, y, z) => x * y * z;
            //    }
            //}

            //События сигнализируют системе о том, что произошло определенное действие.
            //И если нам надо отследить эти действия, то как раз мы можем применять события.

            //var bank = new Bank(100);
            //bank.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            //bank.NotifySecond += DisplayMessageForSecondEvent;
            //bank.Put(40);    // добавляем на счет 40
            //Console.WriteLine($"Сумма на счете: {bank.Sum}");
            //bank.Take(60);   // пытаемся снять со счета 60
            //Console.WriteLine($"Сумма на счете: {bank.Sum}");
            //bank.Take(10000);  // пытаемся снять со счета 10000
            //Console.WriteLine($"Сумма на счете: {bank.Sum}");

            //void DisplayMessage(string message)
            //{
            //    Console.WriteLine(message);
            //}

            //void DisplayMessageForSecondEvent(string message, string name)
            //{
            //    Console.WriteLine(message);
            //    Console.WriteLine(name);
            //}

            //В.NET есть несколько встроенных делегатов, которые используются в различных ситуациях.
            //И наиболее используемыми, с которыми часто приходится сталкиваться, являются Action, Predicate и Func.
            //Делегат Action представляет некоторое действие, которое ничего не возвращает, то есть в качестве возвращаемого типа имеет тип void:
            //Делегат Predicate<T> принимает один параметр и возвращает значение типа bool
            Predicate<double> isNegative = (double x) => x < 0;

            Console.WriteLine(isNegative(20));
            Console.WriteLine(isNegative(-20));

            //Еще одним распространенным делегатом является Func. Он возвращает результат действия и может принимать параметры.
            Func<int, int, double> createDoubleSum = (a, b) => a + b;
            Console.WriteLine(createDoubleSum(1, 5));
            Console.WriteLine(createDoubleSum(3, 5));

        }
    }
}