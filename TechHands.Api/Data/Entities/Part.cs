#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Entities
{
    public class Part : Entity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public uint Quantity { get; set; }

        public long InvoiceId { get; set; }

        public virtual Invoice Invoice { get; set; }

        public long IssueId { get; set; }

        public virtual Issue Issue { get; set; }

    }
}