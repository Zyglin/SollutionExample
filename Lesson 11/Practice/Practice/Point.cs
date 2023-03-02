namespace Practice
{
    class Point<T>
    {
        // Внутренние поля
        T x, y;

        // Конструктор
        public Point(T _x, T _y)
        {
            x = _x; y = _y;
        }

        // Свойства
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод, выводящий данные на экран
        public void Print(string message)
        {
            Console.Write(message + " => ");
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }

    class Point
    {
        // Внутренние поля
       
        // Метод, выводящий данные на экран
        public void Print(string message)
        {
            Console.Write(message + " => ");
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
    public enum Ex
    {
        None,
    }
}