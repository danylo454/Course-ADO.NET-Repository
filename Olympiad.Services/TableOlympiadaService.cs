using Olympiad.Data.Data.Classes;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Services
{
    public class TableOlympiadaService
    {
        private static TableOlympiadaRepository tableOlympiadaRepository = new TableOlympiadaRepository();
        public static void AddTableOlympiada(OlympiadaTable table)
        {
            tableOlympiadaRepository.AddTableOlympiada(table);
        }
        public static void UpdateTableOlympiada(OlympiadaTable table,int id)
        {
            tableOlympiadaRepository.UpdateTableOlympiada(table, id);
        }
        public static int GetIdTable(int id)
        {
            return tableOlympiadaRepository.GetIdTableByCountry(id);
        }
    }
}
