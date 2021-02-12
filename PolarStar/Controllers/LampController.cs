using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Common.models.products;
using Common.repositories;
using Microsoft.AspNetCore.Mvc;
using Utils;

namespace PolarStar.Controllers
{
    [ApiController]
    [Route("api/shop/categories/[controller]")]
    public class LampController: ControllerBase
    {
        private readonly IProductRepository _repository;

        public LampController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lamp>>> GetLamps() =>
            await ControllerErrorHandler.TryDatabaseTask(this, () => _repository.GetLamps());
    }
}