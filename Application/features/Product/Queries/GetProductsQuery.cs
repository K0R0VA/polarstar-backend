using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.common.persistence;
using MediatR;

namespace Application.features.Product.Queries
{
    public class GetProductsQuery : IRequest<IQueryable<ProductDto>>
    {
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IQueryable<ProductDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetProductsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IQueryable<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(
                _context.Products.Select(product => new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quentity = product.Quantity,
                }).AsQueryable());
        }
    }
}