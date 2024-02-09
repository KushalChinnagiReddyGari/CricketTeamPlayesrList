using System;
using System.Collections.Generic;
using System.Linq;


namespace TeamPlayersLibrary
{

    public class TeamPlayer
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Team : TeamBase
    {
        public List<TeamPlayer> players = new List<TeamPlayer>();

        public void AddPlayer(TeamPlayer player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.Name} is added to the team.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            TeamPlayer playerToRemove = players.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} is removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} is not found in the team.");
            }
        }

        public TeamPlayer GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public TeamPlayer GetPlayerByName(string playerName)
        {
            return players.FirstOrDefault(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }

        public List<TeamPlayer> GetAllPlayers()
        {
            return players;
        }
    }
}
