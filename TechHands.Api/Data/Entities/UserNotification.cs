#nullable disable

namespace TechHands.Api.Data.Entities
{
    public class UserNotification
    {
        public long NotificationId { get; set; }
        public Notification Notification { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsRead { get; set; } = false;
    }
}