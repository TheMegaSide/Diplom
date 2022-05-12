using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class CarController : Controller
    {
        private BDService Dbservice;

        public CarController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [Authorize]
        public IActionResult CarTablePage()
        {
            List<Car> cars = Dbservice.GetCarsList();
            return View(cars);
        }
        public ActionResult CarAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Car car)
        {
            Dbservice.AddCar(car);
            return RedirectToAction(nameof(CarAdd));
        }
        public IActionResult CarEdit(string id)
        {
            Car car = Dbservice.GetCarById(id);
            return View(car);
        }
        public IActionResult Edit(Car car)
        {
            Dbservice.CarEdit(car);
            return RedirectToAction(nameof(CarTablePage));
        }
        public IActionResult CarDelete(string id)
        {
            Car car = Dbservice.GetCarById(id);
            return View(car);
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult Delete(Car car)
        {
            Dbservice.DeleteCar(car);
            return RedirectToAction(nameof(CarTablePage));
        }
    }
}