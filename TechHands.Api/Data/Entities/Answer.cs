#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using TechHands.Api.Data.Common;

namespace TechHands.Api.Data.Entities
{

    public class Answer : Entity
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(DataValidation.AnswerContentMaxLength)]
        public string Content { get; set; }

        public uint UpVotes { get; set; } = 0;

        public uint DownVotes { get; set; } = 0;

        [Required]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [Required]
        public long QuestionId { get; set; }

        public virtual Question Question { get; set; }

         public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
    }
}
