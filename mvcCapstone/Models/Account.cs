using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.AccessControl;
using System.Web;

namespace a_01_carApp.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        public string LName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Required(ErrorMessage = "Please enter Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage= "Please enter customer address")]
        [StringLength(50, ErrorMessage = "Only 50 characters allowed for address")]
        public string Address { get; set; }

        public List<Account> ShowAllAccounts { get; set; }

    }
}