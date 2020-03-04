using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string[] info = Console.ReadLine().Split(";");

                if (info[0] == "END")
                {
                    break;
                }

                try
                {
                    switch (info[0])
                    {
                        case "Team":
                            string nameTeam = info[1];

                            teams.Add(new Team(nameTeam));

                            break;
                        case "Add":
                            nameTeam = info[1];


                            if (teams.FirstOrDefault(x => x.Name == nameTeam) == null)
                            {
                                Console.WriteLine($"Team {nameTeam} does not exist.");
                            }
                            else
                            {
                                string namePlayer = info[2];
                                int endurance = int.Parse(info[3]);
                                int sprint = int.Parse(info[4]);
                                int dribble = int.Parse(info[5]);
                                int passing = int.Parse(info[6]);
                                int shooting = int.Parse(info[7]);

                                teams.FirstOrDefault(x => x.Name == nameTeam);
                                Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
                                Player player = new Player(namePlayer, stats);

                                teams.FirstOrDefault(x => x.Name == nameTeam).AddPlayer(player);
                            }
                            break;
                        case "Remove":
                            nameTeam = info[1];
                            string namePlayers = info[2];

                            if (teams.FirstOrDefault(x => x.Name == nameTeam) == null)
                            {
                                Console.WriteLine($"Team {nameTeam} does not exist.");
                            }

                            teams.FirstOrDefault(x => x.Name == nameTeam).RemovePlayer(namePlayers);
                            break;
                        case "Rating":
                            nameTeam = info[1];

                            if (teams.FirstOrDefault(x => x.Name == nameTeam) == null)
                            {
                                Console.WriteLine($"Team {nameTeam} does not exist.");
                            }
                            else
                            {
                                Console.WriteLine($"{nameTeam} - {teams.FirstOrDefault(x => x.Name == nameTeam).Rating}");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
