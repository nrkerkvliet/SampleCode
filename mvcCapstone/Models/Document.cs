using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Description")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Enter  VehicleId")]
        public int VehicleId { get; set; }


        public List<Document> ShowAllDocuments { get; set; }

    }
}