using System;
using System.Collections;

namespace tournament
{
    public class Tournament
    {
        int totalTeams;
        Hashtable teams = new Hashtable();
        public Tournament(string name, string[] team_list)
        {

            totalTeams = team_list.Length;
            // Create Hashtable of team objects with key as seed, value a Team instance
            for (int i=0; i<totalTeams; i++)
            {
                Team aTeam = new Team(team_list[i], i, i);
                teams.Add(i, aTeam);
                Console.WriteLine(aTeam);
            }
            Console.WriteLine($"Read in {0} teams", totalTeams);


        }
        public void CreateGroups()
        {
            // Create group via looping through the team list
            int[] teamSeeds = new int[this.totalTeams];

        }
        // Timings
        class Timings
        {
            public Timings()
            {
                DateTime startDateTime = new DateTime(2019, 1, 1, 9, 0, 0);
                DateTime EndDateTime = new DateTime(2019, 1, 2, 17, 0, 0);
                int gameTimeInMinutes = 55;
                int breakTimeinMinutes = 5;
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
