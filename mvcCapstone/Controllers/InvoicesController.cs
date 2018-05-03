using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a_01_carApp.DataAccess;
using a_01_carApp.Models;

namespace a_01_carApp.Controllers
{
    public class InvoicesController : Controller
    {
        [HttpGet]
        public ActionResult InsertInvoice()
        {
            return View();
        }



        [HttpPost]
        public ActionResult InsertInvoice(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                InvoicesDataAccess access = new InvoicesDataAccess();
                string result = access.InsertData(invoice);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult ShowAllInvoiceDetails()
        {
            Invoice invoice = new Invoice();
            InvoicesDataAccess access = new InvoicesDataAccess();
            invoice.ShowAllInvoices = access.SelectAllData();
            return View(invoice);
        }

        [HttpGet]
        public ActionResult EditInvoice(int Id)
        {
            Invoice invoice = new Invoice();
            InvoicesDataAccess access = new InvoicesDataAccess();
            return View(access.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult EditInvoice(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                InvoicesDataAccess access = new InvoicesDataAccess();
                string result = access.UpdateData(invoice);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteInvoice(int Id)
        {
            Invoice invoice = new Invoice();
            InvoicesDataAccess accesss = new InvoicesDataAccess();
            return View(accesss.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult DeleteInvoice(Invoice invoice)
        {
            InvoicesDataAccess access = new InvoicesDataAccess();
            string result = access.DeleteData(invoice);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }



        [HttpGet]
        public ActionResult ShowInvoiceDetails(int Id)
        {
            InvoiceViewModel invoice = new InvoiceViewModel();
            InvoicesDataAccess access = new InvoicesDataAccess();
            return View(access.SelectSpecificData(Id));
        }
    }
}
