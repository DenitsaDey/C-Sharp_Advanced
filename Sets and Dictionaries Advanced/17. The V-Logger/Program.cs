using System;
using System.Collections.Generic;
using System.Linq;

namespace _17._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> vlogPlatform = new Dictionary<string, Dictionary<string, List<string>>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(command[1] == "joined")
                {
                    string vlogger = command[0];
                    if (!vlogPlatform.ContainsKey(vlogger))
                    {
                        vlogPlatform.Add(vlogger, new Dictionary<string, List<string>>()
                        {
                            {"followers", new List<string>() },
                            {"following", new List<string>() }
                        });
                    }
                }
                else if(command[1] == "followed")
                {
                    string follower = command[0];
                    string vlogger = command[2];
                    
                    if(vlogPlatform.ContainsKey(follower) 
                        && vlogPlatform.ContainsKey(vlogger) 
                        && follower != vlogger)
                    {

                        if (!vlogPlatform[vlogger]["followers"].Contains(follower))
                        {
                            vlogPlatform[vlogger]["followers"].Add(follower);
                        }

                      
                        if (!vlogPlatform[follower]["following"].Contains(vlogger))
                        {
                            vlogPlatform[follower]["following"].Add(vlogger);
                        }
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vlogPlatform.Count} vloggers in its logs.");
            var sortedPlatform = vlogPlatform
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(y => y.Value["following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);
            var mostFamous = sortedPlatform.First();
            string mostFamousVlogger = mostFamous.Key;
            Dictionary<string, List<string>> mostFamousFollowers = mostFamous.Value;
            Console.WriteLine($"1. {mostFamousVlogger} : {mostFamousFollowers["followers"].Count} followers, {mostFamousFollowers["following"].Count} following");
            foreach (var follower in mostFamousFollowers["followers"].OrderBy(x=>x))
            {
                Console.WriteLine($"*  {follower}");
            }
            sortedPlatform.Remove(mostFamousVlogger);
            int counter = 2;
            foreach (var vlogger in sortedPlatform)
            {
                Console.WriteLine($"{counter++}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
            }

        }
    }
}
