using MediatR;

namespace PolarStar.Controllers.Common
{
    
    public class ShopController : ApiController
    {
        public ShopController(IMediator mediator) : base(mediator) { }
    }
}
