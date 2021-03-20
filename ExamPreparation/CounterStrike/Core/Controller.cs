using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository gunsRep;
        private PlayerRepository playerRep;
        private Map map;

        public Controller()
        {
            gunsRep = new GunRepository();
            playerRep = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            if (type == "Pistol" || type == "Rifle")
            {
                if (type == "Pistol")
                    gunsRep.Add(new Pistol(name, bulletsCount));
                else if (type == "Rifle")
                    gunsRep.Add(new Rifle(name, bulletsCount));
            }
            else
                throw new ArgumentException("Invalid gun type.");
            return $"Successfully added gun {name}.";
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun playersGun=gunsRep.FindByName(gunName);
            if (playersGun == null)
                throw new ArgumentException("Gun cannot be found!");
            if (type == "Terrorist" || type == "CounterTerrorist")
            {
                if (type == "Terrorist")
                    playerRep.Add(new Terrorist(username, health, armor, playersGun));
                else if (type == "CounterTerrorist")
                    playerRep.Add(new CounterTerrorist(username, health, armor, playersGun));
            }
            else
                throw new ArgumentException("Invalid player type.");
            return $"Successfully added player {username}.";
        }

        public string Report()
        {
            var sortedPlayers = playerRep.Models.OrderBy(n => n.GetType().Name)
                                              .ThenByDescending(p => p.Health)
                                              .ThenBy(p => p.Username);
            StringBuilder sb = new StringBuilder();
            foreach (var player in sortedPlayers)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string StartGame()
        {
            return map.Start(playerRep.Models.ToList());
        }
    }
}
