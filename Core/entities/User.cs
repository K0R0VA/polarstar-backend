using System.Collections.Generic;
using Core.entities.order;
using Microsoft.AspNetCore.Identity;

namespace Core.entities
{
    public class User: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
