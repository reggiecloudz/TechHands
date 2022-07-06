#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using TechHands.Api.Data.Common;

namespace TechHands.Api.Data.Entities
{

    public class Comment : Entity
    {
        public long Id { get; set; }

        [Required]
        public long ArticleId { get; set; }

        public virtual Article Article { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [Required]
        [MaxLength(DataValidation.CommentContentMaxLength)]
        public string Content { get; set; }
    }
}
