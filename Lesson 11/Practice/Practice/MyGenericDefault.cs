namespace Practice
{
    class MyGenericClass<T,K>
    {
        // Обобщенные переменные
        public T a;
            
        public K b;

        // Конструктор
        public MyGenericClass()
        {
            // Присвоение значения по умолчанию переменным a, b
            a = default;
            b = default;
        }
    }

}