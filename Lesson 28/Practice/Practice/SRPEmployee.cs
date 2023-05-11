namespace Practice
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        // Данный метод добавляет в БД нового сотрудника
        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }
    }

    public class EmployeeReport
    {
        public void GenerateReport(Employee emp)
        {
            // Генерация отчета по деятельности сотрудника
        }
    }
}
