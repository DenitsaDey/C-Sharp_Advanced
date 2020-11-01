using System;
using System.Collections.Generic;
using System.Linq;

namespace _21._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> filters = new List<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];
                string filterType = command[1];
                string criteria = command[2];

                if (commandType == "Add filter")
                {
                    filters.Add($"{filterType};{criteria}");
                }
                else if (commandType == "Remove filter")
                {
                    filters.Remove($"{filterType};{criteria}");
                }
            }
            foreach (var filterLine in filters)
            {
                string[] singleFilter = filterLine.Split(";");
                string filterType = singleFilter[0];
                string criteria = singleFilter[1];

                switch (filterType)
                {
                    case "Starts with":
                        invitations = invitations.Where(p => !p.StartsWith(criteria)).ToList();
                        break;
                    case "Ends with":
                        invitations = invitations.Where(p => !p.EndsWith(criteria)).ToList();
                        break;
                    case "Length":
                        invitations = invitations.Where(p => p.Length != int.Parse(criteria)).ToList();
                        break;
                    case "Contains":
                        invitations = invitations.Where(p => !p.Contains(criteria)).ToList();
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", invitations));
        }
    }
}
