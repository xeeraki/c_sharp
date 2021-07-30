using System;

namespace Basic
{
    public class Person
    {
        private string Name;

        public Person()
        {
            
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to,Name);
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetName("Mosh");
            person.Introduce("Adam");
        }
    }
}
