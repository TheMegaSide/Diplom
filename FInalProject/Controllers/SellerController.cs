using System;
using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class SellerController : Controller
    {
        private BDService Dbservice;

        public SellerController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [Authorize]
        public IActionResult SellerTablePage()
        {
            List<Seller> sellers = Dbservice.GetSellerList();
            return View(sellers);
        }
        public ActionResult SellerAdd()
        {
            List<Seller> sellers = new List<Seller>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Sellers";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Seller seller = new Seller
                        {
                            SellerName =  rdr["SellerName"].ToString(),
                            SellerPhone = rdr["SellerPhone"].ToString(),
                            SellerAddress = rdr["SellerAdress"].ToString()
                        };
                        sellers.Add(seller);
                    }
                }
            }


            ViewBag.listOfProducts = sellers;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Seller seller)
        {
            Dbservice.AddSeller(seller);
            return RedirectToAction(nameof(SellerAdd));
        }
    }
}