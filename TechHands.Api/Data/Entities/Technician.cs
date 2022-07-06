#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Entities
{
    public class Technician : Profile
    {
        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
        public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
        // public virtual ICollection<Expertise> Expertises { get; set; } = new List<Expertise>();
    }
}