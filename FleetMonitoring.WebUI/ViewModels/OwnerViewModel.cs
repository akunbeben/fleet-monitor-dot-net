using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FleetMonitoring.WebUI.ViewModels
{
    public class OwnerViewModel
    {
        public int OwnerId { get; set; }

        [Display(Name = "Owner Name")]
        [Required(ErrorMessage = "Owner name field is required")]
        public string Name { get; set; }
    }
}