using Moq;
using UnitTESTS.Controllers;

namespace WebApplication2Tests.UnitTests
{
    //тело теста формируется по паттерну ААА
    //Arrange - подготовка данных для тестирования 
    //Act - то действие которое мы тестируем
    //Assert - проверка результата  выполнения действия 



    // использование конструктора это не лучший подход.


    //Правила Именования теста: [ТестируемыйМетод_Сценарий_ОжидаемыйРезультат]


    // Признаки хорошего юнит теста 
    // 1) Защита от багов
    // 2) Устойчиваость к рефакторингу
    // 3) Быстрая обратная связь
    // 4) Простота поддержки

    // Существует совместная внепроцесорная зависимость.Иногда чтобы выполнить юнит тест
    // нам нужно заменить эти зависимости заглушками.Чтобы протестировать поведение без учёта работы зависимостей.
    // Заглушка - это общий термин описывающий любые разновидности фиктивных зависимостей,
    // используемых в тестах (Moq)
    // Moq - инструмент позволяющий использовать заглушки

    public class HomeControllerTests
    {
        //private MyClass _data;

        //public HomeControllerTests()
        //{
        //    _data = new MyClass(10);
        //}

        //[Fact]
        //public void Sum_SumOfTwoNumbers_ReturnsSum()
        //{
        //    //Arrange
        //    double first = 10;
        //    double second = 20;

        //    var sut = new HomeController();

        //    // Act 
        //    double result = sut.Sum(first, second);

        //    // Assert
        //    Assert.Equal(30, result);

        //    // Assert позволяет проверить резултат теста 

        //    // стоит избегать в Юнит тестах команду if, это является антипаттерном.
        //    // Тест должен быть простым и без ветвлений. В таком случае лучше разбить тест
        //    // на несколько тестов

        //    // Arrange  самая большая секция 
        //    // Act обычно состоит из одной строки 

        //    // в тестах так же могут быть конкструкторы 
        //}

        //[Fact]
        //public void Test2()
        //{
        //    double first = 10;
        //    double second = 20;

        //    var sut = new HomeController();


        //    double result = sut.Sum(first, second);


        //    Assert.Equal(30, result);
        //}

        //class MyClass
        //{
        //    private int _val;
        //    public MyClass(int val)
        //    {
        //        _val = val;
        //    }
        //}


        // тест вызовется 4 раза 
        //[Theory]
        //[InlineData(1, 20, "Egor")]
        //[InlineData(1, 21, "Maks")]
        //[InlineData(1, 22, "Tom")]
        //[InlineData(1, 23, "Ivan")]
        //public void GetUser_ReturnsUserAge20AndMore(int id, int age, string name)
        //{
        //    var sut = new HomeController();

        //    var result = sut.GetUser(id, age, name);

        //    Assert.NotEqual("Default", result.Name);

        //}

        [Fact]
        public void GetCarsInfo_CarsInformation_ReturnDbCars()
        {
            //Arrenge
            var mock = new Mock<IRepository>();
            // Здесь предполагалось обращение к базе данных но у нас заглушка
            mock.Setup(repo => repo.GetCars()).Returns(GetCarsColl);
            var sut = new HomeController(mock.Object);

            ////Act
            var result = sut.GetCarsInfos();

            //Assert
            Assert.NotNull(result);
        }

        private IEnumerable<Car> GetCarsColl()
        {
            return new List<Car> {
            new Car{ Id = 1, Name = "Audi", Year = 2004},
            new Car{ Id = 1, Name = "Honda", Year = 2020},
            };
        }

    }
}
