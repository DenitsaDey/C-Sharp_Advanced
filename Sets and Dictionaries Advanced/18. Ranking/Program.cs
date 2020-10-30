using System;
using System.Collections.Generic;
using System.Linq;

namespace _18._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "end of contests")
            {
                string[] info = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (!contests.ContainsKey(info[0]))
                {
                    contests.Add(info[0], string.Empty);
                }
                contests[info[0]] = info[1];
            }

            string data = string.Empty;
            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();
            while ((data = Console.ReadLine())!="end of submissions")
            {
                string[] info = data.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = info[0];
                string password = info[1];
                string username = info[2];
                int points = int.Parse(info[3]);
                if (contests.ContainsKey(contest))
                {
                    if(contests[contest] == password)
                    {
                        if (!candidates.ContainsKey(username))
                        {
                            candidates.Add(username, new Dictionary<string, int>());
                        }
                        if (!candidates[username].ContainsKey(contest))
                        {
                            candidates[username].Add(contest, 0);
                        }
                        if (candidates[username][contest] < points)
                        {
                            candidates[username][contest] = points;
                        }
                    }
                }
            }
            var candidatesPoints = new Dictionary<string, int>();
            int sum = 0;
            foreach (var student in candidates)
            {
                foreach (var points in student.Value)
                {
                      sum += points.Value;
                }
                candidatesPoints.Add(student.Key, sum);
                sum = 0;
            }
            var sortedPoints = candidatesPoints.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(x => x.Key, y => y.Value);
            var top = sortedPoints.First();
            string bestCandidate = top.Key;
            int bestResults = top.Value;
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestResults} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in candidates)
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
