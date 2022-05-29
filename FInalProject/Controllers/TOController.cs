using System.Collections.Generic;
using System.Transactions;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class TOController : Controller
    {
        private BDService Dbservice;

        public TOController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        public ActionResult GetAllTO()
        {
            
            return RedirectToAction(nameof(TOTablePage));
        }
        [Authorize]
        public IActionResult TOTablePage(string month, string year)
        {
            ViewBag.Month = month;
            ViewBag.Year = year;
            List<TO> tos = Dbservice.GetTOList(month, year);
            return View(tos);
        }
        public ActionResult TOAdd(string month, string year)
        {
            ViewBag.Month = month;
            ViewBag.Year = year;
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(TO to)
        {
            Dbservice.AddTO(to);
            return RedirectToAction(nameof(TOAdd));
        }
    }
}