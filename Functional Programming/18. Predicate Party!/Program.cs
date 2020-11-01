using System;
using System.Collections.Generic;
using System.Linq;

namespace _20._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string value = command[2];

                if (command[0] == "Remove")
                {
                    if(command[1] == "StartsWith")
                    {
                        guests = guests.Where(g => !g.StartsWith(value)).ToList();
                    }
                    else if(command[1] == "EndsWith")
                    {
                        guests = guests.Where(g => !g.EndsWith(value)).ToList();
                    }
                    else if(command[1] == "Length")
                    {
                        guests = guests.Where(g => !(g.Length == int.Parse(value))).ToList();
                    }
                }
                else if(command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].StartsWith(value))
                            {
                                string newGuest = guests[i];
                                guests.Insert(i + 1, newGuest);
                                i++;
                            }
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(value))
                            {
                                string newGuest = guests[i];
                                guests.Insert(i + 1, newGuest);
                                i++;
                            }
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].Length == int.Parse(value))
                            {
                                string newGuest = guests[i];
                                guests.Insert(i + 1, newGuest);
                                i++;
                            }
                        }
                    }
                }
            }
            if(guests.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
