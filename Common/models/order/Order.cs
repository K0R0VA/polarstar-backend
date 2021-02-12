using System;

namespace Common.models.order
{
    public class Order
    {   
        public int Id { get; set; }
        public uint CartId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}