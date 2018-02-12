using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models.Vehicles
{
    public class VehicleModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

    }
}