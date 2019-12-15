using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APITourismApp.Models
{
    public class Lieu
    {
        [Key]
        public int lieuId { get; set; }


        [Required]
        [MaxLength(128)]
        public string nameLieu { get; set; }

        [Required]
        [MaxLength(128)]
        public string ville { get; set; }


        [Required]
        [MaxLength(256)]
        public string zoneGeo { get; set; }


        [Required]
        [MaxLength(256)]
        public String temperatureZone { get; set; }

        [Required]
        [MaxLength(256)]
        public String image { get; set; }

        [Required]
        [MaxLength(256)]
        public String description { get; set; }
    }
}