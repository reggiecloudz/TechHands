using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Constants
{
    public static class IssueStatus
    {
        public static readonly string Submitted = "Submitted";
        public static readonly string Review = "Review";
        public static readonly string Accepted = "Accepted";
        public static readonly string Declined = "Declined";
        public static readonly string Waiting = "Waiting";
        public static readonly string Working = "Working";
        public static readonly string Completed = "Completed";
        public static readonly string Evaluation = "Evaluation";
        public static readonly string Resolved = "Resolved";
        public static readonly string Unresolved = "Unresolved";

        public static IReadOnlyList<string> ToList()
        {
            return new List<string>
            {
                Submitted,
                Review,
                Accepted,
                Declined,
                Waiting,
                Working,
                Completed,
                Evaluation,
                Resolved,
                Unresolved
            };
        }
    }
}