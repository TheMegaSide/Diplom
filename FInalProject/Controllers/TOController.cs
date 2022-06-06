using System;
using System.Collections.Generic;
using System.Transactions;
using FInalProject.Atribute;
using FInalProject.Data;
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
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult GetAllTO()
        {
            
            return RedirectToAction(nameof(TOTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult TOTablePage(string date)
        {
            try
            {
                var year = date.Substring(0, 4);

                var month = date.Substring(5, 2);

                ViewBag.Month = month;
                ViewBag.Year = year;
                List<TO> tos = Dbservice.GetTOList(month, year);
                return View(tos);
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("Index","Home");
            }
            
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult TOAdd(string month, string year)
        {
            ViewBag.Month = month;
            ViewBag.Year = year;
            return View();
        }

        [HttpPost]
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult Create(TO to)
        {
            Dbservice.AddTO(to);
            return RedirectToAction(nameof(TOAdd));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult TOEditPage(int id, string month, string year)
        {
            ViewBag.Month = month;
            ViewBag.Year = year;
            TO to = Dbservice.GetToById(id);
            return View(to);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public void  Edit(TO to)
        {
            Dbservice.EditTO(to);
            
        }
        [AuthorizeRoles(Roles.SuperAdmin)]
        public ActionResult  Delete(int id, int month1, int year1)
        {
            Dbservice.DeleteTO(id);
            return RedirectToAction(nameof(TOTablePage), new {month = month1, year = year1});

        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ActionResult  CompleteTO(int id, string month1, string year1, DateTime date, int auto, string toType)
        {
            ViewBag.Month = month1;
            ViewBag.Year = year1;
            Dbservice.TOCompleted(id, date, auto, toType);
            return RedirectToAction(nameof(TOTablePage),new {month=month1, year=year1});
            
        }

       
    }
}