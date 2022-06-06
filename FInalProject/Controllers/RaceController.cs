using System;
using System.Collections.Generic;
using FInalProject.Atribute;
using FInalProject.Data;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class RaceController : Controller
    {
        private BDService Dbservice;

        public RaceController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult RaceTablePage()
        {
            List<Race> race = Dbservice.GetRaceList();
            return View(race);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult RaceAdd(int id)
        {
            Console.WriteLine(id);
            ViewBag.Driver = id;
            return View();
        }

        [HttpPost]
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult Create(Race race)
        {
            Dbservice.AddRace(race);
            return RedirectToAction(nameof(RaceTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult RaceEdit(int id)
        {
            Race race = Dbservice.GetRaceById(id);
            return View(race);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult Edit(Race race)
        {
            Dbservice.RaceEdit(race);
            return RedirectToAction(nameof(RaceTablePage));
        }
        [AuthorizeRoles(Roles.SuperAdmin)]
        public IActionResult RaceDelete(int id)
        {
            Race race = Dbservice.GetRaceById(id);
            return View(race);
        }

        [HttpPost]
        [AuthorizeRoles(Roles.SuperAdmin)]
        public IActionResult Delete(int id)
        {
            Dbservice.DeleteRace(id);
            return RedirectToAction(nameof(RaceTablePage));
        }
        
        public ActionResult GetRaceChart()
        {
            List<Race> race = Dbservice.GetRaceList();
            // var myChart = new System.Web.Helpers.Chart(width: 600, height: 400)
            //                               .AddTitle("Перевезенные грузы")
            //                               .AddSeries(
            //                                   name: "Грузы",
            //                                   xValue: race,xField:"date",
            //                                   yValues: race,yFields:"value")
            //                               .Write();
            return null;
        }

        public ActionResult RaceSearch(DateTime startdate, DateTime enddate)
        {
            List<Race> races = Dbservice.GetRaceByDate(startdate, enddate);
            return View(races);
        }
        
    }
}