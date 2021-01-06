using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                string town = data[2];

                people.Add(new Person(name, age, town));
            }

            int n = int.Parse(Console.ReadLine());
            Person personToCompare = people[n - 1];

            int countOfMatches = 0;
            int countOfNotEqual = 0;

            foreach (Person person in people)
            {
                if(personToCompare.CompareTo(person) < 0)
                {
                    countOfNotEqual++;
                }
                if (personToCompare.CompareTo(person) > 0)
                {
                    countOfNotEqual++;
                }
                if (personToCompare.CompareTo(person) == 0)
                {
                    countOfMatches++;
                }
            }
            if(countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqual} {people.Count}");
            }
        }
    }
}
