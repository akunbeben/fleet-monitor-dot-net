using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FleetMonitoring.WebUI.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email field is required")]
        public string Email { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }
        
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }
        
        [Display(Name = "Password Confirmation")]
        [Required(ErrorMessage = "Password Confirmation field is required")]
        public string PasswordConfirmation { get; set; }

    }
}