using System;

namespace TechHands.Api.Data.Entities
{
    public class Entity : IEntity
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}