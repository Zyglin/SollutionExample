namespace Practice
{
    //Все классы по умолчанию могут наследоваться.
    //класс может наследоваться только от одного класса. Но класс может наследовать(реализовывать) несколько интервейсов.
    class Figure
    {

        public string Type { get; set; }
        public virtual string Color { get; set; }
        public string Name { get; set; }


        public Figure(string name)
        {
            Type = "Фигура";
            Color = "Красный";
            Name = name;
        }

       // Полиморфизм [модификатор доступа] virtual тип имя { .... }
       public virtual void ShowSquare() 
       {
            Console.WriteLine("Я обычная фигура ничего не знаю, досвидания");
       }
    }

    //С помощью ключевого слова base мы можем обратиться к базовому классу. И что то там переопределить

    //sealed
}