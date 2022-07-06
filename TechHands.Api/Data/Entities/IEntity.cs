using System;

namespace TechHands.Api.Data.Entities
{
    public interface IEntity
    {
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
    }
}