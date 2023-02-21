namespace Practice
{
    //stuct имя {
    //....
    //}
    struct PersonStruct
    {

        public string name;
        public int age;

        public PersonStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public PersonStruct()
        {
            name = "Artem";
            age = 1;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

    }
}