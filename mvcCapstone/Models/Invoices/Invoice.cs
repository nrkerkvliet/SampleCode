using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models.Invoices
{
    public class Invoice
    {
        public int Id { get; set; }

        public string Details { get; set; }

        public DateTime DateBilled { get; set; }

        public DateTime PaymentDateReceived { get; set; }

        public DateTime PaymentDateDue { get; set; }

        public string InvoiceNumber { get; set; }

        //before deductions etc
        public double InvoiceGross { get; set; }

        public double CreditTotal { get; set; }

        public double PaymentReceived { get; set; }

        public int CustomerId { get; set; }




    }
}