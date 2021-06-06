using System.ComponentModel.DataAnnotations.Schema;

namespace Core.entities.order
{
    public class CompanyOrder: Order
    {
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
    }
}