using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Authorized
{
    [ApiController]
    [Route("api/cart")]
    public class OrderController : AuthorizedController
    {
        public OrderController(IMediator mediator) : base(mediator) { }
    }
}