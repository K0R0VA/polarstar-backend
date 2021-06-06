using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Authorized
{
    [Authorize(Roles = "Admin")]
    [Route("api/admin")]
    public class AdminController : ApiController
    {
        public AdminController(IMediator mediator) : base(mediator) { }
    }
}