using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    [Route("api/account/{userId}/[controller]")]
    public class AdminController : ControllerBase
    {
        public AdminController()
        {
            
        }
    }
}