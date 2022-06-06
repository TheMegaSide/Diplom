using System.Collections.Generic;
using FInalProject.Atribute;
using FInalProject.Data;
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

        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DriverTablePage()
        {
            List<Driver> drivers = Dbservice.GetDriverList();
            return View(drivers);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult DriverAdd()
        {
            return View();
        }

        [HttpPost]
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult Create(Driver driver)
        {
            Dbservice.AddDriver(driver);
            return RedirectToAction(nameof(DriverAdd));
        }
        

        [HttpPost]
        [AuthorizeRoles(Roles.SuperAdmin)]
        public IActionResult Delete(Driver driver)
        {
            Dbservice.DeleteDriver(driver);
            return RedirectToAction(nameof(DriverTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DriverEdit(int id)
        {
            Driver driver = Dbservice.GetDriverById(id);
            return View(driver);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult Edit(Driver driver)
        {
            Dbservice.DriverEdit(driver);
            return RedirectToAction(nameof(DriverTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DriverSearch(string key, string field)
        {
            List<Driver> drivers =Dbservice.GetDriversByField(key, field);
            return View(drivers);
        }
    }
}
