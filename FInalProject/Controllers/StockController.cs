using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class StockController : Controller
    {
        private BDService Dbservice;

        public StockController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [Authorize]
        public IActionResult StockTablePage()
        {
            List<Stock> stocks = Dbservice.GetStockList();
            return View(stocks);
        }
        public ActionResult StockAdd()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Stock stock)
        {
            Dbservice.AddStock(stock);
            return RedirectToAction(nameof(StockAdd));
        }
        public IActionResult EditStock(int id)
        {
            Stock stock = Dbservice.GetStockById(id);
            return View(stock);
        }

        [HttpPost]
        public IActionResult Edit(Stock stock)
        {
            Dbservice.EditStock(stock);
            return RedirectToAction(nameof(StockTablePage));
        }

        [HttpPost]
        public IActionResult DeleteStock(int id)
        {
            Stock stock = Dbservice.GetStockById(id);
            return View(stock);
        }

        [HttpPost]
        public IActionResult Delete(Stock stock)
        {
            Dbservice.DeleteStock(stock);
            return RedirectToAction(nameof(StockTablePage));
        }
    }
}