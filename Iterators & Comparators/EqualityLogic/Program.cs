using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);

                peopleSortedSet.Add(new Person(name, age));
                peopleHashSet.Add(new Person(name, age));
            }
            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
