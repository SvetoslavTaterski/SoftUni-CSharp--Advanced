using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        private string name;
        private int openPositions;
        private char group;

        public Team(string name, int openPositions, char group)
        {
            Players = new List<Player>();
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }

        public char Group
        {
            get { return group; }
            set { group = value; }
        }


        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public int Count { get { return Players.Count; } }

        public string AddPlayer(Player player)
        {

            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }

            if (OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            Players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            if (Players.Any(p => p.Name == name))
            {
                int playerIndexToRemove = Players.FindIndex(p => p.Name == name);
                Players.RemoveAt(playerIndexToRemove);
                OpenPositions++;
                return true;
            }

            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int countOfPlayers = Players.Count;

            if (Players.Any(p => p.Position == position))
            {
                Players.RemoveAll(p => p.Position == position);
                int countOfRemovedPlayers = countOfPlayers - Players.Count;
                OpenPositions += countOfRemovedPlayers;

                return countOfRemovedPlayers;
            }

            return 0;
        }

        public Player RetirePlayer(string name)
        {
            if (Players.Any(p => p.Name == name))
            {
                Players.First(p => p.Name == name).Retired = true;

                return Players.First(p => p.Name == name);
            }

            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            var orderedList = new List<Player>(Players.Where(p => p.Games >= games));

            return orderedList;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var item in Players.Where(p => p.Retired == false))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
