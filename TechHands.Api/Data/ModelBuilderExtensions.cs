using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TechHands.Api.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedRoles(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new List<IdentityRole>
            {
                new IdentityRole 
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole 
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Client",
                    NormalizedName = "CLIENT"
                },
                new IdentityRole 
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Technician",
                    NormalizedName = "TECHNICIAN"
                }
            });
        }
    }
}