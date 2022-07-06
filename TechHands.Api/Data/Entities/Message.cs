#nullable disable

namespace TechHands.Api.Data.Entities
{
    public class Message : Entity
    {
        public long Id { get; set; }
        public string Nick { get; set; }
        public string Content { get; set; }
        public long ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
