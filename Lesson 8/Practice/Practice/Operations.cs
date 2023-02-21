namespace Practice
{
    //static class Имя
    static class Operations
    {
        private static double pi;//поле

        public static double FeigenBaumNumber; //постоянная Фейгенбаума

        static Operations()
        {
            FeigenBaumNumber = 4.669;
        }

        public static double Pi // свойства
        {
            get { return pi; }
            set { if (value == 3.14) { pi = value; }
                else { Console.WriteLine("Pi может быть равно только 3.14"); }
            }
        }

        public static int Sum(int x, int y) //методы
        {
            return x + y;
        }
        public static int Subtraction(int x, int y) 
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Pow(int x, int y) {
            int result = 1;
            if (y != 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            return result; 
        }

        public static int Abs (int x)
        {
            if (x < 0) x = -(x);
            return x;
        }
    }

}