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
        public string VIN { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Model")]
        public string VehicleModel { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Year")]
        public int VehicleYear { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Color")]
        public string VehicleColor { get; set; }

        public List<Vehicle> ShowAllVehicles { get; set; }

    }
}