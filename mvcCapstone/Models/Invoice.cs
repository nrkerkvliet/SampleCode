using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter AccountID")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Enter DocumentId")]
        public int DocumentId { get; set; }

        [Required(ErrorMessage = "Enter Rate")]
        public int Rate { get; set; }

        [Required(ErrorMessage = "Enter hours worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Enter Net Total")]
        public int NetTotal { get; set; }


        public List<Invoice> ShowAllInvoices { get; set; }



    }
}