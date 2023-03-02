namespace Practice
{
    //public class GenericClass<T>
    //{
    //    private T value;
    //    public T GenericField { get; set; }

    //    public GenericClass(T value)
    //    {
    //        this.value = value;
    //    }

    //    public T GetValue()
    //    {
    //        return value;
    //    }

    //}

    //В приведенном выше примере параметр типа "T" может быть любым допустимым типом C#,
    //включая ссылочные типы, типы значений и даже другие обобщенные типы. 


    //public class GenericClass : IGenericInterface<int>
    //{
    //    public void PrintValue(int value)
    //    {
    //        Console.WriteLine("Value: " + value);
    //    }
    //}

    //public class GenericClass : IGenericInterface<double>
    //{
    //    public void PrintValue(double value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class GenericClass : IGenericInterface<string, double, int>
    //{

    //    public void PrintValue(string value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ShowValue(double valueTwo)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteValue(int value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string GetValue(double value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //class Person<T>
    //{
    //    public static T code;
    //    public T Id { get; set; }
    //    public string Name { get; set; }
    //    public Person(T id, string name)
    //    {
    //        Id = id;
    //        Name = name;
    //    }
    //}

    //Task 1:
    /*Create a generic class called Stack<T> that implements a stack data structure.The class should have the following methods:

    void Push(T item) : Adds an item to the top of the stack.
    T Pop() : Removes and returns the item from the top of the stack.
    T Peek() : Returns the item at the top of the stack without removing it.
    bool IsEmpty() : Returns true if the stack is empty, false otherwise.
    */

    //public class Stack<T>
    //{
    //    private List<T> items;

    //    public Stack()
    //    {
    //        items = new List<T>();
    //    }

    //    public void Push(T item)
    //    {
    //        items.Add(item);
    //    }

    //    public T Pop()
    //    {
    //        if (IsEmpty())
    //        {
    //            throw new InvalidOperationException("Stack is empty");
    //        }

    //        T item = items[items.Count - 1];
    //        items.RemoveAt(items.Count - 1);
    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (IsEmpty())
    //        {
    //            throw new InvalidOperationException("Stack is empty");
    //        }

    //        return items[items.Count - 1];
    //    }

    //    public bool IsEmpty()
    //    {
    //        return items.Count == 0;
    //    }
    //}


    //Task 4:
    //Create a generic class called Pair<T1, T2> that represents a pair of values of type T1 and T2
    //.The class should have two properties First and Second of type T1 and T2 respectively.
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
   
}