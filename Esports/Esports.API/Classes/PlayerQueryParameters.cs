using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esports.API.Classes
{
    public class PlayerQueryParameters : QueryParameters
    {
        public string GamerTag { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string Name { get; set; }
    }
}
