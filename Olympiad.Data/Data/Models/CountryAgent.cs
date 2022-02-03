using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Models
{
    public class CountryAgent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdPlayerAgent { get; set; }
        public Player Players { get; set; }
        public List<OlympiadaTable> Olympiada { get; set; }

    }
}
