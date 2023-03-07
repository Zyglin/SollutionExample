namespace Practice
{
    class Bank
    {
        public delegate void BankHandler(string message);
        public delegate void BankHandlerWithTwoParams(string message, string secondMessage);

        //public event имя_делегата имя_события.
        public event BankHandler Notify;              // 1.Определение события
        public event BankHandlerWithTwoParams NotifySecond;            // 1.Определение события
        public Bank(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
            NotifySecond("Деньги поступили на счёт", "Положил Артём");
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
    //С помощью специальных акссесоров add/remove мы можем управлять добавлением и удалением обработчиков.Как правило, подобная функциональность редко требуется
    //BankHandler? notify;
    //public event BankHandler Notify
    //{
    //    add
    //    {
    //        notify += value;
    //        Console.WriteLine($"{value.Method.Name} добавлен");
    //    }
    //    remove
    //    {
    //        notify -= value;
    //        Console.WriteLine($"{value.Method.Name} удален");
    //    }
    //}

}