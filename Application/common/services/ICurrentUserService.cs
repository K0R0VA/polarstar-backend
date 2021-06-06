using System.Security.Claims;

namespace Application.common.services
{
    public interface ICurrentUserService
    {
        int Id { get; }
        string Username { get; }
    }
}