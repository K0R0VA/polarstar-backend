using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.common.persistence;
using Application.common.services;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.features.User.Queries.GetCurrentUserInfoQuery
{
    public class GetCurrentUserInfoQuery: IRequest<CurrentUserDto> { }

    public class GetCurrentUserInfoQueryHandler : IRequestHandler<GetCurrentUserInfoQuery, CurrentUserDto>
    {
        private readonly ICurrentUserService _userService;
        private readonly ApplicationDbContext _context;

        public GetCurrentUserInfoQueryHandler(ICurrentUserService userService, ApplicationDbContext context)
        {
            _userService = userService;
            _context = context;
        }
        public async Task<CurrentUserDto> Handle(GetCurrentUserInfoQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users
                .Where(user => user.Id == _userService.Id)
                .Select(user => new CurrentUserDto
                {
                    
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}