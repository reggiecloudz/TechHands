#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using TechHands.Api.Data.Common;

namespace TechHands.Api.Data.Entities
{

    public class Question : Entity
    {
        public long Id { get; set; }
        
        [Required]
        [MaxLength(DataValidation.QuestionTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DataValidation.QuestionContentMaxLength)]
        public string Content { get; set; }

        public bool IsAnswered { get; set; } = false;

        [Required]
        public string InquirerId { get; set; }

        public virtual ApplicationUser Inquirer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
