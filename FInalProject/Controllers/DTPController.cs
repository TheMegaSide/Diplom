using System;
using System.Collections.Generic;
using FInalProject.Atribute;
using FInalProject.Data;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class DTPController : Controller
    {
        private BDService Dbservice;
        
        public DTPController(BDService dbservice)
        {
            Dbservice = dbservice;
            
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DTPTablePage()
        {
            List<DTP> dtps = Dbservice.GetDTPList();
            return View(dtps); 
        
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DTPEdit(int id)
        {
            DTP dtp = Dbservice.GetDTPById(id);
            return View(dtp);
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult Edit(DTP dtp)
        {
            Dbservice.EditDTP(dtp);
            return RedirectToAction(nameof(DTPTablePage));
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult DTPadd()
        {
            
            return View();
        }
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public IActionResult Create(DTP dtp)
        {
            Console.WriteLine(dtp.ToString());
            Dbservice.AddDTP(dtp);
            return RedirectToAction(nameof(DTPTablePage));
        }

        public IActionResult Delete(int id)
        {
            Dbservice.DeleteDTP(id);
            return RedirectToAction(nameof(DTPTablePage));
        }
        
        
    }
}