namespace Practice
{

    // Плохой пример

    //interface IShape
    //{
    //    void Draw();
    //    void Move();
    //    void Resize();
    //}

    //class RectangleShape : IShape
    //{
    //    public void Draw()
    //    {
    //        // Рисование прямоугольника
    //    }

    //    public void Move()
    //    {
    //        // Перемещение прямоугольника
    //    }

    //    public void Resize()
    //    {
    //        // Изменение размера прямоугольника
    //    }
    //}

    //class CircleShape : IShape
    //{
    //    public void Draw()
    //    {
    //        // Рисование круга
    //    }

    //    public void Move()
    //    {
    //        // Перемещение круга
    //    }

    //    public void Resize()
    //    {
    //        // Изменение размера круга
    //    }
    //}

    //В примере выше интерфейс IShape включает в себя методы Draw(), Move() и Resize(). Однако классы Rectangle и Circle
    //не обязаны реализовывать все эти методы. Это нарушает принцип ISP,
    //поскольку клиенты, которым нужно только рисование, например, должны все равно реализовывать методы Move() и Resize(), хотя они им не нужны.

    interface IDrawable
    {
        void Draw();
    }

    interface IMovable
    {
        void Move();
    }

    interface IResizable
    {
        void Resize();
    }

    class RectangleShape : IDrawable, IMovable, IResizable
    {
        public void Draw()
        {
            // Рисование прямоугольника
        }

        public void Move()
        {
            // Перемещение прямоугольника
        }

        public void Resize()
        {
            // Изменение размера прямоугольника
        }
    }

    class CircleShape : IDrawable, IMovable
    {
        public void Draw()
        {
            // Рисование круга
        }

        public void Move()
        {
            // Перемещение круга 
        }
    }

    class SquareShape : IDrawable , IResizable
    {
        public void Draw()
        {
            // Рисование квадрата
        }

        public void Resize()
        {
            // Изменение размера квадрата
        }
    }
}