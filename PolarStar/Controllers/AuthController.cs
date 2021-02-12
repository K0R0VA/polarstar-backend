using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {
            
        }
        public async Task<IActionResult> SignUp()
        {
            return BadRequest();
        }
        

        public async Task<IActionResult> SignIn()
        {
            return BadRequest();
        }
    }
    
}