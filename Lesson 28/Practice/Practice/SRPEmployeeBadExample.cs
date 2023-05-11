namespace Practice
{
    public class SRPEmployeeBadExample
    {
            public int ID { get; set; }
            public string FullName { get; set; }

            /// Данный метод добавляет в БД нового сотрудника
            public bool Add(SRPEmployeeBadExample emp)
            {
                // Вставить данные сотрудника в таблицу БД
                return true;
            }

            public void GenerateReport(SRPEmployeeBadExample em)
            {
                // Генерация отчета по деятельности сотрудника
            }
    }
    //В данном случае класс SRPEmployeeBadExample не соответствует принципу SRP, т.к. несет две ответственности – добавление нового сотрудника в базу данных и создание отчета.
    //Класс SRPEmployeeBadExample не должен нести ответственность за отчетность, т.к. например, если через какое-то время вам скажут,
    //что нужно предоставить отчет в формате Excel или изменить алгоритм создания отчета, вам потребуется отредактировать класс SRPEmployeeBadExample.
}
