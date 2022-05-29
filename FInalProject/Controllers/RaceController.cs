using System.Collections.Generic;
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
        // GET
        public IActionResult RaceTablePage()
        {
            List<Race> race = Dbservice.GetRaceList();
            return View(race);
        }
        public ActionResult RaceAdd()
        {
           
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Race race)
        {
            Dbservice.AddRace(race);
            return RedirectToAction(nameof(RaceAdd));
        }
        public IActionResult RaceEdit(int id)
        {
            Race race = Dbservice.GetRaceById(id);
            return View(race);
        }

        public IActionResult Edit(Race race)
        {
            Dbservice.RaceEdit(race);
            return RedirectToAction(nameof(RaceTablePage));
        }

        public IActionResult RaceDelete(int id)
        {
            Race race = Dbservice.GetRaceById(id);
            return View(race);
        }

        [HttpPost]
        [Authorize]
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
    }
}