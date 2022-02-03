using Olympiad.Data.Data.Classes;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Services
{
    public class CountryServices
    {
        private static CountryRepository countryRepository = new CountryRepository();
        public static void AddCountry(CountryAgent country)
        {
            countryRepository.AddCountry(country);
        }
        public static void RemoveCountry(CountryAgent country)
        {
            countryRepository.RemoveCountry(country);
        }
        public static void UpdateCountry(CountryAgent country)
        {
            countryRepository.UpdateCountry(country);
        }
        public static int GetIdByAddTableWithPlayer(int id ,string Name)
        {
            return countryRepository.GetIdByAddTableWithPlayer(id , Name);
        }
    }
}
