#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TechHands.Api.Data.Entities
{
    public class LikeArticle
    {
        [Required]
        public long ArticleId { get; set; }

        public virtual Article Article { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
