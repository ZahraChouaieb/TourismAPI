using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APITourismApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Required]
        [MaxLength(128)]
        public string Name { get; set; }


        [Required]
        [MaxLength(256)]
        public string Email { get; set; }


        [Required]
        [MaxLength(256)]
        public String Password { get; set; }

    }
}