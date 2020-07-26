using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Auto
    {
        public int AutoId { get; set; }
        [DisplayName("Kenteken")]
        public string AutoKenteken { get; set; }
        [DisplayName("Merk")]
        public string AutoMerk { get; set; }
        [DisplayName("Type")]
        public string AutoType { get; set; }
        [DisplayName("Eigenaar")]
        public string EigenaarNaam { get; set; }
    }
}