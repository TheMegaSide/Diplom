using System.Collections.Generic;
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
        // GET
        public IActionResult DTPTablePage()
        {
            List<DTP> dtps = Dbservice.GetDTPList();
            return View(dtps);
        }public IActionResult DTPEdit()
        {
            
            return View();
        }
        
    }
}