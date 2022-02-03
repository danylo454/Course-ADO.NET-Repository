using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Interfaces
{
    public interface ICountryRepository
    {
        void AddCountry(CountryAgent countryAgent);
        void RemoveCountry(CountryAgent countryAgent);
        void UpdateCountry(CountryAgent countryAgent);
        int GetIdByAddTableWithPlayer(int idPlayer,string Name);


    }
}
