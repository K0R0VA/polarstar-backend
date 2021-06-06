using MediatR;

namespace PolarStar.Controllers.Common
{
    public class CartController : ApiController
    {
        public CartController(IMediator mediator) : base(mediator) { }
    }
}