using Olympiad.Data.Data.Interfaces;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Classes
{
    public class OlympiadaRepository : IOlympiadaRepository
    {
        public void AddOlympiada(Olympiada olympiada)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    context.Olympiads.Add(olympiada);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
