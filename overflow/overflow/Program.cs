using System;
using System.Collections.Generic;

namespace overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<string>();
            numbers.Add("Hello world");
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine(numbers.Count);
            var dateTime = new DateTime(2021, 08, 28);
            Console.WriteLine(dateTime);

            var now = DateTime.Now;
            var next = DateTime.UtcNow;

            var span = now - next;

            Console.WriteLine("span are\t" + span);
        }
    }
}
