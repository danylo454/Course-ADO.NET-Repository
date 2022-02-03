using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Olympiad.Data.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Country { get; set; }
        public DateTime DateBirth { get; set; }
        public List<CountryAgent> Agents { get; set; }
    }
}
