using System;
using System.Collections;
using System.Linq;

namespace tournament
{
    public class Tournament
    {
        int totalTeams;
        Hashtable teams = new Hashtable();
        Hashtable groups = new Hashtable();
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
        public void CreateGroups(int totalGroups = 4)
        {
            // Create groups via looping through the seed list and remove entries as they are added.
            // Store Groups in groups Hashtable
            // Store team objects within array under group Hashtable key
            // Will need to cycle through the groups, not as easy as python...
            int[] teamSeeds = Enumerable.Range(0, totalTeams).ToArray();
            while (teamSeeds.Length > 0)
            {
                // Get team instance to be added to a group (top seed of remaining seeds)
                Team team = (Team) teams[teamSeeds[0]];
            }

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
