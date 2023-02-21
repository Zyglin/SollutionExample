namespace Practice
{
    // abstact class имя
    // {
    //....
    // }

    ////Главное отличие абстрактных классов от обычных состоит в том, что мы НЕ можем использовать конструктор абстрактного класса для создания экземпляра класса.
    ////Например, следующим образом:
    // Person artem = new Person();
    ////абстрактные классы нужны для описания общего функционала, который могут наследовать и использовать производные классы.
    //abstract class Person
    //{
    //    public abstract int Name { get; set; }
    //    public abstract void Eat();

    //}

    //class Doctor : Person
    //{
    //    public override int Name { get; set; }
    //    // мы должны реализовать все абстрактные методы и свойства базового класса
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Доктор кушает");
    //    }
    //}

    //class Engineer : Person
    //{
    //    public override int Name { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Инженер кушает");
    //    }
    //}

    //class Builder : Person
    //{
    //    public override int Name { get; set; }

    //    public override void Eat()
    //    {
    //        Console.WriteLine("Строитель кушает");
    //    }
    //}



    //abstract class Person : IPersonService
    //{
    //    public abstract void Move();

    //    public abstract void Move();
    //}
    //class Driver : IPersonService
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Водитель едет");
    //    }

    //    public void Sleep()
    //    {
    //        Console.WriteLine("Водитель спит");
    //    }
    //}

    //Интерфейс - ссылочкный тип, который определяет какой-то функционал,
    //где в качестве функционала выстпуает набор методов и свойств.
    //Без реализации
    //Интерфейсы, как и классы, могут наследоваться
    //interface IRunable : IPersonService
    //{
    //    void Run();
    //}
    //class Runner : IRunable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Move");
    //    }

    //    public void Run()
    //    {
    //        Console.WriteLine("Run");
    //    }

    //    public void Sleep()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //в отличие от классов мы не можем применять к интерфейсам модификатор sealed, чтобы запретить наследование интерфейсов.


}