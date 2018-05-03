using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models
{
    public class InvoiceViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter AccountID")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Enter DocumentId")]
        public int DocumentId { get; set; }

        [Required(ErrorMessage = "Enter Rate")]
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "Enter hours worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Enter Net Total")]
        public decimal NetTotal { get; set; }


        [Required(ErrorMessage = "Enter First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Enter Detaills")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Enter Vehicle Model")]
        public string VehicleModel { get; set; }

    }
}