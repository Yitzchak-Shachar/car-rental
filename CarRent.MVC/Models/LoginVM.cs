using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CarRent.MVC.Models
{

    public class LoginVM
    {
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 4, ErrorMessage = "User name must be 4-10 charecters")]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 4, ErrorMessage = "Password must be 4-10 charecters")]
        public string UserPassword { get; set; }


    }
}