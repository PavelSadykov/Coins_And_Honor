using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace ConsoleApp11
{

    class Team
    {
        public string TeamName { get; set; }
        public List<Gamers> TeamPlayers { get; set; }
        public int TeamCoins { get; set; }
        public int TeamHonor { get; set; }
        public int TeamLuck { get; set; }

        public Team()
        {
            TeamName = "";
            TeamPlayers = new List<Gamers>();
            TeamCoins = 0;
            TeamHonor = 0;
            TeamLuck = 1;
        }

        public Team(string teamName)
        {
            TeamName = teamName;
            TeamPlayers = new List<Gamers>();
            TeamCoins = 0;
            TeamHonor = 0;
            TeamLuck = 1;
        }
    }


}
