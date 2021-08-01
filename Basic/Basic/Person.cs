using System;
using System.Collections.Generic;
using System.Text;

namespace Basic { 
    public class Person
{
    private string Name;
    public int Id;
        private DateTime _birthdate;

    public Person()
    {

    }

    public void Introduce(string to)
    {
        Console.WriteLine("Hi {0}, I am {1}", to, Name);
    }

        internal DateTime SetBirthdate(DateTime birthdate)
        {
           return _birthdate = birthdate;
        }

        public string SetName(string name)
    {
        this.Name = name;
        return Name;
    }
}
}
