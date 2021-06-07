using System.Threading;
using System.Threading.Tasks;
using Application.features.Product.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Common
{
    
    public class ShopController : ApiController
    {
        public ShopController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> GetProducts(CancellationToken cancellationToken)
        {
            var products = await _mediator.Send(new GetProductsQuery(), cancellationToken);
            return Ok(products);
        }
    }
}
