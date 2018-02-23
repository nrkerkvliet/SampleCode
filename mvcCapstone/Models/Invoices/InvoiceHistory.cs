using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a_01_carApp.Models.Invoices
{
    public class InvoiceHistory
    {
        public int Id { get; set; }

        public DateTime PaymentDateReceived { get; set; }

        public int CustomerId { get; set; }

        public int InvoiceId { get; set; }

        public string InvoiceNumber { get; set; }

        public double InvoiceGross { get; set; }

        public double CreditTotal { get; set; }

        public double PaymentTotal { get; set; }
    }
}