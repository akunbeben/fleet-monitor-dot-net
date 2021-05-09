using System.ComponentModel.DataAnnotations;

namespace FleetMonitoring.WebUI.Models
{
    public class OwnerModel : BaseModel
    {
        public int OwnerId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Owner Name field is required")]
        public string Name { get; set; }
    }
}