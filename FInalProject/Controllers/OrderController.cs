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
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Order order)
        {
            Dbservice.AddOrder(order);
            return RedirectToAction(nameof(OrderAdd));
        }

        public IActionResult EditOrder(int id)
        {
            Order order = Dbservice.GetOrderById(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            Dbservice.EditOrder(order);
            return RedirectToAction(nameof(OrderTablePage));
        }

        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            Order order = Dbservice.GetOrderById(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Delete(Order order)
        {
            Dbservice.DeleteOrder(order);
            return RedirectToAction(nameof(OrderTablePage));
        }
    }
}