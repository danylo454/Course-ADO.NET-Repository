using Olympiad.Data.Data.Classes;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Services
{
    public class PlayerService
    {
        private static PlayerRepository playerRepository = new PlayerRepository();
        public static void AddPlayer(Player player)
        {
            playerRepository.AddPlayer(player);
        }
        public static void UpdateUser(Player player)
        {
            playerRepository.UpdatePlayer(player);
        }
        public static void RemoveUser(Player player)
        {
            playerRepository.RemovePlayer(player);
        }
        public static int GetUSer(string name,string surname,string midleName)
        {
            return playerRepository.GetUser(name, surname, midleName);
        }
    }
}
