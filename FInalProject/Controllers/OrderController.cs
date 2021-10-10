using System;
using System.Collections.Generic;
using System.Linq;
using FInalProject.Models;
using FInalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Controllers
{
    public class OrderController : Controller
    {
        private BDService Dbservice;

        public OrderController(BDService dbservice)
        {
            Dbservice = dbservice;
        }
        [Authorize]
        public IActionResult OrderTablePage()
        {
            List<Order> orders = Dbservice.GetOrderList();
            
            
            return View(orders);
        }
        public ActionResult OrderAdd()
        {
            List<Order> orders = new List<Order>();

            using (OracleConnection con = new OracleConnection(Dbservice.ConnectionString))
            {
                con.Open();
                string comText = "select * from Orders";

                using (OracleCommand cmd = new OracleCommand(comText, con))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Order order = new Order
                        {
                            OrderDate =  (DateTime)rdr["OrderDate"],
                            CompletionDate = (DateTime)rdr["CompletionDate"],
                            Completion = rdr["Completion"].ToString(),
                            TotalPrice = (decimal)rdr["TotalPrice"],
                            ClientId = (decimal)rdr["ClientId"],
                            OrderList = rdr["OrderList"].ToString()
                        };
                        orders.Add(order);
                    }
                }
            }


            ViewBag.listOfProducts = orders;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Order order)
        {
            Dbservice.AddOrder(order);
            return RedirectToAction(nameof(OrderAdd));
        }
    }
}