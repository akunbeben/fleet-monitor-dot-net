﻿using System;

namespace FleetMonitoring.WebUI.Models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}