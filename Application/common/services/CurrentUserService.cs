using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Application.common.services
{
    public class CurrentUserService: ICurrentUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public int Id
        {
            get
            {
                var sid = _contextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Sid);
                return int.Parse(sid!);
            }
        }

        public string Username
        {
            get
            {
                var name = _contextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name);
                return name;
            }
        }

        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
    }
}