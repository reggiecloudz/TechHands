#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TechHands.Api.Data.Entities
{
    public abstract class Profile : Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string IdentityId { get; set; }
        public ApplicationUser Identity { get; set; }
    }
}