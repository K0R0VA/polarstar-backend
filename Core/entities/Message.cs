using Core.entities;

namespace Common.entities
{
    public class Message
    {
        public uint Id { get; set; }
        
        public int SenderId { get; set; }
        public User Sender { get; set; }
        
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        
        public string Text { get; set; }
    }
}