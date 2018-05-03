using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a_01_carApp.DataAccess;
using a_01_carApp.Models;

namespace a_01_carApp.Controllers
{
    public class DocumentController : Controller
    {
        [HttpGet]
        public ActionResult InsertDocument()
        {
            return View();
        }



        [HttpPost]
        public ActionResult InsertDocument(Document document)
        {
            if (ModelState.IsValid)
            {
                DocumentsDataAccess access = new DocumentsDataAccess();
                string result = access.InsertData(document);
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
        public ActionResult ShowAllDocumentDetails()
        {
            Document document = new Document();
            DocumentsDataAccess access = new DocumentsDataAccess();
            document.ShowAllDocuments = access.SelectAllData();
            return View(document);
        }

        [HttpGet]
        public ActionResult EditDocument(int Id)
        {
            Document document = new Document();
            DocumentsDataAccess access = new DocumentsDataAccess();
            return View(access.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult EditDocument(Document document)
        {
            if (ModelState.IsValid)
            {
                DocumentsDataAccess access = new DocumentsDataAccess();
                string result = access.UpdateData(document);
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
        public ActionResult DeleteDocument(int Id)
        {
            Document document = new Document();
            DocumentsDataAccess accesss = new DocumentsDataAccess();
            return View(accesss.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult DeleteDocument(Document document)
        {
            DocumentsDataAccess access = new DocumentsDataAccess();
            string result = access.DeleteData(document);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }



        [HttpGet]
        public ActionResult ShowDocumentDetails(int Id)
        {
            DocumentViewModel document = new DocumentViewModel();
            DocumentsDataAccess access = new DocumentsDataAccess();
            return View(access.SelectSpecificData(Id));
        }


    }
}
