using System.Text.Json.Serialization;

namespace Common.models
{
    public class Message
    {
        [JsonIgnore]
        public uint Id { get; set; }
        [JsonIgnore]
        public User Sender { get; set; }
        [JsonIgnore]
        public User Receiver { get; set; }
        public string Content { get; set; }
    }
}