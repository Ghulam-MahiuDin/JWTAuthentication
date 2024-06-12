using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        [HttpGet]
    
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
     
    }
}

