using System.Collections.Generic;

namespace TeamPlayersLibrary
{
    public interface TeamBase
    {
        void AddPlayer(TeamPlayer player);
        void RemovePlayer(int playerId);
        TeamPlayer GetPlayerById(int playerId);
        TeamPlayer GetPlayerByName(string playerName);
        List<TeamPlayer> GetAllPlayers();
    }

}
