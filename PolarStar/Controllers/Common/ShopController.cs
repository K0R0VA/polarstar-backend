using System.Threading;
using System.Threading.Tasks;
using Application.features.Product.Queries;
using DevExtreme.AspNet.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolarStar.Controllers.Common
{
    
    public class ShopController : ApiController
    {
        public ShopController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> GetProducts(DataSourceLoadOptionsBase options, CancellationToken cancellationToken)
        {
            var query = await _mediator.Send(new GetProductsQuery(), cancellationToken);
            return Ok(await DataSourceLoader.LoadAsync(query, options, cancellationToken));
        }
    }
}
