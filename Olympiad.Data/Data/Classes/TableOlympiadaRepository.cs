using Olympiad.Data.Data.Interfaces;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Classes
{
    public class TableOlympiadaRepository : ITableOlympiadaRepository
    {
        public void AddTableOlympiada(OlympiadaTable olympiadaTable)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    context.OlympiadaTables.Add(olympiadaTable);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public int GetIdTableByCountry(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                OlympiadaTable table = context.OlympiadaTables.Where(t => t.IdCountryAgent == id).FirstOrDefault();
                return table.Id;
            }
        }

        public void UpdateTableOlympiada(OlympiadaTable olympiadaTable, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                OlympiadaTable table = context.OlympiadaTables.Where(t => t.Id == id).FirstOrDefault();
                table.IdCountryAgent = olympiadaTable.IdCountryAgent != null ? olympiadaTable.IdCountryAgent : table.IdCountryAgent;
                table.Gold = olympiadaTable.Gold != null ? olympiadaTable.Gold : table.Gold; ;
                table.Silver = olympiadaTable.Silver != null ? olympiadaTable.Silver : table.Silver;
                table.Bronze = olympiadaTable.Bronze != null ? olympiadaTable.Bronze : table.Bronze;
                try
                {
                    context.OlympiadaTables.Update(table);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
