using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a_01_carApp.DataAccess;
using a_01_carApp.Models.Invoices;
using a_01_carApp.Models.Vehicles;

namespace a_01_carApp.Controllers.Invoices
{
    public class InvoicesController : Controller
    {
        [HttpGet]
        public ActionResult ShowAllInvoices()
        {
            var invoice = new Invoice();
            InvoicesDataAccess access = new InvoicesDataAccess();
            invoice.ShowAllInvoices = access.SelectAllInvoices();
            return PartialView(invoice);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Invoice());
        }

        [HttpPost]
        public JsonResult InsertInvoice(Invoice objInvoice)
        {
            InvoicesDataAccess access = new InvoicesDataAccess();

            try
            {
                access.InsertInvoice(objInvoice);
                return Json(objInvoice, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}