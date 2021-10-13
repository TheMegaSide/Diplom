using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class ClientController : Controller
    {
        private BDService Dbservice;
        
        public ClientController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        
        [Authorize]
        public IActionResult ClientTablePage()
        {
            List<Client> clients = Dbservice.GetClientList();
            return View(clients);
        }
        public ActionResult ClientAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Client client)
        {
            Dbservice.AddClient(client);
            return RedirectToAction(nameof(ClientAdd));
        }
        public IActionResult EditClient(int id)
        {
            Client client = Dbservice.GetClientById(id);
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Client client)
        {
            Dbservice.ClientEdit(client);
            return RedirectToAction(nameof(ClientTablePage));
        }

        public IActionResult ClientDelete(int id)
        {
            Client client = Dbservice.GetClientById(id);
            return View(client);
        }
        
        [HttpPost]
        public IActionResult Delete(Client client)
        {
            Dbservice.DeleteClient(client);
            return RedirectToAction(nameof(ClientTablePage));
        }
    }
}