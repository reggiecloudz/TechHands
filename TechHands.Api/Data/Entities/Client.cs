# nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TechHands.Api.Data.Entities
{
    public class Client : Profile
    {
        public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}