using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esport.API.Models;
using Esports.API.Classes;
using Esports.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> GetAllPlayers([FromQuery] PlayerQueryParameters queryParameters) 
        {
            IQueryable<Player> player = _context.Players;

            if(queryParameters.MinPrice != null && queryParameters.MaxPrice != null)
            {
                player = player.Where(
                    p => p.Price >= queryParameters.MinPrice.Value && p.Price <= queryParameters.MaxPrice.Value
                    );
            }
            if(!string.IsNullOrEmpty(queryParameters.GamerTag))
            {
                player = player.Where(p => p.GamerTag == queryParameters.GamerTag);
            }
            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                player = player.Where(p => p.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if(typeof(Player).GetProperty(queryParameters.SortBy) != null)
                {
                    player = player.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            player = player
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);

            return Ok(await player.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if(player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}
