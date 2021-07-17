using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

namespace asp_api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        MyContext context;
        public HomeController(MyContext context){ 
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {msg = "me & you"});
        }

        [HttpGet]
        public async Task< IActionResult> Users()
        {
            return Ok(await context.Users.ToListAsync());
        }
    }
}
