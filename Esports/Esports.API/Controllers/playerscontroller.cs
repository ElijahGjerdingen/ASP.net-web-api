using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esports.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class playerscontroller : ControllerBase
    {

        private readonly ShopContext _context;

        public playerscontroller(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Player> GetAllPlayers() { return _context.Players.ToArray(); }
    }
}
