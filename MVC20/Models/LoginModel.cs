using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC20.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="username is Required")]
        public string username { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        public string password { get; set; }
        
    }
}