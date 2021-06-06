using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Authorized
{
    [Route("api/[controller]")]
    public class AccountController : AuthorizedController
    {
        public AccountController(IMediator mediator) : base(mediator) { }

        public IActionResult GetCurrentUser()
        {
            return Ok();
        }
    }
}