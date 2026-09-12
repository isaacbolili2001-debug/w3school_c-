using System;

namespace HelloWorld
{
    public class Person
    {
        // Properties to store data
        public string _name { get; set; }
        public int _age { get; set; }

        // Constructor to initialize the object with values
        public Person(string _name, int _age)
        {
            this._name = _name;
            this._age = _age;
        }

        // Method to perform an action
        public void DisplayAndAge(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("what is your name?");
            string inputName = Console.ReadLine() ?? "";

            Console.WriteLine("what is your age?");
            string inputAgeString = Console.ReadLine() ?? "0";
            int inputAge = Convert.ToInt32(inputAgeString);

            Person person1 = new Person(inputName, inputAge);
            Person person2 = new Person("Alice", 30);

            person1.DisplayAndAge(person1._name, person1._age);
            person2.DisplayAndAge(person2._name, person2._age);

        }
    }
}