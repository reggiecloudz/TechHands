# nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Entities
{
    public class Reply : Entity
    {
        public long Id { get; set; }

        public string Comment { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public long AnswerId { get; set; }
        public Answer Answer { get; set; }

        public long? ParentId { get; set; }
        public Reply Parent { get; set; }

        public virtual ICollection<Reply> Children { get; set; } = new List<Reply>();
    }
}