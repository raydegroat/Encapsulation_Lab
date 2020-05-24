using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    class Program
    {
        public static void Main()
        {            
            var lines = 2;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
