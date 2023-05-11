namespace Practice
{
    //public class OCPEmployeeReport
    //{
    //    public string TypeReport { get; set; }

    //    public void GenerateReport(Employee em)
    //    {
    //        if (TypeReport == "CSV")
    //        {
    //            // Генерация отчета в формате CSV
    //        }

    //        if (TypeReport == "PDF")
    //        {
    //            // Генерация отчета в формате PDF
    //        }

    //        if (TypeReport == "SXP")
    //        {
    //            // Генерация отчета в формате SXP
    //        }
    //    }

    //    //Проблема в этом классе заключается в том, что если мы захотим внести новый тип отчета (например, для выгрузки в Excel),
    //    //нам понадобится добавить новое условие if. Но согласно принципу OCP, наш класс должен быть закрыт
    //    //от модификаций и открыт для расширений.
    //}

    //public class BasicEmployeeReport
    //{
    //    public virtual void GenerateReport(Employee em)
    //    {
    //        // Базовая реализация, которую нельзя модифицировать
    //    }
    //}

    //public class EmployeeCSVReport : BasicEmployeeReport
    //{
    //    public override void GenerateReport(Employee em)
    //    {
    //        // Генерация отчета в формате CSV
    //    }
    //}

    //public class EmployeePDFReport : BasicEmployeeReport
    //{
    //    public override void GenerateReport(Employee em)
    //    {
    //        // Генерация отчета в формате PDF
    //    }
    //}

    //public class EmployeeSXPReport : BasicEmployeeReport
    //{
    //    public override void GenerateReport(Employee em)
    //    {
    //        // Генерация отчета в формате SXP
    //    }
    //}

    //Eсли вы захотите добавить новый тип отчета, просто создайте новый класс и унаследуйте его от BasicEmployeeReport.
    //Таким образом, класс BasicEmployeeReport закрыт от модификаций, но доступен для расширений.
}
