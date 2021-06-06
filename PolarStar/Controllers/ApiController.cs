using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers
{
    [ApiController]
    public class ApiController: ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}