using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a_01_carApp.DataAccess;
using a_01_carApp.Models;

namespace a_01_carApp.Controllers
{
    public class VehiclesController : Controller
    {
        // GET:/Vehicles/
        [HttpGet]
        public ActionResult InsertVehicle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult InsertVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                VehiclesDataAccess access = new VehiclesDataAccess();
                string result = access.InsertData(vehicle);
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
        public ActionResult ShowAllVehicleDetails()
        {
            Vehicle vehicle = new Vehicle();
            VehiclesDataAccess access = new VehiclesDataAccess();
            vehicle.ShowAllVehicles = access.SelectAllData();
            return View(vehicle);
        }

        [HttpGet]
        public ActionResult EditVehicle(int Id)
        {
            Vehicle vehicle = new Vehicle();
            VehiclesDataAccess access = new VehiclesDataAccess();
            return View(access.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult EditVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                VehiclesDataAccess access = new VehiclesDataAccess();
                string result = access.UpdateData(vehicle);
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
        public ActionResult DeleteVehicle(int Id)
        {
            Vehicle vehicle = new Vehicle();
            VehiclesDataAccess accesss = new VehiclesDataAccess();
            return View(accesss.SelectDataById(Id));
        }

        [HttpPost]
        public ActionResult DeleteVehicle(Vehicle vehicle)
        {
            VehiclesDataAccess access = new VehiclesDataAccess();
            string result = access.DeleteData(vehicle);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }
    }
}
