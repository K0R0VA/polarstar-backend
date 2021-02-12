using Microsoft.AspNetCore.Identity;

namespace Common.models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}