using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        private double rating;

        public Team(string name)
        {
            this.Name = name;

            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("A name should not be empty.");
                }

                name = value;
            }
        }

        public double Rating
        {
            get
            {
                if (this.players.Count == 0)
                {
                    return 0;
                }

                return (double)Math.Round(this.players.Average(x => x.SkillPlayers()), 0);
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.players.FirstOrDefault(x => x.Name == playerName) == null)
            {
                throw new Exception($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(this.players.FirstOrDefault(p => p.Name == playerName));
        }
    }
}
