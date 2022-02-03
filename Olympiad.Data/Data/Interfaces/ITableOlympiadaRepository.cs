using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Interfaces
{
    public interface ITableOlympiadaRepository
    {
        void AddTableOlympiada(OlympiadaTable olympiadaTable);
        void UpdateTableOlympiada(OlympiadaTable olympiadaTable, int id);
        int GetIdTableByCountry(int id);
    }
}
