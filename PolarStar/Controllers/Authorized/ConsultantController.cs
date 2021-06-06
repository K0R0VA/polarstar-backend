using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Authorized
{
    [Authorize(Roles = "Consultant")]
    [Route("api/consultant")]
    public class ConsultantController : ApiController
    {
        public ConsultantController(IMediator mediator) : base(mediator) { }
    }
}