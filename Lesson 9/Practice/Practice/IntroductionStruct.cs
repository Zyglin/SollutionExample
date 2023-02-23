namespace Practice
{
    struct IntroductionStruct
    {
        public void Intro()
        {
            Console.WriteLine("\tДобро пожаловать в БАНК");
        }
        internal void Loading()
        {
            Console.Write("Загрузка");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
        }
    }
}