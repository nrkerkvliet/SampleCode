using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a_01_carApp.DataAccess;
using a_01_carApp.Models;

namespace a_01_carApp.Controllers
{
    public class AccountsController : Controller
    {
        // GET:/Accounts/
        [HttpGet]
        public ActionResult InsertAccount()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                AccountsDataAccess access = new AccountsDataAccess();
                string result = access.InsertData(account);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("","error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult ShowAllAccountDetails()
        {
            Account account = new Account();
            AccountsDataAccess access = new AccountsDataAccess();
            account.ShowAllAccounts = access.SelectAllData();
            return View(account);
        }

        [HttpGet]
        public ActionResult EditAccount(string Id)
        {
            Account account = new Account();
            AccountsDataAccess access = new AccountsDataAccess();
            return View(access.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult EditAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                AccountsDataAccess access = new AccountsDataAccess();
                string result = access.UpdateData(account);
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
        public ActionResult DeleteAccount(string Id)
        {
            Account account = new Account();
            AccountsDataAccess accesss = new AccountsDataAccess();
            return View(accesss.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult DeleteAccount(Account account)
        {
            AccountsDataAccess access= new AccountsDataAccess();
            string result = access.DeleteData(account);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }

    }
}