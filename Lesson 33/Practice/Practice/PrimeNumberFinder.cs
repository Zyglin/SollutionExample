using System.Collections.Concurrent;

public class PrimeNumberFinder
{
    public static ConcurrentBag<int> FindPrimesInRange(int start, int end)
    {
        //ConcurrentBag<T>.Представляет потокобезопасную неупорядоченную коллекцию объектов.
        var primes = new ConcurrentBag<int>();
        var lockObject = new object();

        Parallel.For(start, end, number =>  {
            if (IsPrime(number))
            {
                //Оператор lock определяет блок кода, внутри которого весь код блокируется
                //и становится недоступным для других потоков до завершения работы текущего потока. 
                lock (lockObject)
                {
                    primes.Add(number);
                }
            }
        });

        return primes;
    }

    // Используя Parallel.For верните все чётные числа которые деляться на 5  в коллекцию ConcurrentBag.

    //Мониторы, семафоры, мьютексы 

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }
}
