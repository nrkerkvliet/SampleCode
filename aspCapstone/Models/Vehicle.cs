using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter VIN")]
        public string Vin { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Model")]
        public string Model { get; set; }
    }
}