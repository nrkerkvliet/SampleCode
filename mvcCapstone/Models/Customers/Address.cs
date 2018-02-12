using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models.Customers
{
    public class Address
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string StreetAddress { get; set; }

        public string AptSuite { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
        
        public int CustomerId { get; set; }
    }
}