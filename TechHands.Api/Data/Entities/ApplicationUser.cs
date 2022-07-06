using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TechHands.Api.Data.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<LikeArticle> Likes { get; set; } = new List<LikeArticle>();
        public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
        // public ICollection<UserNotification> Notifications { get; set; } = new List<UserNotification>();
        // public ICollection<ChatUser> Chats { get; set; } = new List<ChatUser>();
    }
}