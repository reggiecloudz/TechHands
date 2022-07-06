#nullable disable
using System;

namespace TechHands.Api.Data.Entities
{
    public class ChatUser
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public long ChatId { get; set; }
        public Chat Chat { get; set; }

        public ChatRole Role { get; set; }
    }
}
