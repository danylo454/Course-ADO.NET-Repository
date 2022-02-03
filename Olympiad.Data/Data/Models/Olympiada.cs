using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data.Models
{
    public class Olympiada
    {
        public int Id { get; set; }
        public string NameOlypiada { get; set; }
        public int IdTableOlypida { get; set; }
        public OlympiadaTable OlympiadaTable { get; set; }
    }
}
