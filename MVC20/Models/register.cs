using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC20.Models
{
    public class register
    {
        [Required]
        public int id { get; set; }
        [Required]
       
        [DataType(DataType.Text)]
        public string uname { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string pwd { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("pwd")]
        public string cpwd { get; set; }

        [Required]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [StringLength(10)]
        public string phone { get; set; }
    }
}