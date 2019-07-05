using System;
using System.Collections;

namespace tournament
{
    public class Tournament
    {
        public Tournament(string name, string[] team_list)
        {
            int totalTeams = team_list.Length;
            // Create Hashtable of team objects with key as seed, value a Team instance
            Hashtable teams = new Hashtable();
            for (int i=0; i<totalTeams; i++)
            {
                Team aTeam = new Team(team_list[i], i, i);
                teams.Add(i, aTeam);
                Console.WriteLine(aTeam);
            }

        }
    }

    public class Team
    {
        string name;
        int seed;
        int teamId;
        public Team(string name, int seed, int teamId)
        {
            this.name = name;
            this.seed = seed;
            this.teamId = teamId;
        }
        public override string ToString()
        {
            return this.seed + ": " + name;
        }

    }
}
