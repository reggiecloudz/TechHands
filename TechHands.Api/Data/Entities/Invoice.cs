#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Entities
{
    public class Invoice : Entity
    {
        public long Id { get; set; }

        public uint TimeBilled { get; set; }

        public decimal Rate { get; set; }

        public decimal PartsCost { get; set; } = 0.00m;

        public decimal Total { get; set; }

        [Required]
        public string ClientId { get; set; }

        public virtual Client Client { get; set; }

        [Required]
        public string TechnicianId { get; set; }

        public virtual Technician Technician { get; set; }

        [Required]
        public long IssueId { get; set; }

        public virtual Issue Issue { get; set; }

        public virtual ICollection<Part> Parts { get; set; } = new List<Part>();
    }
}