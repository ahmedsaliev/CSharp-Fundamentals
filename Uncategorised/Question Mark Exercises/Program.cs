using System;

namespace Excersise
{
    internal class Person
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    class Program
    {
        static void Main()
        {
            string text = null;
            string someText = text;

            int? number = 5;

            Console.WriteLine(someText ?? "No text");
            Console.WriteLine(number);

            Person person = new Person();
            person.Name = "Pesho";
            Console.WriteLine(person.Name ?? "No persons");
        }
    }
}
