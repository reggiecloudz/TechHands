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
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
        //DateTime startTime = DateTime.Parse(Input.Date).ToString("hh:mm tt");
        public string StartWorkTime { get; set; }
        public string EndWorkTime { get; set; }
        public decimal HourlyRate { get; set; } = 0.00m;
        public bool OpenToCommunity { get; set; } = false;
        public string ClientId { get; set; }
        public Client Client { get; set; }

        public string TechnicianId { get; set; }
        public Technician Technician { get; set; }

        public virtual ICollection<Part> Parts { get; set; } = new List<Part>();
    }
}