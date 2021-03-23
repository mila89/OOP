using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terroristsList;
        private List<IPlayer> contrasTerroristsList;

        public Map()
        {
            this.terroristsList = new List<IPlayer>();
            this.contrasTerroristsList = new List<IPlayer>();
        }
        public string Start(ICollection<IPlayer> players)
        {
            SplitPlayers(players);
            while (true)
            { //tuk sum
                Attack(terroristsList, contrasTerroristsList);
               
                Attack(contrasTerroristsList, terroristsList);
                if (!IsTeamAlive(contrasTerroristsList))
                    return "Terrorist wins!";
                if (!IsTeamAlive(terroristsList))
                    return "Counter Terrorist wins!";
            }
            //return "";
        }

        private bool IsTeamAlive(List<IPlayer> team)
        {
            foreach (var player in team)
            {
                if (player.IsAlive)
                  return true;
            }
            return false;
        }
        private void Attack(List<IPlayer> attackingTeam, List<IPlayer> defeadindgTeam)
        {
            foreach (var attackingPlayer in attackingTeam)
            {
               // if (!attackingPlayer.IsAlive) continue;

                foreach (var defPleayer in defeadindgTeam)
                {
                    if (defPleayer.IsAlive)
                        defPleayer.TakeDamage(attackingPlayer.Gun.Fire());
                }
            }
        }
        private void SplitPlayers(ICollection<IPlayer> players)
        {
            foreach (var item in players)
            {
                if (item is Terrorist && item.Health > 0)
                    terroristsList.Add(item as Terrorist);
                else if (item is CounterTerrorist && item.Health > 0)
                    contrasTerroristsList.Add(item as CounterTerrorist);
            }
        }

        internal string Start(object p)
        {
            throw new NotImplementedException();
        }
    }
}
