using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family myFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                myFamily.AddMember(new Person(name, age));
            }

            //Console.WriteLine($"{myFamily.GetOldestMember().Name} {myFamily.GetOldestMember().Age}");
            List<Person> sortedFamily = myFamily.People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sortedFamily));
            //foreach (var person in sortedFamily)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Age}");
            //}
        }
    }
}
