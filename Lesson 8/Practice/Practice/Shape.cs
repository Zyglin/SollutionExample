namespace Practice
{
    abstract class Shape
    {
        //периметр
        public abstract double GetPerimeter();
        //площадь
        public abstract double GetArea();
    }
    // производный класс прямоугольника
    class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        //public override double GetPerimeter() { 
        //    return Width * 2 + Height * 2;
        //}

        public override double GetPerimeter() => Width * 2 + Height * 2;
        public override double GetArea() => Width * Height;
    }
    // производный класс окружности
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetPerimeter() => Radius * 2 * 3.14;
        public override double GetArea() => Radius * Radius * 3.14;
    }


}