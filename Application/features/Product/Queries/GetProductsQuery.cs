using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.common.persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.features.Product.Queries
{
    public class GetProductsQuery : IRequest<IList<ProductDto>>
    {
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IList<ProductDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetProductsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return 
                await _context.Products.Select(product => new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quentity = product.Quantity,
                }).ToListAsync(cancellationToken);
        }
    }
}