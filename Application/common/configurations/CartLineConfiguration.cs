using Core.entities.order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;

namespace Application.common.configurations
{
    public class CartLineConfiguration: IEntityTypeConfiguration<CartLine>
    {
        public void Configure(EntityTypeBuilder<CartLine> builder)
        {
            builder.HasKey(cartLine =>
            new {
                ProductId = cartLine.ProductId, CartId = cartLine.CartId
            });
        }
    }
}