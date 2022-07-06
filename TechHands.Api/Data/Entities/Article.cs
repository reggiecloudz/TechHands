#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechHands.Api.Data.Common;

namespace TechHands.Api.Data.Entities
{

    public class Article : Entity
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(DataValidation.ArticleTitleMaxLength)]
        public string Title { get; set; }

        public string VideoUrl { get; set; }

        [Required]
        [MaxLength(DataValidation.ArticleContentMaxLength)]
        public string Content { get; set; }

        public string Picture { get; set; }
    }
}
