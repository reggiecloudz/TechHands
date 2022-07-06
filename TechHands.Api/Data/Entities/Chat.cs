# nullable disable

namespace TechHands.Api.Data.Entities
{
    public class Chat : Entity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<ChatUser> Users { get; set; } = new List<ChatUser>();
        public ChatType Type { get; set; }
    }

    public enum ChatType
    {
        Room,
        Private
    }


}
