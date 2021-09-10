using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CookieSendingPoC.CookieCreator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CookiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCookie()
        {
            Response.Cookies.Append("test", "testValue", new CookieOptions
            {
                 HttpOnly = true,
                 Secure = true
            });
            return Redirect("https://localhost:44313/");
        }
    }
}
