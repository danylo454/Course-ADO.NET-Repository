using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Interfaces
{
    public interface IPlayerRepository
    {
        void AddPlayer(Player player);
        void RemovePlayer(Player player);
        void UpdatePlayer(Player player);
        int GetUser(string n, string s, string m);
    }
}
