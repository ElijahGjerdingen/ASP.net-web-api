using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class playerscontroller : ControllerBase
    {
        [HttpGet]
        public string GetPlayers() { return "Bikerthulu"; }
    }
}
