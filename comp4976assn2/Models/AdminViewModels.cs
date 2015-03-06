using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace comp4976assn2.Models
{
    public class AddRoleViewModel
    {
        [Key]
        public string RoleId { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

    }

    public class AddUserViewModel
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }

    public class AddUserToRoleViewModel
    {

        public string UserId { get; set; }

        public string RoleId { get; set; }

    }
}