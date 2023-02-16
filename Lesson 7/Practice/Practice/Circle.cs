using System.Xml.Linq;

namespace Practice
{

    // Наследник : базовый класс (родитель)
    // Circle : InterfaceOne, InterfaceTwo 
     class Circle : Figure
    {

        public int R { get; set; }
        public double Pi { get; set; } = 3.14;

        public Circle(int radius,string name) : base(name)
        {
            R = radius;
        }

        public override void ShowSquare()
        {
            Console.WriteLine($"Площадь {Color} {Name}:{Square(R, Pi)}");
        }

        private double Square(int pi, double r)
        {
            return pi * Math.Pow(r, 2);
        }

    }
}