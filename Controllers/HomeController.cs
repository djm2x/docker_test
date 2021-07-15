using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace asp_api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        


        public HomeController(){ }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {msg = "me & you"});
        }
    }
}
