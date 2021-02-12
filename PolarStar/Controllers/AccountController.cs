using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {
            
        }
        
        public async Task<IActionResult> GetAccountInfo()
        {
            return BadRequest();
        }
    }
}