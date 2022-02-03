using Olympiad.Data.Data.Classes;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Services
{
    public class OlympiadaService
    {
        private static OlympiadaRepository olympiadaRepository = new OlympiadaRepository();
        public static void AddOlympiada(Olympiada olympiada)
        {
            olympiadaRepository.AddOlympiada(olympiada);
        }
    }
}
