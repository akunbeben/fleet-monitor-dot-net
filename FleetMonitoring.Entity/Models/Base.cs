using System;

namespace FleetMonitoring.Entity.Models
{
    public class Base
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
