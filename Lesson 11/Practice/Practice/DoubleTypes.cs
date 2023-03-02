namespace Practice
{
    class DoubleTypes<T1, T2>
    {
        // Внутренние поля класса
        T1 var1;
        T2 var2;

        // Конструктор
        public DoubleTypes(T1 v1, T2 v2)
        {
            var1 = v1;
            var2 = v2;
        }

        // Метод, выводящий информацию о внутренних полях
        public void Print()
        {
            Console.WriteLine("var1 = {0}", var1);
            Console.WriteLine("var2 = {0}", var2);
        }
    }

    class ArrayClass<T> where T : class
    {
        T[] var1;
        public ArrayClass()
        {
            var1 = new T[12];
        }
    }
}