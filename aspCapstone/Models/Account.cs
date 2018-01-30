using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace a_01_carApp.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }
    }
}