using Olympiad.Data.Data;
using Olympiad.Services.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Services
{
    public class ShowServices
    {
        public static List<GridViewShoww> GridViewTable()
        {
            List<GridViewShoww> list = new List<GridViewShoww>();
            using (AppDbContext context = new AppDbContext())
            {
                var init = from p in context.Players
                           join c in context.CountryAgents on p.Id equals c.IdPlayerAgent
                           where p.Id == c.IdPlayerAgent
                           join t in context.OlympiadaTables on c.Id equals t.IdCountryAgent
                           where t.IdCountryAgent == c.Id
                           join o in context.Olympiads on t.Id equals o.IdTableOlypida
                           where o.IdTableOlypida == t.Id
                           select new { o.NameOlypiada, c.Name, t.Gold, t.Silver, t.Bronze };
                foreach (var item in init)
                {
                    GridViewShoww grid = new GridViewShoww();
                    grid.NameOlympiada = item.NameOlypiada;
                    grid.NameCountry = item.Name;
                    grid.Gold = item.Gold;
                    grid.Silver = item.Silver;
                    grid.Bronze = item.Bronze;
                    grid.Count = grid.Gold + grid.Silver + grid.Bronze;
                    list.Add(grid);
                }
                return list;

            }
        }
        public static List<GridViewShowPlayers> GridViewPlayers()
        {
            List<GridViewShowPlayers> list = new List<GridViewShowPlayers>();
            using (AppDbContext context = new AppDbContext())
            {
                var init = from p in context.Players
                           join c in context.CountryAgents on p.Id equals c.IdPlayerAgent
                           where p.Id == c.IdPlayerAgent
                           join t in context.OlympiadaTables on c.Id equals t.IdCountryAgent
                           where t.IdCountryAgent == c.Id
                           join o in context.Olympiads on t.Id equals o.IdTableOlypida
                           where o.IdTableOlypida == t.Id
                           let nameCountry = c.Name
                           select new { p.Name, p.Surname, p.MiddleName, p.DateBirth, nameCountry };
                foreach (var item in init)
                {
                    GridViewShowPlayers grid = new GridViewShowPlayers()
                    {
                        Name = item.Name,
                        Surname = item.Surname,
                        MidleName = item.MiddleName,
                        DateBirth = item.DateBirth,
                        Country = item.nameCountry
                    };
                    list.Add(grid);
                }
                return list;

            }
        }
    }
}
