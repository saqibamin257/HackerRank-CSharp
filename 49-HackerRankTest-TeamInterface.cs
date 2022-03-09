using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Team
    {
        public string teamName;
        public int noOfPlayers;
        public Team(string _teamName, int _noOfPlayers) 
        {
            teamName = _teamName;
            noOfPlayers = _noOfPlayers;
        }
        public void AddPlayer(int count) 
        {
            noOfPlayers += count;
        }
        public bool RemovePlayer(int count)         
        {
            noOfPlayers -= count;
            return noOfPlayers < 0 ? false : true;
        }
    }
    public class SubTeam:Team
    {
        public SubTeam(string teamName, int noOfPlayers)
            :base(teamName, noOfPlayers) 
        {

        }
        public void ChangeTeamName(string name) 
        {
            teamName = name;
        }
    }

    public class HackerRankTest
    {
        public static void Input()
        {
            if (!typeof(SubTeam).IsSubclassOf(typeof(Team)))
            {
                throw new Exception("Subteam class should inherit from Team class");
            }


            String str = Console.ReadLine();

            String[] strArr = str.Split();

            string initialName = strArr[0];

            int count = Convert.ToInt32(strArr[1]);

            SubTeam teamObj = new SubTeam(initialName, count);

            Console.WriteLine("Team " + teamObj.teamName + " created");



            str = Console.ReadLine();

            count = Convert.ToInt32(str);

            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);

            teamObj.AddPlayer(count);

            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);



            str = Console.ReadLine();

            count = Convert.ToInt32(str);

            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);

            var res = teamObj.RemovePlayer(count);

            if (res)
            {

                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);

            }
            else
            {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }


            str = Console.ReadLine();

            teamObj.ChangeTeamName(str);

            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);

        }

    }
    
}
