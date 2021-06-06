using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace PolarStar.Controllers.Authorized
{
    [Authorize]
    public class AuthorizedController: ApiController
    {
        public AuthorizedController(IMediator mediator) : base(mediator) { }
    }
}