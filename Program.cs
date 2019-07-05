using System;
using tournament;

namespace tournamentDirector
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] team_list = new string[] { "Uni 1", "Uni 2", "Uni 3", "Uni 4" };
            Tournament tournament = new Tournament("tName", team_list);
        }
    }
}
