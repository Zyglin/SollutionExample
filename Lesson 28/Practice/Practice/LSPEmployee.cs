﻿namespace Practice
{

    //следуя принципу LSP, класс-наследник должен быть полностью совместим с базовым классом, то есть
    //он должен реализовывать все публичные члены базового класса и не изменять их предусловия и постусловия.
    //При этом класс-наследник может расширять функциональность базового класса,
    //но не должен изменять его поведение, так как это может привести к нарушению контракта,
    //который ожидается от базового класса.
    class Shape
    {
        public virtual double Area()
        {
            // Вычисление площади фигуры
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }
    }

    //В данном примере класс Shape является базовым классом, а классы Rectangle и Square являются его наследниками.
    //Оба наследника переопределяют метод Area(), чтобы вычислить площадь соответствующей фигуры. Обратите внимание, что каждый из наследников
    //не нарушает контракт базового класса Shape и может быть использован везде,
    //где ожидается объект типа Shape.
    //Таким образом, применение принципа подстановки Лисков позволяет создавать более гибкую и расширяемую архитектуру программного обеспечения,
    //где код можно легко модифицировать и добавлять новые классы, не нарушая работу существующих компонентов.
}