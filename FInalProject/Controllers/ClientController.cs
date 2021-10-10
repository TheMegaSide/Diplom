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
        // GET
        [Authorize]
        public IActionResult ClientTablePage()
        {
            List<Client> clients = Dbservice.GetClientList();
            return View(clients);
        }
        public ActionResult ClientAdd()
        {
            List<Client> clients= new List<Client>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Clients";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Client client = new Client
                        {
                            ClientName =  rdr["ClientName"].ToString(),
                            ClientPhone = rdr["ClientPhone"].ToString(),
                            ClientAdress= rdr["ClientAdress"].ToString(),
                            ClientType =  rdr["ClientType"].ToString()
                        };
                        clients.Add(client);
                    }
                }
            }


            ViewBag.listOfProducts = clients;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Client client)
        {
            Dbservice.AddClient(client);
            return RedirectToAction(nameof(ClientAdd));
        }
    }
}