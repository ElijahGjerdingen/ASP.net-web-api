using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esports.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Player> Players { get; set; }
    }
}
