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
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Seller seller)
        {
            Dbservice.AddSeller(seller);
            return RedirectToAction(nameof(SellerAdd));
        }

        public IActionResult EditSeller(int id)
        {
            Seller seller = Dbservice.GetSellerById(id);
            return View(seller);
        }

        [HttpPost]
        public IActionResult Edit(Seller seller)
        {
            Dbservice.SellerEdit(seller);
            return RedirectToAction(nameof(SellerTablePage));
        }

        [HttpPost]
        public IActionResult SellerDelete(int id)
        {
            Seller seller = Dbservice.GetSellerById(id);
            return View(seller);
        }

        [HttpPost]
        public IActionResult Delete(Seller seller)
        {
            Dbservice.SellerDelete(seller);
            return RedirectToAction(nameof(SellerTablePage));
        }
    }
}