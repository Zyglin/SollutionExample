namespace Practice
{
    /*
     модификатор доступа interface имя_интерфейса<T>
     */
    public interface IGenericInterface<T,K,L>
    {
        void PrintValue(T value);
        void ShowValue(K valueTwo);
        void DeleteValue(L value);

        T GetValue(K value);
    }
}