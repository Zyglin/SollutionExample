namespace Practice
{
        //delegate возвр_тип  имя_Делегата (параметры)
        delegate void DelegateExample(); // 1. Объявляем делегат

        delegate int DefaultOperation(int x, int y, int z);

        delegate void ShowMessage();

        //delegate T имя_Делегата <тип_Даных,тип_Даных>  (тип_Данных имя)
        delegate T DefaultOperationGeneric<T, K>(K val);

        delegate void AnonymousDelegate(string message);
        delegate void AnonymousDelegateSecond();

        enum OperationType
        {
          Add, Subtract, Multiply
        }


}