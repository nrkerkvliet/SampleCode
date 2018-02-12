using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models.Customers
{
    public class Phone
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Number { get; set; }

        public int CustomerId { get; set; }
    }
}