using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Interfaces
{
    public interface IOlympiadaRepository
    {
        void AddOlympiada(Olympiada olympiada);
    }
}
