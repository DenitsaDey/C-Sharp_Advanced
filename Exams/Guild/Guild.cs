using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if(this.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            return roster.Remove(player);            
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            player.Rank = "Member";
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            player.Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string classs)
        {
            Player[] kickedPlayers = roster.Where(p => p.Class == classs).ToArray();
            roster = roster.Where(p => p.Class != classs).ToList();
            return kickedPlayers;
        }

        public string Report()
        {
            return $"Players in the guild: {this.Name}" +
                $"{Environment.NewLine}{string.Join(Environment.NewLine, roster)}";
        }
    }
}
