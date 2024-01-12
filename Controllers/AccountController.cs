using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiradorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("register")]
        public string register()
        {
            return "Register";
        }
        [AllowAnonymous]

        [HttpGet("liste")]
        public string liste()
        {
            return "Liste";
        }
    }
}
