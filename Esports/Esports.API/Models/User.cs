using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esports.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public virtual List<Team> Teams { get; set; }

    }
}
