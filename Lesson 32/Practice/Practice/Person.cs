﻿namespace Practice
{
    public class Person 
    {
        public string Name { get; }
        public Person(string name) => Name = name;

        ~Person() {
            Console.WriteLine();
        }

        // только в классах
        // без модификаторы доступа  и параметров
        // только 1 деструктор

        //метод Finalize

        /*
         * protected override void Finalize(){
            
        try {
            // инструкции деструктора
            }
        finally
            {
             base.Finalize
            }
        }

        сборщик мусора при размещении объекта в куче определяет, поддерживает ли данный объект метод Finalize.
        И если объект имеет метод Finalize, то указатель на него сохраняется в специальной таблице, которая называется очередь финализации.
        Когда наступает момент сборки мусора, сборщик видит, что данный объект должен быть уничтожен,
        и если он имеет метод Finalize, то он копируется в еще одну таблицу и окончательно уничтожается лишь при следующем проходе сборщика мусора.
         */
    }
}