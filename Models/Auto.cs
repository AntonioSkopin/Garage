using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Garage.Models
{
    public class Auto
    {
        public int AutoId { get; set; }

        [DisplayName("Kenteken")]
        [Required]
        public string AutoKenteken { get; set; }

        [DisplayName("Merk")]
        [Required]
        public string AutoMerk { get; set; }

        [DisplayName("Type")]
        [Required]
        public string AutoType { get; set; }

        [DisplayName("Eigenaar")]
        [Required]
        public string EigenaarNaam { get; set; }
    }
}