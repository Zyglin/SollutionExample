using System.Text.Json;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Для бинарной сериализации в .NET можно применять класс BinaryFormatter.
            //Но стоит отметить, что хотя в принципе его можно применять, но не рекомендуется,
            //поскольку он не считается безопасным

            //Чтобы объект определенного класса можно было сериализовать, надо этот класс пометить атрибутом Serializable
            //Атрибуты представляют специальные инструменты, которые позволяют встраивать дополнительные инструкции.

            //Для бинарной сериализации применим класс BinaryFormatter

            //var artem = new Person("Artem", 1200,"Zyglin");

            ////// создаем объект BinaryFormatter

            ////Давайте разберёмся с понятиями. Когда операционная система начинает выполнять какую-либо программу, то она создаёт 
            ////для неё процесс. Процесс - это множество ресурсов ассоциированое с вашей программой.
            ////У процесса есть поток исполнения инструкций. Андрей Кобец (Яндекс).

            ////Поток — это сущность которая используется для чтения или
            ////записи информации.
            ////Немного проще: поток — это просто источник информации или же место,
            ////куда информацию можно направить.
            ////Главная цель потоков - прочитать и записать данные.
            ////Поток – это независимый путь исполнения, способный выполняться одновременно с другими потоками. 


            ////получаем поток, куда будем записывать сериализованный объект

            //var artem = new Person("Artem", 1200,"Zyglin");
            //var formatter = new BinaryFormatter();
            //using (var fs = new FileStream("Artem.dat", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, artem);

            //    Console.WriteLine("Объект сериализован");
            //}


            ////десериализация из файла Artem.dat
            //using (var fs = new FileStream("Artem.dat", FileMode.OpenOrCreate))
            //{
            //    Person newPerson = (Person)formatter.Deserialize(fs);

            //    Console.WriteLine("Объект десериализован");
            //    Console.WriteLine($"Имя: {newPerson.Name} Возраст: {newPerson.Year} Фамилия: {newPerson.LastName}");
            //}

            //Задание создайте класс Book с полями CountOfPages,
            //Name , AuthorName. Сериализуйте и десериализуйте Объект Book.

            //using (resource)
            //{
            //    ...код
            //}


            //Память
            //MemoryStream Создает поток, резервным хранилищем которого является память.

            //var artem = new Person("Artem", 1200,"Zyglin");
            //MemoryStream stream = SerializeToStream(artem);

            //Person newArtem = (Person)DeserializeFromStream(stream);

            //static MemoryStream SerializeToStream(object o)
            //{
            //    var stream = new MemoryStream();
            //    var formatter = new BinaryFormatter();
            //    formatter.Serialize(stream, o);
            //    return stream;
            //}

            //static object DeserializeFromStream(MemoryStream stream)
            //{
            //    var formatter = new BinaryFormatter();
            //    stream.Seek(0, SeekOrigin.Begin);
            //    object o = formatter.Deserialize(stream);
            //    return o;
            //}

            //Расширяемый язык разметки (XML) позволяет определять и хранить данные совместно используемым способом.
            //XML поддерживает обмен информацией между компьютерными системами, такими как веб-сайты, базы данных и сторонние приложения. 
            //Для удобного сохранения и извлечения объектов из файлов xml может использоваться класс XmlSerializer
            //из пространства имен System.Xml.Serialization.Данный класс упрощает сохранение сложных объектов в формат xml
            //и последующее их извлечение.
            //Для создания объекта XmlSerializer можно применять различные конструкторы,
            ////но почти все они требуют указания типа данных, которые будут сериализоваться и десериализоваться.
            //var person = new Person("Artem", 1200,"Zyglin");

            //////// передаем в конструктор тип класса Person
            ////////Следует учитывать, что XmlSerializer предполагает некоторые ограничения.
            ////////класс, подлежащий сериализации, должен иметь стандартный конструктор без параметров и должен иметь модификатор доступа public
            //var xmlSerializer = new XmlSerializer(typeof(Person));

            ////// получаем поток, куда будем записывать сериализованный объект
            //using (var fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs, person);

            //    Console.WriteLine("Объект сериализован");
            //}

            // десериализуем объект
            //using (var fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    var newPerson =xmlSerializer.Deserialize(fs) as Person;
            //    Console.WriteLine($"Name: {newPerson.Name}  Age: {newPerson.Year}   LastName: {newPerson.LastName}");
            //}

            //Person[] people = new Person[]
            //{
            //    new Person("Artem", 1200,"Zyglin"),
            //    new Person("Daniil", 1500,"Chakur")
            //};

            ////int[] numbers = new int[] { 1, 2 };

            //var formatter = new XmlSerializer(typeof(Person[]));
            ////// сохранение массива в файл
            //using (var fs = new FileStream("programmers.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, people);
            //}
            ////// восстановление массива из файла
            //using (var fs = new FileStream("programmers.xml", FileMode.OpenOrCreate))
            //{
            //    Person[] newpeople = formatter.Deserialize(fs) as Person[];

            //    if (newpeople != null)
            //    {
            //        foreach (Person person in newpeople)
            //        {
            //            Console.WriteLine($"Name: {person.Name} Age: {person.Year} LastName: {person.LastName}");
            //        }
            //    }
            //}

            //Задание Написать класс Doctor, Который имеет поля Name, CountOfPatient, DepartmentNumber,Specialization.
            //Создать массив из нескольких докторов и сериализовать их в файл формата Xml. Десериализовать.

            //JSON(JavaScript Object Notation) является одним из наиболее популярных форматов для хранения и передачи данных ключ/значение.
            //И платформа .NET предоставляет функционал для работы с JSON.

            //По умолчанию JsonSerializer сериализует объекты в минимифицированный код. С помощью дополнительного параметра типа
            //JsonSerializerOptions можно настроить механизм сериализации/ десериализации, используя свойства JsonSerializerOptions.
            //Некоторые из его свойств:

            //AllowTrailingCommas: устанавливает, надо ли добавлять после последнего элемента в json запятую.Если равно true, запятая добавляется

            //DefaultIgnoreCondition: устанавливает, будут ли сериализоваться / десериализоваться в json свойства со значениями по умолчанию

            //IgnoreReadOnlyProperties: аналогично устанавливает, будут ли сериализоваться свойства, предназначенные только для чтения

            //WriteIndented: устанавливает, будут ли добавляться в json пробелы(условно говоря, для красоты). Если равно true устанавливаются дополнительные пробелы


            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true
            //};

            //string json = JsonSerializer.Serialize(artem);

            //string json = JsonSerializer.Serialize(artem, options);
            //Console.WriteLine(json);
            //Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(restoredPerson.Year);

            // сохранение данных
            using (var fs = new FileStream("artem.json", FileMode.OpenOrCreate))
            {
                var artem = new Person("Artem", 1200, "Zyglin");
                JsonSerializer.Serialize(fs, artem);
            }

            // чтение данных
            using (var fs = new FileStream("artem.json", FileMode.OpenOrCreate))
            {
                Person person = JsonSerializer.Deserialize<Person>(fs);
                Console.WriteLine($"Name: {person?.Name}  LastName: {person?.LastName}");
            }

            //Весёлая задача SuperHeroSquad


        }
    }
}