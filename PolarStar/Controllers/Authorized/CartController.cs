using MediatR;

namespace PolarStar.Controllers.Authorized
{
    public class CartController : AuthorizedController
    {
        public CartController(IMediator mediator) : base(mediator) { }
    }
}