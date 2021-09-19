using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPattern
{


    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;


        public int add(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return String.Join("\n", entries);
        }
    }


    public class Persistant
    {
        public void save(Journal journal, string filename)
        {
            File.WriteAllText(filename,journal.ToString());
        }


        public string read(string filename)
        {
           return File.ReadAllText(filename);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
           var journal = new Journal();
           journal.add("Im ok");
            journal.add("im not ok...");
            Console.WriteLine(journal);
    


            var p = new Persistant();
            var filename = @"c:\temp\journal.txt";
            p.save(journal,filename);

            var text = p.read(filename);

            Console.WriteLine(text +"- hello");
        }
    }
}
