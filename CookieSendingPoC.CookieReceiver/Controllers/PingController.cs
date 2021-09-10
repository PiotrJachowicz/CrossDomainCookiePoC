using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CookieSendingPoC.CookieReceiver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Request.Cookies.Single(x => x.Key == "test").Value);
        }
    }
}
