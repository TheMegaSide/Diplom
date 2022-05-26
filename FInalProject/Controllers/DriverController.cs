using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class DriverController : Controller
    {
        private BDService Dbservice;

        public DriverController(BDService dbservice)
        {
            Dbservice = dbservice;
        }

        [Authorize]
        public IActionResult DriverTablePage()
        {
            List<Driver> drivers = Dbservice.GetDriverList();
            return View(drivers);
        }
        public ActionResult DriverAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Driver driver)
        {
            Dbservice.AddDriver(driver);
            return RedirectToAction(nameof(DriverAdd));
        }
        public IActionResult DriverDelete(int id)
        {
            Driver driver = Dbservice.GetDriverById(id);
            return View(driver);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(Driver driver)
        {
            Dbservice.DeleteDriver(driver);
            return RedirectToAction(nameof(DriverTablePage));
        }
        public IActionResult DriverEdit(int id)
        {
            Driver driver = Dbservice.GetDriverById(id);
            return View(driver);
        }

        public IActionResult Edit(Driver driver)
        {
            Dbservice.DriverEdit(driver);
            return RedirectToAction(nameof(DriverTablePage));
        }
        public IActionResult DriverSearch(string key, string field)
        {
            List<Driver> drivers =Dbservice.GetDriversByField(key, field);
            return View(drivers);
        }
    }
}
