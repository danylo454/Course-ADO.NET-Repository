using Olympiad.Data.Data.Interfaces;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Classes
{
    public class CountryRepository : ICountryRepository
    {
        public void AddCountry(CountryAgent countryAgent)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    context.CountryAgents.Add(countryAgent);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public int GetIdByAddTableWithPlayer(int idPlayer, string Name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                CountryAgent country = context.CountryAgents.Where(c => c.IdPlayerAgent == idPlayer && c.Name == Name).FirstOrDefault();
                return country.Id;
            }
        }

        public void RemoveCountry(CountryAgent countryAgent)
        {
            using (AppDbContext context = new AppDbContext())
            {
                CountryAgent country = context.CountryAgents.Where(c => c.Id == countryAgent.Id).FirstOrDefault();
                if (country != null)
                {
                    try
                    {
                        context.CountryAgents.Remove(countryAgent);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        public void UpdateCountry(CountryAgent countryAgent)
        {
            using (AppDbContext context = new AppDbContext())
            {
                CountryAgent country = context.CountryAgents.Where(c => c.Id == countryAgent.Id).FirstOrDefault();
                if (country != null)
                {
                    country.Name = countryAgent.Name != null ? countryAgent.Name : country.Name;
                    country.IdPlayerAgent = countryAgent.IdPlayerAgent != null ? countryAgent.IdPlayerAgent : country.IdPlayerAgent;
                    try
                    {
                        context.CountryAgents.Update(country);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
