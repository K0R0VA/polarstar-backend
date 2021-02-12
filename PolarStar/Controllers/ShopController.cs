using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.models.products;
using Common.repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Utils;

namespace PolarStar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {

        private readonly IProductRepository _repository;
        private readonly ILogger<ShopController> _logger;

        public ShopController(IProductRepository repository, ILogger<ShopController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(CancellationToken token)
        {
            try
            {
                var products = await _repository.GetProducts();
                return Ok(products);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}
