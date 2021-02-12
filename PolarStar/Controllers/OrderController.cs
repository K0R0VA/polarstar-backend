using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/cart/{cartId}/[controller]")]
    public class OrderController : Controller
    {
        
    }
}