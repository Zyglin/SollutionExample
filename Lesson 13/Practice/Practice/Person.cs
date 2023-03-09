using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Practice
{

    public class Person
    {
        [JsonPropertyName("id")]
        public int Id = 12;
        public string Name { get; set; }
        public int Year { get; set; }
        [JsonPropertyName("Example")]
        public string LastName { get; set; }
        public Person() { }
        public Person(string name, int year, string lastName)
        {
            Name = name;
            Year = year;
            LastName = lastName;
        }
    }

    //Сериализация применяется к свойствам и полям класса.
    //Если мы не хотим, чтобы какое-то поле класса сериализовалось,
    //то мы его помечаем атрибутом NonSerialized

    //атрибут Serializable автоматически не наследуется

    //[XmlElement("SomeName")]
    //[XmlIgnore]

    //[JsonIgnore]
    //[JsonPropertyName()]

}