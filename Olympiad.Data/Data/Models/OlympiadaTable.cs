using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Models
{
    public class OlympiadaTable
    {
        public int Id { get; set; }
        public int IdCountryAgent { get; set; }
        public CountryAgent CountryAgent { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public List<Olympiada> Olympiads { get; set; }

    }
}
