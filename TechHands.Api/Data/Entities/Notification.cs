# nullable disable

namespace TechHands.Api.Data.Entities
{
    public class Notification : Entity
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public ICollection<UserNotification> Users { get; set; } = new List<UserNotification>();
    }
}