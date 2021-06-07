using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Application.common.persistence;
using Application.common.services;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.features.Cart.Commands
{
    public class UpdateQuantityCartProductsCommand : IRequest<Unit>
    {
        public int ProductId { get; set; }
        public uint Quantity { get; set; }
    }

    public class UpdateQuantityCartProductsCommandHandler : IRequestHandler<UpdateQuantityCartProductsCommand, Unit>
    {
        private readonly ICurrentUserService _service;
        private readonly ApplicationDbContext _context;

        public UpdateQuantityCartProductsCommandHandler(ICurrentUserService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }

        public async Task<Unit> Handle(UpdateQuantityCartProductsCommand request, CancellationToken cancellationToken)
        {
            var line = await _context.CartLines
                .SingleOrDefaultAsync(cartLine => cartLine.Cart.User.Id == _service.Id
                                                  && cartLine.ProductId == request.ProductId,
                    cancellationToken);
            if (line is null) throw new Exception();
            line.Quantity = request.Quantity;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}