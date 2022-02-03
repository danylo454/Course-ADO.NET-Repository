using Olympiad.Data.Data.Interfaces;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Classes
{
    public class PlayerRepository : IPlayerRepository
    {
        public void AddPlayer(Player player)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    context.Players.Add(player);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public int GetUser(string n, string s, string m)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Player getId = context.Players.Where(p => p.Name == n && p.Surname == s && p.MiddleName == m).FirstOrDefault();
                return getId.Id;

            }
        }

        public void RemovePlayer(Player player)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Player removePlayer = context.Players.Where(p => p.Id == player.Id).FirstOrDefault();
                if (removePlayer != null)
                {
                    try
                    {
                        context.Players.Remove(removePlayer);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
        }

        public void UpdatePlayer(Player player)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Player oldPlayer = context.Players.Where(p => p.Id == player.Id).FirstOrDefault();
                oldPlayer.Name = player.Name != null ? player.Name : oldPlayer.Name;
                oldPlayer.Surname = player.Surname != null ? player.Surname : oldPlayer.Surname;
                oldPlayer.Agents = player.Agents != null ? player.Agents : oldPlayer.Agents; ;
                oldPlayer.Country = player.Country != null ? player.Country : oldPlayer.Country;
                oldPlayer.DateBirth = player.DateBirth != null ? player.DateBirth : oldPlayer.DateBirth;
                try
                {
                    context.Players.Update(oldPlayer);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
