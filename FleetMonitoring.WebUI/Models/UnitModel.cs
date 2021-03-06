using System.ComponentModel.DataAnnotations;

namespace FleetMonitoring.WebUI.Models
{
    public class UnitModel : BaseModel
    {
        public int UnitId { get; set; }

        [Display(Name = "Unit ID")]
        [Required(ErrorMessage = "Unit Identity is required")]
        public string Identity { get; set; }
        
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Unit Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Unit Description is required")]
        public string Description { get; set; }

        [Display(Name = "Unit Owner")]
        [Required(ErrorMessage = "Unit must have owner.")]
        public int OwnerId { get; set; }
    }
}