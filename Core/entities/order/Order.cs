using System;
using Common.enums;

namespace Core.entities.order
{
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        
        public PaymentMethodEnum PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
        public int TransportServiceId { get; set; }
        public TransportService TransportService { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}