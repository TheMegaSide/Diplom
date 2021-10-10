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
            List<Stock> stocks = new List<Stock>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Stocks";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Stock stock = new Stock
                        {
                            StockId =  (int)(long)rdr["StockId"],
                            StockAddress = rdr["StockAdress"].ToString()
                        };
                        stocks.Add(stock);
                    }
                }
            }


            ViewBag.listOfProducts = stocks;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Stock stock)
        {
            Dbservice.AddStock(stock);
            return RedirectToAction(nameof(StockAdd));
        }
    }
}