using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fire.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public dynamic Get()
        {
            return new
            {
                name = User.Claims.Where(x => x.Type == "name").FirstOrDefault().Value,
                // email = User.Claims.Where(x => x.Type == "email").FirstOrDefault().Value,
                picture = User.Claims.Where(x => x.Type == "picture").FirstOrDefault().Value,
            };
        }
    }
}
