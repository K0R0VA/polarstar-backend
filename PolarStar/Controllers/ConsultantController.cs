using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    [Authorize(Roles = "Consultant")]
    [Route("api/account/{userId}/[controller]")]
    public class ConsultantController : Controller
    {
        public ConsultantController()
        {
            
        }
    }
}