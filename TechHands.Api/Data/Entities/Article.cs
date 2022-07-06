﻿#nullable disable
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

        [Required]
        public string TechnicianId { get; set; }

        public virtual Technician Technician { get; set; }

        public virtual ICollection<LikeArticle> Likes { get; set; } = new List<LikeArticle>();

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
