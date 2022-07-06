#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Entities
{
    public class Issue : Entity
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Solution { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ResolvedDate { get; set; }

        public string ClientId { get; set; }
        public Client Client { get; set; }

        public string TechnicianId { get; set; }
        public Technician Technician { get; set; }
    }
}