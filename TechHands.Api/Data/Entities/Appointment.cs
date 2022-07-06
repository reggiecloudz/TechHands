#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechHands.Api.Data.Common;

namespace TechHands.Api.Data.Entities
{

    public class Appointment : Entity
    {
        public long Id { get; set; }

        [Required]
        public string ClientId { get; set; }

        public virtual Client Client { get; set; }

        [Required]
        public string TechnicianId { get; set; }

        public virtual Technician Technician { get; set; }

        [Required]
        public long IssueId { get; set; }

        public virtual Issue Issue { get; set; }

        public string Location { get; set; }

        public DateTime? MeetinDate { get; set; }
    }
}
